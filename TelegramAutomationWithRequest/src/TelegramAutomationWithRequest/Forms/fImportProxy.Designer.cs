using TelegramAutomationWithRequest.Helper;

namespace TelegramAutomationWithRequest.Forms
{
    partial class fImportProxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportProxy));
            btnCancel = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            button3 = new Button();
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            button2 = new Button();
            button1 = new Button();
            lblProxy = new Label();
            cbbTypeProxy = new ComboBox();
            F32C6BA9 = new Label();
            label3 = new Label();
            txtProxy = new RichTextBox();
            label8 = new Label();
            plSettingProxy = new Panel();
            rbSequence = new RadioButton();
            rbRandom = new RadioButton();
            ckbNoEnterExistingAccount = new CheckBox();
            nudAccountProxy = new NumericUpDown();
            F5A329B5 = new Label();
            E38C2636 = new Label();
            panel1.SuspendLayout();
            plSettingProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccountProxy).BeginInit();
            SuspendLayout();
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
            btnCancel.Location = new Point(250, 425);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 33);
            btnCancel.TabIndex = 189;
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
            btnAdd.Location = new Point(124, 425);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(bunifuCustomLabel1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 39);
            panel1.TabIndex = 201;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.CornflowerBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(437, 1);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 85;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
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
            bunifuCustomLabel1.Size = new Size(472, 39);
            bunifuCustomLabel1.TabIndex = 84;
            bunifuCustomLabel1.Text = "Import Proxy";
            bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.btnClose;
            button2.Location = new Point(436, 1);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 83;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.btnClose;
            button1.Location = new Point(698, 1);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 81;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblProxy
            // 
            lblProxy.AutoSize = true;
            lblProxy.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProxy.Location = new Point(30, 66);
            lblProxy.Name = "lblProxy";
            lblProxy.Size = new Size(87, 16);
            lblProxy.TabIndex = 203;
            lblProxy.Text = "Proxy List (0):";
            // 
            // cbbTypeProxy
            // 
            cbbTypeProxy.Cursor = Cursors.Hand;
            cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeProxy.Enabled = false;
            cbbTypeProxy.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTypeProxy.FormattingEnabled = true;
            cbbTypeProxy.Items.AddRange(new object[] { "HTTP", "Sock5" });
            cbbTypeProxy.Location = new Point(178, 283);
            cbbTypeProxy.Name = "cbbTypeProxy";
            cbbTypeProxy.Size = new Size(140, 24);
            cbbTypeProxy.TabIndex = 213;
            // 
            // F32C6BA9
            // 
            F32C6BA9.AutoSize = true;
            F32C6BA9.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            F32C6BA9.ForeColor = Color.Red;
            F32C6BA9.Location = new Point(239, 66);
            F32C6BA9.Name = "F32C6BA9";
            F32C6BA9.Size = new Size(204, 13);
            F32C6BA9.TabIndex = 206;
            F32C6BA9.Text = "(Format: IP:PORT, IP:PORT:USER:PASS)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 286);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 207;
            label3.Text = "Proxy Type:";
            // 
            // txtProxy
            // 
            txtProxy.BorderStyle = BorderStyle.FixedSingle;
            txtProxy.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProxy.Location = new Point(34, 85);
            txtProxy.Name = "txtProxy";
            txtProxy.Size = new Size(409, 181);
            txtProxy.TabIndex = 204;
            txtProxy.Text = "";
            txtProxy.WordWrap = false;
            txtProxy.TextChanged += txtProxy_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(331, 271);
            label8.Name = "label8";
            label8.Size = new Size(114, 16);
            label8.TabIndex = 202;
            label8.Text = "(Each proxy 1 line)";
            // 
            // plSettingProxy
            // 
            plSettingProxy.Controls.Add(rbSequence);
            plSettingProxy.Controls.Add(rbRandom);
            plSettingProxy.Controls.Add(ckbNoEnterExistingAccount);
            plSettingProxy.Controls.Add(nudAccountProxy);
            plSettingProxy.Controls.Add(F5A329B5);
            plSettingProxy.Controls.Add(E38C2636);
            plSettingProxy.Location = new Point(30, 313);
            plSettingProxy.Name = "plSettingProxy";
            plSettingProxy.Size = new Size(413, 94);
            plSettingProxy.TabIndex = 214;
            // 
            // rbSequence
            // 
            rbSequence.AutoSize = true;
            rbSequence.Checked = true;
            rbSequence.Cursor = Cursors.Hand;
            rbSequence.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbSequence.Location = new Point(151, 39);
            rbSequence.Name = "rbSequence";
            rbSequence.Size = new Size(81, 20);
            rbSequence.TabIndex = 217;
            rbSequence.TabStop = true;
            rbSequence.Text = "Sequence";
            rbSequence.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            rbRandom.AutoSize = true;
            rbRandom.Cursor = Cursors.Hand;
            rbRandom.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbRandom.Location = new Point(240, 39);
            rbRandom.Name = "rbRandom";
            rbRandom.Size = new Size(72, 20);
            rbRandom.TabIndex = 218;
            rbRandom.Text = "Random";
            rbRandom.UseVisualStyleBackColor = true;
            // 
            // ckbNoEnterExistingAccount
            // 
            ckbNoEnterExistingAccount.AutoSize = true;
            ckbNoEnterExistingAccount.Cursor = Cursors.Hand;
            ckbNoEnterExistingAccount.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbNoEnterExistingAccount.Location = new Point(5, 65);
            ckbNoEnterExistingAccount.Name = "ckbNoEnterExistingAccount";
            ckbNoEnterExistingAccount.Size = new Size(289, 20);
            ckbNoEnterExistingAccount.TabIndex = 216;
            ckbNoEnterExistingAccount.Text = "Do not enter accounts that already have Proxy";
            ckbNoEnterExistingAccount.UseVisualStyleBackColor = true;
            ckbNoEnterExistingAccount.Visible = false;
            // 
            // nudAccountProxy
            // 
            nudAccountProxy.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudAccountProxy.Location = new Point(150, 12);
            nudAccountProxy.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudAccountProxy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAccountProxy.Name = "nudAccountProxy";
            nudAccountProxy.Size = new Size(69, 23);
            nudAccountProxy.TabIndex = 215;
            nudAccountProxy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // F5A329B5
            // 
            F5A329B5.AutoSize = true;
            F5A329B5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            F5A329B5.Location = new Point(2, 41);
            F5A329B5.Name = "F5A329B5";
            F5A329B5.Size = new Size(129, 16);
            F5A329B5.TabIndex = 213;
            F5A329B5.Text = "Proxy import options:";
            // 
            // E38C2636
            // 
            E38C2636.AutoSize = true;
            E38C2636.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            E38C2636.Location = new Point(3, 14);
            E38C2636.Name = "E38C2636";
            E38C2636.Size = new Size(141, 16);
            E38C2636.TabIndex = 214;
            E38C2636.Text = "Account/proxy number:";
            // 
            // fImportProxy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 481);
            Controls.Add(plSettingProxy);
            Controls.Add(lblProxy);
            Controls.Add(cbbTypeProxy);
            Controls.Add(F32C6BA9);
            Controls.Add(label3);
            Controls.Add(txtProxy);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fImportProxy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fReadNotification";
            Load += fAddFriendByKW_Load;
            panel1.ResumeLayout(false);
            plSettingProxy.ResumeLayout(false);
            plSettingProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccountProxy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Button btnCancel;
        private Button btnAdd;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        internal Label lblProxy;
        internal ComboBox cbbTypeProxy;
        internal Label F32C6BA9;
        internal Label label3;
        internal RichTextBox txtProxy;
        internal Label label8;
        private Panel plSettingProxy;
        internal RadioButton rbSequence;
        internal RadioButton rbRandom;
        internal CheckBox ckbNoEnterExistingAccount;
        internal NumericUpDown nudAccountProxy;
        internal Label F5A329B5;
        internal Label E38C2636;
    }
}