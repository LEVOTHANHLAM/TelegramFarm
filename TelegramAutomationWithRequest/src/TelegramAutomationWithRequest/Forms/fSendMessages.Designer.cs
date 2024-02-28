namespace TelegramAutomationWithRequest.Forms
{
    partial class fSendMessages
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
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            btnCancel = new Button();
            btnAdd = new Button();
            label21 = new Label();
            label16 = new Label();
            nudDelayTo = new NumericUpDown();
            nudDelayFrom = new NumericUpDown();
            label2 = new Label();
            txtListGroups = new RichTextBox();
            lbListUser = new Label();
            label1 = new Label();
            label4 = new Label();
            nudCountTo = new NumericUpDown();
            nudCountFrom = new NumericUpDown();
            groupBox1 = new GroupBox();
            pInvite = new Panel();
            groupBox3 = new GroupBox();
            ckbImage = new CheckBox();
            panel2 = new Panel();
            label13 = new Label();
            nudImageCountTo = new NumericUpDown();
            label12 = new Label();
            txtFolderImage = new TextBox();
            label15 = new Label();
            nudImageCountFrom = new NumericUpDown();
            label9 = new Label();
            label11 = new Label();
            nudDelayInviteTo = new NumericUpDown();
            nudDelayInviteFrom = new NumericUpDown();
            label6 = new Label();
            groupBox2 = new GroupBox();
            ckbCommentContent = new CheckBox();
            label5 = new Label();
            txtListComment = new RichTextBox();
            nudInviteTo = new NumericUpDown();
            nudInviteFrom = new NumericUpDown();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCountTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCountFrom).BeginInit();
            groupBox1.SuspendLayout();
            pInvite.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudImageCountTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudImageCountFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteFrom).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInviteTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInviteFrom).BeginInit();
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
            panel1.Controls.Add(bunifuCustomLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 38);
            panel1.TabIndex = 0;
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
            bunifuCustomLabel1.Size = new Size(835, 38);
            bunifuCustomLabel1.TabIndex = 14;
            bunifuCustomLabel1.Text = "Send Messages";
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
            btnCancel.Location = new Point(426, 533);
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
            btnAdd.Location = new Point(300, 533);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(59, 57);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(120, 15);
            label21.TabIndex = 198;
            label21.Text = "Delay time (seconds):";
            // 
            // label16
            // 
            label16.Location = new Point(290, 57);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 18);
            label16.TabIndex = 200;
            label16.Text = "to";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDelayTo
            // 
            nudDelayTo.Location = new Point(332, 55);
            nudDelayTo.Margin = new Padding(4, 3, 4, 3);
            nudDelayTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayTo.Name = "nudDelayTo";
            nudDelayTo.Size = new Size(65, 23);
            nudDelayTo.TabIndex = 197;
            // 
            // nudDelayFrom
            // 
            nudDelayFrom.Location = new Point(217, 55);
            nudDelayFrom.Margin = new Padding(4, 3, 4, 3);
            nudDelayFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayFrom.Name = "nudDelayFrom";
            nudDelayFrom.Size = new Size(65, 23);
            nudDelayFrom.TabIndex = 196;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 229);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 245;
            label2.Text = "(Each content on a separate line)";
            // 
            // txtListGroups
            // 
            txtListGroups.Location = new Point(55, 144);
            txtListGroups.Margin = new Padding(4, 3, 4, 3);
            txtListGroups.Name = "txtListGroups";
            txtListGroups.Size = new Size(736, 82);
            txtListGroups.TabIndex = 244;
            txtListGroups.Text = "";
            txtListGroups.WordWrap = false;
            txtListGroups.TextChanged += txtListUser_TextChanged;
            // 
            // lbListUser
            // 
            lbListUser.AutoSize = true;
            lbListUser.Location = new Point(55, 119);
            lbListUser.Margin = new Padding(4, 0, 4, 0);
            lbListUser.Name = "lbListUser";
            lbListUser.Size = new Size(168, 15);
            lbListUser.TabIndex = 243;
            lbListUser.Text = "List of Member Usernames (0):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 248;
            label1.Text = "Number of Members:";
            // 
            // label4
            // 
            label4.Location = new Point(290, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 250;
            label4.Text = "to";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCountTo
            // 
            nudCountTo.Location = new Point(332, 85);
            nudCountTo.Margin = new Padding(4, 3, 4, 3);
            nudCountTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCountTo.Name = "nudCountTo";
            nudCountTo.Size = new Size(65, 23);
            nudCountTo.TabIndex = 247;
            // 
            // nudCountFrom
            // 
            nudCountFrom.Location = new Point(217, 85);
            nudCountFrom.Margin = new Padding(4, 3, 4, 3);
            nudCountFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCountFrom.Name = "nudCountFrom";
            nudCountFrom.Size = new Size(65, 23);
            nudCountFrom.TabIndex = 246;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pInvite);
            groupBox1.Location = new Point(53, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 270);
            groupBox1.TabIndex = 251;
            groupBox1.TabStop = false;
            // 
            // pInvite
            // 
            pInvite.Controls.Add(groupBox3);
            pInvite.Controls.Add(label9);
            pInvite.Controls.Add(label11);
            pInvite.Controls.Add(nudDelayInviteTo);
            pInvite.Controls.Add(nudDelayInviteFrom);
            pInvite.Controls.Add(label6);
            pInvite.Controls.Add(groupBox2);
            pInvite.Controls.Add(nudInviteTo);
            pInvite.Controls.Add(nudInviteFrom);
            pInvite.Controls.Add(label8);
            pInvite.Dock = DockStyle.Fill;
            pInvite.Location = new Point(3, 19);
            pInvite.Name = "pInvite";
            pInvite.Size = new Size(741, 248);
            pInvite.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckbImage);
            groupBox3.Controls.Add(panel2);
            groupBox3.Location = new Point(374, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 114);
            groupBox3.TabIndex = 252;
            groupBox3.TabStop = false;
            groupBox3.Text = "                                             ";
            // 
            // ckbImage
            // 
            ckbImage.AutoSize = true;
            ckbImage.Location = new Point(15, -2);
            ckbImage.Name = "ckbImage";
            ckbImage.Size = new Size(97, 19);
            ckbImage.TabIndex = 0;
            ckbImage.Text = "Attach Media";
            ckbImage.UseVisualStyleBackColor = true;
            ckbImage.CheckedChanged += ckbImage_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(nudImageCountTo);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtFolderImage);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(nudImageCountFrom);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 92);
            panel2.TabIndex = 253;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 18);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(139, 15);
            label13.TabIndex = 265;
            label13.Text = "Number of Attachments:";
            // 
            // nudImageCountTo
            // 
            nudImageCountTo.Location = new Point(275, 16);
            nudImageCountTo.Margin = new Padding(4, 3, 4, 3);
            nudImageCountTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudImageCountTo.Name = "nudImageCountTo";
            nudImageCountTo.Size = new Size(65, 23);
            nudImageCountTo.TabIndex = 264;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 55);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 1;
            label12.Text = "Folder:";
            // 
            // txtFolderImage
            // 
            txtFolderImage.Location = new Point(88, 50);
            txtFolderImage.Name = "txtFolderImage";
            txtFolderImage.Size = new Size(233, 23);
            txtFolderImage.TabIndex = 2;
            // 
            // label15
            // 
            label15.Location = new Point(233, 18);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(34, 18);
            label15.TabIndex = 267;
            label15.Text = "to";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudImageCountFrom
            // 
            nudImageCountFrom.Location = new Point(160, 16);
            nudImageCountFrom.Margin = new Padding(4, 3, 4, 3);
            nudImageCountFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudImageCountFrom.Name = "nudImageCountFrom";
            nudImageCountFrom.Size = new Size(65, 23);
            nudImageCountFrom.TabIndex = 263;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 260;
            label9.Text = "Delay time (seconds):";
            // 
            // label11
            // 
            label11.Location = new Point(234, 45);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 18);
            label11.TabIndex = 262;
            label11.Text = "to";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDelayInviteTo
            // 
            nudDelayInviteTo.Location = new Point(276, 43);
            nudDelayInviteTo.Margin = new Padding(4, 3, 4, 3);
            nudDelayInviteTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayInviteTo.Name = "nudDelayInviteTo";
            nudDelayInviteTo.Size = new Size(65, 23);
            nudDelayInviteTo.TabIndex = 259;
            // 
            // nudDelayInviteFrom
            // 
            nudDelayInviteFrom.Location = new Point(161, 43);
            nudDelayInviteFrom.Margin = new Padding(4, 3, 4, 3);
            nudDelayInviteFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayInviteFrom.Name = "nudDelayInviteFrom";
            nudDelayInviteFrom.Size = new Size(65, 23);
            nudDelayInviteFrom.TabIndex = 258;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 255;
            label6.Text = "Number of Messages:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckbCommentContent);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtListComment);
            groupBox2.Location = new Point(6, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 173);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // ckbCommentContent
            // 
            ckbCommentContent.AutoSize = true;
            ckbCommentContent.Location = new Point(15, 0);
            ckbCommentContent.Name = "ckbCommentContent";
            ckbCommentContent.Size = new Size(118, 19);
            ckbCommentContent.TabIndex = 263;
            ckbCommentContent.Text = "Message Content";
            ckbCommentContent.UseVisualStyleBackColor = true;
            ckbCommentContent.CheckedChanged += ckbCommentContent_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(3, 155);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(283, 15);
            label5.TabIndex = 252;
            label5.Text = "Each content on a separate line with Spintax support";
            // 
            // txtListComment
            // 
            txtListComment.Location = new Point(6, 22);
            txtListComment.Name = "txtListComment";
            txtListComment.Size = new Size(335, 130);
            txtListComment.TabIndex = 0;
            txtListComment.Text = "";
            // 
            // nudInviteTo
            // 
            nudInviteTo.Location = new Point(276, 7);
            nudInviteTo.Margin = new Padding(4, 3, 4, 3);
            nudInviteTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudInviteTo.Name = "nudInviteTo";
            nudInviteTo.Size = new Size(65, 23);
            nudInviteTo.TabIndex = 254;
            // 
            // nudInviteFrom
            // 
            nudInviteFrom.Location = new Point(161, 7);
            nudInviteFrom.Margin = new Padding(4, 3, 4, 3);
            nudInviteFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudInviteFrom.Name = "nudInviteFrom";
            nudInviteFrom.Size = new Size(65, 23);
            nudInviteFrom.TabIndex = 253;
            // 
            // label8
            // 
            label8.Location = new Point(234, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 18);
            label8.TabIndex = 257;
            label8.Text = "to";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fSendMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 590);
            Controls.Add(groupBox1);
            Controls.Add(txtListGroups);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(nudCountTo);
            Controls.Add(nudCountFrom);
            Controls.Add(label2);
            Controls.Add(lbListUser);
            Controls.Add(label21);
            Controls.Add(label16);
            Controls.Add(nudDelayTo);
            Controls.Add(nudDelayFrom);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fSendMessages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreateChannels";
            Load += fCreateChannels_load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCountTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCountFrom).EndInit();
            groupBox1.ResumeLayout(false);
            pInvite.ResumeLayout(false);
            pInvite.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudImageCountTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudImageCountFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteFrom).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInviteTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInviteFrom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Button btnCancel;
        private Button btnAdd;
        private Label lblStatus;
        private Panel pInvite;
        private RichTextBox txtListComment;
        private Label label21;
        private Label label16;
        private NumericUpDown nudDelayTo;
        private NumericUpDown nudDelayFrom;
        private Label label2;
        private RichTextBox txtListGroups;
        private Label lbListUser;
        private Label label1;
        private Label label4;
        private NumericUpDown nudCountTo;
        private NumericUpDown nudCountFrom;
        private GroupBox groupBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private Label label8;
        private NumericUpDown nudInviteTo;
        private NumericUpDown nudInviteFrom;
        private Label label9;
        private Label label11;
        private NumericUpDown nudDelayInviteTo;
        private NumericUpDown nudDelayInviteFrom;
        private GroupBox groupBox3;
        private TextBox txtFolderImage;
        private Label label12;
        private CheckBox ckbImage;
        private Label label13;
        private Label label15;
        private NumericUpDown nudImageCountTo;
        private NumericUpDown nudImageCountFrom;
        private Panel panel2;
        private CheckBox ckbCommentContent;
    }
}