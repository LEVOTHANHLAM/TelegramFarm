using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Model;
using TelegramAutomationWithRequest.Services.Interfaces;
using WTelegram;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fCreaterSession : Form
    {
        private readonly IAccountsService _accountsService;
        public AccountsModel _account;
        public fCreaterSession(string id, IAccountsService accountsService)
        {
            InitializeComponent();
            _accountsService = accountsService;
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
            if (!string.IsNullOrEmpty(id))
            {
                _account = _accountsService.GetAccountById(id);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void fUpdateData_Load(object sender, EventArgs e)
        {
            try
            {
                if (_account != null)
                {
                    txtPhone.Text = _account.PhoneNumber;
                    txtPassword.Text = _account.Password;
                    txtProxy.Text = _account.Proxy;
                    txtAppHash.Text = _account.AppHash;
                    txtAppId.Text = _account.AppId;

                }
            }
            catch
            {
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string password = string.Empty;
            string sessionFile = string.Empty;
            if (string.IsNullOrEmpty(txtAppHash.Text) || string.IsNullOrEmpty(txtAppId.Text))
            {
                MessageCommon.ShowMessageBox("Please enter AppID and AppHash if you do not want Automatic Registration");
                return;
            }
            if (int.TryParse(txtAppId.Text.Trim(), out int apIdnum))
            {
                fLoading loading = new fLoading();
                loading.StartLoading();
                sessionFile = Path.Combine(Environment.CurrentDirectory, $"Database\\DataImport\\Admin\\Session\\{txtPhone.Text.Trim()}.session");
                if (!string.IsNullOrEmpty(_account.Session) && File.Exists(_account.Session))
                {
                    sessionFile = _account.Session;
                }
                else
                {
                    File.Create(sessionFile).Close();
                }
                Client client = new Client(apIdnum, txtAppHash.Text.Trim(), sessionFile);
                if (!string.IsNullOrEmpty(txtProxy.Text.Trim()))
                {
                    client.TcpHandler = async (address, port) =>
                    {
                        var proxy = xNet.HttpProxyClient.Parse(txtProxy.Text.Trim());
                        return proxy.CreateConnection(address, port);
                    };
                }
                var a = await client.Login(txtPhone.Text.Trim());
                if (a.Contains("verification_code"))
                {
                    loading.StopLoading();
                    fInput input = new fInput();
                    input.ShowDialog();
                    string code = input.Code;
                    loading.StartLoading();
                    a = await client.Login(code);
                }
                if (a.Contains("password"))
                {
                    if (!string.IsNullOrEmpty(_account.Password))
                    {
                        password = _account.Password;
                    }
                    else
                    {
                        loading.StopLoading();
                        fInput input = new fInput("Inport Password");
                        input.ShowDialog();
                        password = input.Code;
                        loading.StartLoading();
                    }
                    a = await client.Login(password);
                }
                if (string.IsNullOrEmpty(a))
                {
                    AccountsModel model = new AccountsModel();
                    model.Session = sessionFile;
                    model.Password = password;
                    model.AppHash = txtAppHash.Text.Trim();
                    model.AppId = txtAppId.Text.Trim();
                    model.Proxy = txtProxy.Text.Trim();
                    model.Info = "Live";
                    _accountsService.UpdateAccountSession(new Guid(_account.IdAccount), model);
                    loading.StopLoading();
                    MessageCommon.ShowMessageBox("Login Done", 1);
                }
                loading.StopLoading();
            }
        }
        private void ckbAutoCreatorAppId_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
