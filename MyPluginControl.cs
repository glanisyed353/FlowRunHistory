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
using PowerAutomateRunHistoryViewer;

namespace MyXrmToolBoxTool1
{
    public partial class PowerAutomateHistory : PluginControlBase
    {       
        List<FlowSession> flowSessions = null;
        private Settings mySettings;
        public string AccessToken { get; private set; }
        public string EnvironmentId { get; private set; }
        public string TenantId { get; private set; }
 
        public PowerAutomateHistory()
        {
            InitializeComponent();
            this.Resize += PluginControlResize;
            this.Resize += (s, e) => ResizeCheckedListBox();
            this.Load += (s, e) => ResizeCheckedListBox();
            filterDateBox.SelectedIndex = Constants.today;
            filterStatusBox.SelectedIndex = Constants.failed_success_sesssion;
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
            if (Service == null)
            {
                ShowInfoNotification(Constants.NotConnectedMessage, Constants.InfoNotificationUri);
                EnableAllComponents(false);
            }

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
                Helper.DisplayMessage(string.Format(Constants.ErrorGettingToken, ex.Message), Constants.ErrorTitle, Constants.Error);
            }
        }
       
        private void GetPowerAutomateFlowsListButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Service == null)
                {
                    MessageBox.Show(Constants.NotConnectedMessage);
                    return;
                }

                EntityCollection results = Helper.RetrievePowerAutomateFlows(Service);

                List<FlowItem> flowItems = new List<FlowItem>();

                foreach (var flow in results.Entities)
                {
                    string name = Helper.GetStringAttribute(flow, Constants.Name);
                    string flowId = Helper.GetGuidAttribute(flow, Constants.WorkflowId);
                    flowItems.Add(new FlowItem(name, flowId));
                }
                flowItems = flowItems.OrderBy(f => f.Name).ToList();
                checkedListBox1.Items.Clear();

                foreach (var item in flowItems)
                {
                    checkedListBox1.Items.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                Helper.DisplayMessage(string.Format(Constants.ErrorLoadingFlow, ex.Message), Constants.ErrorTitle, Constants.Error);
            }
        }
        private async Task<string> GetNewTokenForPowerAutomate()
        {
            return null;
        }
        
        public List<FlowSession> GetFilteredSession(List<FlowSession> flowSessions)
        {
            return null;
        }
        public void UpdateExecutionHistoryGridColumn (List<FlowSession> flowSessions)
        {
        }
        public async Task<List<JObject>> GetAllFlowSessionsAsync(string flowId)
        {
            return null;
        }
        public static bool IsValidToken(string token)
        {
            return false;
        }
        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            return;
        }
        private void gridFlowExecutionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = Constants.AuthorProfile,
                UseShellExecute = true
            });
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void filterDateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

}
