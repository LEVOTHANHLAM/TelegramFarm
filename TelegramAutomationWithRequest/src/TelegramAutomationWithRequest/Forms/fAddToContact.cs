﻿using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fAddToContact : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fAddToContact(IActionsService actionsService, string scriptId)
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
                nudDelayInviteFrom.Value = jsonHelper.GetIntType("nudDelayInviteFrom", 10);
                nudDelayInviteTo.Value = jsonHelper.GetIntType("nudDelayInviteTo", 30);
                txtListComment.Text = jsonHelper.GetValuesFromInputString("txtListUsername");
                nudInviteFrom.Value = jsonHelper.GetIntType("nudInviteFrom", 1);
                nudInviteTo.Value = jsonHelper.GetIntType("nudInviteTo", 1);
                ckbImage.Checked = jsonHelper.GetBooleanValue("ckbImage", false);
                txtFolderImage.Text = jsonHelper.GetValuesFromInputString("txtFolderImage");
                nudImageCountFrom.Value = jsonHelper.GetIntType("nudImageCountFrom", 10);
                nudImageCountTo.Value = jsonHelper.GetIntType("nudImageCountTo", 30);
                ckbCommentContent.Checked = jsonHelper.GetBooleanValue("ckbCommentContent", false);
                ckbSendMessager.Checked = jsonHelper.GetBooleanValue("ckbSendMessager", false);
                panel2.Enabled = ckbImage.Checked;
                txtListComment.Enabled = ckbCommentContent.Checked;
                pInvite.Enabled = ckbSendMessager.Checked;
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
                MessageCommon.ShowMessageBox("Please enter the Username", 3);
                return;
            }
            if (ckbCommentContent.Checked && string.IsNullOrEmpty(txtListComment.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the content", 3);
                return;
            }
            if (ckbImage.Checked && string.IsNullOrEmpty(txtFolderImage.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Foler Media", 3);
                return;
            }
            json.AddValue("nudDelayFrom", nudDelayFrom.Value);
            json.AddValue("nudDelayTo", nudDelayTo.Value);
            json.AddValue("nudCountFrom", nudCountFrom.Value);
            json.AddValue("nudCountTo", nudCountTo.Value);
            json.AddValue("txtListGroups", (object)txtListGroups.Text.Trim());
            json.AddValue("nudDelayInviteFrom", nudDelayInviteFrom.Value);
            json.AddValue("nudDelayInviteTo", nudDelayInviteTo.Value);
            json.AddValue("nudInviteFrom", nudInviteFrom.Value);
            json.AddValue("nudInviteTo", nudInviteTo.Value);
            json.AddValue("txtListUsername", (object)txtListComment.Text.Trim());
            json.AddValue("ckbImage", ckbImage.Checked);
            json.AddValue("txtFolderImage", (object)txtFolderImage.Text.Trim());
            json.AddValue("nudImageCountFrom", nudImageCountFrom.Value);
            json.AddValue("nudImageCountTo", nudImageCountTo.Value);
            json.AddValue("ckbCommentContent", ckbCommentContent.Checked);
            json.AddValue("ckbSendMessager", ckbSendMessager.Checked);
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

        private void ckbImage_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = ckbImage.Checked;
        }

        private void ckbCommentContent_CheckedChanged(object sender, EventArgs e)
        {
            txtListComment.Enabled = ckbCommentContent.Checked;
        }

        private void ckbSendMessager_CheckedChanged(object sender, EventArgs e)
        {
            pInvite.Enabled  = ckbSendMessager.Checked;
        }
    }
}
