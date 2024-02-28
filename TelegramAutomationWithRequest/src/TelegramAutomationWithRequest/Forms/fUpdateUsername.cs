using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fUpdateUsername : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;

        public fUpdateUsername(IActionsService actionsService, string scriptId)
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
                txtListUsername.Enabled = rdbCustom.Checked;

                txtListUsername.Text = jsonHelper.GetValuesFromInputString("txtListGroups");
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();
            if (rdbCustom.Checked && string.IsNullOrEmpty(txtListUsername.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please enter the Channels", 3);
                return;
            }
            int action = 0;
            if(rdbCustom.Checked)
            {
                action = 1;
            }
            json.AddValue("action", action);
            json.AddValue("txtListGroups", (object)txtListUsername.Text.Trim());
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }

        private void LoadCheckBox()
        {
        }

        private void txtListUser_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtListUsername, lbListUser);
        }

        private void rdbRandom_CheckedChanged(object sender, EventArgs e)
        {
            txtListUsername.Enabled = rdbCustom.Checked;
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtListUsername.Enabled = rdbCustom.Checked;
        }
    }
}
