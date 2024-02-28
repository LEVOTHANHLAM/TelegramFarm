using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fCreateChannels : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fCreateChannels(IActionsService actionsService, string scriptId)
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
                txtListChannels.Text = jsonHelper.GetValuesFromInputString("txtListChannels");
                nudCountFrom.Value = jsonHelper.GetIntType("nudCountFrom", 10);
                nudCountTo.Value = jsonHelper.GetIntType("nudCountTo", 30);
                txtListUsername.Text = jsonHelper.GetValuesFromInputString("txtListUsername");
                nudInviteFrom.Value = jsonHelper.GetIntType("nudInviteFrom", 1);
                nudInviteTo.Value = jsonHelper.GetIntType("nudInviteTo", 4);
                ckbBio.Checked = jsonHelper.GetBooleanValue("ckbBio", false);
                txtBio.Text = jsonHelper.GetValuesFromInputString("txtBio");
                txtBio.Enabled = ckbBio.Checked;
                ckbAvtar.Checked = jsonHelper.GetBooleanValue("ckbAvtar", false);
                txtFolderImage.Text = jsonHelper.GetValuesFromInputString("txtFolderImage");
                txtFolderImage.Enabled = ckbAvtar.Checked;
                ckbInviteToChannel.Checked = jsonHelper.GetBooleanValue("ckbInviteToChannel", false);
                pInvite.Enabled = ckbInviteToChannel.Checked;
                nudDelayInviteFrom.Value = jsonHelper.GetIntType("nudDelayInviteFrom", 10);
                nudDelayInviteTo.Value = jsonHelper.GetIntType("nudDelayInviteTo", 30);
                ckbInviteNemberSubscribers_CheckedChanged(null, null);
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();

            if (string.IsNullOrEmpty(txtListChannels.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Channels", 3);
                return;
            }
            if (ckbInviteToChannel.Checked && string.IsNullOrEmpty(txtListUsername.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Username", 3);
                return;
            }
            if (ckbBio.Checked && string.IsNullOrEmpty(txtBio.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Descriptions", 3);
                return;
            }
            if (ckbAvtar.Checked && !Directory.Exists(txtFolderImage.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Foler Media", 3);
                return;
            }
            txtFolderImage.Text = jsonHelper.GetValuesFromInputString("txtFolderImage");
            json.AddValue("nudDelayFrom", nudDelayFrom.Value);
            json.AddValue("nudDelayTo", nudDelayTo.Value);
            json.AddValue("nudCountFrom", nudCountFrom.Value);
            json.AddValue("nudCountTo", nudCountTo.Value);
            json.AddValue("txtListChannels", (object)txtListChannels.Text.Trim());
            json.AddValue("nudInviteFrom", nudInviteFrom.Value);
            json.AddValue("nudInviteTo", nudInviteTo.Value);
            json.AddValue("txtListUsername", (object)txtListUsername.Text.Trim());
            json.AddValue("txtBio", (object)txtBio.Text.Trim());
            json.AddValue("txtFolderImage", (object)txtFolderImage.Text.Trim());
            json.AddValue("ckbBio", ckbBio.Checked);
            json.AddValue("ckbAvtar", ckbAvtar.Checked);
            json.AddValue("ckbInviteToChannel", ckbInviteToChannel.Checked);
            json.AddValue("nudDelayInviteFrom", nudDelayInviteFrom.Value);
            json.AddValue("nudDelayInviteTo", nudDelayInviteTo.Value);
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }

        private void LoadCheckBox()
        {
        }

        private void txtListUser_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtListChannels, lbListUser);
        }

        private void ckbInviteNemberSubscribers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtListUsername_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtListUsername, groupBox2);
        }

        private void txtBio_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtBio, label7);
        }

        private void ckbBio_CheckedChanged(object sender, EventArgs e)
        {
            txtBio.Enabled = ckbBio.Checked;
        }

        private void ckbAvtar_CheckedChanged(object sender, EventArgs e)
        {
            txtFolderImage.Enabled = ckbAvtar.Checked;
        }

        private void ckbInviteToChannel_CheckedChanged(object sender, EventArgs e)
        {
            pInvite.Enabled = ckbInviteToChannel.Checked;
        }
    }
}
