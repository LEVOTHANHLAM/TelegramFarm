using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fUpdateFullname : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fUpdateFullname(IActionsService actionsService, string scriptId)
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
                rdbCustom.Checked = false;
                rdbRandomUS.Checked = true;
                rdbVN.Checked = false;
                if (jsonHelper.GetIntType("action", 0) == 1)
                {
                    rdbCustom.Checked = true;
                    rdbRandomUS.Checked = false;
                    rdbVN.Checked = false;
                }
                else if (jsonHelper.GetIntType("action", 0) == 2)
                {
                    rdbCustom.Checked = false;
                    rdbRandomUS.Checked = false;
                    rdbVN.Checked = true;
                }
                panel2.Enabled = rdbCustom.Checked;

                txtListFirtname.Text = jsonHelper.GetValuesFromInputString("txtListFirtname");
                txtLastname.Text = jsonHelper.GetValuesFromInputString("txtLastname");
                ckbUpdateBio.Checked = jsonHelper.GetBooleanValue("ckbUpdateBio");
                txtListBio.Text = jsonHelper.GetValuesFromInputString("txtListBio");
                txtListBio.Enabled = ckbUpdateBio.Checked;
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();
            if (rdbCustom.Checked && string.IsNullOrEmpty(txtListFirtname.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Channels", 3);
                return;
            }
            int action = 0;
            if (rdbCustom.Checked)
            {
                action = 1;
            }
            else if (rdbVN.Checked)
            {
                action = 2;
            }
            json.AddValue("action", action);
            json.AddValue("txtListFirtname", (object)txtListFirtname.Text.Trim());
            json.AddValue("txtLastname", (object)txtLastname.Text.Trim());
            json.AddValue("ckbUpdateBio", ckbUpdateBio.Checked);
            json.AddValue("txtListBio", (object)txtListBio.Text.Trim());
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }

        private void LoadCheckBox()
        {
        }

        private void txtListUser_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtListFirtname, lbListUser);
        }

        private void rdbRandom_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = rdbCustom.Checked;
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = rdbCustom.Checked;
        }

        private void rdbVN_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = rdbCustom.Checked;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtLastname, label1);
        }

        private void ckbUpdateBio_CheckedChanged(object sender, EventArgs e)
        {
            txtListBio.Enabled = ckbUpdateBio.Checked;
        }
    }
}
