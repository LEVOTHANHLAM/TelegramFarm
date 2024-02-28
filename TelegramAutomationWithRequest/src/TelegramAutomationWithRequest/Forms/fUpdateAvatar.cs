using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fUpdateAvatar : Form
    {
        private string _scriptId;
        private readonly IActionsService _actionsService;
        private JsonHelper jsonHelper;
        private string conf;
        public fUpdateAvatar(IActionsService actionsService, string scriptId)
        {
            InitializeComponent();
            _actionsService = actionsService;
            _scriptId = scriptId;
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
            conf = _actionsService.GetDataActions(Name, _scriptId);
            jsonHelper = new JsonHelper(conf, isJsonString: true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void fAddFile_Load(object sender, EventArgs e)
        {
            txtNameFolder.Text = jsonHelper.GetValuesFromInputString("txtNameFolder");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JsonHelper json = new JsonHelper();

            if (string.IsNullOrEmpty(txtNameFolder.Text.Trim()) || !Directory.Exists(txtNameFolder.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Please check folder", 3);
                return;
            }
            json.AddValue("txtNameFolder", (object)txtNameFolder.Text.Trim());
            _actionsService.CreateUpdate(Name, _scriptId, json.GetJsonString());
            CommonMethods.CloseForm(this);
        }
      
    }
}
