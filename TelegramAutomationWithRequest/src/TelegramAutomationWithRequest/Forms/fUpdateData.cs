using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fUpdateData : Form
    {
        private readonly IAccountsService _accountsService;


        public fUpdateData(IAccountsService accountsService)
        {
            InitializeComponent();
            _accountsService = accountsService;
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
            cbbTypeUpdate.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void fUpdateData_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txbData.Text.Equals("") || txbData.Text.Equals("|"))
            {
                if (MessageCommon.ShowConfirmationBox(string.Format("Are you sure you want to delete the data of [{0}] account?", fMain._fMain.GetListSelect().Count)) == DialogResult.Yes)
                {
                    flag = true;
                }
            }
            else if (MessageCommon.ShowConfirmationBox(string.Format("Are you sure you want to update the data of [{0}] accounts", fMain._fMain.GetListSelect().Count)) == DialogResult.Yes)
            {
                flag = true;
            }
            if (!flag)
            {
                return;
            }
            List<string> list = fMain._fMain.GetListSelect();
            string txtData = txbData.Text;
            string typeUpdate = cbbTypeUpdate.Text;
            switch (typeUpdate)
            {
                case "Password":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.Password, txtData);
                        }
                        break;
                    }
                case "Username":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.UserName, txtData);
                        }
                        break;
                    }
                case "Proxy":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.Proxy, txtData);
                        }
                        break;
                    }
                case "AppId":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.AppId, txtData);
                        }
                        break;
                    }
                case "App Hash":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.AppHash, txtData);
                        }
                        break;
                    }
                case "Name":
                    {
                        foreach (var item in list)
                        {
                           // _accountsService.UpdateColumn(new Guid(item), x => x.Name, txtData);
                        }
                        break;
                    }
                case "Account Status":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.Info, txtData);
                        }
                        break;
                    }
                case "Session":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.Session, txtData);
                        }
                        break;
                    }
                case "Cookie":
                    {
                        foreach (var item in list)
                        {
                            _accountsService.UpdateColumn(new Guid(item), x => x.Cookie, txtData);
                        }
                        break;
                    }
                default:
                    break;
            }
            CommonMethods.CloseForm(this);
        }
    }
}
