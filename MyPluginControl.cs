using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Newtonsoft.Json;
using System.Linq;
using System.Drawing;
using System.Diagnostics;

namespace MyXrmToolBoxTool1
{
    public partial class PowerAutomateHistory : PluginControlBase
    {
        int today = 0;
        int yesterday = 1;
        int last_07_Days = 2;
        int last_15_Days = 3;
        int last_30_Days = 4;
        int last_180_Days = 5;

        int successfulSessions = 0;
        int failedSession = 1;
        int failed_success_sesssion = 2;
        List<FlowSession> flowSessions = null;

        private Settings mySettings;
        public string AccessToken { get; private set; }
        public string EnvironmentId { get; private set; }
        public string TenantId { get; private set; }
        private const string ScopeEndPoint = "https://service.flow.microsoft.com/.default";
        private const string TokenEndpoint = "https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";
        private const string FlowHyperLink = "https://make.powerautomate.com/environments/{EnvironmentId}/flows/{flowId}";
        private const string FlowExecutionHistoryEndPoint = "https://api.flow.microsoft.com/providers/Microsoft.ProcessSimple/environments/{EnvironmentId}/flows/{flowId}/runs?api-version=2016-11-01";

        public PowerAutomateHistory()
        {
            InitializeComponent();
            this.Resize += PluginControlResize;
            this.Resize += (s, e) => ResizeCheckedListBox();
            this.Load += (s, e) => ResizeCheckedListBox();
            filterDateBox.SelectedIndex = today;
            filterStatusBox.SelectedIndex = failed_success_sesssion;
        }
        private void ResizeCheckedListBox()
        {
            int marginX = (int)(this.ClientSize.Width * 0.02);  
            int marginY = (int)(this.ClientSize.Height * 0.02); 

            checkedListBox1.Location = new Point(marginX, marginY);
            checkedListBox1.Size = new Size(
                this.ClientSize.Width - (2 * marginX),
                this.ClientSize.Height - (2 * marginY)
            );
        }
        private void PluginControlResize(object sender, EventArgs e)
        {
            int width = (int)(this.ClientSize.Width * 0.9);
            int height = (int)(this.ClientSize.Height * 0.9);

            tableLayoutPanel1.Size = new Size(width, height);

            // Optional: center the panel
            tableLayoutPanel1.Location = new Point(
                (this.ClientSize.Width - width) / 2,
                (this.ClientSize.Height - height) / 2);
        }
        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            try
            {
                AccessToken = null; ;
                EnvironmentId = detail.EnvironmentId;
                TenantId = detail.TenantId.ToString().Trim('{', '}');
                base.UpdateConnection(newService, detail, actionName, parameter);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error getting environment or token: " + ex.Message);
            }
        }
        private void GetPowerAutomateFlowsListButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Service == null)
                {
                    MessageBox.Show("Not connected to Dataverse.");
                    return;
                }

                QueryExpression query = new QueryExpression("workflow");

                query.ColumnSet = new ColumnSet("name", "workflowid", "statecode", "ownerid", "createdon", "clientdata");

                query.Criteria = new FilterExpression(LogicalOperator.And);
                query.Criteria.AddCondition("category", ConditionOperator.Equal, 5);
                query.Criteria.AddCondition("type", ConditionOperator.Equal, 1);
                query.Criteria.AddCondition("statuscode", ConditionOperator.Equal, 2); // Activated

                var results = Service.RetrieveMultiple(query);
                List<FlowItem> flowItems = new List<FlowItem>();

                foreach (var flow in results.Entities)
                {
                    string name = flow.GetAttributeValue<string>("name");
                    string flowId = flow.GetAttributeValue<Guid>("workflowid").ToString();
                    flowItems.Add(new FlowItem(name, flowId));
                }
                flowItems = flowItems.OrderBy(f => f.Name).ToList();
                checkedListBox1.Items.Clear();

                foreach (var item in flowItems)
                {
                    checkedListBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading flows:\n{ex.Message}");
            }
        }
        private async Task<string> GetNewTokenForPowerAutomate()
        {
            var form = new Popup();

            if (form.ShowDialog() == DialogResult.OK)
            {
                string clientId = form.clientId.ToString();
                string clientSecret = form.clientSecret;

                if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
                {
                    return null;
                }

                using (var client = new HttpClient())
                {
                    var tokenEndpoint = TokenEndpoint.Replace("{tenantId}", TenantId);

                    var requestBody = new FormUrlEncodedContent(new[]
                    {
                            new KeyValuePair<string, string>("client_id", clientId),
                            new KeyValuePair<string, string>("client_secret", clientSecret),
                            new KeyValuePair<string, string>("scope", ScopeEndPoint),
                            new KeyValuePair<string, string>("grant_type", "client_credentials")
                        });

                    var response = await client.PostAsync(tokenEndpoint, requestBody);
                    var json = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Token request failed: {response.StatusCode}\n{json}");
                        AccessToken = null;
                        return null;
                    }

                    var tokenObj = JObject.Parse(json);
                    AccessToken = tokenObj["access_token"]?.ToString();
                    return AccessToken.ToString();
                }
            }
            return null;
        }
        
        public List<FlowSession> GetFilteredSession(List<FlowSession> flowSessions)
        {
            int filterDate = filterDateBox.SelectedIndex;
            int filterStatus = filterStatusBox.SelectedIndex;

            List<FlowSession> filteredSessions;

            #region DATE FILTER
            DateTime dateFilter = DateTime.Now;

            if (filterDate == today)
            {
                dateFilter = DateTime.Now;
                filteredSessions = flowSessions.Where(s => s.StartTime.HasValue && s.StartTime.Value.Date == dateFilter.Date).ToList();
            }
            else if (filterDate == yesterday)
            {
                dateFilter = DateTime.Now.AddDays(-1);
                filteredSessions = flowSessions.Where(s => s.StartTime.HasValue && s.StartTime.Value.Date == dateFilter.Date).ToList();
            }
            else if (filterDate == last_07_Days)
            {
                dateFilter = DateTime.Now.AddDays(-7);
                filteredSessions = flowSessions.Where(s => s.StartTime.HasValue && s.StartTime.Value.Date >= dateFilter.Date).ToList();
            }
            else if (filterDate == last_15_Days)
            {
                dateFilter = DateTime.Now.AddDays(-15);
                filteredSessions = flowSessions.Where(s => s.StartTime.HasValue && s.StartTime.Value.Date >= dateFilter.Date).ToList();
            }
            else if (filterDate == last_30_Days)
            {
                dateFilter = DateTime.Now.AddDays(-30);
                filteredSessions = flowSessions.Where(s => s.StartTime.HasValue && s.StartTime.Value.Date >= dateFilter.Date).ToList();
            }
            else 
            {
                dateFilter = DateTime.Now.AddDays(-180);
                filteredSessions = flowSessions.Where(s => s.StartTime.HasValue && s.StartTime.Value.Date >= dateFilter.Date).ToList();
            }
            #endregion

            #region STATUS FILTER
            if (filterStatus == successfulSessions)
            {
                filteredSessions = filteredSessions.Where(s => s.Status != null && s.Status.Equals("Succeeded", StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (filterStatus == failedSession)
            {
                filteredSessions = filteredSessions.Where(s => s.Status != null && s.Status.Equals("Failed", StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                
            }

            #endregion

            // OrderBy then return
            return filteredSessions.Where(s => s.StartTime.HasValue).OrderByDescending(s => s.StartTime).ToList();
        }
        public void UpdateExecutionHistoryGridColumn (List<FlowSession> flowSessions)
        {
            var filteredSession = GetFilteredSession(flowSessions);

            gridFlowExecutionHistory.DataSource = filteredSession;

            var linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Flow Name";
            linkColumn.DataPropertyName = "FlowNamee";
            linkColumn.Name = "FlowLink";
            linkColumn.UseColumnTextForLinkValue = false;

            gridFlowExecutionHistory.Columns.Remove("Id"); 
            gridFlowExecutionHistory.Columns.Remove("FlowName"); 

            if (!gridFlowExecutionHistory.Columns.Contains("FlowLink"))
            {
                gridFlowExecutionHistory.Columns.Insert(0, linkColumn); 
            }

            foreach (DataGridViewRow row in gridFlowExecutionHistory.Rows)
            {
                if (row.DataBoundItem is FlowSession session)
                {
                    var flowUrl = session.Id;
                    var hyperLink = "https://flow.microsoft.com/manage/" + flowUrl.Replace("/providers/Microsoft.ProcessSimple", "");
                    row.Cells["FlowLink"].Value = session.FlowName;
                    row.Cells["FlowLink"].Tag = hyperLink;
                }
            }

            int totalWidth = gridFlowExecutionHistory.ClientSize.Width;
            int[] percentages = { 40, 20, 20, 20 };

            for (int i = 0; i < gridFlowExecutionHistory.Columns.Count && i < percentages.Length; i++)
            {
                gridFlowExecutionHistory.Columns[i].Width = (totalWidth * percentages[i]) / 100;
            }

            toolStripLabel1.Text = "Total Sessions: " + filteredSession.Count.ToString();
        }
        public async Task<List<JObject>> GetAllFlowSessionsAsync(string flowId)
        {
            var form = new ProgressBar();

            var crmServiceClient = (this.Service as Microsoft.Xrm.Tooling.Connector.CrmServiceClient);
            List<JObject> allSessions = new List<JObject>();

            if (crmServiceClient != null)
            {
                string baseUrl = FlowExecutionHistoryEndPoint.Replace("{EnvironmentId}", EnvironmentId).Replace("{flowId}", flowId);

                string filteredUrl = baseUrl;

                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                int i = 0;
                form.Show();
                form.UpdateStatus($"Session loading...");
                while (!string.IsNullOrEmpty(filteredUrl))
                {
                    i++;
                    
                    var response = await httpClient.GetAsync(filteredUrl);
                    form.UpdateStatus($"Session loading... {i * 50} ");

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Failed to retrieve flow history: {response.StatusCode}");
                        AccessToken = null;
                        break;
                    }

                    var content = await response.Content.ReadAsStringAsync();
                    var runSummary = JsonConvert.DeserializeObject<Root>(content);

                    var json = JObject.Parse(content);

                    // Add this page's results
                    var valueArray = json["value"] as JArray;
                    if (valueArray != null)
                    {
                        foreach (var session in valueArray)
                        {
                            allSessions.Add((JObject)session);
                        }
                    }

                    // Check for next page
                    filteredUrl = json["nextLink"]?.ToString() ?? null;

                }
                form.Close();
                return allSessions;
            }
            else
            {
                MessageBox.Show("Could not access CrmServiceClient.");
                return null;
            }
        }
        public static bool IsValidToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return false;

            if (token.Length < 20) 
                return false;

            // Optional: Regex to match token pattern (alphanumeric and a few special chars)
            var tokenPattern = @"^[A-Za-z0-9\-_\.]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(token, tokenPattern);
        }
        private async void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please select a flow before clicking.");
                return;
            }

            if (!IsValidToken(AccessToken))
            {
                AccessToken = await GetNewTokenForPowerAutomate();
            }

            if (IsValidToken(AccessToken))
            {
                int totalCount = 0;
                flowSessions = new List<FlowSession>();

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    if (item is FlowItem flowItem)
                    {

                        var responseList = await GetAllFlowSessionsAsync(flowItem.Id);

                        totalCount = totalCount + responseList.Count;

                        foreach (var sessionObj in responseList)
                        {
                            var id = sessionObj["id"]?.ToString();
                            var name = sessionObj["name"]?.ToString();
                            var props = sessionObj["properties"];
                            var status = props?["status"]?.ToString();
                            var startTimeStr = props?["startTime"]?.ToString();
                            var endTimeStr = props?["endTime"]?.ToString();

                            DateTime? startTime = DateTime.TryParse(startTimeStr, out DateTime parsedStart) ? parsedStart : (DateTime?)null;
                            DateTime? endTime = DateTime.TryParse(endTimeStr, out DateTime parsedEnd) ? parsedEnd : (DateTime?)null;

                            flowSessions.Add(new FlowSession
                            {
                                FlowName = flowItem.Name,
                                Id = id,
                                Status = status,
                                StartTime = startTime,
                                EndTime = endTime
                            });
                        }
                    }
                }

                UpdateExecutionHistoryGridColumn(flowSessions);

                
            }
        }
        private void gridFlowExecutionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFlowExecutionHistory.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                string flowLink = gridFlowExecutionHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
                // Do something like open details view or browser
                if (!string.IsNullOrEmpty(flowLink))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(new ProcessStartInfo
                        {
                            FileName = flowLink,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not open link: " + ex.Message);
                    }
                }
            }
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/glanisyed";
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flowSessions != null)
            {
                UpdateExecutionHistoryGridColumn(flowSessions);
            }
        }

        private void filterDateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flowSessions != null)
            {
                UpdateExecutionHistoryGridColumn(flowSessions);
            }
        }
    }

    public class Root
    {
        public List<Run> value { get; set; }
    }

    public class Run
    {
        public string name { get; set; }
        public string id { get; set; }
        public Propertiess properties { get; set; }
    }

    public class Propertiess
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string status { get; set; }
    }
    public class FlowItem
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public FlowItem(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
        public class FlowRun
        {
            public string name { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public string startTime { get; set; }
            public string endTime { get; set; }
            public string status { get; set; }
        }

    }
    public class FlowSession
    {
        public string FlowName { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}