using Bunifu.Framework.UI;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fBlockByUsername : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fBlockByUsername(IActionsService actionsService, string scriptId)
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
                MessageCommon.ShowMessageBox("Please enter the Usernames", 3);
                return;
            }
            json.AddValue("nudDelayFrom", nudDelayFrom.Value);
            json.AddValue("nudDelayTo", nudDelayTo.Value);
            json.AddValue("nudCountFrom", nudCountFrom.Value);
            json.AddValue("nudCountTo", nudCountTo.Value);
            json.AddValue("txtListGroups", (object)txtListGroups.Text.Trim());
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
