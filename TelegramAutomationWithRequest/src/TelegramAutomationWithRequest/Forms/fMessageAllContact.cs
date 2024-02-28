using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fMessageAllContact : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fMessageAllContact(IActionsService actionsService, string scriptId)
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
                rdbAllContact.Checked = true;
                rdbQuantity.Checked = false;
                if(jsonHelper.GetIntType("action", 0) == 1)
                {
                    rdbAllContact.Checked = false;
                    rdbQuantity.Checked = true;
                }
                nudDelayFrom.Value = jsonHelper.GetIntType("nudDelayFrom", 10);
                nudDelayTo.Value = jsonHelper.GetIntType("nudDelayTo", 30);
                nudCountFrom.Value = jsonHelper.GetIntType("nudCountFrom", 10);
                nudCountTo.Value = jsonHelper.GetIntType("nudCountTo", 30);
                nudDelayInviteFrom.Value = jsonHelper.GetIntType("nudDelayInviteFrom", 10);
                nudDelayInviteTo.Value = jsonHelper.GetIntType("nudDelayInviteTo", 30);
                txtListComment.Text = jsonHelper.GetValuesFromInputString("txtListComment");
                nudInviteFrom.Value = jsonHelper.GetIntType("nudInviteFrom", 1);
                nudInviteTo.Value = jsonHelper.GetIntType("nudInviteTo", 1);
                ckbImage.Checked = jsonHelper.GetBooleanValue("ckbImage", false);
                txtFolderImage.Text = jsonHelper.GetValuesFromInputString("txtFolderImage");
                nudImageCountFrom.Value = jsonHelper.GetIntType("nudImageCountFrom", 10);
                nudImageCountTo.Value = jsonHelper.GetIntType("nudImageCountTo", 30);
                ckbCommentContent.Checked = jsonHelper.GetBooleanValue("ckbCommentContent", false);
                panel2.Enabled = ckbImage.Checked;
                txtListComment.Enabled = ckbCommentContent.Checked;
                panel3.Enabled = rdbQuantity.Checked;
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();
            if (ckbCommentContent.Checked && string.IsNullOrEmpty(txtListComment.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the content", 3);
                return;
            }
            if (ckbImage.Checked && string.IsNullOrEmpty(txtFolderImage.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Folder Media", 3);
                return;
            }
            int action = 0;
            if(rdbQuantity.Checked)
            {
                action = 1;
            }
            json.AddValue("action", action);
            json.AddValue("nudDelayFrom", nudDelayFrom.Value);
            json.AddValue("nudDelayTo", nudDelayTo.Value);
            json.AddValue("nudCountFrom", nudCountFrom.Value);
            json.AddValue("nudCountTo", nudCountTo.Value);
            json.AddValue("nudDelayInviteFrom", nudDelayInviteFrom.Value);
            json.AddValue("nudDelayInviteTo", nudDelayInviteTo.Value);
            json.AddValue("nudInviteFrom", nudInviteFrom.Value);
            json.AddValue("nudInviteTo", nudInviteTo.Value);
            json.AddValue("txtListComment", (object)txtListComment.Text.Trim());
            json.AddValue("ckbImage", ckbImage.Checked);
            json.AddValue("txtFolderImage", (object)txtFolderImage.Text.Trim());
            json.AddValue("nudImageCountFrom", nudImageCountFrom.Value);
            json.AddValue("nudImageCountTo", nudImageCountTo.Value);
            json.AddValue("ckbCommentContent", ckbCommentContent.Checked);
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }

        private void LoadCheckBox()
        {
        }


        private void ckbImage_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = ckbImage.Checked;
        }

        private void ckbCommentContent_CheckedChanged(object sender, EventArgs e)
        {
            txtListComment.Enabled = ckbCommentContent.Checked;
        }

        private void rdbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = rdbQuantity.Checked;
        }

        private void rdbAllContact_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = rdbQuantity.Checked;
        }
    }
}
