using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fUpdatePassword : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fUpdatePassword(IActionsService actionsService, string scriptId)
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
                rdbRandom.Checked = true;
                if (jsonHelper.GetIntType("action", 0) == 1)
                {
                    rdbCustom.Checked = true;
                    rdbRandom.Checked = false;
                }
                txtCustom.Enabled = rdbCustom.Checked;
                panel2.Enabled = rdbRandom.Checked;
                txtCustom.Text = jsonHelper.GetValuesFromInputString("txtCustom");
                nudFrom.Value = jsonHelper.GetIntType("nudFrom", 6);
                nudTo.Value = jsonHelper.GetIntType("nudTo", 20);
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();
            if (rdbCustom.Checked && string.IsNullOrEmpty(txtCustom.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Password ", 3);
                return;
            }
            int action = 0;
            if (rdbCustom.Checked)
            {
                action = 1;
            }
            json.AddValue("action", action);
            json.AddValue("txtCustom", (object)txtCustom.Text.Trim());
            json.AddValue("nudFrom", nudFrom.Value);
            json.AddValue("nudTo", nudTo.Value);
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }

        private void LoadCheckBox()
        {
        }

    
        private void rdbRandom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustom.Enabled = rdbCustom.Checked;
            panel2.Enabled = rdbRandom.Checked;
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustom.Enabled = rdbCustom.Checked;
            panel2.Enabled = rdbRandom.Checked;
        }
    }
}
