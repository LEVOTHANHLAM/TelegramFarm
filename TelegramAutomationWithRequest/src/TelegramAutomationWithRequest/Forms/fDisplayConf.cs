using TelegramAutomationWithRequest.Helper;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fDisplayConf : Form
    {
        internal static bool add = false;
        internal static string folderName = string.Empty;

        public fDisplayConf()
        {
            InitializeComponent();
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void fDisplayConf_Load(object sender, EventArgs e)
        {
            ckbApHash.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbApHash");
            ckbUsername.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbUsername");
            ckbSession.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbSession");
            ckbFullname.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbFullname");
            ckbCookie.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbCookie");
            ckbApId.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbApId");
            ckbStatus.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbStatus");
            ckbFolder.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbFolder");
            ckbInteractEnd.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbInteractEnd");
            ckbAccountStatus.Checked = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbAccountStatus");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbApHash", ckbApHash.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbSession", ckbSession.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbFullname", ckbFullname.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbCookie", ckbCookie.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbApId", ckbApId.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbStatus", ckbStatus.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbFolder", ckbFolder.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbInteractEnd", ckbInteractEnd.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbAccountStatus", ckbAccountStatus.Checked);
            SettingsTool.GetSettings("configDatagridview").AddValue("ckbUsername", ckbUsername.Checked);
            SettingsTool.UpdateSetting("configDatagridview");
            CommonMethods.CloseForm(this);
        }

    }
}
