using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fGetNembersInGroups : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fGetNembersInGroups(IActionsService actionsService, string scriptId)
        {
            InitializeComponent();
            _actionsService = actionsService;
            _scriptId = scriptId;
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
            conf = _actionsService.GetDataActions(Name, _scriptId);
            jsonHelper = new JsonHelper(conf, isJsonString: true);
            LoadCheckBox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }
        private void fCreateChannels_load(object sender, EventArgs e)
        {
            try
            {
                nudDelayFrom.Value = jsonHelper.GetIntType("nudDelayFrom", 10);
                nudDelayTo.Value = jsonHelper.GetIntType("nudDelayTo", 30);
                txtListGroups.Text = jsonHelper.GetValuesFromInputString("txtListGroups");
                nudCountFrom.Value = jsonHelper.GetIntType("nudCountFrom", 10);
                nudCountTo.Value = jsonHelper.GetIntType("nudCountTo", 30);
                nudNembersForm.Value = jsonHelper.GetIntType("nudNembersForm", 0);
                txtFolderExport.Text = jsonHelper.GetValuesFromInputString("txtFolderExport");
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();

            if (string.IsNullOrEmpty(txtListGroups.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Groups", 3);
                return;
            }
            if (string.IsNullOrEmpty(txtFolderExport.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Folder Export", 3);
                return;
            }
            else
            {
                if (!Directory.Exists(txtFolderExport.Text.Trim()))
                {
                    MessageCommon.ShowMessageBox("Directory does not exist.");
                    return;
                }
            }
            json.AddValue("nudDelayFrom", nudDelayFrom.Value);
            json.AddValue("nudDelayTo", nudDelayTo.Value);
            json.AddValue("nudCountFrom", nudCountFrom.Value);
            json.AddValue("nudCountTo", nudCountTo.Value);
            json.AddValue("txtListGroups", (object)txtListGroups.Text.Trim());
            json.AddValue("nudNembersForm", nudNembersForm.Value);
            json.AddValue("txtFolderExport", (object)txtFolderExport.Text.Trim());
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }

        private void LoadCheckBox()
        {
        }

        private void txtListUser_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtListGroups, lbListUser);
        }
    }
}
