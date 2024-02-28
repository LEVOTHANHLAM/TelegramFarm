namespace TelegramAutomationWithRequest.Forms
{
    partial class fCreateChannels
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
            txtListChannels = new RichTextBox();
            lbListUser = new Label();
            label1 = new Label();
            label4 = new Label();
            nudCountTo = new NumericUpDown();
            nudCountFrom = new NumericUpDown();
            groupBox1 = new GroupBox();
            ckbInviteToChannel = new CheckBox();
            pInvite = new Panel();
            label9 = new Label();
            label11 = new Label();
            nudDelayInviteTo = new NumericUpDown();
            nudDelayInviteFrom = new NumericUpDown();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtListUsername = new RichTextBox();
            nudInviteTo = new NumericUpDown();
            nudInviteFrom = new NumericUpDown();
            label8 = new Label();
            groupBox3 = new GroupBox();
            ckbAvtar = new CheckBox();
            panel2 = new Panel();
            label12 = new Label();
            txtFolderImage = new TextBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            ckbBio = new CheckBox();
            label7 = new Label();
            txtBio = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCountTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCountFrom).BeginInit();
            groupBox1.SuspendLayout();
            pInvite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteFrom).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInviteTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInviteFrom).BeginInit();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
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
            bunifuCustomLabel1.Text = "Create Channels";
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
            btnCancel.Location = new Point(426, 474);
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
            btnAdd.Location = new Point(300, 474);
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
            label21.Location = new Point(13, 59);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(120, 15);
            label21.TabIndex = 198;
            label21.Text = "Delay time (seconds):";
            // 
            // label16
            // 
            label16.Location = new Point(247, 57);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 18);
            label16.TabIndex = 200;
            label16.Text = "to";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDelayTo
            // 
            nudDelayTo.Location = new Point(289, 55);
            nudDelayTo.Margin = new Padding(4, 3, 4, 3);
            nudDelayTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayTo.Name = "nudDelayTo";
            nudDelayTo.Size = new Size(65, 23);
            nudDelayTo.TabIndex = 197;
            // 
            // nudDelayFrom
            // 
            nudDelayFrom.Location = new Point(174, 55);
            nudDelayFrom.Margin = new Padding(4, 3, 4, 3);
            nudDelayFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayFrom.Name = "nudDelayFrom";
            nudDelayFrom.Size = new Size(65, 23);
            nudDelayFrom.TabIndex = 196;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 301);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 245;
            label2.Text = "(Each content on a separate line)";
            // 
            // txtListChannels
            // 
            txtListChannels.Location = new Point(59, 144);
            txtListChannels.Margin = new Padding(4, 3, 4, 3);
            txtListChannels.Name = "txtListChannels";
            txtListChannels.Size = new Size(348, 154);
            txtListChannels.TabIndex = 244;
            txtListChannels.Text = "";
            txtListChannels.WordWrap = false;
            txtListChannels.TextChanged += txtListUser_TextChanged;
            // 
            // lbListUser
            // 
            lbListUser.AutoSize = true;
            lbListUser.Location = new Point(55, 122);
            lbListUser.Margin = new Padding(4, 0, 4, 0);
            lbListUser.Name = "lbListUser";
            lbListUser.Size = new Size(146, 15);
            lbListUser.TabIndex = 243;
            lbListUser.Text = "List of Channel Names (0):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 248;
            label1.Text = "Number of Channels:";
            // 
            // label4
            // 
            label4.Location = new Point(247, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 250;
            label4.Text = "to";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCountTo
            // 
            nudCountTo.Location = new Point(289, 85);
            nudCountTo.Margin = new Padding(4, 3, 4, 3);
            nudCountTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCountTo.Name = "nudCountTo";
            nudCountTo.Size = new Size(65, 23);
            nudCountTo.TabIndex = 247;
            // 
            // nudCountFrom
            // 
            nudCountFrom.Location = new Point(174, 85);
            nudCountFrom.Margin = new Padding(4, 3, 4, 3);
            nudCountFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCountFrom.Name = "nudCountFrom";
            nudCountFrom.Size = new Size(65, 23);
            nudCountFrom.TabIndex = 246;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbInviteToChannel);
            groupBox1.Controls.Add(pInvite);
            groupBox1.Location = new Point(425, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 306);
            groupBox1.TabIndex = 251;
            groupBox1.TabStop = false;
            // 
            // ckbInviteToChannel
            // 
            ckbInviteToChannel.AutoSize = true;
            ckbInviteToChannel.Location = new Point(20, -2);
            ckbInviteToChannel.Name = "ckbInviteToChannel";
            ckbInviteToChannel.Size = new Size(163, 19);
            ckbInviteToChannel.TabIndex = 2;
            ckbInviteToChannel.Text = "Add Members To Channel";
            ckbInviteToChannel.UseVisualStyleBackColor = true;
            ckbInviteToChannel.CheckedChanged += ckbInviteToChannel_CheckedChanged;
            // 
            // pInvite
            // 
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
            pInvite.Size = new Size(347, 284);
            pInvite.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 43);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 265;
            label9.Text = "Delay Time (seconds):";
            // 
            // label11
            // 
            label11.Location = new Point(222, 43);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 18);
            label11.TabIndex = 266;
            label11.Text = "to";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDelayInviteTo
            // 
            nudDelayInviteTo.Location = new Point(264, 41);
            nudDelayInviteTo.Margin = new Padding(4, 3, 4, 3);
            nudDelayInviteTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayInviteTo.Name = "nudDelayInviteTo";
            nudDelayInviteTo.Size = new Size(65, 23);
            nudDelayInviteTo.TabIndex = 264;
            // 
            // nudDelayInviteFrom
            // 
            nudDelayInviteFrom.Location = new Point(149, 41);
            nudDelayInviteFrom.Margin = new Padding(4, 3, 4, 3);
            nudDelayInviteFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayInviteFrom.Name = "nudDelayInviteFrom";
            nudDelayInviteFrom.Size = new Size(65, 23);
            nudDelayInviteFrom.TabIndex = 263;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 255;
            label6.Text = "Number of Members:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtListUsername);
            groupBox2.Location = new Point(6, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 211);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "List of Usernames (0):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(3, 193);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(179, 15);
            label5.TabIndex = 252;
            label5.Text = "(Each content on a separate line)";
            // 
            // txtListUsername
            // 
            txtListUsername.Location = new Point(6, 22);
            txtListUsername.Name = "txtListUsername";
            txtListUsername.Size = new Size(335, 168);
            txtListUsername.TabIndex = 0;
            txtListUsername.Text = "";
            txtListUsername.TextChanged += txtListUsername_TextChanged;
            // 
            // nudInviteTo
            // 
            nudInviteTo.Location = new Point(264, 7);
            nudInviteTo.Margin = new Padding(4, 3, 4, 3);
            nudInviteTo.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudInviteTo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInviteTo.Name = "nudInviteTo";
            nudInviteTo.Size = new Size(65, 23);
            nudInviteTo.TabIndex = 254;
            nudInviteTo.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudInviteFrom
            // 
            nudInviteFrom.Location = new Point(149, 7);
            nudInviteFrom.Margin = new Padding(4, 3, 4, 3);
            nudInviteFrom.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudInviteFrom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInviteFrom.Name = "nudInviteFrom";
            nudInviteFrom.Size = new Size(65, 23);
            nudInviteFrom.TabIndex = 253;
            nudInviteFrom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Location = new Point(222, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 18);
            label8.TabIndex = 257;
            label8.Text = "to";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckbAvtar);
            groupBox3.Controls.Add(panel2);
            groupBox3.Location = new Point(430, 399);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 65);
            groupBox3.TabIndex = 258;
            groupBox3.TabStop = false;
            groupBox3.Text = "                                             ";
            // 
            // ckbAvtar
            // 
            ckbAvtar.AutoSize = true;
            ckbAvtar.Location = new Point(15, -2);
            ckbAvtar.Name = "ckbAvtar";
            ckbAvtar.Size = new Size(148, 19);
            ckbAvtar.TabIndex = 0;
            ckbAvtar.Text = "Update Channel Avatar";
            ckbAvtar.UseVisualStyleBackColor = true;
            ckbAvtar.CheckedChanged += ckbAvtar_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtFolderImage);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 43);
            panel2.TabIndex = 253;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 17);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 1;
            label12.Text = "Folder:";
            // 
            // txtFolderImage
            // 
            txtFolderImage.Location = new Point(91, 12);
            txtFolderImage.Name = "txtFolderImage";
            txtFolderImage.Size = new Size(233, 23);
            txtFolderImage.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(ckbBio);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(55, 319);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(364, 149);
            groupBox4.TabIndex = 252;
            groupBox4.TabStop = false;
            groupBox4.Text = "                        ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(283, 15);
            label3.TabIndex = 248;
            label3.Text = "Each content on a separate line with Spintax support";
            // 
            // ckbBio
            // 
            ckbBio.AutoSize = true;
            ckbBio.Location = new Point(13, 0);
            ckbBio.Name = "ckbBio";
            ckbBio.Size = new Size(182, 19);
            ckbBio.TabIndex = 1;
            ckbBio.Text = "Update Description (optional)";
            ckbBio.UseVisualStyleBackColor = true;
            ckbBio.CheckedChanged += ckbBio_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 24);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 15);
            label7.TabIndex = 246;
            label7.Text = "Descriptions (optional) (0):";
            // 
            // txtBio
            // 
            txtBio.Location = new Point(59, 361);
            txtBio.Margin = new Padding(4, 3, 4, 3);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(362, 85);
            txtBio.TabIndex = 247;
            txtBio.Text = "";
            txtBio.WordWrap = false;
            txtBio.TextChanged += txtBio_TextChanged;
            // 
            // fCreateChannels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 531);
            Controls.Add(groupBox3);
            Controls.Add(txtBio);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(nudCountTo);
            Controls.Add(nudCountFrom);
            Controls.Add(label2);
            Controls.Add(txtListChannels);
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
            Name = "fCreateChannels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreateChannels";
            Load += fCreateChannels_load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCountTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCountFrom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pInvite.ResumeLayout(false);
            pInvite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayInviteFrom).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInviteTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInviteFrom).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private RichTextBox txtListUsername;
        private Label label21;
        private Label label16;
        private NumericUpDown nudDelayTo;
        private NumericUpDown nudDelayFrom;
        private Label label2;
        private RichTextBox txtListChannels;
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
        private GroupBox groupBox3;
        private CheckBox ckbAvtar;
        private Panel panel2;
        private Label label12;
        private TextBox txtFolderImage;
        private GroupBox groupBox4;
        private CheckBox ckbBio;
        private Label label3;
        private Label label7;
        private RichTextBox txtBio;
        private CheckBox ckbInviteToChannel;
        private Label label9;
        private Label label11;
        private NumericUpDown nudDelayInviteTo;
        private NumericUpDown nudDelayInviteFrom;
    }
}