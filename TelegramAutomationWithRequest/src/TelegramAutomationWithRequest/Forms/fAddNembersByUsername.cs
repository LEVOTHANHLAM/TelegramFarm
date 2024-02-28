using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fAddNembersByUsername : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fAddNembersByUsername(IActionsService actionsService, string scriptId)
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
                txtListGroups.Text = jsonHelper.GetValuesFromInputString("txtListChannels");
                nudCountFrom.Value = jsonHelper.GetIntType("nudCountFrom", 10);
                nudCountTo.Value = jsonHelper.GetIntType("nudCountTo", 30);
                nudDelayInviteFrom.Value = jsonHelper.GetIntType("nudDelayInviteFrom", 10);
                nudDelayInviteTo.Value = jsonHelper.GetIntType("nudDelayInviteTo", 30);
                txtListUsername.Text = jsonHelper.GetValuesFromInputString("txtListUsername");
                nudInviteFrom.Value = jsonHelper.GetIntType("nudInviteFrom", 1);
                nudInviteTo.Value = jsonHelper.GetIntType("nudInviteTo", 4);
               
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
                MessageCommon.ShowMessageBox("Please enter the Channels", 3);
                return;
            }
            if (string.IsNullOrEmpty(txtListUsername.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Username", 3);
                return;
            }
            json.AddValue("nudDelayFrom", nudDelayFrom.Value);
            json.AddValue("nudDelayTo", nudDelayTo.Value);
            json.AddValue("nudCountFrom", nudCountFrom.Value);
            json.AddValue("nudCountTo", nudCountTo.Value);
            json.AddValue("txtListChannels", (object)txtListGroups.Text.Trim());
            json.AddValue("nudDelayInviteFrom", nudDelayInviteFrom.Value);
            json.AddValue("nudDelayInviteTo", nudDelayInviteTo.Value);
            json.AddValue("nudInviteFrom", nudInviteFrom.Value);
            json.AddValue("nudInviteTo", nudInviteTo.Value);
            json.AddValue("txtListUsername", (object)txtListUsername.Text.Trim());

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
