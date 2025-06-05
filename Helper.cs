using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PowerAutomateRunHistoryViewer
{
    public class Helper
    {
        public static void DisplayMessage(string msg, string title, string icon)
        {
            if (icon.ToUpper() == Constants.Error)
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (icon.ToUpper() == Constants.Info)
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static string GetStringAttribute(Entity entity, string field)
        {
            return entity.GetAttributeValue<string>(field);
        }
        public static string GetGuidAttribute(Entity entity, string field)
        {
            return entity.GetAttributeValue<Guid>(field).ToString();
        }

        public static EntityCollection RetrievePowerAutomateFlows(IOrganizationService service)
        {
            QueryExpression query = new QueryExpression(Constants.WorkflowEntity);

            query.ColumnSet = new ColumnSet(
                Constants.Name,
                Constants.WorkflowId,
                Constants.StateCode,
                Constants.OwnerId,
                Constants.CreatedOn,
                Constants.ClientData
                );

            query.Criteria = new FilterExpression(LogicalOperator.And);
            query.Criteria.AddCondition(Constants.Category, ConditionOperator.Equal, 5);
            query.Criteria.AddCondition(Constants.Type, ConditionOperator.Equal, 1);
            query.Criteria.AddCondition(Constants.StatusCode, ConditionOperator.Equal, 2); // Activated

            EntityCollection entityCol = service.RetrieveMultiple(query);

            if (entityCol.Entities.Count > 0)
                return entityCol;
            return null;
        }

    }
        public class Constants
    {
        public const int today = 0;
        public const int yesterday = 1;
        public const int last_07_Days = 2;
        public const int last_15_Days = 3;
        public const int last_30_Days = 4;
        public const int last_180_Days = 5;

        public const int successfulSessions = 0;
        public const int failedSession = 1;
        public const int failed_success_sesssion = 2;

        public const string Error = "Error";
        public const string Info = "Info";
        public const string Warning = "Warning";

        public const string WorkflowEntity = "workflow";
        public const string Name = "name";
        public const string WorkflowId = "workflowid";
        public const string StateCode = "statecode";
        public const string OwnerId = "ownerid";
        public const string CreatedOn = "createdon";
        public const string ClientData = "clientdata";
        public const string Category = "category";
        public const string Type = "type";
        public const string StatusCode = "statuscode";
        public const string Value = "value";
        public const string NextLink = "nextLink";

        public const string SessionLoading = "Session loading...";
        public const string GridHeaderFlowLink = "FlowLink";
        public const string Id = "Id";
        
        public const string FlowName = "Flow Name";
        public const string FlowNamee = "FlowNamee";

        public const string TotalSession = "Total Sessions: ";
        public const string FlowId = "{flowId}";
        public const string EnvironmentId = "{EnvironmentId}";
        public const string Bearer = "Bearer";

        public const string HyperLinkFlow = "https://flow.microsoft.com/manage/";
        public const string ReplaceLink = "/providers/Microsoft.ProcessSimple";
        public const string ScopeEndPoint = "https://service.flow.microsoft.com/.default";
        public const string TokenEndpoint = "https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";
        public const string FlowHyperLink = "https://make.powerautomate.com/environments/{EnvironmentId}/flows/{flowId}";
        public const string FlowExecutionHistoryEndPoint = "https://api.flow.microsoft.com/providers/Microsoft.ProcessSimple/environments/{EnvironmentId}/flows/{flowId}/runs?api-version=2016-11-01";
        public static readonly string AuthorProfile = "https://www.linkedin.com/in/glanisyed";


        public const string ErrorGettingToken = "Error getting environment or token: {0}";
        public const string ErrorFlowHistory = "Failed to retrieve flow history: {0}";
        public const string ErrorLoadingFlow = "Error loading flows: {0}";
        public const string ErrorTitle = "Failed";
        public const string ErrorAccessClient = "Could not access CrmServiceClient.";
        public const string SelectFlowFirst = "Please select a flow before clicking.";
        public const string LinkOpenError = "Could not open link: {0}";
        public static readonly string NotConnectedMessage = "Not connected to Dataverse. Please connect to your environment before using this tool.";

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
