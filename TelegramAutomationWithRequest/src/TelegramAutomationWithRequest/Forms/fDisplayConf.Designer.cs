﻿namespace TelegramAutomationWithRequest.Forms
{
    partial class fDisplayConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDisplayConf));
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            panel1 = new Panel();
            button1 = new Button();
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            btnCancel = new Button();
            btnAdd = new Button();
            ckbFolder = new CheckBox();
            ckbInteractEnd = new CheckBox();
            ckbStatus = new CheckBox();
            ckbApId = new CheckBox();
            ckbCookie = new CheckBox();
            ckbFullname = new CheckBox();
            ckbSession = new CheckBox();
            ckbUsername = new CheckBox();
            ckbApHash = new CheckBox();
            ckbAccountStatus = new CheckBox();
            DB37CC26 = new Bunifu.Framework.UI.BunifuCustomLabel();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(bunifuCustomLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 38);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(320, 1);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 78;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            bunifuCustomLabel1.Size = new Size(355, 38);
            bunifuCustomLabel1.TabIndex = 15;
            bunifuCustomLabel1.Text = "Display configuration";
            bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnCancel.Location = new Point(191, 230);
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
            btnAdd.Location = new Point(39, 230);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ckbFolder
            // 
            ckbFolder.AutoSize = true;
            ckbFolder.Cursor = Cursors.Hand;
            ckbFolder.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbFolder.Location = new Point(191, 189);
            ckbFolder.Name = "ckbFolder";
            ckbFolder.Size = new Size(62, 20);
            ckbFolder.TabIndex = 190;
            ckbFolder.Text = "Folder";
            ckbFolder.UseVisualStyleBackColor = true;
            // 
            // ckbInteractEnd
            // 
            ckbInteractEnd.AutoSize = true;
            ckbInteractEnd.Cursor = Cursors.Hand;
            ckbInteractEnd.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbInteractEnd.Location = new Point(191, 111);
            ckbInteractEnd.Name = "ckbInteractEnd";
            ckbInteractEnd.Size = new Size(113, 20);
            ckbInteractEnd.TabIndex = 210;
            ckbInteractEnd.Text = "Last interaction";
            ckbInteractEnd.UseVisualStyleBackColor = true;
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Cursor = Cursors.Hand;
            ckbStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbStatus.Location = new Point(191, 163);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(62, 20);
            ckbStatus.TabIndex = 209;
            ckbStatus.Text = "Status";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // ckbApId
            // 
            ckbApId.AutoSize = true;
            ckbApId.Cursor = Cursors.Hand;
            ckbApId.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbApId.Location = new Point(39, 85);
            ckbApId.Name = "ckbApId";
            ckbApId.Size = new Size(59, 20);
            ckbApId.TabIndex = 208;
            ckbApId.Text = "AppId";
            ckbApId.UseVisualStyleBackColor = true;
            // 
            // ckbCookie
            // 
            ckbCookie.AutoSize = true;
            ckbCookie.Cursor = Cursors.Hand;
            ckbCookie.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbCookie.Location = new Point(39, 189);
            ckbCookie.Name = "ckbCookie";
            ckbCookie.Size = new Size(64, 20);
            ckbCookie.TabIndex = 207;
            ckbCookie.Text = "Cookie";
            ckbCookie.UseVisualStyleBackColor = true;
            // 
            // ckbFullname
            // 
            ckbFullname.AutoSize = true;
            ckbFullname.Cursor = Cursors.Hand;
            ckbFullname.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbFullname.Location = new Point(191, 85);
            ckbFullname.Name = "ckbFullname";
            ckbFullname.Size = new Size(78, 20);
            ckbFullname.TabIndex = 206;
            ckbFullname.Text = "Fullname";
            ckbFullname.UseVisualStyleBackColor = true;
            // 
            // ckbSession
            // 
            ckbSession.AutoSize = true;
            ckbSession.Cursor = Cursors.Hand;
            ckbSession.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbSession.Location = new Point(39, 163);
            ckbSession.Name = "ckbSession";
            ckbSession.Size = new Size(70, 20);
            ckbSession.TabIndex = 205;
            ckbSession.Text = "Session";
            ckbSession.UseVisualStyleBackColor = true;
            // 
            // ckbUsername
            // 
            ckbUsername.AutoSize = true;
            ckbUsername.Cursor = Cursors.Hand;
            ckbUsername.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbUsername.Location = new Point(39, 137);
            ckbUsername.Name = "ckbUsername";
            ckbUsername.Size = new Size(84, 20);
            ckbUsername.TabIndex = 202;
            ckbUsername.Text = "Username";
            ckbUsername.UseVisualStyleBackColor = true;
            // 
            // ckbApHash
            // 
            ckbApHash.AutoSize = true;
            ckbApHash.Cursor = Cursors.Hand;
            ckbApHash.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbApHash.Location = new Point(39, 111);
            ckbApHash.Name = "ckbApHash";
            ckbApHash.Size = new Size(80, 20);
            ckbApHash.TabIndex = 193;
            ckbApHash.Text = "App Hash";
            ckbApHash.UseVisualStyleBackColor = true;
            // 
            // ckbAccountStatus
            // 
            ckbAccountStatus.AutoSize = true;
            ckbAccountStatus.Cursor = Cursors.Hand;
            ckbAccountStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ckbAccountStatus.Location = new Point(191, 137);
            ckbAccountStatus.Name = "ckbAccountStatus";
            ckbAccountStatus.Size = new Size(111, 20);
            ckbAccountStatus.TabIndex = 213;
            ckbAccountStatus.Text = "Account Status";
            ckbAccountStatus.UseVisualStyleBackColor = true;
            // 
            // DB37CC26
            // 
            DB37CC26.BackColor = Color.Transparent;
            DB37CC26.Cursor = Cursors.SizeAll;
            DB37CC26.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DB37CC26.ForeColor = Color.Black;
            DB37CC26.Location = new Point(28, 41);
            DB37CC26.Name = "DB37CC26";
            DB37CC26.Size = new Size(306, 32);
            DB37CC26.TabIndex = 214;
            DB37CC26.Text = "Please select the columns to display!";
            DB37CC26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fDisplayConf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 286);
            Controls.Add(DB37CC26);
            Controls.Add(ckbFolder);
            Controls.Add(ckbInteractEnd);
            Controls.Add(ckbStatus);
            Controls.Add(ckbApId);
            Controls.Add(ckbCookie);
            Controls.Add(ckbFullname);
            Controls.Add(ckbSession);
            Controls.Add(ckbUsername);
            Controls.Add(ckbApHash);
            Controls.Add(ckbAccountStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fDisplayConf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddFile";
            Load += fDisplayConf_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Panel panel1;
        private Button btnCancel;
        private Button btnAdd;
        private Button button1;
        private CheckBox ckbXoaAnhDaDung;
        internal CheckBox ckbFolder;
        internal CheckBox ckbInteractEnd;
        internal CheckBox ckbStatus;
        internal CheckBox ckbApId;
        internal CheckBox ckbCookie;
        internal CheckBox ckbFullname;
        internal CheckBox ckbSession;
        internal CheckBox ckbUsername;
        internal CheckBox ckbApHash;
        internal CheckBox ckbAccountStatus;
        internal Bunifu.Framework.UI.BunifuCustomLabel DB37CC26;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}