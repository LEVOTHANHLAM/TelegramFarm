using Krypton.Toolkit;
using Serilog;
using System.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fAddAccounts : KryptonForm
    {
        internal List<string> listFormat = new List<string>();
        IFilesService _filesService;
        IAccountsService _accountsService;
        internal int Indexfolder = 0;
        internal bool update = false;
        internal string folderName = string.Empty;
        internal List<ComboBox> Other;
        public fAddAccounts(IFilesService filesService, IAccountsService accountsService)
        {
            InitializeComponent();
            _filesService = filesService;
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
            _accountsService = accountsService;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listAccount = txbAccount.Lines.ToList();
                listAccount = CommonMethods.RemoveEmptyLines(listAccount);
                if (listAccount.Count == 0)
                {
                    MessageCommon.ShowMessageBox("Please enter your account information", 3);
                    txbAccount.Focus();
                    return;
                }
                if (cbbFolder.SelectedValue == null)
                {
                    MessageCommon.ShowMessageBox("Please select folder", 3);
                    return;
                }
                string folderValue = cbbFolder.SelectedValue.ToString();
                string inputFormatText = cbbInputFormat.Text;
                int selectedIndex = cbbInputFormat.SelectedIndex;
                if (string.IsNullOrEmpty(inputFormatText))
                {
                    MessageCommon.ShowMessageBox("Please choose an account format", 3);
                    return;
                }
                if (inputFormatText.Contains("Other"))
                {
                    bool flag = false;
                    for (int i = 0; i < Other.Count; i++)
                    {
                        if (Other[i].SelectedIndex > 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        MessageCommon.ShowMessageBox("Please choose an account format!", 3);
                        return;
                    }
                    var formatOther = "";
                    for (int j = 0; j < Other.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(Other[j].Text))
                        {
                            formatOther = formatOther + Other[j].Text + "|";
                        }

                    }
                    formatOther = formatOther.TrimEnd('|');
                    inputFormatText = formatOther;
                }
                string[] inputFormatTexts = inputFormatText.Split('|');

                List<Accounts> list_accounts = new List<Accounts>();
                int success = 0; int error = 0;
                var dateTime = DateTime.Now;
                lblStatus.Text = "Adding an account...";
                foreach (var account in listAccount)
                {
                    try
                    {
                        var newAccount = new Accounts();
                        List<string> accounts = account.Split('|').ToList();
                        foreach (var formatText in inputFormatTexts)
                        {
                            int i = Array.IndexOf(inputFormatTexts, formatText);
                            switch (formatText)
                            {
                                case "Phone":
                                   newAccount.PhoneNumber = accounts[i].Trim();
                                    break;
                                case "Password":
                                    newAccount.Password = accounts[i].Trim();
                                    break;
                                case "Session":
                                    newAccount.Session = accounts[i].Trim();
                                    break;
                                case "Proxy":
                                    newAccount.Proxy = accounts[i].Trim();
                                    break;
                                case "AppId":
                                   newAccount.AppId = accounts[i].Trim();
                                    break;
                                case "AppHash":
                                    newAccount.AppHash = accounts[i].Trim();
                                    break;
                                case "UserName":
                                    newAccount.UserName = accounts[i].Trim();
                                    break;
                            }
                        }
                        if (string.IsNullOrEmpty(newAccount.PhoneNumber))
                        {
                            lblError.Text = error.ToString();
                            error++;
                            continue;
                        }
                        var checkUid = _accountsService.GetAccountByPhonenumber(newAccount.PhoneNumber);
                        if (checkUid != null)
                        {
                            lblError.Text = error.ToString();
                            error++;
                            continue;
                        }
                        newAccount.DateImport = dateTime;
                        newAccount.IdAccount = Guid.NewGuid();
                        newAccount.IdFile = new Guid(folderValue);
                        list_accounts.Add(newAccount);
                        lblSuccess.Text = success.ToString();
                        success++;
                    }
                    catch (Exception)
                    {
                        lblError.Text = error.ToString();
                        error++;
                    }
                }
                //lblSuccess.Text = success.ToString();
                //lblError.Text = error.ToString();
                if (list_accounts.Any())
                {
                    _accountsService.CreateList(list_accounts);
                    lblStatus.Text = "Successfully added account!";
                    MessageCommon.ShowMessageBox("Successfully added account!", 1);
                }
                else
                {
                    lblStatus.Text = "Adding account failed!";
                    MessageCommon.ShowMessageBox("Adding account failed!", 3);
                }
                update = true;
                folderName = cbbFolder.Text.ToString();
            }
            catch
            {
            }
        }

        private void fAddAccounts_Load(object sender, EventArgs e)
        {
            var fileFormat = Path.Combine(Environment.CurrentDirectory, "settings\\ListFormat.txt");
            if (File.Exists(fileFormat))
            {
                listFormat = new FileHelper(fileFormat).ReadFile();
                listFormat.Add("Other ...");
                Other = new List<ComboBox>
            {
                cbbFormat1, cbbFormat2, cbbFormat3, cbbFormat4, cbbFormat5, cbbFormat6, cbbFormat7, cbbFormat8
            };
                foreach (ComboBox item in Other)
                {
                    BindComboBoxWithLocalizedValues(item, new List<string>
            {
                "Phone", "Password", "Session", "AppId", "AppHash", "Proxy","UserName"
            });
                    item.SelectedIndex = -1;
                    item.DropDownWidth = 100;
                }
                SetListFormat();
                GetDataFolder("");
            }

        }
        public static void BindComboBoxWithLocalizedValues(ComboBox comboBox, List<string> stringValues)
        {
            Dictionary<string, string> localizedDictionary = new Dictionary<string, string>();
            for (int i = 0; i < stringValues.Count; i++)
            {
                localizedDictionary.Add(i.ToString() ?? "", stringValues[i]);
            }
            comboBox.DataSource = new BindingSource(localizedDictionary, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        private void SetListFormat()
        {
            cbbInputFormat.Items.Clear();
            for (int i = 0; i < listFormat.Count; i++)
            {
                cbbInputFormat.Items.Add(listFormat[i]);
            }
            cbbInputFormat.SelectedIndex = 0;
            //cbbInputFormat.Items.Add("Other...");
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            fAddFile form_ = new fAddFile(_filesService);
            FormHelper.ShowFormWithoutTaskbar(form_);
            if (fAddFile.add)
            {
                GetDataFolder(fAddFile.folderName);
            }
        }
        private void GetDataFolder(string folderName)
        {
            Indexfolder = cbbFolder.SelectedIndex;
            var data = new List<KeyValuePair<string, string>>();

            var list = _filesService.GetAll();

            if (list != null && list.Count > 0)
            {
                data.AddRange(list.Select(x => new KeyValuePair<string, string>(x.IdFile.ToString(), x.Name)).ToList());
                cbbFolder.DataSource = null;
                cbbFolder.Items.Clear();
                cbbFolder.DataSource = data;
                cbbFolder.DisplayMember = "Value"; // Hiển thị tên
                cbbFolder.ValueMember = "Key"; // Lấy Id
                if (!string.IsNullOrEmpty(folderName))
                {
                    var selectedItem = data.FirstOrDefault(x => x.Value == folderName);
                    if (selectedItem.Key != null)
                    {
                        var index = data.IndexOf(selectedItem);
                        cbbFolder.SelectedIndex = index;
                    }
                }
                else
                {
                    if (Indexfolder == -1)
                    {
                        Indexfolder = 0;
                    }
                    cbbFolder.SelectedIndex = Indexfolder;
                }
            }
            else
            {
                cbbFolder.Items.Clear();
            }
        }

        private void txbAccount_TextChanged(object sender, EventArgs e)
        {
            List<string> listAccount = txbAccount.Lines.ToList();
            listAccount = CommonMethods.RemoveEmptyLines(listAccount);
            lblTotal.Text = listAccount.Count.ToString();
        }

        private void cbbInputFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            plFormatInput.Visible = cbbInputFormat.SelectedIndex == cbbInputFormat.Items.Count - 1;
        }

        private void btnResetFormat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Other.Count; i++)
                {
                    Other[i].SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }

        private void SaveFormat_Click(object sender, EventArgs e)
        {
            try
            {
                var formatOther = "";
                for (int j = 0; j < Other.Count; j++)
                {
                    if (!string.IsNullOrEmpty(Other[j].Text))
                    {
                        formatOther = formatOther + Other[j].Text + "|";
                    }

                }
                formatOther = formatOther.TrimEnd('|');
                if (!string.IsNullOrEmpty(formatOther))
                {
                    listFormat.Remove("Other ...");
                    listFormat.Add(formatOther);
                    var fileFormat = Path.Combine(Environment.CurrentDirectory, "settings\\ListFormat.txt");
                    new FileHelper(fileFormat).WriteFile(listFormat);
                    MessageCommon.ShowMessageBox("Save format successfully!", 1);
                }
            }
            catch (Exception ex)
            {

                Log.Error(ex, ex.Message);
            }

        }
    }
}
