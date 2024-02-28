using System.Xml.Linq;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;
using TelegramAutomationWithRequest.Forms;
using TelegramAutomationWithRequest.Services;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fImportProxy : Form
    {
        private readonly IAccountsService _accountsService;
        internal List<string> _lstProxy;
        internal int accountProxy;
        public fImportProxy(IAccountsService? accountsService, List<string>? lstProxy)
        {
            InitializeComponent();
            if (accountsService != null)
            {
                _accountsService = accountsService;
            }
            if (lstProxy != null)
            {
                _lstProxy = lstProxy;
            }

            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
            cbbTypeProxy.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void fAddFriendByKW_Load(object sender, EventArgs e)
        {
            try
            {
                if (_lstProxy != null)
                {
                    string str2 = "System.Collections.Generic.List`1[System.String]";
                    if (_lstProxy.Count > 0 && !_lstProxy[0].Equals(str2))
                    {
                        txtProxy.Lines = _lstProxy.ToArray();
                    }
                    CommonMethods.UpdateLineCount(txtProxy, lblProxy);
                }
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                List<string> proxies = txtProxy.Lines.ToList();
                proxies = CommonMethods.RemoveEmptyLines(proxies);
                if (_accountsService != null)
                {
                    List<string> list = new List<string>();
                    if (proxies.Count == 0)
                    {
                        MessageCommon.ShowMessageBox("Please enter proxy!", 3);
                        return;
                    }
                    int num = Convert.ToInt32(nudAccountProxy.Value);
                    for (int i = 0; i < num; i++)
                    {
                        list.AddRange(proxies);
                    }
                    if (rbRandom.Checked)
                    {
                        list = CommonMethods.ShuffleList(list);
                    }
                    Queue<string> queue = new Queue<string>(list);
                    //int selectedIndex = cbbTypeProxy.SelectedIndex;
                    List<string> list2 = new List<string>();
                    for (int j = 0; j < fMain._fMain.dtgvAcc.Rows.Count; j++)
                    {
                        if (Convert.ToBoolean(fMain._fMain.GetCellValue(j, "cChose")) && (!(fMain._fMain.GetCellValue(j, "cProxy") != "") || !ckbNoEnterExistingAccount.Checked))
                        {
                            if (queue.Count == 0)
                            {
                                break;
                            }
                            string text = queue.Dequeue().Replace("'", "''");
                            list2.Add(fMain._fMain.GetCellValue(j, "cId") + "|" + text);
                        }
                    }
                    if (_accountsService.UpdateProxy(list2))
                    {
                        queue = new Queue<string>(list);
                        for (int k = 0; k < fMain._fMain.dtgvAcc.Rows.Count; k++)
                        {
                            if (Convert.ToBoolean(fMain._fMain.GetCellValue(k, "cChose")) && (!(fMain._fMain.GetCellValue(k, "cProxy") != "") || !ckbNoEnterExistingAccount.Checked))
                            {
                                if (queue.Count == 0)
                                {
                                    break;
                                }
                                string object_ = queue.Dequeue().Replace("'", "''");
                                fMain._fMain.SetCellAccount(k, "cProxy", object_);
                            }
                        }
                    }
                }
                if (_lstProxy != null)
                {
                    _lstProxy = txtProxy.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                MessageCommon.ShowMessageBox("Import Proxy Success!");
                Close();
            }
            catch (Exception)
            {
                MessageCommon.ShowMessageBox("Error please try again later!", 4);
            }
        }

        private void txtProxy_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.UpdateLineCount(txtProxy, lblProxy);
        }
    }
}
