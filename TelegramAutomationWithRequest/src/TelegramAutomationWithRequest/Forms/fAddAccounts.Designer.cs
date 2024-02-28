using TelegramAutomationWithRequest.Helper;

namespace TelegramAutomationWithRequest.Forms
{
    partial class fAddAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            panel1 = new Panel();
            button2 = new Button();
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            txbAccount = new RichTextBox();
            btnAddFolder = new Button();
            cbbFolder = new ComboBox();
            cbbInputFormat = new ComboBox();
            label16 = new Label();
            label8 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            label1 = new Label();
            lblSuccess = new Label();
            label3 = new Label();
            lblError = new Label();
            lblTotal = new Label();
            label6 = new Label();
            lblStatus = new Label();
            plFormatInput = new Panel();
            btnResetFormat = new Button();
            SaveFormat = new Button();
            cbbFormat1 = new ComboBox();
            cbbFormat2 = new ComboBox();
            cbbFormat3 = new ComboBox();
            cbbFormat4 = new ComboBox();
            BBA5A390 = new Label();
            cbbFormat5 = new ComboBox();
            label17 = new Label();
            cbbFormat8 = new ComboBox();
            DC9393BB = new Label();
            cbbFormat6 = new ComboBox();
            label12 = new Label();
            cbbFormat7 = new ComboBox();
            EEB71809 = new Label();
            DE01B417 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            plFormatInput.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(bunifuCustomLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 44);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.CornflowerBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(1094, 0);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(40, 44);
            button2.TabIndex = 78;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bunifuCustomLabel1
            // 
            bunifuCustomLabel1.BackColor = Color.CornflowerBlue;
            bunifuCustomLabel1.Cursor = Cursors.SizeAll;
            bunifuCustomLabel1.Dock = DockStyle.Fill;
            bunifuCustomLabel1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuCustomLabel1.ForeColor = Color.Transparent;
            bunifuCustomLabel1.Location = new Point(0, 0);
            bunifuCustomLabel1.Margin = new Padding(4, 0, 4, 0);
            bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            bunifuCustomLabel1.Size = new Size(1134, 44);
            bunifuCustomLabel1.TabIndex = 14;
            bunifuCustomLabel1.Text = "Add Accounts";
            bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbAccount
            // 
            txbAccount.Location = new Point(67, 97);
            txbAccount.Margin = new Padding(4, 3, 4, 3);
            txbAccount.Name = "txbAccount";
            txbAccount.Size = new Size(1016, 321);
            txbAccount.TabIndex = 50;
            txbAccount.Text = "";
            txbAccount.WordWrap = false;
            txbAccount.TextChanged += txbAccount_TextChanged;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Cursor = Cursors.Hand;
            btnAddFolder.Location = new Point(433, 428);
            btnAddFolder.Margin = new Padding(4, 3, 4, 3);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(79, 29);
            btnAddFolder.TabIndex = 55;
            btnAddFolder.Text = "Add";
            btnAddFolder.UseVisualStyleBackColor = true;
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // cbbFolder
            // 
            cbbFolder.Cursor = Cursors.Hand;
            cbbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFolder.DropDownWidth = 234;
            cbbFolder.FormattingEnabled = true;
            cbbFolder.Location = new Point(184, 432);
            cbbFolder.Margin = new Padding(4, 3, 4, 3);
            cbbFolder.Name = "cbbFolder";
            cbbFolder.Size = new Size(241, 23);
            cbbFolder.TabIndex = 53;
            // 
            // cbbInputFormat
            // 
            cbbInputFormat.Cursor = Cursors.Hand;
            cbbInputFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbInputFormat.FormattingEnabled = true;
            cbbInputFormat.Location = new Point(184, 465);
            cbbInputFormat.Margin = new Padding(4, 3, 4, 3);
            cbbInputFormat.Name = "cbbInputFormat";
            cbbInputFormat.Size = new Size(313, 23);
            cbbInputFormat.TabIndex = 54;
            cbbInputFormat.SelectedValueChanged += cbbInputFormat_SelectedValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(63, 435);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 51;
            label16.Text = "Select a folder:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 469);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 52;
            label8.Text = "Input format:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(582, 595);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 36);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.BackColor = Color.Green;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(432, 595);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 36);
            btnAdd.TabIndex = 56;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 58;
            label1.Text = "Success:";
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.ForeColor = Color.FromArgb(0, 192, 0);
            lblSuccess.Location = new Point(118, 62);
            lblSuccess.Margin = new Padding(4, 0, 4, 0);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(13, 15);
            lblSuccess.TabIndex = 59;
            lblSuccess.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 60;
            label3.Text = "Error:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(184, 62);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(13, 15);
            lblError.TabIndex = 61;
            lblError.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(0, 192, 192);
            lblTotal.Location = new Point(254, 62);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 63;
            lblTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 62);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 62;
            label6.Text = "Total:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(285, 62);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 64;
            // 
            // plFormatInput
            // 
            plFormatInput.BorderStyle = BorderStyle.FixedSingle;
            plFormatInput.Controls.Add(btnResetFormat);
            plFormatInput.Controls.Add(SaveFormat);
            plFormatInput.Controls.Add(cbbFormat1);
            plFormatInput.Controls.Add(cbbFormat2);
            plFormatInput.Controls.Add(cbbFormat3);
            plFormatInput.Controls.Add(cbbFormat4);
            plFormatInput.Controls.Add(BBA5A390);
            plFormatInput.Controls.Add(cbbFormat5);
            plFormatInput.Controls.Add(label17);
            plFormatInput.Controls.Add(cbbFormat8);
            plFormatInput.Controls.Add(DC9393BB);
            plFormatInput.Controls.Add(cbbFormat6);
            plFormatInput.Controls.Add(label12);
            plFormatInput.Controls.Add(cbbFormat7);
            plFormatInput.Controls.Add(EEB71809);
            plFormatInput.Controls.Add(DE01B417);
            plFormatInput.Controls.Add(label10);
            plFormatInput.Location = new Point(67, 494);
            plFormatInput.Name = "plFormatInput";
            plFormatInput.Size = new Size(1016, 75);
            plFormatInput.TabIndex = 65;
            plFormatInput.Visible = false;
            // 
            // btnResetFormat
            // 
            btnResetFormat.AccessibleDescription = "";
            btnResetFormat.Anchor = AnchorStyles.Bottom;
            btnResetFormat.BackColor = Color.DarkOrange;
            btnResetFormat.Cursor = Cursors.Hand;
            btnResetFormat.FlatAppearance.BorderSize = 0;
            btnResetFormat.FlatStyle = FlatStyle.Flat;
            btnResetFormat.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetFormat.ForeColor = Color.White;
            btnResetFormat.Location = new Point(375, 41);
            btnResetFormat.Name = "btnResetFormat";
            btnResetFormat.Size = new Size(121, 29);
            btnResetFormat.TabIndex = 43;
            btnResetFormat.Text = "Reset Format";
            btnResetFormat.UseVisualStyleBackColor = false;
            btnResetFormat.Click += btnResetFormat_Click;
            // 
            // SaveFormat
            // 
            SaveFormat.Anchor = AnchorStyles.Bottom;
            SaveFormat.BackColor = Color.FromArgb(53, 120, 229);
            SaveFormat.Cursor = Cursors.Hand;
            SaveFormat.FlatAppearance.BorderSize = 0;
            SaveFormat.FlatStyle = FlatStyle.Flat;
            SaveFormat.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SaveFormat.ForeColor = Color.White;
            SaveFormat.Location = new Point(519, 41);
            SaveFormat.Name = "SaveFormat";
            SaveFormat.Size = new Size(120, 29);
            SaveFormat.TabIndex = 42;
            SaveFormat.Text = "Save Format";
            SaveFormat.UseVisualStyleBackColor = false;
            SaveFormat.Click += SaveFormat_Click;
            // 
            // cbbFormat1
            // 
            cbbFormat1.Cursor = Cursors.Hand;
            cbbFormat1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat1.DropDownWidth = 100;
            cbbFormat1.FormattingEnabled = true;
            cbbFormat1.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat1.Location = new Point(3, 3);
            cbbFormat1.Name = "cbbFormat1";
            cbbFormat1.Size = new Size(78, 23);
            cbbFormat1.TabIndex = 40;
            // 
            // cbbFormat2
            // 
            cbbFormat2.Cursor = Cursors.Hand;
            cbbFormat2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat2.DropDownWidth = 100;
            cbbFormat2.FormattingEnabled = true;
            cbbFormat2.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat2.Location = new Point(96, 3);
            cbbFormat2.Name = "cbbFormat2";
            cbbFormat2.Size = new Size(78, 23);
            cbbFormat2.TabIndex = 40;
            // 
            // cbbFormat3
            // 
            cbbFormat3.Cursor = Cursors.Hand;
            cbbFormat3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat3.DropDownWidth = 100;
            cbbFormat3.FormattingEnabled = true;
            cbbFormat3.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat3.Location = new Point(189, 3);
            cbbFormat3.Name = "cbbFormat3";
            cbbFormat3.Size = new Size(78, 23);
            cbbFormat3.TabIndex = 40;
            // 
            // cbbFormat4
            // 
            cbbFormat4.Cursor = Cursors.Hand;
            cbbFormat4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat4.DropDownWidth = 100;
            cbbFormat4.FormattingEnabled = true;
            cbbFormat4.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat4.Location = new Point(282, 3);
            cbbFormat4.Name = "cbbFormat4";
            cbbFormat4.Size = new Size(78, 23);
            cbbFormat4.TabIndex = 40;
            // 
            // BBA5A390
            // 
            BBA5A390.AutoSize = true;
            BBA5A390.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BBA5A390.Location = new Point(546, 3);
            BBA5A390.Name = "BBA5A390";
            BBA5A390.Size = new Size(15, 19);
            BBA5A390.TabIndex = 41;
            BBA5A390.Text = "|";
            // 
            // cbbFormat5
            // 
            cbbFormat5.Cursor = Cursors.Hand;
            cbbFormat5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat5.DropDownWidth = 100;
            cbbFormat5.FormattingEnabled = true;
            cbbFormat5.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat5.Location = new Point(375, 3);
            cbbFormat5.Name = "cbbFormat5";
            cbbFormat5.Size = new Size(78, 23);
            cbbFormat5.TabIndex = 40;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(639, 3);
            label17.Name = "label17";
            label17.Size = new Size(15, 19);
            label17.TabIndex = 41;
            label17.Text = "|";
            // 
            // cbbFormat8
            // 
            cbbFormat8.Cursor = Cursors.Hand;
            cbbFormat8.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat8.DropDownWidth = 100;
            cbbFormat8.FormattingEnabled = true;
            cbbFormat8.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat8.Location = new Point(654, 3);
            cbbFormat8.Name = "cbbFormat8";
            cbbFormat8.Size = new Size(78, 23);
            cbbFormat8.TabIndex = 40;
            // 
            // DC9393BB
            // 
            DC9393BB.AutoSize = true;
            DC9393BB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DC9393BB.Location = new Point(453, 3);
            DC9393BB.Name = "DC9393BB";
            DC9393BB.Size = new Size(15, 19);
            DC9393BB.TabIndex = 41;
            DC9393BB.Text = "|";
            // 
            // cbbFormat6
            // 
            cbbFormat6.Cursor = Cursors.Hand;
            cbbFormat6.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat6.DropDownWidth = 100;
            cbbFormat6.FormattingEnabled = true;
            cbbFormat6.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat6.Location = new Point(468, 3);
            cbbFormat6.Name = "cbbFormat6";
            cbbFormat6.Size = new Size(78, 23);
            cbbFormat6.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(360, 3);
            label12.Name = "label12";
            label12.Size = new Size(15, 19);
            label12.TabIndex = 41;
            label12.Text = "|";
            // 
            // cbbFormat7
            // 
            cbbFormat7.Cursor = Cursors.Hand;
            cbbFormat7.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormat7.DropDownWidth = 100;
            cbbFormat7.FormattingEnabled = true;
            cbbFormat7.Items.AddRange(new object[] { "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday", "DateCreate", "MailRecovery" });
            cbbFormat7.Location = new Point(561, 3);
            cbbFormat7.Name = "cbbFormat7";
            cbbFormat7.Size = new Size(78, 23);
            cbbFormat7.TabIndex = 40;
            // 
            // EEB71809
            // 
            EEB71809.AutoSize = true;
            EEB71809.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EEB71809.Location = new Point(267, 3);
            EEB71809.Name = "EEB71809";
            EEB71809.Size = new Size(15, 19);
            EEB71809.TabIndex = 41;
            EEB71809.Text = "|";
            // 
            // DE01B417
            // 
            DE01B417.AutoSize = true;
            DE01B417.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DE01B417.Location = new Point(81, 3);
            DE01B417.Name = "DE01B417";
            DE01B417.Size = new Size(15, 19);
            DE01B417.TabIndex = 41;
            DE01B417.Text = "|";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(174, 3);
            label10.Name = "label10";
            label10.Size = new Size(15, 19);
            label10.TabIndex = 41;
            label10.Text = "|";
            // 
            // fAddAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 658);
            Controls.Add(plFormatInput);
            Controls.Add(lblStatus);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(lblError);
            Controls.Add(label3);
            Controls.Add(lblSuccess);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(btnAddFolder);
            Controls.Add(cbbFolder);
            Controls.Add(cbbInputFormat);
            Controls.Add(label16);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(txbAccount);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fAddAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddAccounts";
            Load += fAddAccounts_Load;
            Controls.SetChildIndex(txbAccount, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(cbbInputFormat, 0);
            Controls.SetChildIndex(cbbFolder, 0);
            Controls.SetChildIndex(btnAddFolder, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lblSuccess, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(lblError, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(lblTotal, 0);
            Controls.SetChildIndex(lblStatus, 0);
            Controls.SetChildIndex(plFormatInput, 0);
            panel1.ResumeLayout(false);
            plFormatInput.ResumeLayout(false);
            plFormatInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Panel panel1;
        private RichTextBox txbAccount;
        private Button btnAddFolder;
        private ComboBox cbbFolder;
        private ComboBox cbbInputFormat;
        private Label label16;
        private Label label8;
        private Button btnCancel;
        private Button btnAdd;
        private Button button2;
        private Label label1;
        private Label lblSuccess;
        private Label label3;
        private Label lblError;
        private Label lblTotal;
        private Label label6;
        private Label lblStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        internal Panel plFormatInput;
        internal Button btnResetFormat;
        internal Button button3;
        internal ComboBox cbbFormat1;
        internal ComboBox cbbFormat2;
        internal ComboBox cbbFormat3;
        internal ComboBox cbbFormat4;
        internal Label BBA5A390;
        internal ComboBox cbbFormat5;
        internal Label label17;
        internal ComboBox cbbFormat8;
        internal Label DC9393BB;
        internal ComboBox cbbFormat6;
        internal Label label12;
        internal ComboBox cbbFormat7;
        internal Label EEB71809;
        internal Label DE01B417;
        internal Label label10;
        internal Button SaveFormat;
    }
}