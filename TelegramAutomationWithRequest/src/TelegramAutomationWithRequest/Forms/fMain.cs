using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using TelegramAutomationWithRequest.ApiQnibot;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Model;
using TelegramAutomationWithRequest.Services.Interfaces;
using TelegramAutomationWithRequest.Telegram;
using TL;
using WTelegram;
using Application = System.Windows.Forms.Application;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using FontStyle = System.Drawing.FontStyle;
using Image = System.Drawing.Image;
using Log = Serilog.Log;
using Path = System.IO.Path;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SystemColors = System.Drawing.SystemColors;
using TextBox = System.Windows.Forms.TextBox;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fMain : KryptonForm
    {
        private string IdScript = "";
        private string IdFile = "";
        private readonly IScriptService _scriptService;
        private readonly Func<IActionsService> _actionsService;
        private readonly IFilesService _filesService;
        private readonly IAccountsService _accountsService;
        private string search = "";
        internal List<string> list_proxy = new List<string>();
        internal static fMain _fMain;
        private Random _random;
        private object _lockObject;
        private int nudAccountProxy = 0;
        private bool rbRandom = false;
        private readonly IServiceProvider _serviceProvider;
        private int numberView = 0;
        private CancellationTokenSource cancellationTokenSource;
        private List<Task> tasks;
        private int MaxThread { get; set; }
        private SemaphoreSlim semaphore;
        private int MaxDisplay { get; set; }
        private fLoading _fLoading;
        public fMain(IScriptService scriptService, Func<IActionsService> actionsService, IFilesService filesService, IAccountsService accountsService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _scriptService = scriptService;
            _actionsService = actionsService;
            _filesService = filesService;
            _accountsService = accountsService;
            GetConfigDatagridview();
            _fMain = this;
            RichTextBoxHelper._RichTextBox = new RichTextBox();
            RichTextBoxHelper._RichTextBox = rtbLog;
            _random = new Random();
            _lockObject = new object();
            string pathProxy = Path.Combine(Environment.CurrentDirectory, "Database\\Proxy\\Proxy.txt");
            if (File.Exists(pathProxy))
            {
                var lines = File.ReadAllLines(pathProxy);
                foreach (var line in lines)
                {
                    list_proxy.Add(line);
                }
            }
            _serviceProvider = serviceProvider;
            tasks = new List<Task>();
            cancellationTokenSource = new CancellationTokenSource();
            _fLoading = new fLoading();
        }
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(fMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            kryptonPalette1 = new KryptonCustomPaletteBase(components);
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            ctmsAcc = new ContextMenuStrip(components);
            selectedToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            selectAllHighlightedToolStripMenuItem = new ToolStripMenuItem();
            deselectAllToolStripMenuItem = new ToolStripMenuItem();
            moveFolderToolStripMenuItem = new ToolStripMenuItem();
            deleteAccToolStripMenuItem = new ToolStripMenuItem();
            assignAProxyToolStripMenuItem = new ToolStripMenuItem();
            exportFileToolStripMenuItem = new ToolStripMenuItem();
            updateAccountToolStripMenuItem = new ToolStripMenuItem();
            proxy = new TabPage();
            pictureBox2 = new PictureBox();
            home = new TabPage();
            groupBox2 = new GroupBox();
            dtgvAcc = new DataGridView();
            cChose = new DataGridViewCheckBoxColumn();
            cStt = new DataGridViewTextBoxColumn();
            cId = new DataGridViewTextBoxColumn();
            cPhone = new DataGridViewTextBoxColumn();
            cPassword = new DataGridViewTextBoxColumn();
            cAppId = new DataGridViewTextBoxColumn();
            cAppHash = new DataGridViewTextBoxColumn();
            cUsername = new DataGridViewTextBoxColumn();
            cSession = new DataGridViewTextBoxColumn();
            cCookies = new DataGridViewTextBoxColumn();
            cProxy = new DataGridViewTextBoxColumn();
            cFullname = new DataGridViewTextBoxColumn();
            cThuMuc = new DataGridViewTextBoxColumn();
            cInteractEnd = new DataGridViewTextBoxColumn();
            cInfo = new DataGridViewTextBoxColumn();
            cStatus = new DataGridViewTextBoxColumn();
            cLogin = new DataGridViewButtonColumn();
            cChrome = new DataGridViewButtonColumn();
            cGetCode = new DataGridViewButtonColumn();
            cUserAgent = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gbChannels = new GroupBox();
            btnDeleteChannels = new BunifuImageButton();
            cb_fLeaveChannels = new CheckBox();
            btnSubscribersChannels = new BunifuImageButton();
            cb_fSubscribersChannels = new CheckBox();
            btnCreateChannels = new BunifuImageButton();
            cb_fCreateChannels = new CheckBox();
            gbGroups = new GroupBox();
            btnLeaveGroups = new BunifuImageButton();
            cb_fLeaveGroups = new CheckBox();
            btnGetNembersInGroups = new BunifuImageButton();
            cb_fGetNembersInGroups = new CheckBox();
            btnSendPrivateMessagesToEveryoneInTheGroups = new BunifuImageButton();
            cb_fSendPrivateMessages = new CheckBox();
            btnSendMessagesToGroups = new BunifuImageButton();
            cb_fSendMessagesToGroups = new CheckBox();
            btnJoinGroups = new BunifuImageButton();
            cb_fJoinGroups = new CheckBox();
            btnAddNembersByUsername = new BunifuImageButton();
            cb_fAddNembersByUsername = new CheckBox();
            btnCreateGroups = new BunifuImageButton();
            cb_fCreateGroups = new CheckBox();
            gbProfile = new GroupBox();
            btnUpdateBIOS = new BunifuImageButton();
            cb_fUpdateBio = new CheckBox();
            btnUpdatePassword = new BunifuImageButton();
            cb_fUpdatePassword = new CheckBox();
            btnUpdateFullname = new BunifuImageButton();
            cb_fUpdateFullname = new CheckBox();
            btnUpdateUsername = new BunifuImageButton();
            cb_fUpdateUsername = new CheckBox();
            btnUpdateAvatar = new BunifuImageButton();
            cb_fUpdateAvatar = new CheckBox();
            gbFriends = new GroupBox();
            btnMessageAllContact = new BunifuImageButton();
            cb_fMessageAllContact = new CheckBox();
            btnAddToContact = new BunifuImageButton();
            cb_fAddToContact = new CheckBox();
            btnBlockByUsername = new BunifuImageButton();
            cb_fBlockByUsername = new CheckBox();
            btnSendMessagesByUsername = new BunifuImageButton();
            cb_fSendMessages = new CheckBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            ckbRandomAction = new CheckBox();
            plRepeat = new Panel();
            nudRepeatFrom = new NumericUpDown();
            nudRepeatTo = new NumericUpDown();
            label3 = new Label();
            ckbRepeatAfter = new CheckBox();
            lbAccount = new Label();
            btn_AddScript = new BunifuImageButton();
            btn_delScript = new BunifuImageButton();
            btn_saveScript = new Button();
            btnSave = new Button();
            label2 = new Label();
            scriptName = new TextBox();
            ddl_Script = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            cbCheckDuplicate = new CheckBox();
            btn_clearUM = new Button();
            btnDelFolder = new BunifuImageButton();
            btn_stop = new Button();
            btnDisplay = new Button();
            btn_start = new Button();
            btnSearch = new Button();
            nudNumberThreads = new NumericUpDown();
            txtSearch = new TextBox();
            btnAddAccount = new Button();
            cbbFolder = new ComboBox();
            label8 = new Label();
            groupBox9 = new GroupBox();
            btnEnterFile = new Button();
            rbProxyFromFile = new RadioButton();
            rbProxyFromAccount = new RadioButton();
            rbNoProxy = new RadioButton();
            menu = new TabControl();
            tpLog = new TabPage();
            panel1 = new Panel();
            rtbLog = new RichTextBox();
            ctmsAcc.SuspendLayout();
            proxy.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            home.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)dtgvAcc).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            gbChannels.SuspendLayout();
            ((ISupportInitialize)btnDeleteChannels).BeginInit();
            ((ISupportInitialize)btnSubscribersChannels).BeginInit();
            ((ISupportInitialize)btnCreateChannels).BeginInit();
            gbGroups.SuspendLayout();
            ((ISupportInitialize)btnLeaveGroups).BeginInit();
            ((ISupportInitialize)btnGetNembersInGroups).BeginInit();
            ((ISupportInitialize)btnSendPrivateMessagesToEveryoneInTheGroups).BeginInit();
            ((ISupportInitialize)btnSendMessagesToGroups).BeginInit();
            ((ISupportInitialize)btnJoinGroups).BeginInit();
            ((ISupportInitialize)btnAddNembersByUsername).BeginInit();
            ((ISupportInitialize)btnCreateGroups).BeginInit();
            gbProfile.SuspendLayout();
            ((ISupportInitialize)btnUpdateBIOS).BeginInit();
            ((ISupportInitialize)btnUpdatePassword).BeginInit();
            ((ISupportInitialize)btnUpdateFullname).BeginInit();
            ((ISupportInitialize)btnUpdateUsername).BeginInit();
            ((ISupportInitialize)btnUpdateAvatar).BeginInit();
            gbFriends.SuspendLayout();
            ((ISupportInitialize)btnMessageAllContact).BeginInit();
            ((ISupportInitialize)btnAddToContact).BeginInit();
            ((ISupportInitialize)btnBlockByUsername).BeginInit();
            ((ISupportInitialize)btnSendMessagesByUsername).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            plRepeat.SuspendLayout();
            ((ISupportInitialize)nudRepeatFrom).BeginInit();
            ((ISupportInitialize)nudRepeatTo).BeginInit();
            ((ISupportInitialize)btn_AddScript).BeginInit();
            ((ISupportInitialize)btn_delScript).BeginInit();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)btnDelFolder).BeginInit();
            ((ISupportInitialize)nudNumberThreads).BeginInit();
            groupBox9.SuspendLayout();
            menu.SuspendLayout();
            tpLog.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.BaseFontSize = 9F;
            kryptonPalette1.BasePaletteType = BasePaletteType.Custom;
            kryptonPalette1.ThemeName = null;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ThemeName = null;
            // 
            // ctmsAcc
            // 
            ctmsAcc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ctmsAcc.Items.AddRange(new ToolStripItem[] { selectedToolStripMenuItem, deselectAllToolStripMenuItem, moveFolderToolStripMenuItem, deleteAccToolStripMenuItem, assignAProxyToolStripMenuItem, exportFileToolStripMenuItem, updateAccountToolStripMenuItem });
            ctmsAcc.Name = "contextMenuStrip1";
            ctmsAcc.Size = new Size(158, 158);
            ctmsAcc.Opening += ctmsAcc_Opening;
            // 
            // selectedToolStripMenuItem
            // 
            selectedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectAllToolStripMenuItem, selectAllHighlightedToolStripMenuItem });
            selectedToolStripMenuItem.Image = (Image)resources.GetObject("selectedToolStripMenuItem.Image");
            selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            selectedToolStripMenuItem.Size = new Size(157, 22);
            selectedToolStripMenuItem.Text = "Selected";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Image = (Image)resources.GetObject("selectAllToolStripMenuItem.Image");
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(184, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // selectAllHighlightedToolStripMenuItem
            // 
            selectAllHighlightedToolStripMenuItem.Image = (Image)resources.GetObject("selectAllHighlightedToolStripMenuItem.Image");
            selectAllHighlightedToolStripMenuItem.Name = "selectAllHighlightedToolStripMenuItem";
            selectAllHighlightedToolStripMenuItem.Size = new Size(184, 22);
            selectAllHighlightedToolStripMenuItem.Text = "Select all highlighted";
            selectAllHighlightedToolStripMenuItem.Click += selectAllHighlightedToolStripMenuItem_Click;
            // 
            // deselectAllToolStripMenuItem
            // 
            deselectAllToolStripMenuItem.Image = (Image)resources.GetObject("deselectAllToolStripMenuItem.Image");
            deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            deselectAllToolStripMenuItem.Size = new Size(157, 22);
            deselectAllToolStripMenuItem.Text = "Deselect all";
            deselectAllToolStripMenuItem.Click += deselectAllToolStripMenuItem_Click;
            // 
            // moveFolderToolStripMenuItem
            // 
            moveFolderToolStripMenuItem.Image = (Image)resources.GetObject("moveFolderToolStripMenuItem.Image");
            moveFolderToolStripMenuItem.Name = "moveFolderToolStripMenuItem";
            moveFolderToolStripMenuItem.Size = new Size(157, 22);
            moveFolderToolStripMenuItem.Text = "Move folder";
            moveFolderToolStripMenuItem.Click += moveFolderToolStripMenuItem_Click;
            // 
            // deleteAccToolStripMenuItem
            // 
            deleteAccToolStripMenuItem.Image = (Image)resources.GetObject("deleteAccToolStripMenuItem.Image");
            deleteAccToolStripMenuItem.Name = "deleteAccToolStripMenuItem";
            deleteAccToolStripMenuItem.Size = new Size(157, 22);
            deleteAccToolStripMenuItem.Text = "Delete Account";
            deleteAccToolStripMenuItem.Click += deleteAccToolStripMenuItem_Click;
            // 
            // assignAProxyToolStripMenuItem
            // 
            assignAProxyToolStripMenuItem.Image = (Image)resources.GetObject("assignAProxyToolStripMenuItem.Image");
            assignAProxyToolStripMenuItem.Name = "assignAProxyToolStripMenuItem";
            assignAProxyToolStripMenuItem.Size = new Size(157, 22);
            assignAProxyToolStripMenuItem.Text = "Assign a proxy";
            assignAProxyToolStripMenuItem.Click += assignAProxyToolStripMenuItem_Click;
            // 
            // exportFileToolStripMenuItem
            // 
            exportFileToolStripMenuItem.Image = (Image)resources.GetObject("exportFileToolStripMenuItem.Image");
            exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            exportFileToolStripMenuItem.Size = new Size(157, 22);
            exportFileToolStripMenuItem.Text = "Export File";
            exportFileToolStripMenuItem.Click += exportFileToolStripMenuItem_Click;
            // 
            // updateAccountToolStripMenuItem
            // 
            updateAccountToolStripMenuItem.Image = (Image)resources.GetObject("updateAccountToolStripMenuItem.Image");
            updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            updateAccountToolStripMenuItem.Size = new Size(157, 22);
            updateAccountToolStripMenuItem.Text = "UpdateAccount";
            updateAccountToolStripMenuItem.Click += updateAccountToolStripMenuItem_Click;
            // 
            // proxy
            // 
            proxy.Controls.Add(pictureBox2);
            proxy.Location = new Point(4, 24);
            proxy.Name = "proxy";
            proxy.Padding = new Padding(3);
            proxy.Size = new Size(1584, 814);
            proxy.TabIndex = 5;
            proxy.Text = "License";
            proxy.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1578, 808);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // home
            // 
            home.Controls.Add(groupBox2);
            home.Location = new Point(4, 24);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(1584, 814);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dtgvAcc);
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1578, 808);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // dtgvAcc
            // 
            dtgvAcc.AllowUserToAddRows = false;
            dtgvAcc.AllowUserToDeleteRows = false;
            dtgvAcc.AllowUserToResizeRows = false;
            dtgvAcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAcc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvAcc.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAcc.Columns.AddRange(new DataGridViewColumn[] { cChose, cStt, cId, cPhone, cPassword, cAppId, cAppHash, cUsername, cSession, cCookies, cProxy, cFullname, cThuMuc, cInteractEnd, cInfo, cStatus, cLogin, cChrome, cGetCode, cUserAgent });
            dtgvAcc.ContextMenuStrip = ctmsAcc;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvAcc.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvAcc.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvAcc.Location = new Point(3, 318);
            dtgvAcc.Name = "dtgvAcc";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvAcc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvAcc.RowHeadersVisible = false;
            dtgvAcc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgvAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAcc.Size = new Size(1572, 487);
            dtgvAcc.TabIndex = 30;
            dtgvAcc.CellClick += DtgvAcc_CellClick;
            dtgvAcc.CellContentClick += dtgvAcc_CellContentClick;
            dtgvAcc.CellDoubleClick += dtgvAcc_CellDoubleClick;
            dtgvAcc.SelectionChanged += dtgvAcc_SelectionChanged;
            // 
            // cChose
            // 
            cChose.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cChose.FillWeight = 55F;
            cChose.HeaderText = "Choose";
            cChose.Name = "cChose";
            cChose.SortMode = DataGridViewColumnSortMode.Automatic;
            cChose.Width = 55;
            // 
            // cStt
            // 
            cStt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cStt.DefaultCellStyle = dataGridViewCellStyle2;
            cStt.FillWeight = 61.4097557F;
            cStt.HeaderText = "No.";
            cStt.Name = "cStt";
            cStt.Width = 53;
            // 
            // cId
            // 
            cId.HeaderText = "Id";
            cId.Name = "cId";
            cId.Visible = false;
            // 
            // cPhone
            // 
            cPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cPhone.FillWeight = 95.24205F;
            cPhone.HeaderText = "Phone";
            cPhone.Name = "cPhone";
            cPhone.Width = 62;
            // 
            // cPassword
            // 
            cPassword.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cPassword.FillWeight = 91.195F;
            cPassword.HeaderText = "Password";
            cPassword.Name = "cPassword";
            cPassword.Width = 86;
            // 
            // cAppId
            // 
            cAppId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cAppId.HeaderText = "App Id";
            cAppId.Name = "cAppId";
            cAppId.SortMode = DataGridViewColumnSortMode.NotSortable;
            cAppId.Width = 90;
            // 
            // cAppHash
            // 
            cAppHash.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cAppHash.HeaderText = "App Hash";
            cAppHash.Name = "cAppHash";
            cAppHash.ReadOnly = true;
            // 
            // cUsername
            // 
            cUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cUsername.FillWeight = 108.81488F;
            cUsername.HeaderText = "Username";
            cUsername.Name = "cUsername";
            // 
            // cSession
            // 
            cSession.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cSession.FillWeight = 89.08846F;
            cSession.HeaderText = "Session";
            cSession.Name = "cSession";
            cSession.Width = 73;
            // 
            // cCookies
            // 
            cCookies.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cCookies.HeaderText = "Cookies";
            cCookies.Name = "cCookies";
            // 
            // cProxy
            // 
            cProxy.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cProxy.FillWeight = 65.04761F;
            cProxy.HeaderText = "Proxy";
            cProxy.Name = "cProxy";
            cProxy.Width = 65;
            // 
            // cFullname
            // 
            cFullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cFullname.HeaderText = "Fullname";
            cFullname.Name = "cFullname";
            // 
            // cThuMuc
            // 
            cThuMuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cThuMuc.FillWeight = 112.204025F;
            cThuMuc.HeaderText = "Folder";
            cThuMuc.Name = "cThuMuc";
            cThuMuc.Width = 67;
            // 
            // cInteractEnd
            // 
            cInteractEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cInteractEnd.FillWeight = 107.753716F;
            cInteractEnd.HeaderText = "Last Interaction";
            cInteractEnd.Name = "cInteractEnd";
            cInteractEnd.Width = 120;
            // 
            // cInfo
            // 
            cInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cInfo.HeaderText = "Account Status";
            cInfo.Name = "cInfo";
            cInfo.Width = 70;
            // 
            // cStatus
            // 
            cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cStatus.FillWeight = 500F;
            cStatus.HeaderText = "Log";
            cStatus.MinimumWidth = 100;
            cStatus.Name = "cStatus";
            // 
            // cLogin
            // 
            cLogin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cLogin.HeaderText = "Manual Login";
            cLogin.Name = "cLogin";
            // 
            // cChrome
            // 
            cChrome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cChrome.HeaderText = "Show Browser";
            cChrome.Name = "cChrome";
            cChrome.Resizable = DataGridViewTriState.True;
            cChrome.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cGetCode
            // 
            cGetCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cGetCode.HeaderText = "Get Code";
            cGetCode.Name = "cGetCode";
            // 
            // cUserAgent
            // 
            cUserAgent.HeaderText = "cUserAgent";
            cUserAgent.Name = "cUserAgent";
            cUserAgent.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(gbChannels);
            flowLayoutPanel1.Controls.Add(gbGroups);
            flowLayoutPanel1.Controls.Add(gbProfile);
            flowLayoutPanel1.Controls.Add(gbFriends);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1572, 293);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // gbChannels
            // 
            gbChannels.Controls.Add(btnDeleteChannels);
            gbChannels.Controls.Add(cb_fLeaveChannels);
            gbChannels.Controls.Add(btnSubscribersChannels);
            gbChannels.Controls.Add(cb_fSubscribersChannels);
            gbChannels.Controls.Add(btnCreateChannels);
            gbChannels.Controls.Add(cb_fCreateChannels);
            gbChannels.Location = new Point(3, 3);
            gbChannels.Name = "gbChannels";
            gbChannels.Size = new Size(234, 135);
            gbChannels.TabIndex = 34;
            gbChannels.TabStop = false;
            gbChannels.Text = "Channels";
            // 
            // btnDeleteChannels
            // 
            btnDeleteChannels.BackColor = Color.White;
            btnDeleteChannels.ErrorImage = Properties.Resources.settings;
            btnDeleteChannels.Image = Properties.Resources.gear;
            btnDeleteChannels.ImageActive = Properties.Resources.gear;
            btnDeleteChannels.InitialImage = Properties.Resources.settings;
            btnDeleteChannels.Location = new Point(201, 74);
            btnDeleteChannels.Name = "btnDeleteChannels";
            btnDeleteChannels.Size = new Size(21, 17);
            btnDeleteChannels.SizeMode = PictureBoxSizeMode.Zoom;
            btnDeleteChannels.TabIndex = 31;
            btnDeleteChannels.TabStop = false;
            btnDeleteChannels.Zoom = 10;
            btnDeleteChannels.Click += btnDeleteChannels_Click;
            // 
            // cb_fLeaveChannels
            // 
            cb_fLeaveChannels.AutoSize = true;
            cb_fLeaveChannels.Location = new Point(12, 72);
            cb_fLeaveChannels.Name = "cb_fLeaveChannels";
            cb_fLeaveChannels.Size = new Size(108, 19);
            cb_fLeaveChannels.TabIndex = 29;
            cb_fLeaveChannels.Text = "Leave Channels";
            cb_fLeaveChannels.UseVisualStyleBackColor = true;
            // 
            // btnSubscribersChannels
            // 
            btnSubscribersChannels.BackColor = Color.White;
            btnSubscribersChannels.ErrorImage = Properties.Resources.settings;
            btnSubscribersChannels.Image = Properties.Resources.gear;
            btnSubscribersChannels.ImageActive = Properties.Resources.gear;
            btnSubscribersChannels.InitialImage = Properties.Resources.settings;
            btnSubscribersChannels.Location = new Point(201, 49);
            btnSubscribersChannels.Name = "btnSubscribersChannels";
            btnSubscribersChannels.Size = new Size(21, 17);
            btnSubscribersChannels.SizeMode = PictureBoxSizeMode.Zoom;
            btnSubscribersChannels.TabIndex = 25;
            btnSubscribersChannels.TabStop = false;
            btnSubscribersChannels.Zoom = 10;
            btnSubscribersChannels.Click += btnSubscribersChannels_Click;
            // 
            // cb_fSubscribersChannels
            // 
            cb_fSubscribersChannels.AutoSize = true;
            cb_fSubscribersChannels.Location = new Point(12, 47);
            cb_fSubscribersChannels.Name = "cb_fSubscribersChannels";
            cb_fSubscribersChannels.Size = new Size(144, 19);
            cb_fSubscribersChannels.TabIndex = 24;
            cb_fSubscribersChannels.Text = "Subscribe To Channels";
            cb_fSubscribersChannels.UseVisualStyleBackColor = true;
            // 
            // btnCreateChannels
            // 
            btnCreateChannels.BackColor = Color.White;
            btnCreateChannels.ErrorImage = Properties.Resources.settings;
            btnCreateChannels.Image = Properties.Resources.gear;
            btnCreateChannels.ImageActive = Properties.Resources.gear;
            btnCreateChannels.InitialImage = Properties.Resources.settings;
            btnCreateChannels.Location = new Point(201, 22);
            btnCreateChannels.Name = "btnCreateChannels";
            btnCreateChannels.Size = new Size(21, 17);
            btnCreateChannels.SizeMode = PictureBoxSizeMode.Zoom;
            btnCreateChannels.TabIndex = 23;
            btnCreateChannels.TabStop = false;
            btnCreateChannels.Zoom = 10;
            btnCreateChannels.Click += btnCreateChannels_Click;
            // 
            // cb_fCreateChannels
            // 
            cb_fCreateChannels.AutoSize = true;
            cb_fCreateChannels.Location = new Point(12, 22);
            cb_fCreateChannels.Name = "cb_fCreateChannels";
            cb_fCreateChannels.Size = new Size(112, 19);
            cb_fCreateChannels.TabIndex = 22;
            cb_fCreateChannels.Text = "Create Channels";
            cb_fCreateChannels.UseVisualStyleBackColor = true;
            // 
            // gbGroups
            // 
            gbGroups.Controls.Add(btnLeaveGroups);
            gbGroups.Controls.Add(cb_fLeaveGroups);
            gbGroups.Controls.Add(btnGetNembersInGroups);
            gbGroups.Controls.Add(cb_fGetNembersInGroups);
            gbGroups.Controls.Add(btnSendPrivateMessagesToEveryoneInTheGroups);
            gbGroups.Controls.Add(cb_fSendPrivateMessages);
            gbGroups.Controls.Add(btnSendMessagesToGroups);
            gbGroups.Controls.Add(cb_fSendMessagesToGroups);
            gbGroups.Controls.Add(btnJoinGroups);
            gbGroups.Controls.Add(cb_fJoinGroups);
            gbGroups.Controls.Add(btnAddNembersByUsername);
            gbGroups.Controls.Add(cb_fAddNembersByUsername);
            gbGroups.Controls.Add(btnCreateGroups);
            gbGroups.Controls.Add(cb_fCreateGroups);
            gbGroups.Location = new Point(243, 3);
            gbGroups.Name = "gbGroups";
            gbGroups.Size = new Size(554, 135);
            gbGroups.TabIndex = 34;
            gbGroups.TabStop = false;
            gbGroups.Text = "Groups";
            // 
            // btnLeaveGroups
            // 
            btnLeaveGroups.BackColor = Color.White;
            btnLeaveGroups.ErrorImage = Properties.Resources.settings;
            btnLeaveGroups.Image = Properties.Resources.gear;
            btnLeaveGroups.ImageActive = Properties.Resources.gear;
            btnLeaveGroups.InitialImage = Properties.Resources.settings;
            btnLeaveGroups.Location = new Point(457, 68);
            btnLeaveGroups.Name = "btnLeaveGroups";
            btnLeaveGroups.Size = new Size(21, 17);
            btnLeaveGroups.SizeMode = PictureBoxSizeMode.Zoom;
            btnLeaveGroups.TabIndex = 51;
            btnLeaveGroups.TabStop = false;
            btnLeaveGroups.Zoom = 10;
            btnLeaveGroups.Click += btnLeaveGroups_Click;
            // 
            // cb_fLeaveGroups
            // 
            cb_fLeaveGroups.AutoSize = true;
            cb_fLeaveGroups.Location = new Point(223, 64);
            cb_fLeaveGroups.Name = "cb_fLeaveGroups";
            cb_fLeaveGroups.Size = new Size(97, 19);
            cb_fLeaveGroups.TabIndex = 50;
            cb_fLeaveGroups.Text = "Leave Groups";
            cb_fLeaveGroups.UseVisualStyleBackColor = true;
            // 
            // btnGetNembersInGroups
            // 
            btnGetNembersInGroups.BackColor = Color.White;
            btnGetNembersInGroups.ErrorImage = Properties.Resources.settings;
            btnGetNembersInGroups.Image = Properties.Resources.gear;
            btnGetNembersInGroups.ImageActive = Properties.Resources.gear;
            btnGetNembersInGroups.InitialImage = Properties.Resources.settings;
            btnGetNembersInGroups.Location = new Point(196, 95);
            btnGetNembersInGroups.Name = "btnGetNembersInGroups";
            btnGetNembersInGroups.Size = new Size(21, 17);
            btnGetNembersInGroups.SizeMode = PictureBoxSizeMode.Zoom;
            btnGetNembersInGroups.TabIndex = 49;
            btnGetNembersInGroups.TabStop = false;
            btnGetNembersInGroups.Zoom = 10;
            btnGetNembersInGroups.Click += btnGetNembersInGroups_Click;
            // 
            // cb_fGetNembersInGroups
            // 
            cb_fGetNembersInGroups.AutoSize = true;
            cb_fGetNembersInGroups.Location = new Point(7, 95);
            cb_fGetNembersInGroups.Name = "cb_fGetNembersInGroups";
            cb_fGetNembersInGroups.Size = new Size(181, 19);
            cb_fGetNembersInGroups.TabIndex = 48;
            cb_fGetNembersInGroups.Text = "Scrape Members From Group";
            cb_fGetNembersInGroups.UseVisualStyleBackColor = true;
            // 
            // btnSendPrivateMessagesToEveryoneInTheGroups
            // 
            btnSendPrivateMessagesToEveryoneInTheGroups.BackColor = Color.White;
            btnSendPrivateMessagesToEveryoneInTheGroups.ErrorImage = Properties.Resources.settings;
            btnSendPrivateMessagesToEveryoneInTheGroups.Image = Properties.Resources.gear;
            btnSendPrivateMessagesToEveryoneInTheGroups.ImageActive = Properties.Resources.gear;
            btnSendPrivateMessagesToEveryoneInTheGroups.InitialImage = Properties.Resources.settings;
            btnSendPrivateMessagesToEveryoneInTheGroups.Location = new Point(457, 45);
            btnSendPrivateMessagesToEveryoneInTheGroups.Name = "btnSendPrivateMessagesToEveryoneInTheGroups";
            btnSendPrivateMessagesToEveryoneInTheGroups.Size = new Size(21, 17);
            btnSendPrivateMessagesToEveryoneInTheGroups.SizeMode = PictureBoxSizeMode.Zoom;
            btnSendPrivateMessagesToEveryoneInTheGroups.TabIndex = 47;
            btnSendPrivateMessagesToEveryoneInTheGroups.TabStop = false;
            btnSendPrivateMessagesToEveryoneInTheGroups.Zoom = 10;
            btnSendPrivateMessagesToEveryoneInTheGroups.Click += btnSendPrivateMessagesToEveryoneInTheGroups_Click;
            // 
            // cb_fSendPrivateMessages
            // 
            cb_fSendPrivateMessages.AutoSize = true;
            cb_fSendPrivateMessages.Location = new Point(223, 43);
            cb_fSendPrivateMessages.Name = "cb_fSendPrivateMessages";
            cb_fSendPrivateMessages.Size = new Size(204, 19);
            cb_fSendPrivateMessages.TabIndex = 46;
            cb_fSendPrivateMessages.Text = "Send Message to Group Members";
            cb_fSendPrivateMessages.UseVisualStyleBackColor = true;
            // 
            // btnSendMessagesToGroups
            // 
            btnSendMessagesToGroups.BackColor = Color.White;
            btnSendMessagesToGroups.ErrorImage = Properties.Resources.settings;
            btnSendMessagesToGroups.Image = Properties.Resources.gear;
            btnSendMessagesToGroups.ImageActive = Properties.Resources.gear;
            btnSendMessagesToGroups.InitialImage = Properties.Resources.settings;
            btnSendMessagesToGroups.Location = new Point(196, 72);
            btnSendMessagesToGroups.Name = "btnSendMessagesToGroups";
            btnSendMessagesToGroups.Size = new Size(21, 17);
            btnSendMessagesToGroups.SizeMode = PictureBoxSizeMode.Zoom;
            btnSendMessagesToGroups.TabIndex = 45;
            btnSendMessagesToGroups.TabStop = false;
            btnSendMessagesToGroups.Zoom = 10;
            btnSendMessagesToGroups.Click += btnSendMessagesToGroups_Click;
            // 
            // cb_fSendMessagesToGroups
            // 
            cb_fSendMessagesToGroups.AutoSize = true;
            cb_fSendMessagesToGroups.Location = new Point(7, 72);
            cb_fSendMessagesToGroups.Name = "cb_fSendMessagesToGroups";
            cb_fSendMessagesToGroups.Size = new Size(161, 19);
            cb_fSendMessagesToGroups.TabIndex = 44;
            cb_fSendMessagesToGroups.Text = "Send Messages to Groups";
            cb_fSendMessagesToGroups.UseVisualStyleBackColor = true;
            cb_fSendMessagesToGroups.CheckedChanged += cb_fSendMessagesToGroups_CheckedChanged;
            // 
            // btnJoinGroups
            // 
            btnJoinGroups.BackColor = Color.White;
            btnJoinGroups.ErrorImage = Properties.Resources.settings;
            btnJoinGroups.Image = Properties.Resources.gear;
            btnJoinGroups.ImageActive = Properties.Resources.gear;
            btnJoinGroups.InitialImage = Properties.Resources.settings;
            btnJoinGroups.Location = new Point(457, 20);
            btnJoinGroups.Name = "btnJoinGroups";
            btnJoinGroups.Size = new Size(21, 17);
            btnJoinGroups.SizeMode = PictureBoxSizeMode.Zoom;
            btnJoinGroups.TabIndex = 43;
            btnJoinGroups.TabStop = false;
            btnJoinGroups.Zoom = 10;
            btnJoinGroups.Click += btnJoinGroups_Click;
            // 
            // cb_fJoinGroups
            // 
            cb_fJoinGroups.AutoSize = true;
            cb_fJoinGroups.Location = new Point(223, 20);
            cb_fJoinGroups.Name = "cb_fJoinGroups";
            cb_fJoinGroups.Size = new Size(88, 19);
            cb_fJoinGroups.TabIndex = 41;
            cb_fJoinGroups.Text = "Join Groups";
            cb_fJoinGroups.UseVisualStyleBackColor = true;
            // 
            // btnAddNembersByUsername
            // 
            btnAddNembersByUsername.BackColor = Color.White;
            btnAddNembersByUsername.ErrorImage = Properties.Resources.settings;
            btnAddNembersByUsername.Image = Properties.Resources.gear;
            btnAddNembersByUsername.ImageActive = Properties.Resources.gear;
            btnAddNembersByUsername.InitialImage = Properties.Resources.settings;
            btnAddNembersByUsername.Location = new Point(196, 49);
            btnAddNembersByUsername.Name = "btnAddNembersByUsername";
            btnAddNembersByUsername.Size = new Size(21, 17);
            btnAddNembersByUsername.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddNembersByUsername.TabIndex = 37;
            btnAddNembersByUsername.TabStop = false;
            btnAddNembersByUsername.Zoom = 10;
            btnAddNembersByUsername.Click += btnAddNembersByUsername_Click;
            // 
            // cb_fAddNembersByUsername
            // 
            cb_fAddNembersByUsername.AutoSize = true;
            cb_fAddNembersByUsername.Location = new Point(7, 47);
            cb_fAddNembersByUsername.Name = "cb_fAddNembersByUsername";
            cb_fAddNembersByUsername.Size = new Size(173, 19);
            cb_fAddNembersByUsername.TabIndex = 36;
            cb_fAddNembersByUsername.Text = "Add Members By Username";
            cb_fAddNembersByUsername.UseVisualStyleBackColor = true;
            // 
            // btnCreateGroups
            // 
            btnCreateGroups.BackColor = Color.White;
            btnCreateGroups.ErrorImage = Properties.Resources.settings;
            btnCreateGroups.Image = Properties.Resources.gear;
            btnCreateGroups.ImageActive = Properties.Resources.gear;
            btnCreateGroups.InitialImage = Properties.Resources.settings;
            btnCreateGroups.Location = new Point(196, 22);
            btnCreateGroups.Name = "btnCreateGroups";
            btnCreateGroups.Size = new Size(21, 17);
            btnCreateGroups.SizeMode = PictureBoxSizeMode.Zoom;
            btnCreateGroups.TabIndex = 35;
            btnCreateGroups.TabStop = false;
            btnCreateGroups.Zoom = 10;
            btnCreateGroups.Click += btnCreateGroups_Click;
            // 
            // cb_fCreateGroups
            // 
            cb_fCreateGroups.AutoSize = true;
            cb_fCreateGroups.Location = new Point(7, 22);
            cb_fCreateGroups.Name = "cb_fCreateGroups";
            cb_fCreateGroups.Size = new Size(101, 19);
            cb_fCreateGroups.TabIndex = 34;
            cb_fCreateGroups.Text = "Create Groups";
            cb_fCreateGroups.UseVisualStyleBackColor = true;
            // 
            // gbProfile
            // 
            gbProfile.Controls.Add(btnUpdateBIOS);
            gbProfile.Controls.Add(cb_fUpdateBio);
            gbProfile.Controls.Add(btnUpdatePassword);
            gbProfile.Controls.Add(cb_fUpdatePassword);
            gbProfile.Controls.Add(btnUpdateFullname);
            gbProfile.Controls.Add(cb_fUpdateFullname);
            gbProfile.Controls.Add(btnUpdateUsername);
            gbProfile.Controls.Add(cb_fUpdateUsername);
            gbProfile.Controls.Add(btnUpdateAvatar);
            gbProfile.Controls.Add(cb_fUpdateAvatar);
            gbProfile.Location = new Point(803, 3);
            gbProfile.Name = "gbProfile";
            gbProfile.Size = new Size(345, 135);
            gbProfile.TabIndex = 35;
            gbProfile.TabStop = false;
            gbProfile.Text = "Profile";
            // 
            // btnUpdateBIOS
            // 
            btnUpdateBIOS.BackColor = Color.White;
            btnUpdateBIOS.ErrorImage = Properties.Resources.settings;
            btnUpdateBIOS.Image = Properties.Resources.gear;
            btnUpdateBIOS.ImageActive = Properties.Resources.gear;
            btnUpdateBIOS.InitialImage = Properties.Resources.settings;
            btnUpdateBIOS.Location = new Point(295, 47);
            btnUpdateBIOS.Name = "btnUpdateBIOS";
            btnUpdateBIOS.Size = new Size(21, 17);
            btnUpdateBIOS.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateBIOS.TabIndex = 22;
            btnUpdateBIOS.TabStop = false;
            btnUpdateBIOS.Zoom = 10;
            btnUpdateBIOS.Click += btnUpdateBIOS_Click;
            // 
            // cb_fUpdateBio
            // 
            cb_fUpdateBio.AutoSize = true;
            cb_fUpdateBio.Location = new Point(175, 45);
            cb_fUpdateBio.Name = "cb_fUpdateBio";
            cb_fUpdateBio.Size = new Size(87, 19);
            cb_fUpdateBio.TabIndex = 21;
            cb_fUpdateBio.Text = "Change Bio";
            cb_fUpdateBio.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.White;
            btnUpdatePassword.ErrorImage = Properties.Resources.settings;
            btnUpdatePassword.Image = Properties.Resources.gear;
            btnUpdatePassword.ImageActive = Properties.Resources.gear;
            btnUpdatePassword.InitialImage = Properties.Resources.settings;
            btnUpdatePassword.Location = new Point(295, 22);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(21, 17);
            btnUpdatePassword.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdatePassword.TabIndex = 20;
            btnUpdatePassword.TabStop = false;
            btnUpdatePassword.Zoom = 10;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // cb_fUpdatePassword
            // 
            cb_fUpdatePassword.AutoSize = true;
            cb_fUpdatePassword.Location = new Point(175, 20);
            cb_fUpdatePassword.Name = "cb_fUpdatePassword";
            cb_fUpdatePassword.Size = new Size(120, 19);
            cb_fUpdatePassword.TabIndex = 19;
            cb_fUpdatePassword.Text = "Change Password";
            cb_fUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFullname
            // 
            btnUpdateFullname.BackColor = Color.White;
            btnUpdateFullname.ErrorImage = Properties.Resources.settings;
            btnUpdateFullname.Image = Properties.Resources.gear;
            btnUpdateFullname.ImageActive = Properties.Resources.gear;
            btnUpdateFullname.InitialImage = Properties.Resources.settings;
            btnUpdateFullname.Location = new Point(133, 72);
            btnUpdateFullname.Name = "btnUpdateFullname";
            btnUpdateFullname.Size = new Size(21, 17);
            btnUpdateFullname.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateFullname.TabIndex = 18;
            btnUpdateFullname.TabStop = false;
            btnUpdateFullname.Zoom = 10;
            btnUpdateFullname.Click += btnUpdateFullname_Click;
            // 
            // cb_fUpdateFullname
            // 
            cb_fUpdateFullname.AutoSize = true;
            cb_fUpdateFullname.Location = new Point(7, 72);
            cb_fUpdateFullname.Name = "cb_fUpdateFullname";
            cb_fUpdateFullname.Size = new Size(119, 19);
            cb_fUpdateFullname.TabIndex = 17;
            cb_fUpdateFullname.Text = "Change Fullname";
            cb_fUpdateFullname.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUsername
            // 
            btnUpdateUsername.BackColor = Color.White;
            btnUpdateUsername.ErrorImage = Properties.Resources.settings;
            btnUpdateUsername.Image = Properties.Resources.gear;
            btnUpdateUsername.ImageActive = Properties.Resources.gear;
            btnUpdateUsername.InitialImage = Properties.Resources.settings;
            btnUpdateUsername.Location = new Point(133, 47);
            btnUpdateUsername.Name = "btnUpdateUsername";
            btnUpdateUsername.Size = new Size(21, 17);
            btnUpdateUsername.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateUsername.TabIndex = 16;
            btnUpdateUsername.TabStop = false;
            btnUpdateUsername.Zoom = 10;
            btnUpdateUsername.Click += btnUpdateUsername_Click;
            // 
            // cb_fUpdateUsername
            // 
            cb_fUpdateUsername.AutoSize = true;
            cb_fUpdateUsername.Location = new Point(7, 47);
            cb_fUpdateUsername.Name = "cb_fUpdateUsername";
            cb_fUpdateUsername.Size = new Size(123, 19);
            cb_fUpdateUsername.TabIndex = 15;
            cb_fUpdateUsername.Text = "Change Username";
            cb_fUpdateUsername.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAvatar
            // 
            btnUpdateAvatar.BackColor = Color.White;
            btnUpdateAvatar.ErrorImage = Properties.Resources.settings;
            btnUpdateAvatar.Image = Properties.Resources.gear;
            btnUpdateAvatar.ImageActive = Properties.Resources.gear;
            btnUpdateAvatar.InitialImage = Properties.Resources.settings;
            btnUpdateAvatar.Location = new Point(133, 22);
            btnUpdateAvatar.Name = "btnUpdateAvatar";
            btnUpdateAvatar.Size = new Size(21, 17);
            btnUpdateAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateAvatar.TabIndex = 14;
            btnUpdateAvatar.TabStop = false;
            btnUpdateAvatar.Zoom = 10;
            btnUpdateAvatar.Click += btnUpdateAvatar_Click;
            // 
            // cb_fUpdateAvatar
            // 
            cb_fUpdateAvatar.AutoSize = true;
            cb_fUpdateAvatar.Location = new Point(7, 22);
            cb_fUpdateAvatar.Name = "cb_fUpdateAvatar";
            cb_fUpdateAvatar.Size = new Size(101, 19);
            cb_fUpdateAvatar.TabIndex = 13;
            cb_fUpdateAvatar.Text = "Update Avatar";
            cb_fUpdateAvatar.UseVisualStyleBackColor = true;
            // 
            // gbFriends
            // 
            gbFriends.Controls.Add(btnMessageAllContact);
            gbFriends.Controls.Add(cb_fMessageAllContact);
            gbFriends.Controls.Add(btnAddToContact);
            gbFriends.Controls.Add(cb_fAddToContact);
            gbFriends.Controls.Add(btnBlockByUsername);
            gbFriends.Controls.Add(cb_fBlockByUsername);
            gbFriends.Controls.Add(btnSendMessagesByUsername);
            gbFriends.Controls.Add(cb_fSendMessages);
            gbFriends.Location = new Point(1154, 3);
            gbFriends.Name = "gbFriends";
            gbFriends.Size = new Size(415, 135);
            gbFriends.TabIndex = 36;
            gbFriends.TabStop = false;
            gbFriends.Text = "Contacts";
            // 
            // btnMessageAllContact
            // 
            btnMessageAllContact.BackColor = Color.White;
            btnMessageAllContact.ErrorImage = Properties.Resources.settings;
            btnMessageAllContact.Image = Properties.Resources.gear;
            btnMessageAllContact.ImageActive = Properties.Resources.gear;
            btnMessageAllContact.InitialImage = Properties.Resources.settings;
            btnMessageAllContact.Location = new Point(196, 92);
            btnMessageAllContact.Name = "btnMessageAllContact";
            btnMessageAllContact.Size = new Size(21, 17);
            btnMessageAllContact.SizeMode = PictureBoxSizeMode.Zoom;
            btnMessageAllContact.TabIndex = 28;
            btnMessageAllContact.TabStop = false;
            btnMessageAllContact.Zoom = 10;
            btnMessageAllContact.Click += btnMessageAllContact_Click;
            // 
            // cb_fMessageAllContact
            // 
            cb_fMessageAllContact.AutoSize = true;
            cb_fMessageAllContact.Location = new Point(7, 92);
            cb_fMessageAllContact.Name = "cb_fMessageAllContact";
            cb_fMessageAllContact.Size = new Size(171, 19);
            cb_fMessageAllContact.TabIndex = 27;
            cb_fMessageAllContact.Text = "Send Messages To Contacts";
            cb_fMessageAllContact.UseVisualStyleBackColor = true;
            // 
            // btnAddToContact
            // 
            btnAddToContact.BackColor = Color.White;
            btnAddToContact.ErrorImage = Properties.Resources.settings;
            btnAddToContact.Image = Properties.Resources.gear;
            btnAddToContact.ImageActive = Properties.Resources.gear;
            btnAddToContact.InitialImage = Properties.Resources.settings;
            btnAddToContact.Location = new Point(196, 70);
            btnAddToContact.Name = "btnAddToContact";
            btnAddToContact.Size = new Size(21, 17);
            btnAddToContact.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddToContact.TabIndex = 26;
            btnAddToContact.TabStop = false;
            btnAddToContact.Zoom = 10;
            btnAddToContact.Click += btnAddToContact_Click;
            // 
            // cb_fAddToContact
            // 
            cb_fAddToContact.AutoSize = true;
            cb_fAddToContact.Location = new Point(7, 68);
            cb_fAddToContact.Name = "cb_fAddToContact";
            cb_fAddToContact.Size = new Size(98, 19);
            cb_fAddToContact.TabIndex = 25;
            cb_fAddToContact.Text = "Add Contacts";
            cb_fAddToContact.UseVisualStyleBackColor = true;
            // 
            // btnBlockByUsername
            // 
            btnBlockByUsername.BackColor = Color.White;
            btnBlockByUsername.ErrorImage = Properties.Resources.settings;
            btnBlockByUsername.Image = Properties.Resources.gear;
            btnBlockByUsername.ImageActive = Properties.Resources.gear;
            btnBlockByUsername.InitialImage = Properties.Resources.settings;
            btnBlockByUsername.Location = new Point(196, 47);
            btnBlockByUsername.Name = "btnBlockByUsername";
            btnBlockByUsername.Size = new Size(21, 17);
            btnBlockByUsername.SizeMode = PictureBoxSizeMode.Zoom;
            btnBlockByUsername.TabIndex = 24;
            btnBlockByUsername.TabStop = false;
            btnBlockByUsername.Zoom = 10;
            btnBlockByUsername.Click += btnBlockByUsername_Click;
            // 
            // cb_fBlockByUsername
            // 
            cb_fBlockByUsername.AutoSize = true;
            cb_fBlockByUsername.Location = new Point(7, 45);
            cb_fBlockByUsername.Name = "cb_fBlockByUsername";
            cb_fBlockByUsername.Size = new Size(132, 19);
            cb_fBlockByUsername.TabIndex = 23;
            cb_fBlockByUsername.Text = "Block By Usernames";
            cb_fBlockByUsername.UseVisualStyleBackColor = true;
            // 
            // btnSendMessagesByUsername
            // 
            btnSendMessagesByUsername.BackColor = Color.White;
            btnSendMessagesByUsername.ErrorImage = Properties.Resources.settings;
            btnSendMessagesByUsername.Image = Properties.Resources.gear;
            btnSendMessagesByUsername.ImageActive = Properties.Resources.gear;
            btnSendMessagesByUsername.InitialImage = Properties.Resources.settings;
            btnSendMessagesByUsername.Location = new Point(196, 20);
            btnSendMessagesByUsername.Name = "btnSendMessagesByUsername";
            btnSendMessagesByUsername.Size = new Size(21, 17);
            btnSendMessagesByUsername.SizeMode = PictureBoxSizeMode.Zoom;
            btnSendMessagesByUsername.TabIndex = 22;
            btnSendMessagesByUsername.TabStop = false;
            btnSendMessagesByUsername.Zoom = 10;
            btnSendMessagesByUsername.Click += btnSendMessagesByUsername_Click;
            // 
            // cb_fSendMessages
            // 
            cb_fSendMessages.AutoSize = true;
            cb_fSendMessages.Location = new Point(7, 20);
            cb_fSendMessages.Name = "cb_fSendMessages";
            cb_fSendMessages.Size = new Size(183, 19);
            cb_fSendMessages.TabIndex = 21;
            cb_fSendMessages.Text = "Send Messages By Usernames";
            cb_fSendMessages.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox9);
            panel2.Location = new Point(3, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(1566, 149);
            panel2.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbRandomAction);
            groupBox1.Controls.Add(plRepeat);
            groupBox1.Controls.Add(ckbRepeatAfter);
            groupBox1.Controls.Add(lbAccount);
            groupBox1.Controls.Add(btn_AddScript);
            groupBox1.Controls.Add(btn_delScript);
            groupBox1.Controls.Add(btn_saveScript);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(scriptName);
            groupBox1.Controls.Add(ddl_Script);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 143);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose a script option";
            // 
            // ckbRandomAction
            // 
            ckbRandomAction.AutoSize = true;
            ckbRandomAction.Cursor = Cursors.Hand;
            ckbRandomAction.Location = new Point(107, 74);
            ckbRandomAction.Name = "ckbRandomAction";
            ckbRandomAction.Size = new Size(176, 17);
            ckbRandomAction.TabIndex = 209;
            ckbRandomAction.Text = "Randomize the order of actions";
            ckbRandomAction.UseVisualStyleBackColor = true;
            // 
            // plRepeat
            // 
            plRepeat.Controls.Add(nudRepeatFrom);
            plRepeat.Controls.Add(nudRepeatTo);
            plRepeat.Controls.Add(label3);
            plRepeat.Location = new Point(252, 106);
            plRepeat.Margin = new Padding(4, 3, 4, 3);
            plRepeat.Name = "plRepeat";
            plRepeat.Size = new Size(184, 29);
            plRepeat.TabIndex = 208;
            // 
            // nudRepeatFrom
            // 
            nudRepeatFrom.Location = new Point(4, 5);
            nudRepeatFrom.Margin = new Padding(4, 3, 4, 3);
            nudRepeatFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudRepeatFrom.Name = "nudRepeatFrom";
            nudRepeatFrom.Size = new Size(65, 21);
            nudRepeatFrom.TabIndex = 200;
            // 
            // nudRepeatTo
            // 
            nudRepeatTo.Location = new Point(115, 4);
            nudRepeatTo.Margin = new Padding(4, 3, 4, 3);
            nudRepeatTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudRepeatTo.Name = "nudRepeatTo";
            nudRepeatTo.Size = new Size(65, 21);
            nudRepeatTo.TabIndex = 201;
            // 
            // label3
            // 
            label3.Location = new Point(73, 5);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 203;
            label3.Text = "to";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbRepeatAfter
            // 
            ckbRepeatAfter.AutoSize = true;
            ckbRepeatAfter.Cursor = Cursors.Hand;
            ckbRepeatAfter.Location = new Point(107, 112);
            ckbRepeatAfter.Name = "ckbRepeatAfter";
            ckbRepeatAfter.Size = new Size(136, 17);
            ckbRepeatAfter.TabIndex = 207;
            ckbRepeatAfter.Text = "Repeat after (Minutes)";
            ckbRepeatAfter.UseVisualStyleBackColor = true;
            ckbRepeatAfter.CheckedChanged += ckbRepeatAfter_CheckedChanged;
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbAccount.Location = new Point(6, 123);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(66, 16);
            lbAccount.TabIndex = 38;
            lbAccount.Text = "Item: (0)";
            // 
            // btn_AddScript
            // 
            btn_AddScript.BackColor = Color.White;
            btn_AddScript.ErrorImage = (Image)resources.GetObject("btn_AddScript.ErrorImage");
            btn_AddScript.Image = (Image)resources.GetObject("btn_AddScript.Image");
            btn_AddScript.ImageActive = (Image)resources.GetObject("btn_AddScript.ImageActive");
            btn_AddScript.InitialImage = (Image)resources.GetObject("btn_AddScript.InitialImage");
            btn_AddScript.Location = new Point(560, 33);
            btn_AddScript.Name = "btn_AddScript";
            btn_AddScript.Size = new Size(24, 22);
            btn_AddScript.SizeMode = PictureBoxSizeMode.Zoom;
            btn_AddScript.TabIndex = 36;
            btn_AddScript.TabStop = false;
            btn_AddScript.Zoom = 10;
            btn_AddScript.Click += btn_AddScript_Click;
            // 
            // btn_delScript
            // 
            btn_delScript.BackColor = Color.White;
            btn_delScript.ErrorImage = (Image)resources.GetObject("btn_delScript.ErrorImage");
            btn_delScript.Image = (Image)resources.GetObject("btn_delScript.Image");
            btn_delScript.ImageActive = (Image)resources.GetObject("btn_delScript.ImageActive");
            btn_delScript.InitialImage = (Image)resources.GetObject("btn_delScript.InitialImage");
            btn_delScript.Location = new Point(107, 33);
            btn_delScript.Name = "btn_delScript";
            btn_delScript.Size = new Size(21, 20);
            btn_delScript.SizeMode = PictureBoxSizeMode.Zoom;
            btn_delScript.TabIndex = 35;
            btn_delScript.TabStop = false;
            btn_delScript.Zoom = 10;
            btn_delScript.Click += btn_delScript_Click;
            // 
            // btn_saveScript
            // 
            btn_saveScript.Anchor = AnchorStyles.Bottom;
            btn_saveScript.BackColor = Color.CornflowerBlue;
            btn_saveScript.Cursor = Cursors.Hand;
            btn_saveScript.FlatAppearance.BorderSize = 0;
            btn_saveScript.FlatStyle = FlatStyle.Flat;
            btn_saveScript.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_saveScript.ForeColor = Color.White;
            btn_saveScript.Location = new Point(275, 31);
            btn_saveScript.Name = "btn_saveScript";
            btn_saveScript.Size = new Size(75, 21);
            btn_saveScript.TabIndex = 22;
            btn_saveScript.Text = "Save";
            btn_saveScript.UseVisualStyleBackColor = false;
            btn_saveScript.Click += btn_saveScript_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.DeepSkyBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(495, -190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 21);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 13);
            label2.TabIndex = 12;
            label2.Text = "Script name:";
            // 
            // scriptName
            // 
            scriptName.Location = new Point(444, 34);
            scriptName.Name = "scriptName";
            scriptName.Size = new Size(110, 21);
            scriptName.TabIndex = 11;
            // 
            // ddl_Script
            // 
            ddl_Script.Cursor = Cursors.Hand;
            ddl_Script.DropDownStyle = ComboBoxStyle.DropDownList;
            ddl_Script.DropDownWidth = 135;
            ddl_Script.FormattingEnabled = true;
            ddl_Script.Location = new Point(134, 33);
            ddl_Script.Name = "ddl_Script";
            ddl_Script.Size = new Size(135, 21);
            ddl_Script.TabIndex = 1;
            ddl_Script.SelectedIndexChanged += ddl_Script_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(74, 13);
            label1.TabIndex = 0;
            label1.Text = "Select a script";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(cbCheckDuplicate);
            groupBox3.Controls.Add(btn_clearUM);
            groupBox3.Controls.Add(btnDelFolder);
            groupBox3.Controls.Add(btn_stop);
            groupBox3.Controls.Add(btnDisplay);
            groupBox3.Controls.Add(btn_start);
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(nudNumberThreads);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(btnAddAccount);
            groupBox3.Controls.Add(cbbFolder);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(624, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 143);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Control center";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(161, 74);
            button1.Name = "button1";
            button1.Size = new Size(23, 21);
            button1.TabIndex = 47;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbCheckDuplicate
            // 
            cbCheckDuplicate.AutoSize = true;
            cbCheckDuplicate.Cursor = Cursors.Hand;
            cbCheckDuplicate.Location = new Point(11, 77);
            cbCheckDuplicate.Name = "cbCheckDuplicate";
            cbCheckDuplicate.Size = new Size(147, 17);
            cbCheckDuplicate.TabIndex = 46;
            cbCheckDuplicate.Text = "Check for duplicate users";
            cbCheckDuplicate.UseVisualStyleBackColor = true;
            // 
            // btn_clearUM
            // 
            btn_clearUM.Anchor = AnchorStyles.Bottom;
            btn_clearUM.BackColor = Color.SlateGray;
            btn_clearUM.Cursor = Cursors.Hand;
            btn_clearUM.FlatAppearance.BorderSize = 0;
            btn_clearUM.FlatStyle = FlatStyle.Flat;
            btn_clearUM.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clearUM.ForeColor = Color.White;
            btn_clearUM.Location = new Point(236, 72);
            btn_clearUM.Name = "btn_clearUM";
            btn_clearUM.Size = new Size(256, 21);
            btn_clearUM.TabIndex = 45;
            btn_clearUM.Text = "Clear used data (send message functions)\r\n\r\n";
            btn_clearUM.UseVisualStyleBackColor = false;
            btn_clearUM.Click += btn_clearUM_Click;
            // 
            // btnDelFolder
            // 
            btnDelFolder.BackColor = Color.White;
            btnDelFolder.ErrorImage = (Image)resources.GetObject("btnDelFolder.ErrorImage");
            btnDelFolder.Image = (Image)resources.GetObject("btnDelFolder.Image");
            btnDelFolder.ImageActive = (Image)resources.GetObject("btnDelFolder.ImageActive");
            btnDelFolder.InitialImage = (Image)resources.GetObject("btnDelFolder.InitialImage");
            btnDelFolder.Location = new Point(176, 114);
            btnDelFolder.Name = "btnDelFolder";
            btnDelFolder.Size = new Size(21, 20);
            btnDelFolder.SizeMode = PictureBoxSizeMode.Zoom;
            btnDelFolder.TabIndex = 37;
            btnDelFolder.TabStop = false;
            btnDelFolder.Zoom = 10;
            btnDelFolder.Click += btnDelFolder_Click;
            // 
            // btn_stop
            // 
            btn_stop.Anchor = AnchorStyles.Bottom;
            btn_stop.BackColor = Color.Crimson;
            btn_stop.Cursor = Cursors.Hand;
            btn_stop.FlatAppearance.BorderSize = 0;
            btn_stop.FlatStyle = FlatStyle.Flat;
            btn_stop.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stop.ForeColor = Color.White;
            btn_stop.Location = new Point(317, 30);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(75, 21);
            btn_stop.TabIndex = 21;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Anchor = AnchorStyles.Bottom;
            btnDisplay.BackColor = Color.Aquamarine;
            btnDisplay.Cursor = Cursors.Hand;
            btnDisplay.FlatAppearance.BorderSize = 0;
            btnDisplay.FlatStyle = FlatStyle.Flat;
            btnDisplay.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisplay.ForeColor = Color.Black;
            btnDisplay.Location = new Point(12, 113);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(138, 21);
            btnDisplay.TabIndex = 32;
            btnDisplay.Text = "Display configuration";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btn_start
            // 
            btn_start.Anchor = AnchorStyles.Bottom;
            btn_start.BackColor = Color.DarkGreen;
            btn_start.Cursor = Cursors.AppStarting;
            btn_start.FlatAppearance.BorderSize = 0;
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_start.ForeColor = Color.White;
            btn_start.Location = new Point(227, 29);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 21);
            btn_start.TabIndex = 20;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(485, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 23);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nudNumberThreads
            // 
            nudNumberThreads.Location = new Point(158, 32);
            nudNumberThreads.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            nudNumberThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberThreads.Name = "nudNumberThreads";
            nudNumberThreads.Size = new Size(48, 21);
            nudNumberThreads.TabIndex = 5;
            nudNumberThreads.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(312, 114);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 21);
            txtSearch.TabIndex = 29;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Anchor = AnchorStyles.Bottom;
            btnAddAccount.BackColor = Color.Goldenrod;
            btnAddAccount.Cursor = Cursors.Hand;
            btnAddAccount.FlatAppearance.BorderSize = 0;
            btnAddAccount.FlatStyle = FlatStyle.Flat;
            btnAddAccount.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.Location = new Point(409, 30);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(104, 21);
            btnAddAccount.TabIndex = 27;
            btnAddAccount.Text = "Add Account";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btn_addAcount_Click;
            // 
            // cbbFolder
            // 
            cbbFolder.Cursor = Cursors.Hand;
            cbbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFolder.DropDownWidth = 86;
            cbbFolder.FormattingEnabled = true;
            cbbFolder.Location = new Point(203, 114);
            cbbFolder.Name = "cbbFolder";
            cbbFolder.Size = new Size(96, 21);
            cbbFolder.TabIndex = 28;
            cbbFolder.SelectedIndexChanged += cbbFolder_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 36);
            label8.Name = "label8";
            label8.Size = new Size(101, 13);
            label8.TabIndex = 38;
            label8.Text = "Number of threads:";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(btnEnterFile);
            groupBox9.Controls.Add(rbProxyFromFile);
            groupBox9.Controls.Add(rbProxyFromAccount);
            groupBox9.Controls.Add(rbNoProxy);
            groupBox9.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox9.Location = new Point(1232, 6);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(315, 140);
            groupBox9.TabIndex = 27;
            groupBox9.TabStop = false;
            groupBox9.Text = "Network";
            // 
            // btnEnterFile
            // 
            btnEnterFile.Cursor = Cursors.Hand;
            btnEnterFile.Image = (Image)resources.GetObject("btnEnterFile.Image");
            btnEnterFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnterFile.Location = new Point(143, 69);
            btnEnterFile.Margin = new Padding(4, 3, 4, 3);
            btnEnterFile.Name = "btnEnterFile";
            btnEnterFile.Size = new Size(89, 29);
            btnEnterFile.TabIndex = 31;
            btnEnterFile.Text = "Import File";
            btnEnterFile.TextAlign = ContentAlignment.MiddleRight;
            btnEnterFile.UseVisualStyleBackColor = true;
            btnEnterFile.Click += btnEnterFile_Click;
            // 
            // rbProxyFromFile
            // 
            rbProxyFromFile.AutoSize = true;
            rbProxyFromFile.Cursor = Cursors.Hand;
            rbProxyFromFile.Location = new Point(21, 75);
            rbProxyFromFile.Name = "rbProxyFromFile";
            rbProxyFromFile.Size = new Size(107, 17);
            rbProxyFromFile.TabIndex = 30;
            rbProxyFromFile.Text = "Proxy (From File)";
            rbProxyFromFile.UseVisualStyleBackColor = true;
            // 
            // rbProxyFromAccount
            // 
            rbProxyFromAccount.AutoSize = true;
            rbProxyFromAccount.Cursor = Cursors.Hand;
            rbProxyFromAccount.Location = new Point(143, 32);
            rbProxyFromAccount.Name = "rbProxyFromAccount";
            rbProxyFromAccount.Size = new Size(156, 17);
            rbProxyFromAccount.TabIndex = 25;
            rbProxyFromAccount.Text = "Proxy (From Account Data)";
            rbProxyFromAccount.UseVisualStyleBackColor = true;
            // 
            // rbNoProxy
            // 
            rbNoProxy.AutoSize = true;
            rbNoProxy.Checked = true;
            rbNoProxy.Cursor = Cursors.Hand;
            rbNoProxy.Location = new Point(21, 32);
            rbNoProxy.Name = "rbNoProxy";
            rbNoProxy.Size = new Size(69, 17);
            rbNoProxy.TabIndex = 23;
            rbNoProxy.TabStop = true;
            rbNoProxy.Text = "No Proxy";
            rbNoProxy.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            menu.Controls.Add(home);
            menu.Controls.Add(proxy);
            menu.Controls.Add(tpLog);
            menu.Dock = DockStyle.Fill;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.SelectedIndex = 0;
            menu.Size = new Size(1592, 842);
            menu.TabIndex = 2;
            // 
            // tpLog
            // 
            tpLog.Controls.Add(panel1);
            tpLog.Location = new Point(4, 24);
            tpLog.Name = "tpLog";
            tpLog.Padding = new Padding(3);
            tpLog.Size = new Size(1584, 814);
            tpLog.TabIndex = 6;
            tpLog.Text = "Log";
            tpLog.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rtbLog);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 808);
            panel1.TabIndex = 0;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = Color.White;
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.Location = new Point(0, 0);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(1578, 808);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            rtbLog.TextChanged += rtbLog_TextChanged;
            rtbLog.DoubleClick += rtbLog_DoubleClick;
            // 
            // fMain
            // 
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1592, 842);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fMain";
            Palette = kryptonPalette1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateInactive.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Text = "Telegram Automation Pro";
            FormClosing += fMain_FormClosing;
            FormClosed += fMain_FormClosed;
            Load += fMain_Load;
            Controls.SetChildIndex(menu, 0);
            ctmsAcc.ResumeLayout(false);
            proxy.ResumeLayout(false);
            ((ISupportInitialize)pictureBox2).EndInit();
            home.ResumeLayout(false);
            home.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((ISupportInitialize)dtgvAcc).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            gbChannels.ResumeLayout(false);
            gbChannels.PerformLayout();
            ((ISupportInitialize)btnDeleteChannels).EndInit();
            ((ISupportInitialize)btnSubscribersChannels).EndInit();
            ((ISupportInitialize)btnCreateChannels).EndInit();
            gbGroups.ResumeLayout(false);
            gbGroups.PerformLayout();
            ((ISupportInitialize)btnLeaveGroups).EndInit();
            ((ISupportInitialize)btnGetNembersInGroups).EndInit();
            ((ISupportInitialize)btnSendPrivateMessagesToEveryoneInTheGroups).EndInit();
            ((ISupportInitialize)btnSendMessagesToGroups).EndInit();
            ((ISupportInitialize)btnJoinGroups).EndInit();
            ((ISupportInitialize)btnAddNembersByUsername).EndInit();
            ((ISupportInitialize)btnCreateGroups).EndInit();
            gbProfile.ResumeLayout(false);
            gbProfile.PerformLayout();
            ((ISupportInitialize)btnUpdateBIOS).EndInit();
            ((ISupportInitialize)btnUpdatePassword).EndInit();
            ((ISupportInitialize)btnUpdateFullname).EndInit();
            ((ISupportInitialize)btnUpdateUsername).EndInit();
            ((ISupportInitialize)btnUpdateAvatar).EndInit();
            gbFriends.ResumeLayout(false);
            gbFriends.PerformLayout();
            ((ISupportInitialize)btnMessageAllContact).EndInit();
            ((ISupportInitialize)btnAddToContact).EndInit();
            ((ISupportInitialize)btnBlockByUsername).EndInit();
            ((ISupportInitialize)btnSendMessagesByUsername).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            plRepeat.ResumeLayout(false);
            ((ISupportInitialize)nudRepeatFrom).EndInit();
            ((ISupportInitialize)nudRepeatTo).EndInit();
            ((ISupportInitialize)btn_AddScript).EndInit();
            ((ISupportInitialize)btn_delScript).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((ISupportInitialize)btnDelFolder).EndInit();
            ((ISupportInitialize)nudNumberThreads).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            menu.ResumeLayout(false);
            tpLog.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            GetListFromDatabase();
            LoadConfigMain();
            GetDataCheckBox();
        }
        private void LoadConfigMain()
        {
            var folderName = "";
            try
            {
                var typeProxy = SettingsTool.GetSettings("configMain").GetIntType("typeProxy");
                if (typeProxy == 1)
                {
                    rbProxyFromAccount.Checked = true;
                }
                else if (typeProxy == 2)
                {
                    rbProxyFromFile.Checked = true;
                }
                else
                {
                    rbNoProxy.Checked = true;
                }

                folderName = SettingsTool.GetSettings("configMain").GetValuesFromInputString("folderName");
                nudNumberThreads.Value = SettingsTool.GetSettings("configMain").GetIntType("nudNumberThreads", 1);
                nudRepeatFrom.Value = SettingsTool.GetSettings("configMain").GetIntType("nudRepeatFrom", 10);
                nudRepeatTo.Value = SettingsTool.GetSettings("configMain").GetIntType("nudRepeatTo", 60);
                ckbRandomAction.Checked = SettingsTool.GetSettings("configMain").GetBooleanValue("ckbRandomAction", false);
                ckbRepeatAfter.Checked = SettingsTool.GetSettings("configMain").GetBooleanValue("ckbRepeatAfter", false);
                cbCheckDuplicate.Checked = SettingsTool.GetSettings("configMain").GetBooleanValue("cbCheckDuplicate", false);
                plRepeat.Enabled = ckbRepeatAfter.Checked;
            }
            catch (Exception ex)
            {
                Log.Error($"ERROR: {nameof(fMain)}, params; {nameof(LoadConfigMain)}, Error; {ex.Message}, Exception; {ex}");
            }
            try
            {
                GetDataFolder(folderName);
            }
            catch (Exception ex)
            {
                Log.Error($"ERROR: {nameof(fMain)}, params; {nameof(LoadConfigMain)}, Error; {ex.Message}, Exception; {ex}");
            }
        }
        private async void btn_addAcount_Click(object sender, EventArgs e)
        {

            try
            {
                var _addAccounts = new fAddAccounts(_filesService, _accountsService);
                FormHelper.ShowFormWithoutTaskbar(_addAccounts);
                if (_addAccounts.update)
                {
                    GetDataFolder(_addAccounts.folderName);
                    GetDataAccounts(search);
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }

        private void btn_AddScript_Click(object sender, EventArgs e)
        {
            try
            {
                var name = scriptName.Text;
                if (!string.IsNullOrEmpty(name))
                {
                    var checkName = _scriptService.Create(name);
                    if (!checkName)
                    {
                        System.Windows.Forms.MessageBox.Show("Script already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        GetListFromDatabase();
                    }
                }
                GetDataCheckBox();
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }
        private void ddl_Script_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdScript = ddl_Script.SelectedValue?.ToString();
            // CheckDropDownListValue();
        }
        private void GetDataCheckBox()
        {
            try
            {
                if (!string.IsNullOrEmpty(IdScript))
                {
                    var scripts = _scriptService.GetById(IdScript);
                    if (scripts != null)
                    {
                        try
                        {
                            var actionConf = JObject.Parse(scripts.Configuration);
                            cb_fAddNembersByUsername.Checked = Convert.ToBoolean(actionConf[cb_fAddNembersByUsername.Name.Replace("cb_", "")]);
                            cb_fSubscribersChannels.Checked = Convert.ToBoolean(actionConf[cb_fSubscribersChannels.Name.Replace("cb_", "")]);
                            cb_fBlockByUsername.Checked = Convert.ToBoolean(actionConf[cb_fBlockByUsername.Name.Replace("cb_", "")]);
                            cb_fCreateChannels.Checked = Convert.ToBoolean(actionConf[cb_fCreateChannels.Name.Replace("cb_", "")]);
                            cb_fCreateGroups.Checked = Convert.ToBoolean(actionConf[cb_fCreateGroups.Name.Replace("cb_", "")]);

                            cb_fLeaveChannels.Checked = Convert.ToBoolean(actionConf[cb_fLeaveChannels.Name.Replace("cb_", "")]);
                            cb_fGetNembersInGroups.Checked = Convert.ToBoolean(actionConf[cb_fGetNembersInGroups.Name.Replace("cb_", "")]);
                            cb_fJoinGroups.Checked = Convert.ToBoolean(actionConf[cb_fJoinGroups.Name.Replace("cb_", "")]);
                            cb_fLeaveGroups.Checked = Convert.ToBoolean(actionConf[cb_fLeaveGroups.Name.Replace("cb_", "")]);

                            cb_fSendMessages.Checked = Convert.ToBoolean(actionConf[cb_fSendMessages.Name.Replace("cb_", "")]);
                            cb_fSendMessagesToGroups.Checked = Convert.ToBoolean(actionConf[cb_fSendMessagesToGroups.Name.Replace("cb_", "")]);
                            cb_fSendPrivateMessages.Checked = Convert.ToBoolean(actionConf[cb_fSendPrivateMessages.Name.Replace("cb_", "")]);
                            cb_fUpdateAvatar.Checked = Convert.ToBoolean(actionConf[cb_fUpdateAvatar.Name.Replace("cb_", "")]);
                            cb_fUpdateFullname.Checked = Convert.ToBoolean(actionConf[cb_fUpdateFullname.Name.Replace("cb_", "")]);
                            cb_fUpdatePassword.Checked = Convert.ToBoolean(actionConf[cb_fUpdatePassword.Name.Replace("cb_", "")]);
                            cb_fUpdateUsername.Checked = Convert.ToBoolean(actionConf[cb_fUpdateUsername.Name.Replace("cb_", "")]);
                            cb_fMessageAllContact.Checked = Convert.ToBoolean(actionConf[cb_fMessageAllContact.Name.Replace("cb_", "")]);
                            cb_fAddToContact.Checked = Convert.ToBoolean(actionConf[cb_fAddToContact.Name.Replace("cb_", "")]);
                            cb_fUpdateBio.Checked = Convert.ToBoolean(actionConf[cb_fUpdateBio.Name.Replace("cb_", "")]);
                        }
                        catch (Exception)
                        {
                            cb_fAddNembersByUsername.Checked = false;
                            //  cb_fAddSubscribersByKeyword.Checked = false;
                            cb_fSubscribersChannels.Checked = false;
                            cb_fBlockByUsername.Checked = false;
                            cb_fCreateChannels.Checked = false;
                            cb_fCreateGroups.Checked = false;

                            cb_fLeaveChannels.Checked = false;
                            cb_fGetNembersInGroups.Checked = false;
                            cb_fJoinGroups.Checked = false;
                            cb_fLeaveGroups.Checked = false;

                            cb_fSendMessages.Checked = false;
                            cb_fSendMessagesToGroups.Checked = false;
                            cb_fSendPrivateMessages.Checked = false;
                            cb_fUpdateAvatar.Checked = false;
                            cb_fUpdateFullname.Checked = false;
                            cb_fUpdatePassword.Checked = false;
                            cb_fUpdateUsername.Checked = false;
                            cb_fMessageAllContact.Checked = false;
                            cb_fAddToContact.Checked = false;
                            cb_fUpdateBio.Checked = false;
                        }

                    }
                    gbChannels.Enabled = true;
                    gbFriends.Enabled = true;
                    gbGroups.Enabled = true;
                    gbProfile.Enabled = true;
                }
                else
                {
                    gbChannels.Enabled = false;
                    gbFriends.Enabled = false;
                    gbGroups.Enabled = false;
                    gbProfile.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }
        private void btn_saveScript_Click(object sender, EventArgs e)
        {
            try
            {
                JsonHelper Configuration = new JsonHelper();
                Configuration.AddValue(cb_fAddNembersByUsername.Name.Replace("cb_", ""), cb_fAddNembersByUsername.Checked);
                Configuration.AddValue(cb_fSubscribersChannels.Name.Replace("cb_", ""), cb_fSubscribersChannels.Checked);
                Configuration.AddValue(cb_fBlockByUsername.Name.Replace("cb_", ""), cb_fBlockByUsername.Checked);
                Configuration.AddValue(cb_fCreateChannels.Name.Replace("cb_", ""), cb_fCreateChannels.Checked);
                Configuration.AddValue(cb_fCreateGroups.Name.Replace("cb_", ""), cb_fCreateGroups.Checked);
                Configuration.AddValue(cb_fUpdateBio.Name.Replace("cb_", ""), cb_fUpdateBio.Checked);
                Configuration.AddValue(cb_fLeaveChannels.Name.Replace("cb_", ""), cb_fLeaveChannels.Checked);
                Configuration.AddValue(cb_fGetNembersInGroups.Name.Replace("cb_", ""), cb_fGetNembersInGroups.Checked);
                Configuration.AddValue(cb_fJoinGroups.Name.Replace("cb_", ""), cb_fJoinGroups.Checked);
                Configuration.AddValue(cb_fLeaveGroups.Name.Replace("cb_", ""), cb_fLeaveGroups.Checked);

                Configuration.AddValue(cb_fSendMessages.Name.Replace("cb_", ""), cb_fSendMessages.Checked);
                Configuration.AddValue(cb_fSendMessagesToGroups.Name.Replace("cb_", ""), cb_fSendMessagesToGroups.Checked);
                Configuration.AddValue(cb_fSendPrivateMessages.Name.Replace("cb_", ""), cb_fSendPrivateMessages.Checked);
                Configuration.AddValue(cb_fUpdateAvatar.Name.Replace("cb_", ""), cb_fUpdateAvatar.Checked);
                Configuration.AddValue(cb_fUpdateFullname.Name.Replace("cb_", ""), cb_fUpdateFullname.Checked);
                Configuration.AddValue(cb_fUpdatePassword.Name.Replace("cb_", ""), cb_fUpdatePassword.Checked);
                Configuration.AddValue(cb_fUpdateUsername.Name.Replace("cb_", ""), cb_fUpdateUsername.Checked);
                Configuration.AddValue(cb_fMessageAllContact.Name.Replace("cb_", ""), cb_fMessageAllContact.Checked);
                Configuration.AddValue(cb_fAddToContact.Name.Replace("cb_", ""), cb_fAddToContact.Checked);
                _scriptService.Update(IdScript, Configuration.GetJsonString());
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
            }


        }
        public void GetListFromDatabase()
        {
            try
            {
                var data = new List<KeyValuePair<string, string>>();

                var list = _scriptService.GetAllScript();

                if (list != null && list.Count > 0)
                {
                    data.AddRange(list.Select(x => new KeyValuePair<string, string>(x.IdScript.ToString(), x.Name)).ToList());
                    //ddl_Script.Enabled = true;
                    ddl_Script.DataSource = null;
                    ddl_Script.Items.Clear();
                    ddl_Script.DisplayMember = "Value"; // Hiển thị tên
                    ddl_Script.ValueMember = "Key"; // Lấy Id
                    ddl_Script.DataSource = data;

                    // Gán dữ liệu cho biến data từ một nguồn dữ liệu phù hợp
                    if (!string.IsNullOrEmpty(scriptName.Text))
                    {
                        var selectedItem = data.FirstOrDefault(x => x.Value == scriptName.Text);
                        if (selectedItem.Key != null)
                        {
                            //IdScript = selectedItem.Key;
                            var index = data.IndexOf(selectedItem);
                            ddl_Script.SelectedIndex = index;
                            scriptName.Text = "";

                        }
                    }
                }
                else
                {
                    // Xử lý khi danh sách là null, ví dụ:
                    ddl_Script.DataSource = null;
                    ddl_Script.Items.Clear();
                    //ddl_Script.Enabled = false; // Vô hiệu hóa DropDownList
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
                System.Windows.Forms.Application.Restart();
            }

        }

        private void btn_delScript_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdScript))
            {
                if (MessageCommon.ShowConfirmationBox(string.Format("Do you want to delete script [{0}]?", ddl_Script.Text)) != DialogResult.Yes)
                {
                    return;
                }
                _scriptService.DeleteById(IdScript);
                GetListFromDatabase();

            }
            GetDataCheckBox();
        }
        private void GetDataFolder(string folderName)
        {
            try
            {
                var data = new List<KeyValuePair<string, string>>();

                var list = _filesService.GetAll();

                if (list != null && list.Count > 0)
                {
                    data.AddRange(list.Select(x => new KeyValuePair<string, string>(x.IdFile.ToString(), x.Name)).ToList());
                    data.Add(new KeyValuePair<string, string>("", "All"));
                    cbbFolder.DataSource = null;
                    cbbFolder.Items.Clear();
                    cbbFolder.DisplayMember = "Value"; // Hiển thị tên
                    cbbFolder.ValueMember = "Key"; // Lấy Id
                    cbbFolder.DataSource = data;

                    if (!string.IsNullOrEmpty(folderName))
                    {
                        var selectedItem = data.FirstOrDefault(x => x.Value == folderName);
                        if (selectedItem.Key != null)
                        {
                            var index = data.IndexOf(selectedItem);
                            cbbFolder.SelectedIndex = index;
                        }
                    }
                }
                else
                {
                    cbbFolder.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }

        private void GetDataAccounts(string _search)
        {
            try
            {
                //Load Account vao datagridview
                var accounts = _accountsService.GetAll();
                if (accounts != null)
                {
                    if (!string.IsNullOrEmpty(IdFile))
                    {
                        var _idFile = new Guid(IdFile);
                        accounts = accounts.Where(x => x.IdFile == _idFile).ToList();
                    }
                    if (!string.IsNullOrEmpty(_search))
                    {
                        accounts = accounts.Where(x => new[] { x.PhoneNumber, x.UserName, x.FullName, x.Proxy }
                                                .Any(field => field?.Contains(_search) ?? false)).ToList();
                    }
                    dtgvAcc.Invoke((MethodInvoker)delegate
                    {
                        dtgvAcc.Rows.Clear();
                    });
                    dtgvAcc.Invoke((MethodInvoker)delegate
                    {
                        int i = 1;
                        foreach (var a in accounts)
                        {
                            Button button = new Button();

                            dtgvAcc.Invoke((MethodInvoker)delegate
                            {
                                dtgvAcc.Rows.Add(false, i, a.IdAccount, a.PhoneNumber, a.Password, a.AppId, a.AppHash, a.UserName, a.Session, a.Cookie, a.Proxy, a.FullName, a.FolderName, a.Interac, a.Info, a.Status, "Login", "Show", "Get Code", a.UserAgent);
                            });

                            if (!string.IsNullOrEmpty(a.Info))
                            {
                                dtgvAcc.Invoke((MethodInvoker)delegate
                                {
                                    dtgvAcc.Rows[i - 1].DefaultCellStyle.BackColor = Color.Pink;
                                });
                            }
                            if (!string.IsNullOrEmpty(a.Info) && a.Info == "Live")
                            {
                                dtgvAcc.Invoke((MethodInvoker)delegate
                                {
                                    dtgvAcc.Rows[i - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                                });
                            }
                            i++;
                        }
                    });
                }
                else
                {
                    MessageCommon.ShowMessageBox("ERROR SQL ", 4);
                }

            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }

        private void cbbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdFile = cbbFolder.SelectedValue?.ToString();
                GetDataAccounts(search);
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            GetDataAccounts(search);
        }
        private void GetConfigDatagridview()
        {
            try
            {
                dtgvAcc.Columns["cAppHash"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbApHash", true);
                dtgvAcc.Columns["cUsername"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbUsername", true);
                dtgvAcc.Columns["cSession"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbSession", true);
                dtgvAcc.Columns["cFullname"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbFullname", true);
                dtgvAcc.Columns["cCookies"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbCookie", true);
                dtgvAcc.Columns["cAppId"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbApId", true);
                dtgvAcc.Columns["cStatus"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbStatus", true);
                dtgvAcc.Columns["cThuMuc"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbFolder", true);
                dtgvAcc.Columns["cInteractEnd"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbInteractEnd", true);
                dtgvAcc.Columns["cInfo"].Visible = SettingsTool.GetSettings("configDatagridview").GetBooleanValue("ckbAccountStatus", true);
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            FormHelper.ShowFormWithoutTaskbar(new fDisplayConf());
            GetConfigDatagridview();
        }

        private void DtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                try
                {
                    dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
                }
                catch (Exception ex)
                {
                    MessageCommon.ShowMessageBox(ex.Message, 4);
                    RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                    Log.Error(ex, ex.Message);
                }
            }
        }

        private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
                }
                catch (Exception ex)
                {
                    MessageCommon.ShowMessageBox(ex.Message, 4);
                    RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                    Log.Error(ex, ex.Message);
                }
            }
        }

        private void PerformAction(string action)
        {
            try
            {
                switch (action)
                {
                    case "ToggleCheck":
                        {
                            for (int k = 0; k < dtgvAcc.SelectedRows.Count; k++)
                            {
                                int index = dtgvAcc.SelectedRows[k].Index;
                                SetCellAccount(index, "cChose", !Convert.ToBoolean(GetCellValue(index, "cChose")));
                            }
                            //UpdateSelectedRowCount();

                            break;
                        }
                    case "SelectHighline":
                        {
                            DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
                            for (int j = 0; j < selectedRows.Count; j++)
                            {
                                SetCellAccount(selectedRows[j].Index, "cChose", true);
                            }
                            //UpdateSelectedRowCount();
                            break;
                        }
                    case "UnAll":
                        {
                            for (int l = 0; l < dtgvAcc.RowCount; l++)
                            {
                                SetCellAccount(l, "cChose", false);
                            }
                            //UpdateSelectedRowCount(0);
                            break;
                        }
                    case "All":
                        {
                            for (int i = 0; i < dtgvAcc.RowCount; i++)
                            {
                                SetCellAccount(i, "cChose", true);
                            }
                            //UpdateSelectedRowCount(dtgvAcc.RowCount);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }

        public void SetCellAccount(int rowIndex, string columnName, object cellValue, bool allowNull = true)
        {
            if (allowNull || !(cellValue.ToString().Trim() == ""))
            {
                DataGridViewHelper.SetCellValue(dtgvAcc, rowIndex, columnName, cellValue);
            }
        }

        public string GetCellValue(int rowIndex, string columnName)
        {
            return DataGridViewHelper.GetCellValue(dtgvAcc, rowIndex, columnName);
        }

        private void ctmsAcc_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                moveFolderToolStripMenuItem.DropDownItems.Clear();
                var list = _filesService.GetAll();
                int num = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].IdFile.ToString() != ((cbbFolder.SelectedValue == null) ? "" : cbbFolder.SelectedValue.ToString()))
                    {
                        moveFolderToolStripMenuItem.DropDownItems.Add(list[i].Name.ToString());
                        moveFolderToolStripMenuItem.DropDownItems[i - num].Tag = list[i].IdFile.ToString();
                        moveFolderToolStripMenuItem.DropDownItems[i - num].Click += MoveAccountsToFolder;
                    }
                    else
                    {
                        num++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformAction("All");
        }

        private void selectAllHighlightedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformAction("SelectHighline");
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformAction("UnAll");
        }

        private async void deleteAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = GetListSelect();
                if (list.Count == 0)
                {
                    MessageCommon.ShowMessageBox("Please select the account to delete!", 4);
                }
                else
                {
                    if (MessageCommon.ShowConfirmationBox(string.Format("Do you want to delete the {0} selected accounts?", list.Count)) != DialogResult.Yes)
                    {
                        return;
                    }
                    var check = _accountsService.DeleteList(list);
                    if (check)
                    {
                        MessageCommon.ShowMessageBox("Account deleted successfully!");
                        GetDataAccounts(search);
                    }
                    else
                    {
                        MessageCommon.ShowMessageBox("Delete failed, please try again later!", 4);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }


        public List<string> GetListSelect()
        {
            List<string> list = new List<string>();
            try
            {
                for (int i = 0; i < dtgvAcc.RowCount; i++)
                {
                    if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
                    {
                        list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
            return list;
        }

        private void MoveAccountsToFolder(object sender, EventArgs e)
        {
            try
            {
                var list = GetListSelect();
                if (list.Count == 0)
                {
                    MessageCommon.ShowMessageBox("Please select the device you want to transfer!", 3);
                    return;
                }

                ToolStripMenuItem selectedMenuItem = sender as ToolStripMenuItem;
                string targetFolderId = selectedMenuItem.Tag.ToString();
                string targetFolderName = selectedMenuItem.Text;

                string confirmationMessage = string.Format("Do you really want to move {0} accounts to the [{1}] directory?", list.Count, targetFolderName);
                if (MessageCommon.ShowConfirmationBox(confirmationMessage) == DialogResult.Yes)
                {
                    MoveSelectedAccountsToFolder(targetFolderId);
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }

        private void MoveSelectedAccountsToFolder(string targetFolderId)
        {
            try
            {
                List<string> selectedAccountIds = GetListSelect();
                var check = _accountsService.UpdateFolder(selectedAccountIds, targetFolderId);
                if (check)
                {
                    MessageCommon.ShowMessageBox(string.Format("Successfully transferred {0} device!", selectedAccountIds.Count));
                    GetDataAccounts(search);
                }
                else
                {
                    MessageCommon.ShowMessageBox("Transfer failed, please try again later!", 2);
                }

            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }

        private void btnDelFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageCommon.ShowConfirmationBox(string.Format("Do you want to delete folder [{0}]?", cbbFolder.Text) + "\r\n" + "Note: Deleting the folder will delete the attached device") != DialogResult.Yes)
                {
                    return;
                }
                var _IdFile = cbbFolder.SelectedValue?.ToString();
                var check = _filesService.Delete(_IdFile);
                if (check)
                {
                    MessageCommon.ShowMessageBox("Delete folder successfully");
                    GetDataFolder("");
                }
                else
                {
                    MessageCommon.ShowMessageBox("Transfer failed, please try again later!", 2);
                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }
        private void SaveConfigMain()
        {
            try
            {
                var typeProxy = 0;
                if (rbProxyFromAccount.Checked)
                {
                    typeProxy = 1;
                }
                else if (rbProxyFromFile.Checked)
                {
                    typeProxy = 2;
                }
                SettingsTool.GetSettings("configMain").AddValue("typeProxy", typeProxy);
                SettingsTool.GetSettings("configMain").AddValue("folderName", cbbFolder.Text);
                SettingsTool.GetSettings("configMain").AddValue("nudNumberThreads", nudNumberThreads.Value);
                SettingsTool.GetSettings("configMain").AddValue("nudRepeatFrom", nudRepeatFrom.Value);
                SettingsTool.GetSettings("configMain").AddValue("ckbRandomAction", ckbRandomAction.Checked);
                SettingsTool.GetSettings("configMain").AddValue("ckbRepeatAfter", ckbRepeatAfter.Checked);
                SettingsTool.GetSettings("configMain").AddValue("cbCheckDuplicate", cbCheckDuplicate.Checked);
                SettingsTool.UpdateSetting("configMain");
            }
            catch (Exception ex)
            {
                Log.Error($"ERROR: {nameof(fMain)}, params; {nameof(SaveConfigMain)}, Error; {ex.Message}, Exception; {ex}");
            }
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }

        }

        private void assignAProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetListSelect().Count == 0)
            {
                MessageCommon.ShowMessageBox("Please select the device you want to import proxy", 3);
            }
            else
            {
                FormHelper.ShowFormWithoutTaskbar(new fImportProxy(_accountsService, null));
            }
        }
        private async void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_start.BackColor = Color.DarkSeaGreen;
            GlobalModel.ListUserMessage.Clear();
            if (cbCheckDuplicate.Checked)
            {
                GlobalModel.ListUserMessage.AddRange(File.ReadAllLines(GlobalModel.FileMessage).ToList());
            }
            GlobalModel.ListScript.Clear();
            int maxThread;
            if (int.TryParse(nudNumberThreads.Value.ToString(), out maxThread))
            {
                // Nếu giá trị được chuyển đổi thành công, thực hiện các hành động ở đây
                maxThread = int.Parse(nudNumberThreads.Value.ToString());
            }
            else
            {
                MessageCommon.ShowMessageBox("Please enter the number to run again.", 2);
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }
            if (maxThread < 1)
            {
                MessageCommon.ShowMessageBox("Please enter the number to run again.", 2);
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }
            var script = getListNameCheckBox();
            if (script == null)
            {
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }
            else if (!script.Any())
            {
                MessageCommon.ShowMessageBox("You haven't selected any action.", 2);
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }
            else
            {
                GlobalModel.ListScript.AddRange(script);
            }
            ////////////import Account in List Account///////////////
            List<string> idAccounts = new List<string>();
            foreach (DataGridViewRow row in dtgvAcc.Rows)
            {
                bool chosen = (bool)row.Cells["cChose"].Value;
                if (chosen)
                {
                    var id = row.Cells["cId"].Value.ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        idAccounts.Add(id);
                    }
                }
            }
            if (!idAccounts.Any())
            {
                MessageCommon.ShowMessageBox("Please select account!", 2);
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }

            HttpHelper httpHelper = new HttpHelper();
            string hardwareId = httpHelper.GetHardwareId();
            ApiQnibot.Constant.licenseKey = (string)Properties.Settings.Default["Key"];
            var softwareId = ApiQnibot.Constant.SoftwareId;
            var checkLicenseResult = await httpHelper.CheckLicense(ApiQnibot.Constant.licenseKey, hardwareId, softwareId);
            if (checkLicenseResult != null)
            {
                if (checkLicenseResult.Data is false)
                {
                    MessageCommon.ShowMessageBox(checkLicenseResult.Message, 3);
                    btn_start.Enabled = true;
                    btn_start.BackColor = Color.DarkGreen;
                    return;
                }
            }
            else
            {
                MessageCommon.ShowMessageBox("There's an error, please try again later.", 3);
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }
            SaveConfigMain();
            /////////////////// check proxy //////////////////
            if (rbProxyFromFile.Checked)
            {
                list_proxy.Clear();

                string pathProxy = Path.Combine(Environment.CurrentDirectory, "Database\\Proxy\\Proxy.txt");
                var lines = File.ReadAllLines(pathProxy);
                if (lines.Any())
                {
                    list_proxy.AddRange(lines);
                }
                if (!list_proxy.Any())
                {
                    MessageCommon.ShowMessageBox("Please enter the file proxy!", 3);
                    btn_start.Enabled = true;
                    btn_start.BackColor = Color.DarkGreen;
                    return;
                }
            }
            ///////////////////////////////////////////////////////////
            GlobalModel.ListAccount.Clear();
            int index = 0;
            foreach (var id in idAccounts)
            {
                DevicesModel device = new DevicesModel();
                device.Index = index;
                device.IdAccount = id;
                device.Repeat = 4;
                if (rbProxyFromFile.Checked)
                {
                    device.Proxy = list_proxy[_random.Next(0, list_proxy.Count)];
                }
                device.Status = "Waitting";
                GlobalModel.ListAccount.Add(device);
                index++;
            }
            if (!GlobalModel.ListAccount.Any())
            {
                MessageCommon.ShowMessageBox("Please check the list of selected accounts!", 3);
                btn_start.Enabled = true;
                btn_start.BackColor = Color.DarkGreen;
                return;
            }

            //////////////import script in List Script/////////////
            cancellationTokenSource = new CancellationTokenSource();
            semaphore = new SemaphoreSlim(maxThread);
            foreach (var item in GlobalModel.ListAccount)
            {
                tasks.Add(Task.Run(async () =>
                {
                    await StartDevice(item);
                }, cancellationTokenSource.Token));
            }
            await Task.WhenAll(tasks);
            tasks.Clear();
            try
            {
                if (cbCheckDuplicate.Checked)
                {
                    GlobalModel.ListUserMessage.AddRange(File.ReadAllLines(GlobalModel.FileMessage).ToList());
                }
                if (ckbRepeatAfter.Checked)
                {
                    List<string> stringsToRemove = new List<string> { "fUpAvatar", "f2FA", "fUpdateInformation", "fChangeName", "fChangeUsername", "fUpdateBio" };

                    foreach (var strToRemove in stringsToRemove)
                    {
                        GlobalModel.ListScript.RemoveAll(script => script.Contains(strToRemove));
                    }
                    while (!cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        tasks.Clear();
                        checkLicenseResult = await httpHelper.CheckLicense(ApiQnibot.Constant.licenseKey, hardwareId, softwareId);
                        if (checkLicenseResult != null)
                        {
                            if (checkLicenseResult.Data is false)
                            {
                                MessageCommon.ShowMessageBox(checkLicenseResult.Message, 3);
                                return;
                            }
                        }
                        else
                        {
                            MessageCommon.ShowMessageBox("There's an error, please try again later.", 3);
                            return;
                        }
                        var timeRepeat = _random.Next((int)nudRepeatFrom.Value, (int)nudRepeatTo.Value);
                        await WaitingDialog.ShowWaitingDialogAsync($"Repeat After {timeRepeat} minutes...", async () =>
                        {
                            // Thực hiện công việc chờ đợi ở đây
                            await Task.Delay(timeRepeat * 60 * 1000); // Chuyển đổi phút thành mili giây // Ví dụ: chờ 5 giây
                                                                      // Công việc đã hoàn thành
                        });
                        if (cancellationTokenSource.Token.IsCancellationRequested)
                        {
                            break;
                        }
                        GlobalModel.ListAccount.ForEach(account => account.Repeat = 4);
                        foreach (var item in GlobalModel.ListAccount)
                        {
                            tasks.Add(Task.Run(async () =>
                            {
                                await StartDevice(item);
                            }, cancellationTokenSource.Token));
                        }
                        await Task.WhenAll(tasks);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            if (!File.Exists(GlobalModel.FileMessage))
            {
                File.Create(GlobalModel.FileMessage);
            }
            using (StreamWriter writer = new StreamWriter(GlobalModel.FileMessage))
            {
                // Ghi từng phần tử của danh sách vào tệp tin, mỗi phần tử trên một dòng
                foreach (string item in GlobalModel.ListUserMessage)
                {
                    writer.WriteLine(item);
                }
            }

            MessageCommon.ShowMessageBox("Task completed!", 1);
            btn_start.Enabled = true;
            btn_start.BackColor = Color.DarkGreen;
        }

        public class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern IntPtr GetParent(IntPtr hWnd);
        }
        private List<string> getListNameCheckBox()
        {
            var result = new List<string>();
            var actionsService = _actionsService();
            if (cb_fAddNembersByUsername.Checked)
            {
                var json = actionsService.GetDataActions(cb_fAddNembersByUsername.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fAddNembersByUsername.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fAddNembersByUsername.Name.Replace("cb_", ""));

            }
            if (cb_fSubscribersChannels.Checked)
            {
                var json = actionsService.GetDataActions(cb_fSubscribersChannels.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fSubscribersChannels.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fSubscribersChannels.Name.Replace("cb_", ""));
            }
            if (cb_fBlockByUsername.Checked)
            {
                var json = actionsService.GetDataActions(cb_fBlockByUsername.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fBlockByUsername.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fBlockByUsername.Name.Replace("cb_", ""));
            }
            if (cb_fCreateChannels.Checked)
            {
                var json = actionsService.GetDataActions(cb_fCreateChannels.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fCreateChannels.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fCreateChannels.Name.Replace("cb_", ""));
            }
            if (cb_fCreateGroups.Checked)
            {
                var json = actionsService.GetDataActions(cb_fCreateGroups.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fCreateGroups.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fCreateGroups.Name.Replace("cb_", ""));
            }
            if (cb_fLeaveChannels.Checked)
            {
                var json = actionsService.GetDataActions(cb_fLeaveChannels.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fLeaveChannels.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fLeaveChannels.Name.Replace("cb_", ""));
            }
            if (cb_fGetNembersInGroups.Checked)
            {
                var json = actionsService.GetDataActions(cb_fGetNembersInGroups.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fGetNembersInGroups.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fGetNembersInGroups.Name.Replace("cb_", ""));
            }
            if (cb_fJoinGroups.Checked)
            {
                var json = actionsService.GetDataActions(cb_fJoinGroups.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fJoinGroups.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fJoinGroups.Name.Replace("cb_", ""));
            }
            if (cb_fLeaveGroups.Checked)
            {
                var json = actionsService.GetDataActions(cb_fLeaveGroups.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fLeaveGroups.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fLeaveGroups.Name.Replace("cb_", ""));
            }
            if (cb_fSendMessages.Checked)
            {
                var json = actionsService.GetDataActions(cb_fSendMessages.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fSendMessages.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fSendMessages.Name.Replace("cb_", ""));
            }
            if (cb_fSendMessagesToGroups.Checked)
            {
                var json = actionsService.GetDataActions(cb_fSendMessagesToGroups.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fSendMessagesToGroups.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fSendMessagesToGroups.Name.Replace("cb_", ""));
            }
            if (cb_fSendPrivateMessages.Checked)
            {
                var json = actionsService.GetDataActions(cb_fSendPrivateMessages.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fSendPrivateMessages.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fSendPrivateMessages.Name.Replace("cb_", ""));
            }
            if (cb_fUpdateAvatar.Checked)
            {
                var json = actionsService.GetDataActions(cb_fUpdateAvatar.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fUpdateAvatar.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fUpdateAvatar.Name.Replace("cb_", ""));
            }
            if (cb_fUpdateFullname.Checked)
            {
                var json = actionsService.GetDataActions(cb_fUpdateFullname.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fUpdateFullname.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fUpdateFullname.Name.Replace("cb_", ""));
            }
            if (cb_fUpdatePassword.Checked)
            {
                var json = actionsService.GetDataActions(cb_fUpdatePassword.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fUpdatePassword.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fUpdatePassword.Name.Replace("cb_", ""));
            }
            if (cb_fUpdateUsername.Checked)
            {
                var json = actionsService.GetDataActions(cb_fUpdateUsername.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fUpdateUsername.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fUpdateUsername.Name.Replace("cb_", ""));
            }
            if (cb_fMessageAllContact.Checked)
            {
                var json = actionsService.GetDataActions(cb_fMessageAllContact.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fMessageAllContact.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fMessageAllContact.Name.Replace("cb_", ""));
            }
            if (cb_fAddToContact.Checked)
            {
                var json = actionsService.GetDataActions(cb_fAddToContact.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fAddToContact.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fAddToContact.Name.Replace("cb_", ""));
            }
            if (cb_fUpdateBio.Checked)
            {
                var json = actionsService.GetDataActions(cb_fUpdateBio.Name.Replace("cb_", ""), IdScript);
                if (string.IsNullOrEmpty(json))
                {
                    MessageCommon.ShowMessageBox($"Action '{cb_fUpdateBio.Text}' has not been set, please unselect or set the data.", 3);
                    return null;
                }
                result.Add(cb_fUpdateBio.Name.Replace("cb_", ""));
            }
            return result;
        }
        private List<int> GenerateRandomIndices(int listCount, decimal prercent)
        {
            prercent = prercent / 100;
            int numberOfIndices = (int)Math.Round(prercent * listCount);
            Random random = new Random();
            List<int> indices = new List<int>();
            while (indices.Count < numberOfIndices)
            {
                int index = random.Next(0, listCount);
                if (!indices.Contains(index))
                {
                    indices.Add(index);
                }
            }
            return indices;
        }
        private int ExtractSeconds(string timePattern)
        {
            string[] timeParts = timePattern.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int seconds = 0;
            int currentNumber = 0;
            for (int i = 0; i < timeParts.Length; i += 2)
            {
                currentNumber = int.Parse(timeParts[i]);
                string unit = timeParts[i + 1].ToLower();

                if (unit == "hours")
                {
                    seconds += currentNumber * 3600;
                }
                else if (unit == "minutes")
                {
                    seconds += currentNumber * 60;
                }
                else if (unit == "seconds")
                {
                    seconds += currentNumber;
                }
            }

            return seconds;
        }
        private async void btn_stop_Click(object sender, EventArgs e)
        {
            StopAll();
        }
        private bool CheckProxy(string proxy)
        {
            try
            {
                string host = "";
                string port = "";
                string username = "";
                string password = "";
                if (!string.IsNullOrEmpty(proxy))
                {
                    // Tách thông tin từ chuỗi proxy
                    string[] parts = proxy.Split(':');
                    if (parts.Length >= 2)
                    {
                        host = parts[0];
                        port = parts[1];
                    }
                    if (parts.Length >= 4)
                    {
                        username = parts[2];
                        password = parts[3];
                    }
                }
                if (!string.IsNullOrEmpty(host) && !string.IsNullOrEmpty(port))
                {
                    string proxyAddress = host + ":" + port;

                    // Create a WebRequest using proxy
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api64.ipify.org/");
                    request.Proxy = new WebProxy(proxyAddress);

                    // Set proxy credentials if provided
                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {
                        request.Proxy.Credentials = new NetworkCredential(username, password);
                    }

                    // Send a GET request to check the proxy
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        // Check the HTTP status code to determine proxy validity
                        HttpStatusCode statusCode = response.StatusCode;

                        // Return true if status code indicates success
                        return statusCode >= HttpStatusCode.OK && statusCode < HttpStatusCode.Ambiguous;
                    }
                }
                else
                {
                    RichTextBoxHelper.WriteLogRichTextBox($"ERROR: Format Proxy {proxy}", 1);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                // An error occurred when using the proxy
                return false;
            }
            return false;
        }
        private async Task StartDevice(DevicesModel device)
        {
            writeLogs(device.Index, device.Status, device.IdAccount, 3, false);
            await semaphore.WaitAsync();
            try
            {
                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    device.Client = null;
                    tasks.Clear();
                    return;
                }
                writeLogs(device.Index, "Running", device.IdAccount, 2, false);
                device.Status = "run";
                var accountService = _serviceProvider.GetService<IAccountsService>();
                var account = accountService.GetAccountById(device.IdAccount);
                if (account != null)
                {
                    if (rbProxyFromFile.Checked && !string.IsNullOrEmpty(account.Proxy))
                    {
                        device.Proxy = account.Proxy;
                    }
                    if (!rbNoProxy.Checked && !string.IsNullOrEmpty(device.Proxy))
                    {
                        if (!CheckProxy(device.Proxy))
                        {
                            device.Client = null;
                            writeLogs(device.Index, $"Proxy Dead : {device.Proxy}", device.IdAccount, 1, true);
                            device.Status = " fail";
                            goto NextAccount;
                        }
                    }
                    if (device.Status == "run")
                    {
                        if (string.IsNullOrEmpty(account.Session) && !File.Exists(account.Session))
                        {
                            device.Client = null;
                            writeLogs(device.Index, "Session not found", device.IdAccount, 1, true);
                            goto NextAccount;
                        }
                        if (File.Exists(account.Session) && !string.IsNullOrEmpty(account.AppId) && !string.IsNullOrEmpty(account.AppHash))
                        {
                            try
                            {
                                if (int.TryParse(account.AppId, out int apIdnum))
                                {
                                    device.Client = new Client(apIdnum, account.AppHash, account.Session);
                                    if (!string.IsNullOrEmpty(device.Proxy))
                                    {
                                        device.Client.TcpHandler = async (address, port) =>
                                        {
                                            var proxy = xNet.HttpProxyClient.Parse(device.Proxy);
                                            return proxy.CreateConnection(address, port);
                                        };
                                    }
                                    device.Status = await device.Client.Login(account.PhoneNumber);
                                }
                            }
                            catch (Exception ex)
                            {
                                device.Client = null;
                                writeLogs(device.Index, $"ERROR Login Session   {ex.Message}", device.IdAccount, 1, true);
                                goto NextAccount;
                            }
                        }
                        if (device.Client != null)
                        {
                            if (!string.IsNullOrEmpty(device.Status))
                            {
                                device.Client = null;
                                accountService.UpdateAccountStatus(new Guid(account.IdAccount), device.Status);
                                DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cInfo", device.Status, 1);
                                writeLogs(device.Index, $"ERROR Login Session   {device.Status}", device.IdAccount, 1, true);
                                goto NextAccount;
                            }
                            else
                            {
                                accountService.UpdateAccountStatus(new Guid(account.IdAccount), "Live");
                                DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cInfo", "Live", 2);
                            }
                            accountService.UpdateFullname(new Guid(account.IdAccount), $"{device.Client.User.first_name} {device.Client.User.last_name}");
                            DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cFullname", $"{device.Client.User.first_name} {device.Client.User.last_name}", 2);
                            accountService.UpdateUsername(new Guid(account.IdAccount), $"{device.Client.User.username}");
                            DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cUsername", $"{device.Client.User.username}", 2);
                            List<string> actions = new List<string>();
                            if (ckbRandomAction.Checked)
                            {
                                actions.AddRange(FileHelper.ShuffleList(GlobalModel.ListScript));
                            }
                            else
                            {
                                actions.AddRange(GlobalModel.ListScript);
                            }
                            if (actions.Any())
                            {
                                var name = device.Client.User.first_name + " " + device.Client.User.last_name;
                                var username = device.Client.User.username;
                                //   device.Client.Channels_CreateChannel
                                foreach (var action in actions)
                                {
                                    var actionsService = _actionsService();
                                    var json = actionsService.GetDataActions(action, IdScript);
                                    if (!string.IsNullOrEmpty(json))
                                    {
                                        await WorkingWithScript(device, account, action, accountService);// thực thi kịch bản tại đây
                                        accountService.UpdateInterac(Guid.Parse(account.IdAccount), $"{action.Replace("f", "")} {DateTime.Now.Date}");
                                        DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cInteractEnd", $"{action.Replace("f", "")} {DateTime.Now.ToString("MM/dd/yyyy")}", 2);
                                    }
                                    else
                                    {
                                        writeLogs(device.Index, $" The action {action.Replace("f", "")} has not been set up.", null, 1, true);
                                    }
                                    if (cancellationTokenSource.Token.IsCancellationRequested)
                                    {
                                        device.Client = null;
                                        tasks.Clear();
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                writeLogs(device.Index, $"List action not found", device.IdAccount, 1, true);
                                goto NextAccount;
                            }
                        }
                    }
                }
                else
                {
                    writeLogs(device.Index, "Account not found by ID", device.IdAccount, 1, true);
                    goto NextAccount;
                }
            NextAccount:
                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    tasks.Clear();
                    return;
                }
                device.Client = null;
            }
            catch (Exception ex)
            {
                device.Client = null;
                Log.Error($"End {nameof(fMain)}, params; {nameof(StartDevice)}, messager; {ex.Message}, Exception; {ex}");
                writeLogs(device.Index, ex.Message, device.IdAccount, 1, true);
            }
            finally
            {
                device.Client = null;
                semaphore.Release();
            }
        }
        private void StopAll()
        {
            cancellationTokenSource?.Cancel();
            tasks.Clear();
            Application.ExitThread();
        }
        private async Task WorkingWithScript(DevicesModel device, AccountsModel account, string script, IAccountsService accountsService)
        {
            try
            {
                switch (script)
                {
                    case "fCreateChannels":
                        {

                            writeLogs(device.Index, $"Action Create Channels", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fCreateChannels", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListChannels"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    string bio = string.Empty;
                                    if (jsonHelper.GetBooleanValue("ckbBio", false))
                                    {
                                        bio = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtBio"), 1).FirstOrDefault();
                                    }
                                    var result = await device.Client.Channels_CreateChannel(title: item, about: bio);
                                    if (result != null)
                                    {
                                        var channel = (TL.Channel)result.Chats[result.Chats.FirstOrDefault().Key];
                                        writeLogs(device.Index, $"Action Create Channel: {channel.Title}", account.IdAccount, 2);
                                        if (channel != null)
                                        {
                                            if (jsonHelper.GetBooleanValue("ckbAvtar", false))
                                            {
                                                try
                                                {
                                                    var folderimage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                                    if (Directory.Exists(folderimage))
                                                    {
                                                        var images = Directory.GetFiles(folderimage);
                                                        if (images.Any())
                                                        {
                                                            var image = FileHelper.ShuffleAndReturn(images.ToList(), 1).FirstOrDefault();
                                                            if (File.Exists(image))
                                                            {
                                                                var file = await device.Client.UploadFileAsync(image);
                                                                if (file != null)
                                                                {
                                                                    var avtar = await device.Client.Channels_EditPhoto(channel, file.ToInputChatPhoto());
                                                                    if (avtar != null)
                                                                    {
                                                                        writeLogs(device.Index, $"Update avatar {image}", null);
                                                                    }
                                                                }

                                                            }
                                                            else
                                                            {
                                                                writeLogs(device.Index, $"{folderimage} not fond", null, 1);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            writeLogs(device.Index, $"{folderimage} not files", null, 1);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        writeLogs(device.Index, $"{folderimage} not fond", null, 1);
                                                    }

                                                }
                                                catch (Exception ex)
                                                {
                                                    Log.Error(ex, ex.Message);
                                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                                }

                                            }
                                            if (jsonHelper.GetBooleanValue("ckbInviteToChannel", false))
                                            {
                                                var countMembers = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 4));
                                                var members = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListUsername"), countMembers);
                                                foreach (var member in members)
                                                {
                                                    try
                                                    {
                                                        var user = await device.Client.Contacts_ResolveUsername(member);
                                                        if (user != null)
                                                        {
                                                            var addmember = await device.Client.Channels_InviteToChannel(channel, user.User);
                                                            if (addmember != null)
                                                            {
                                                                writeLogs(device.Index, $"Invite Member: {member}", null);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            writeLogs(device.Index, $"{member} not fond", null, 1);
                                                        }
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Log.Error(ex, ex.Message);
                                                        writeLogs(device.Index, $"{member} {ex.Message}", null, 1);
                                                    }
                                                    var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                    await FileHelper.DalayAsync(time);
                                                }

                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }

                            break;
                        }
                    case "fSubscribersChannels":
                        {
                            writeLogs(device.Index, $"Action Subscribers Channels", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fSubscribersChannels", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListChannels"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    if (resolved.Chat is TL.Channel channel)
                                    {
                                        await device.Client.Channels_JoinChannel(channel);
                                        writeLogs(device.Index, $"Action Subscribers Channel: https://t.me/{item}", account.IdAccount, 2);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fLeaveChannels":
                        {
                            writeLogs(device.Index, $"Action Leave Channels", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fLeaveChannels", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListChannels"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    if (resolved.Chat is TL.Channel channel)
                                    {
                                        await device.Client.Channels_LeaveChannel(channel);
                                        writeLogs(device.Index, $"Action Leave Channel: https://t.me/{item}", account.IdAccount, 2);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fCreateGroups":
                        {
                            writeLogs(device.Index, $"Action Create Group", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fCreateGroups", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListChannels"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var result = await device.Client.Channels_CreateChannel(title: item, about: "", megagroup: true);
                                    if (result != null)
                                    {
                                        var channel = (TL.Channel)result.Chats[result.Chats.FirstOrDefault().Key];
                                        writeLogs(device.Index, $"Action Create Groups: {channel.Title}", account.IdAccount, 2);
                                        if (channel != null)
                                        {
                                            if (jsonHelper.GetBooleanValue("ckbAvtar", false))
                                            {
                                                try
                                                {
                                                    var folderimage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                                    if (Directory.Exists(folderimage))
                                                    {
                                                        var images = Directory.GetFiles(folderimage);
                                                        if (images.Any())
                                                        {
                                                            var image = FileHelper.ShuffleAndReturn(images.ToList(), 1).FirstOrDefault();
                                                            if (File.Exists(image))
                                                            {
                                                                var file = await device.Client.UploadFileAsync(image);
                                                                if (file != null)
                                                                {
                                                                    var avtar = await device.Client.Channels_EditPhoto(channel, file.ToInputChatPhoto());
                                                                    if (avtar != null)
                                                                    {
                                                                        writeLogs(device.Index, $"Update avatar {image}", null);
                                                                    }
                                                                }

                                                            }
                                                            else
                                                            {
                                                                writeLogs(device.Index, $"{folderimage} not fond", null, 1);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            writeLogs(device.Index, $"{folderimage} not files", null, 1);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        writeLogs(device.Index, $"{folderimage} not fond", null, 1);
                                                    }

                                                }
                                                catch (Exception ex)
                                                {
                                                    Log.Error(ex, ex.Message);
                                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                                }

                                            }
                                            if (jsonHelper.GetBooleanValue("ckbInviteToChannel", false))
                                            {
                                                var countMembers = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 4));
                                                var members = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListUsername"), countMembers);
                                                foreach (var member in members)
                                                {
                                                    try
                                                    {
                                                        var user = await device.Client.Contacts_ResolveUsername(member);
                                                        if (user != null)
                                                        {
                                                            var addmember = await device.Client.Channels_InviteToChannel(channel, user.User);
                                                            if (addmember != null)
                                                            {
                                                                writeLogs(device.Index, $"Invite Member: {member}", null);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            writeLogs(device.Index, $"{member} not fond", null, 1);
                                                        }
                                                        var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                        await FileHelper.DalayAsync(time);
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Log.Error(ex, ex.Message);
                                                        writeLogs(device.Index, $"{member} {ex.Message}", null, 1);
                                                    }

                                                }

                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }

                            break;
                        }
                    case "fGetNembersInGroups":
                        {
                            writeLogs(device.Index, $"Action Export Members In Groups", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fGetNembersInGroups", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            var folderExport = jsonHelper.GetValuesFromInputString("txtFolderExport");
                            if (Directory.Exists(folderExport))
                            {
                                foreach (var item in list)
                                {
                                    string file = item + ".txt";
                                    List<string> users = new List<string>();
                                    string filePathToCheck = Path.Combine(folderExport, file);
                                    bool check = false;
                                    lock (filePathToCheck)
                                    {
                                        if (!File.Exists(filePathToCheck))
                                        {
                                            check = true;
                                            File.Create(filePathToCheck).Close();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    if (check)
                                    {
                                        var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                        if (resolved.Chat is TL.Channel channel)
                                        {
                                            var participants = await device.Client.Channels_GetParticipants(channel, null, 0);
                                            foreach (var user in participants.users)
                                            {
                                                if (!user.Value.IsBot && !string.IsNullOrEmpty(user.Value.username))
                                                {
                                                    users.Add(user.Value.username);
                                                }

                                            }
                                        }
                                        if (users.Any())
                                        {
                                            List<string> outPut = new List<string>();
                                            var indexOut = jsonHelper.GetIntType("nudNembersForm", 10);
                                            if (jsonHelper.GetIntType("nudNembersForm", 0) > 0)
                                            {
                                                outPut.AddRange(FileHelper.ShuffleAndReturn(users, indexOut));
                                            }
                                            else
                                            {
                                                outPut.AddRange(users);
                                            }
                                            if (outPut.Any())
                                            {
                                                File.WriteAllLines(filePathToCheck, outPut);
                                                writeLogs(device.Index, $"Action Export Members ({outPut.Count}) In Groups: {item} ", account.IdAccount, 2);
                                            }
                                            var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                            await FileHelper.DalayAsync(delay);
                                        }

                                    }



                                }
                            }
                            break;
                        }
                    case "fAddNembersByUsername":
                        {
                            writeLogs(device.Index, $"Action Add Members By Username", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fAddNembersByUsername", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListChannels"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    if (resolved.Chat is TL.Channel channel)
                                    {
                                        writeLogs(device.Index, $"Action Add Member to Group: {channel.Title}", account.IdAccount, 2);
                                        var countMembers = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 4));
                                        var members = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListUsername"), countMembers);
                                        foreach (var member in members)
                                        {
                                            try
                                            {
                                                var user = await device.Client.Contacts_ResolveUsername(member);
                                                if (user != null)
                                                {
                                                    var addmember = await device.Client.Channels_InviteToChannel(channel, user.User);
                                                    if (addmember != null)
                                                    {
                                                        writeLogs(device.Index, $"Add Member: {member}", null);
                                                    }
                                                }
                                                else
                                                {
                                                    writeLogs(device.Index, $"{member} not fond", null, 1);
                                                }
                                                var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                await FileHelper.DalayAsync(time);
                                            }
                                            catch (Exception ex)
                                            {
                                                Log.Error(ex, ex.Message);
                                                writeLogs(device.Index, $"{member} {ex.Message}", null, 1);
                                            }

                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;

                        }
                    case "fSendMessagesToGroups":
                        {
                            writeLogs(device.Index, $"Action Send Message To Groups", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fSendMessagesToGroups", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    if (!GlobalModel.ListUserMessage.Contains(item))
                                    {
                                        GlobalModel.ListUserMessage.Add(item);
                                        var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                        if (resolved.Chat is TL.Channel channel)
                                        {
                                            writeLogs(device.Index, $"Action Send Message To Group: {channel.Title}", account.IdAccount, 2);
                                            int index = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 2));
                                            for (int i = 0; i < index; i++)
                                            {
                                                string content = "";
                                                List<string> images = new List<string>();
                                                if (jsonHelper.GetBooleanValue("ckbCommentContent", false))
                                                {
                                                    content = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListComment"), 1).FirstOrDefault();
                                                }
                                                string folderImage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                                if (jsonHelper.GetBooleanValue("ckbImage", false) && Directory.Exists(folderImage))
                                                {
                                                    var countImage = _random.Next(jsonHelper.GetIntType("nudImageCountFrom", 1), jsonHelper.GetIntType("nudImageCountTo", 2));
                                                    images.AddRange(FileHelper.ShuffleAndReturn(Directory.GetFiles(folderImage).ToList(), countImage));
                                                }
                                                try
                                                {
                                                    InputPeer peer = resolved.Chat;
                                                    if (images.Any() && images.Count == 1)
                                                    {
                                                        var inputFile = await device.Client.UploadFileAsync(images.FirstOrDefault());
                                                        await device.Client.SendMediaAsync(peer, content, inputFile);
                                                        writeLogs(device.Index, $"Send Message to group {channel.Title} connet {content} image {images.FirstOrDefault()}", null);
                                                    }
                                                    else if (images.Count > 1)
                                                    {
                                                        var inputMedias = new List<InputMedia>
                                                        {
                                                        };
                                                        foreach (var image in images)
                                                        {
                                                            var inputFile = await device.Client.UploadFileAsync(image);
                                                            var s = new InputMediaUploadedPhoto { file = inputFile };
                                                            inputMedias.Add(s);
                                                        }
                                                        await device.Client.SendAlbumAsync(peer, inputMedias, content);
                                                        writeLogs(device.Index, $"Messager group {channel.Title} content {content} images {inputMedias.Count}", null);
                                                    }
                                                    else
                                                    {
                                                        if (!string.IsNullOrEmpty(content))
                                                        {
                                                            await device.Client.SendMessageAsync(peer, content);
                                                            writeLogs(device.Index, $"Messager group {channel.Title} content {content}", null);
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Log.Error(ex, ex.Message);
                                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                                }
                                                var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                await FileHelper.DalayAsync(time);
                                            }
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fJoinGroups":
                        {
                            writeLogs(device.Index, $"Action Join Groups", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fJoinGroups", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    if (resolved.Chat is TL.Channel channel)
                                    {
                                        await device.Client.Channels_JoinChannel(channel);
                                        writeLogs(device.Index, $"Action Jion Group: https://t.me/{item}", account.IdAccount, 2);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }

                            break;
                        }
                    case "fSendPrivateMessages":
                        {
                            writeLogs(device.Index, $"Action Send Private Messages", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fSendPrivateMessages", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    if (resolved.Chat is TL.Channel channel)
                                    {
                                        var countUser = _random.Next(jsonHelper.GetIntType("nudNembersFrom", 1), jsonHelper.GetIntType("nudNembersTo", 2));
                                        var participants = await device.Client.Channels_GetParticipants(channel, null, 0);
                                        foreach (var user in participants.users)
                                        {
                                            if (!GlobalModel.ListUserMessage.Contains(user.Value.username))
                                            {
                                                GlobalModel.ListUserMessage.Add(user.Value.username);
                                                countUser--;
                                                if (countUser > 0 && !user.Value.IsBot)
                                                {
                                                    writeLogs(device.Index, $"Action Send Messages User {user.Value.first_name} {user.Value.last_name}", account.IdAccount, 2);

                                                    string content = "";
                                                    List<string> images = new List<string>();
                                                    if (jsonHelper.GetBooleanValue("ckbCommentContent", false))
                                                    {
                                                        content = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListComment"), 1).FirstOrDefault();
                                                    }
                                                    string folderImage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                                    if (jsonHelper.GetBooleanValue("ckbImage", false) && Directory.Exists(folderImage))
                                                    {
                                                        var countImage = _random.Next(jsonHelper.GetIntType("nudImageCountFrom", 1), jsonHelper.GetIntType("nudImageCountTo", 2));
                                                        images.AddRange(FileHelper.ShuffleAndReturn(Directory.GetFiles(folderImage).ToList(), countImage));
                                                    }
                                                    try
                                                    {
                                                        if (images.Any() && images.Count == 1)
                                                        {
                                                            var inputFile = await device.Client.UploadFileAsync(images.FirstOrDefault());
                                                            await device.Client.SendMediaAsync(user.Value, content, inputFile);
                                                            writeLogs(device.Index, $"Send Message Member {user.Value.first_name} {user.Value.last_name} connet {content} file {images.FirstOrDefault()}", null);
                                                        }
                                                        else if (images.Count > 1)
                                                        {
                                                            var inputMedias = new List<InputMedia>
                                                            {
                                                            };
                                                            foreach (var image in images)
                                                            {
                                                                var inputFile = await device.Client.UploadFileAsync(image);
                                                                var s = new InputMediaUploadedPhoto { file = inputFile };
                                                                inputMedias.Add(s);
                                                            }
                                                            await device.Client.SendAlbumAsync(user.Value, inputMedias, content);
                                                            writeLogs(device.Index, $"Send Message Member {user.Value.first_name} {user.Value.last_name} content {content} files {inputMedias.Count}", null);
                                                        }
                                                        else
                                                        {
                                                            if (!string.IsNullOrEmpty(content))
                                                            {
                                                                await device.Client.SendMessageAsync(user.Value, content);
                                                                writeLogs(device.Index, $"Send Message Member {user.Value.first_name} {user.Value.last_name} content {content}", null);
                                                            }
                                                        }
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Log.Error(ex, ex.Message);
                                                        writeLogs(device.Index, $"{ex.Message}", null, 1);
                                                    }
                                                    var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                    await FileHelper.DalayAsync(time);
                                                }

                                            }
                                        }

                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fUpdateAvatar":
                        {
                            writeLogs(device.Index, $"Action Update Avatar", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fUpdateAvatar", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            string folderImage = jsonHelper.GetValuesFromInputString("txtNameFolder");
                            if (Directory.Exists(folderImage))
                            {
                                var fileImage = FileHelper.ShuffleAndReturn(Directory.GetFiles(folderImage).ToList(), 1).FirstOrDefault();
                                if (File.Exists(fileImage))
                                {
                                    var file = await device.Client.UploadFileAsync(fileImage);
                                    await device.Client.Photos_UploadProfilePhoto(file);
                                    writeLogs(device.Index, $"Action Update Avatar {fileImage}", account.IdAccount, 2);
                                }
                            }
                            break;
                        }
                    case "fLeaveGroups":
                        {
                            writeLogs(device.Index, $"Action Leave Groups", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fLeaveGroups", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    if (resolved.Chat is TL.Channel channel)
                                    {
                                        await device.Client.Channels_LeaveChannel(channel);
                                        writeLogs(device.Index, $"Action Leave Group: https://t.me/{item}", account.IdAccount, 2);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }

                            break;
                        }
                    case "fUpdateUsername":
                        {
                            writeLogs(device.Index, $"Action Change Username", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fUpdateUsername", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            string username = string.Empty;
                            if (jsonHelper.GetIntType("action", 0) == 1)
                            {
                                username = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), 1).FirstOrDefault();
                            }
                            else
                            {

                                username = FileHelper.TakeRandomList(FileHelper.LastnamesUS).ToLower() + FileHelper.GenerateRandomString("abcdefghijklmnopqrstuvwxyz0123456789", _random.Next(6, 14));
                            }
                            if (!string.IsNullOrEmpty(username))
                            {
                                await device.Client.Account_UpdateUsername(username);
                                writeLogs(device.Index, $"Action Change Username {username}", account.IdAccount, 2);
                                accountsService.UpdateUsername(new Guid(account.IdAccount), username);
                                DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cUsername", $"{device.Client.User.username}", 2);
                            }
                            break;
                        }
                    case "fUpdateFullname":
                        {
                            writeLogs(device.Index, $"Action Update Fullname", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fUpdateFullname", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            string firtname = string.Empty; string lastname = string.Empty, bio = string.Empty;
                            if (jsonHelper.GetIntType("action", 0) == 0)
                            {
                                // US
                                firtname = FileHelper.TakeRandomList(FileHelper.FirtnamesUS);
                                lastname = FileHelper.TakeRandomList(FileHelper.LastnamesUS);

                            }
                            else if (jsonHelper.GetIntType("action", 0) == 1)
                            {
                                //Custom
                                var firtnames = jsonHelper.GetValuesList("txtListFirtname");
                                var lastnames = jsonHelper.GetValuesList("txtLastname");
                                if (firtnames.Any() && lastnames.Any())
                                {
                                    firtname = FileHelper.TakeRandomList(firtnames);
                                    lastname = FileHelper.TakeRandomList(lastnames);
                                }
                            }
                            else if (jsonHelper.GetIntType("action", 0) == 2)
                            {
                                //VN
                                firtname = FileHelper.TakeRandomList(FileHelper.FirtnamesVN);
                                lastname = FileHelper.TakeRandomList(FileHelper.LastnamesVN);
                            }
                            if (jsonHelper.GetBooleanValue("ckbUpdateBio"))
                            {
                                var bios = jsonHelper.GetValuesList("txtListBio");
                                if (bios.Any())
                                {
                                    bio = FileHelper.TakeRandomList(bios);
                                }
                            }
                            await device.Client.Account_UpdateProfile(firtname, lastname, bio);
                            writeLogs(device.Index, $"Action Change Fullname : {firtname} {lastname} Bio {bio}", account.IdAccount, 2);
                            accountsService.UpdateFullname(new Guid(account.IdAccount), $"{firtname} {lastname}");
                            DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, account.IdAccount, "cId", "cFullname", $"{device.Client.User.first_name} {device.Client.User.last_name}", 2);
                            break;
                        }
                    case "fUpdatePassword":
                        {
                            writeLogs(device.Index, $"Action Change Password", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fUpdatePassword", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            string password = string.Empty;
                            if (jsonHelper.GetIntType("action", 0) == 1)
                            {
                                //custom
                                password = jsonHelper.GetValuesFromInputString("txtCustom");
                            }
                            else
                            {
                                //random
                                int count = _random.Next(jsonHelper.GetIntType("nudFrom", 6), jsonHelper.GetIntType("nudTo", 20));
                                password = FileHelper.GenerateRandomString("abcdefghijklmnopqrstuvwxyz0123456789", count);
                            }

                            try
                            {
                                string old_password = "";
                                if (!string.IsNullOrEmpty(account.Password))
                                {
                                    old_password = account.Password;
                                }
                                string new_password = password;
                                var accountPwd = await device.Client.Account_GetPassword();
                                var passwordNew = accountPwd.current_algo == null ? null : await WTelegram.Client.InputCheckPassword(accountPwd, old_password);
                                accountPwd.current_algo = null; // makes InputCheckPassword generate a new password
                                var new_password_hash = new_password == null ? null : await WTelegram.Client.InputCheckPassword(accountPwd, new_password);
                                if (await device.Client.Account_UpdatePasswordSettings(passwordNew, new Account_PasswordInputSettings
                                {
                                    flags = Account_PasswordInputSettings.Flags.has_new_algo,
                                    new_password_hash = new_password_hash?.A,
                                    new_algo = accountPwd.new_algo,
                                    hint = "new password hint",
                                }))
                                {
                                    writeLogs(device.Index, $"Action Change Password {password}", account.IdAccount, 2);
                                    accountsService.UpdateTowFA(new Guid(account.IdAccount), password);
                                }
                                else
                                {
                                    writeLogs(device.Index, $"Action Change Password Fail", null, 1);
                                }
                            }
                            catch (Exception ex)
                            {
                                Log.Error(ex, ex.Message);
                            }

                            break;
                        }
                    case "fSendMessages":
                        {
                            writeLogs(device.Index, $"Action Send Message", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fSendMessages", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    if (!GlobalModel.ListUserMessage.Contains(item))
                                    {
                                        GlobalModel.ListUserMessage.Add(item);
                                        var user = await device.Client.Contacts_ResolveUsername(item);
                                        if (user != null)
                                        {
                                            int index = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 2));
                                            for (int i = 0; i < index; i++)
                                            {
                                                writeLogs(device.Index, $"Action Send Message User {user.User.first_name} {user.User.last_name}", account.IdAccount, 2);
                                                string content = "";
                                                List<string> images = new List<string>();
                                                if (jsonHelper.GetBooleanValue("ckbCommentContent", false))
                                                {
                                                    content = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListUsername"), 1).FirstOrDefault();
                                                }
                                                string folderImage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                                if (jsonHelper.GetBooleanValue("ckbImage", false) && Directory.Exists(folderImage))
                                                {
                                                    var countImage = _random.Next(jsonHelper.GetIntType("nudImageCountFrom", 1), jsonHelper.GetIntType("nudImageCountTo", 2));
                                                    images.AddRange(FileHelper.ShuffleAndReturn(Directory.GetFiles(folderImage).ToList(), countImage));
                                                }
                                                try
                                                {
                                                    if (images.Any() && images.Count == 1)
                                                    {
                                                        var inputFile = await device.Client.UploadFileAsync(images.FirstOrDefault());
                                                        await device.Client.SendMediaAsync(user, content, inputFile);
                                                        writeLogs(device.Index, $"Send Message User {user.User.first_name} {user.User.last_name} connet {content} file {images.FirstOrDefault()}", null);
                                                    }
                                                    else if (images.Count > 1)
                                                    {
                                                        var inputMedias = new List<InputMedia>
                                                        {
                                                        };
                                                        foreach (var image in images)
                                                        {
                                                            var inputFile = await device.Client.UploadFileAsync(image);
                                                            var s = new InputMediaUploadedPhoto { file = inputFile };
                                                            inputMedias.Add(s);
                                                        }
                                                        await device.Client.SendAlbumAsync(user.User, inputMedias, content);
                                                        writeLogs(device.Index, $"Send Message User {user.User.first_name} {user.User.last_name} content {content} files {inputMedias.Count}", null);
                                                    }
                                                    else
                                                    {
                                                        if (!string.IsNullOrEmpty(content))
                                                        {
                                                            await device.Client.SendMessageAsync(user.User, content);
                                                            writeLogs(device.Index, $"Send Message User {user.User.first_name} {user.User.last_name} content {content}", null);
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Log.Error(ex, ex.Message);
                                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                                }
                                                var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                await FileHelper.DalayAsync(time);
                                            }
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fBlockByUsername":
                        {
                            writeLogs(device.Index, $"Action Block By Username", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fBlockByUsername", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);

                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    var resolved = await device.Client.Contacts_ResolveUsername(item); // without the @
                                    await device.Client.Contacts_Block(resolved.User);
                                    writeLogs(device.Index, $"Action Block User: {item}", account.IdAccount, 2);
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fAddToContact":
                        {
                            writeLogs(device.Index, $"Action Add To Contact", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fAddToContact", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            var list = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListGroups"), count);
                            foreach (var item in list)
                            {
                                try
                                {
                                    if (!GlobalModel.ListUserMessage.Contains(item))
                                    {
                                        GlobalModel.ListUserMessage.Add(item);
                                        var user = await device.Client.Contacts_ResolveUsername(item);
                                        if (user != null)
                                        {
                                            await device.Client.Contacts_AddContact(user.User, user.User.first_name, user.User.last_name, "");
                                            int index = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 2));
                                            for (int i = 0; i < index; i++)
                                            {
                                                writeLogs(device.Index, $"Action Send Message User {user.User.first_name} {user.User.last_name}", account.IdAccount, 2);
                                                string content = "";
                                                List<string> images = new List<string>();
                                                if (jsonHelper.GetBooleanValue("ckbCommentContent", false))
                                                {
                                                    content = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListUsername"), 1).FirstOrDefault();
                                                }
                                                string folderImage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                                if (jsonHelper.GetBooleanValue("ckbImage", false) && Directory.Exists(folderImage))
                                                {
                                                    var countImage = _random.Next(jsonHelper.GetIntType("nudImageCountFrom", 1), jsonHelper.GetIntType("nudImageCountTo", 2));
                                                    images.AddRange(FileHelper.ShuffleAndReturn(Directory.GetFiles(folderImage).ToList(), countImage));
                                                }
                                                try
                                                {
                                                    if (images.Any() && images.Count == 1)
                                                    {
                                                        var inputFile = await device.Client.UploadFileAsync(images.FirstOrDefault());
                                                        await device.Client.SendMediaAsync(user, content, inputFile);
                                                        writeLogs(device.Index, $"Send Message User {user.User.first_name} {user.User.last_name} connet {content} file {images.FirstOrDefault()}", null);
                                                    }
                                                    else if (images.Count > 1)
                                                    {
                                                        var inputMedias = new List<InputMedia>
                                                        {
                                                        };
                                                        foreach (var image in images)
                                                        {
                                                            var inputFile = await device.Client.UploadFileAsync(image);
                                                            var s = new InputMediaUploadedPhoto { file = inputFile };
                                                            inputMedias.Add(s);
                                                        }
                                                        await device.Client.SendAlbumAsync(user.User, inputMedias, content);
                                                        writeLogs(device.Index, $"Send Message User {user.User.first_name} {user.User.last_name} content {content} files {inputMedias.Count}", null);
                                                    }
                                                    else
                                                    {
                                                        if (!string.IsNullOrEmpty(content))
                                                        {
                                                            await device.Client.SendMessageAsync(user.User, content);
                                                            writeLogs(device.Index, $"Send Message User {user.User.first_name} {user.User.last_name} content {content}", null);
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Log.Error(ex, ex.Message);
                                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                                }
                                                var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                                await FileHelper.DalayAsync(time);
                                            }
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex, ex.Message);
                                    writeLogs(device.Index, $"{ex.Message}", null, 1);
                                }
                                var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                await FileHelper.DalayAsync(delay);
                            }
                            break;
                        }
                    case "fMessageAllContact":
                        {
                            writeLogs(device.Index, $"Action Message All Contact", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fMessageAllContact", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var chats = await device.Client.Messages_GetAllChats();
                            var count = _random.Next(jsonHelper.GetIntType("nudCountFrom", 1), jsonHelper.GetIntType("nudCountTo", 2));
                            foreach (var chat in chats.chats.Values)
                            {
                                if (!GlobalModel.ListUserMessage.Contains(chat.MainUsername))
                                {
                                    GlobalModel.ListUserMessage.Add(chat.MainUsername);
                                    if (jsonHelper.GetIntType("action", 0) == 1 && count <= 0)
                                    {
                                        break;
                                    }
                                    count--;
                                    int index = _random.Next(jsonHelper.GetIntType("nudInviteFrom", 1), jsonHelper.GetIntType("nudInviteTo", 2));
                                    for (int i = 0; i < index; i++)
                                    {
                                        writeLogs(device.Index, $"Action Send Messages  {chat.Title}", account.IdAccount, 2);
                                        string content = "";
                                        List<string> images = new List<string>();
                                        if (jsonHelper.GetBooleanValue("ckbCommentContent", false))
                                        {
                                            content = FileHelper.ShuffleAndReturn(jsonHelper.GetValuesList("txtListComment"), 1).FirstOrDefault();
                                        }
                                        string folderImage = jsonHelper.GetValuesFromInputString("txtFolderImage");
                                        if (jsonHelper.GetBooleanValue("ckbImage", false) && Directory.Exists(folderImage))
                                        {
                                            var countImage = _random.Next(jsonHelper.GetIntType("nudImageCountFrom", 1), jsonHelper.GetIntType("nudImageCountTo", 2));
                                            images.AddRange(FileHelper.ShuffleAndReturn(Directory.GetFiles(folderImage).ToList(), countImage));
                                        }
                                        try
                                        {
                                            if (images.Any() && images.Count == 1)
                                            {
                                                var inputFile = await device.Client.UploadFileAsync(images.FirstOrDefault());
                                                await device.Client.SendMediaAsync(chat, content, inputFile);
                                                writeLogs(device.Index, $"Send Messages {chat.Title} connet {content} file {images.FirstOrDefault()}", null);
                                            }
                                            else if (images.Count > 1)
                                            {
                                                var inputMedias = new List<InputMedia>
                                                {
                                                };
                                                foreach (var image in images)
                                                {
                                                    var inputFile = await device.Client.UploadFileAsync(image);
                                                    var s = new InputMediaUploadedPhoto { file = inputFile };
                                                    inputMedias.Add(s);
                                                }
                                                await device.Client.SendAlbumAsync(chat, inputMedias, content);
                                                writeLogs(device.Index, $"Send Messages  {chat.Title} content {content} files {inputMedias.Count}", null);
                                            }
                                            else
                                            {
                                                if (!string.IsNullOrEmpty(content))
                                                {
                                                    await device.Client.SendMessageAsync(chat, content);
                                                    writeLogs(device.Index, $"Send Messages {chat.Title} content {content}", null);
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Log.Error(ex, ex.Message);
                                            writeLogs(device.Index, $"{ex.Message}", null, 1);
                                        }
                                        var time = _random.Next(jsonHelper.GetIntType("nudDelayInviteFrom", 10), jsonHelper.GetIntType("nudDelayInviteTo", 20));
                                        await FileHelper.DalayAsync(time);
                                    }
                                    var delay = _random.Next(jsonHelper.GetIntType("nudDelayFrom", 1), jsonHelper.GetIntType("nudDelayTo", 2));
                                    await FileHelper.DalayAsync(delay);
                                }

                            }
                            break;
                        }
                    case "fUpdateBio":
                        {
                            writeLogs(device.Index, $"Action Update Bio", account.IdAccount, 2);
                            var actionsService = _actionsService();
                            var json = actionsService.GetDataActions("fUpdateBio", IdScript);
                            JsonHelper jsonHelper = new JsonHelper(json, true);
                            var bios = jsonHelper.GetValuesList("txtListBio");
                            if (bios.Any())
                            {
                                string bio = FileHelper.TakeRandomList(bios);
                                if (!string.IsNullOrEmpty(bio))
                                {
                                    await device.Client.Account_UpdateProfile(null, null, bio);
                                }
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                writeLogs(device.Index, $"{ex.Message}", account.IdAccount, 1, true);
            }
        }
        private void btnLoadDevice_Click(object sender, EventArgs e)
        {
            loadDevice();
        }
        private void loadDevice()
        {


        }
        public void writeLogs(int index, string message, string? idAccount, int type = 0, bool isWriteRichTextBox = true)
        {
            try
            {
                if (!string.IsNullOrEmpty(idAccount))
                {
                    DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, idAccount, "cId", "cStatus", message, type);
                }
                if (isWriteRichTextBox)
                {
                    RichTextBoxHelper.WriteLogRichTextBox($"Thread ({index}):       {message}", type);
                }
            }
            catch (Exception ex)
            {
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }

        }
        private void dtgvAcc_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRowCount = dtgvAcc.SelectedRows.Count;
            lbAccount.Text = $"Item: ({selectedRowCount})";
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageCommon.ShowConfirmationBox("Are you sure you want to close the software?");
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true; // Hủy việc đóng Form nếu người dùng không đồng ý
                }
                else
                {
                    SaveConfigMain();
                    if (!File.Exists(GlobalModel.FileMessage))
                    {
                        File.Create(GlobalModel.FileMessage).Close();
                    }
                    using (StreamWriter writer = new StreamWriter(GlobalModel.FileMessage))
                    {
                        // Ghi từng phần tử của danh sách vào tệp tin, mỗi phần tử trên một dòng
                        foreach (string item in GlobalModel.ListUserMessage)
                        {
                            writer.WriteLine(item);
                        }
                    }
                    System.Windows.Forms.Application.ExitThread();
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WriteDataGridViewToFile(saveFileDialog.FileName, dtgvAcc);
            }
        }
        private void WriteDataGridViewToFile(string filePath, DataGridView dataGridView)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string columnHeader = "";
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (!column.Visible || column.Index == 0 || column.Index == 1 || column.Index == dataGridView.Columns.Count - 1 || column.Index == dataGridView.Columns.Count - 2) continue;
                    if (!string.IsNullOrEmpty(columnHeader)) columnHeader += "|";
                    columnHeader += column.HeaderText;
                }
                writer.WriteLine(columnHeader);
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string rowData = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!cell.Visible || cell.ColumnIndex == 0 || cell.ColumnIndex == 1 || cell.ColumnIndex == row.Cells.Count - 1 || cell.ColumnIndex == row.Cells.Count - 2) continue;
                        if (!string.IsNullOrEmpty(rowData)) rowData += "|";
                        rowData += cell.Value != null ? cell.Value.ToString() : "";
                    }
                    writer.WriteLine(rowData);
                }
            }

        }
        private void moveFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void updatingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetListSelect().Count == 0)
            {
                MessageCommon.ShowMessageBox("Please select the device you want to Updating data", 3);
            }
            else
            {
                FormHelper.ShowFormWithoutTaskbar(new fUpdateData(_accountsService));
            }
        }
        private void rtbLog_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt"))
                {
                    if (!File.Exists("Log.txt"))
                    {
                        File.WriteAllBytes("Log.txt", new byte[0]);
                    }

                    writer.Write(rtbLog.Text);
                    writer.Close();
                }
                string notepadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "notepad.exe");
                Process.Start(notepadPath, Path.Combine("Log.txt"));
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }

        public async Task<string> getCodeLogin(string apId, string apHash, string phone, string? addProxy, string fileSession, string id)
        {
            int apIdnum;
            if (int.TryParse(apId, out apIdnum))
            {
                Client client = new Client(apIdnum, apHash, fileSession);
                try
                {

                    if (!string.IsNullOrEmpty(addProxy))
                    {
                        client.TcpHandler = async (address, port) =>
                        {
                            var proxy = xNet.HttpProxyClient.Parse(addProxy);
                            return proxy.CreateConnection(address, port);
                        };
                    }
                    var a = await client.Login(phone);
                    if (string.IsNullOrEmpty(a))
                    {
                        _accountsService.UpdateColumn(new Guid(id), x => x.Info, "Live");
                        DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, id, "cId", "cInfo", "Live", 2);
                        var dialogs = await client.Messages_GetAllDialogs(null);
                        for (int j = 0; j < dialogs.TotalCount; j++)
                        {
                            if (dialogs.Messages[j].Peer.ID == 777000)
                            {
                                var sms = (TL.Message)dialogs.messages[j];
                                string body = sms.message;
                                RichTextBoxHelper.WriteLogRichTextBox($"{phone}: \n     {body}", 2);
                                string[] line = body.Split(':', '.', '\n', '\t', ' ');
                                foreach (var item in line)
                                {
                                    if (item.Length == 11 || item.Length == 5 && !item.Contains("Login"))
                                    {
                                        string code = item;
                                        client.Dispose();
                                        return code;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        _accountsService.UpdateColumn(new Guid(id), x => x.Info, a);
                        DataGridViewHelper.SetCellValueByColumnValue(dtgvAcc, id, "cId", "cInfo", a, 1);
                    }
                    client.Dispose();
                    return null;
                }
                catch (Exception ex)
                {
                    client.Dispose();
                    Log.Error(ex, ex.Message);
                    RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                    return null;
                }
            }
            return null;
        }

        private async void dtgvAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAcc.Columns["cGetCode"].Index)
            {
                DataGridViewHelper.SetCellValue(dtgvAcc, e.RowIndex, "cStatus", $"Running");
                var id = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cId");
                var phone = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cPhone");
                var proxy = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cProxy");
                var fileSession = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cSession");
                var apId = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cAppId");
                var apHash = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cAppHash");
                if (!string.IsNullOrEmpty(phone) && File.Exists(fileSession) && !string.IsNullOrEmpty(apId) && !string.IsNullOrEmpty(apHash))
                {
                    var code = await getCodeLogin(apId, apHash, phone, proxy, fileSession, id);
                    if (!string.IsNullOrEmpty(code))
                    {
                        DataGridViewHelper.SetCellValue(dtgvAcc, e.RowIndex, "cStatus", $"Code Login: {code}", 2);
                    }
                    else
                    {
                        MessageCommon.ShowMessageBox("No sms", 1);
                    }
                }
                else
                {
                    MessageCommon.ShowMessageBox("Missing Data", 3);
                }

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAcc.Columns["cLogin"].Index)
            {
                _fLoading.StartLoading();
                var id = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cId");
                fCreaterSession fCreater = new fCreaterSession(id, _accountsService);
                _fLoading.StopLoading();
                fCreater.ShowDialog();
                GetDataAccounts(search);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAcc.Columns["cChrome"].Index)
            {
                var id = DataGridViewHelper.GetCellValue(dtgvAcc, e.RowIndex, "cId");
                var accountService = _serviceProvider.GetService<IAccountsService>();
                var account = accountService.GetAccountById(id);
                if (account != null)
                {
                    _fLoading.StartLoading();
                    try
                    {
                        try
                        {
                            string addProxy = account.Proxy;
                            if (!string.IsNullOrEmpty(account.Session) && File.Exists(account.Session) && !string.IsNullOrEmpty(account.AppId))
                            {
                                if (string.IsNullOrEmpty(account.UserAgent) && string.IsNullOrEmpty(account.Cookie))
                                {
                                    if (int.TryParse(account.AppId, out int apIdnum))
                                    {
                                        Client client = new Client(apIdnum, account.AppHash, account.Session);
                                        try
                                        {
                                            if (!string.IsNullOrEmpty(addProxy))
                                            {
                                                client.TcpHandler = async (address, port) =>
                                                {
                                                    var proxy = xNet.HttpProxyClient.Parse(addProxy);
                                                    return proxy.CreateConnection(address, port);
                                                };
                                            }
                                            var a = await client.Login(account.PhoneNumber);
                                            if (string.IsNullOrEmpty(a))
                                            {
                                                var userAgent = FileHelper.GetUserAgents();
                                                var chrome = ChromeDriverServiceHelper.NewChrome("https://web.telegram.org/a/", account.Proxy, userAgent, true);
                                                if (chrome != null)
                                                {
                                                    var login = await ChromeDriverServiceHelper.LoginTelegramWebClient(chrome, client, account.PhoneNumber, account.Password);
                                                    if (!string.IsNullOrEmpty(login))
                                                    {
                                                        AccountsModel model = new AccountsModel();
                                                        model.UserAgent = userAgent;
                                                        model.Cookie = login;
                                                        accountService.UpdateCookies(new Guid(account.IdAccount), model);
                                                        _fLoading.StopLoading();
                                                    }
                                                    else
                                                    {
                                                        _fLoading.StopLoading();
                                                        MessageCommon.ShowMessageBox("ERROR LOGIN!", 3);
                                                    }

                                                }
                                            }
                                            else
                                            {
                                                _fLoading.StopLoading();
                                                MessageCommon.ShowMessageBox(a);
                                                return;
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            _fLoading.StopLoading();
                                        }
                                        _fLoading.StopLoading();
                                    }
                                }
                                else if (!string.IsNullOrEmpty(account.UserAgent) && !string.IsNullOrEmpty(account.Cookie))
                                {
                                    var chrome = ChromeDriverServiceHelper.NewChrome("https://web.telegram.org/a/", account.Proxy, account.UserAgent, true);
                                    if (chrome != null)
                                    {
                                        await ChromeDriverServiceHelper.RestoreTelegramWebClient(chrome, account.Cookie);
                                        _fLoading.StopLoading();
                                    }

                                }
                            }
                            else
                            {
                                _fLoading.StopLoading();
                                MessageCommon.ShowMessageBox("No login chrome driver!", 2);
                            }
                        }
                        catch (Exception ex)
                        {
                            _fLoading.StopLoading();
                            MessageCommon.ShowMessageBox(ex.Message, 2);
                        }
                    }
                    catch (Exception ex)
                    {
                        _fLoading.StopLoading();
                        MessageCommon.ShowMessageBox(ex.Message, 2);
                    }
                    _fLoading.StopLoading();
                }

            }
        }

        private void btnEnterFile_Click(object sender, EventArgs e)
        {
            fImportProxy fProxy = new fImportProxy(null, list_proxy);
            FormHelper.ShowFormWithoutTaskbar(fProxy);
            list_proxy = fProxy._lstProxy;
            rbRandom = fProxy.rbRandom.Checked;
            nudAccountProxy = (int)fProxy.nudAccountProxy.Value;
            string pathProxy = Path.Combine(Environment.CurrentDirectory, "Database\\Proxy\\Proxy.txt");
            using (StreamWriter writer = new StreamWriter(pathProxy))
            {
                if (!File.Exists(pathProxy))
                {
                    File.WriteAllBytes(pathProxy, new byte[0]);
                }
                foreach (var line in list_proxy)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private async void btn_Setup_Click(object sender, EventArgs e)
        {

        }


        private void rtbLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (GetListSelect().Count > 0)
                {
                    var _updateAccounts = new fUpdateData(_accountsService);
                    FormHelper.ShowFormWithoutTaskbar(_updateAccounts);
                    GetDataAccounts(search);
                }
                else
                {
                    MessageCommon.ShowMessageBox("Please select your account to update", 3);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                RichTextBoxHelper.WriteLogRichTextBox(ex.Message, 1);
                Log.Error(ex, ex.Message);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

        }



        private void gpViewMethod_Enter(object sender, EventArgs e)
        {

        }

        private void ckbRepeatAfter_CheckedChanged(object sender, EventArgs e)
        {
            plRepeat.Enabled = ckbRepeatAfter.Checked;
        }

        private void fUpdateBio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fAddSubscribersByPhone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateChannels_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fCreateChannels(actionsService, IdScript));

        }

        private void btnSubscribersChannels_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fSubscribersChannels(actionsService, IdScript));
        }

        private void btnCreateGroups_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fCreateGroups(actionsService, IdScript));
        }

        private void btnAddNembersByUsername_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fAddNembersByUsername(actionsService, IdScript));
        }

        private void btnSendMessagesToGroups_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fSendMessagesToGroups(actionsService, IdScript));
        }

        private void cb_fSendMessagesToGroups_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteChannels_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fLeaveChannels(actionsService, IdScript));
        }

        private void btnGetNembersInGroups_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fGetNembersInGroups(actionsService, IdScript));
        }


        private void btnJoinGroups_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fJoinGroups(actionsService, IdScript));
        }

        private void btnSendPrivateMessagesToEveryoneInTheGroups_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fSendPrivateMessages(actionsService, IdScript));

        }

        private void btnLeaveGroups_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fLeaveGroups(actionsService, IdScript));

        }

        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fUpdateAvatar(actionsService, IdScript));

        }

        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fUpdateUsername(actionsService, IdScript));

        }

        private void btnUpdateFullname_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fUpdateFullname(actionsService, IdScript));

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fUpdatePassword(actionsService, IdScript));
        }

        private void btnSendMessagesByUsername_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fSendMessages(actionsService, IdScript));

        }

        private void btnBlockByUsername_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fBlockByUsername(actionsService, IdScript));

        }

        private void btnAddToContact_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fAddToContact(actionsService, IdScript));

        }

        private void btnMessageAllContact_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fMessageAllContact(actionsService, IdScript));

        }

        private void btnUpdateBIOS_Click(object sender, EventArgs e)
        {
            var actionsService = _actionsService();
            FormHelper.ShowFormWithoutTaskbar(new fUpdateBio(actionsService, IdScript));
        }

        private void btn_clearUM_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalModel.FileMessage))
            {
                File.WriteAllBytes(GlobalModel.FileMessage, new byte[0]);
            }
            GlobalModel.ListUserMessage.Clear();
            MessageCommon.ShowMessageBox("Clear Done!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDuplicateUsersMessage();
        }
        public static void ShowDuplicateUsersMessage()
        {
            string title = "Check for duplicate users";
            string message = "Active features using the user duplication check are:\n" +
                             "- Send Messages to Groups\n" +
                             "- Send Message to Group Members\n" +
                             "- Send Messages By Usernames\n" +
                             "- Add Contacts (Send Message)\n" +
                             "- Send Messages To Contacts\n" +
                             "User duplication check feature ensures that messaging actions are not duplicated for users who have been previously followed or messaged.";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

