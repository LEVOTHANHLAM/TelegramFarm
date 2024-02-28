namespace TelegramAutomationWithRequest.Forms
{
    partial class fUpdateFullname
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
            label2 = new Label();
            txtListFirtname = new RichTextBox();
            lbListUser = new Label();
            rdbCustom = new RadioButton();
            rdbRandomUS = new RadioButton();
            panel2 = new Panel();
            label1 = new Label();
            txtLastname = new RichTextBox();
            label3 = new Label();
            rdbVN = new RadioButton();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            txtListBio = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            ckbUpdateBio = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(569, 38);
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
            bunifuCustomLabel1.Size = new Size(569, 38);
            bunifuCustomLabel1.TabIndex = 14;
            bunifuCustomLabel1.Text = "Change Fullname";
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
            btnCancel.Location = new Point(297, 454);
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
            btnAdd.Location = new Point(171, 454);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 245;
            label2.Text = "(Each content on a separate line)";
            // 
            // txtListFirtname
            // 
            txtListFirtname.Location = new Point(9, 25);
            txtListFirtname.Margin = new Padding(4, 3, 4, 3);
            txtListFirtname.Name = "txtListFirtname";
            txtListFirtname.Size = new Size(234, 110);
            txtListFirtname.TabIndex = 244;
            txtListFirtname.Text = "";
            txtListFirtname.WordWrap = false;
            txtListFirtname.TextChanged += txtListUser_TextChanged;
            // 
            // lbListUser
            // 
            lbListUser.AutoSize = true;
            lbListUser.Location = new Point(9, 7);
            lbListUser.Margin = new Padding(4, 0, 4, 0);
            lbListUser.Name = "lbListUser";
            lbListUser.Size = new Size(79, 15);
            lbListUser.TabIndex = 243;
            lbListUser.Text = "Firstname (0):";
            // 
            // rdbCustom
            // 
            rdbCustom.AutoSize = true;
            rdbCustom.Location = new Point(337, 55);
            rdbCustom.Name = "rdbCustom";
            rdbCustom.Size = new Size(67, 19);
            rdbCustom.TabIndex = 262;
            rdbCustom.Text = "Custom";
            rdbCustom.UseVisualStyleBackColor = true;
            rdbCustom.CheckedChanged += rdbCustom_CheckedChanged;
            // 
            // rdbRandomUS
            // 
            rdbRandomUS.AutoSize = true;
            rdbRandomUS.Checked = true;
            rdbRandomUS.Location = new Point(46, 55);
            rdbRandomUS.Name = "rdbRandomUS";
            rdbRandomUS.Size = new Size(87, 19);
            rdbRandomUS.TabIndex = 261;
            rdbRandomUS.TabStop = true;
            rdbRandomUS.Text = "Random US";
            rdbRandomUS.UseVisualStyleBackColor = true;
            rdbRandomUS.CheckedChanged += rdbRandom_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtLastname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbListUser);
            panel2.Controls.Add(txtListFirtname);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(22, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 158);
            panel2.TabIndex = 263;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 246;
            label1.Text = "Lastname (0):";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(293, 25);
            txtLastname.Margin = new Padding(4, 3, 4, 3);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(234, 110);
            txtLastname.TabIndex = 247;
            txtLastname.Text = "";
            txtLastname.WordWrap = false;
            txtLastname.TextChanged += txtLastname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 15);
            label3.TabIndex = 248;
            label3.Text = "(Each content on a separate line)";
            // 
            // rdbVN
            // 
            rdbVN.AutoSize = true;
            rdbVN.Location = new Point(171, 55);
            rdbVN.Name = "rdbVN";
            rdbVN.Size = new Size(134, 19);
            rdbVN.TabIndex = 264;
            rdbVN.Text = "Random Vietnamese";
            rdbVN.UseVisualStyleBackColor = true;
            rdbVN.CheckedChanged += rdbVN_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(ckbUpdateBio);
            groupBox1.Location = new Point(21, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 187);
            groupBox1.TabIndex = 265;
            groupBox1.TabStop = false;
            groupBox1.Text = "                                ";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtListBio);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 165);
            panel3.TabIndex = 1;
            // 
            // txtListBio
            // 
            txtListBio.Dock = DockStyle.Fill;
            txtListBio.Location = new Point(0, 15);
            txtListBio.Margin = new Padding(4, 3, 4, 3);
            txtListBio.Name = "txtListBio";
            txtListBio.Size = new Size(528, 135);
            txtListBio.TabIndex = 250;
            txtListBio.Text = "";
            txtListBio.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(0, 150);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(283, 15);
            label5.TabIndex = 249;
            label5.Text = "Each content on a separate line with Spintax support";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 247;
            label4.Text = "Bio Details (0):";
            // 
            // ckbUpdateBio
            // 
            ckbUpdateBio.AutoSize = true;
            ckbUpdateBio.Location = new Point(9, 0);
            ckbUpdateBio.Name = "ckbUpdateBio";
            ckbUpdateBio.Size = new Size(87, 19);
            ckbUpdateBio.TabIndex = 0;
            ckbUpdateBio.Text = "Change Bio";
            ckbUpdateBio.UseVisualStyleBackColor = true;
            ckbUpdateBio.CheckedChanged += ckbUpdateBio_CheckedChanged;
            // 
            // fUpdateFullname
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 511);
            Controls.Add(groupBox1);
            Controls.Add(rdbVN);
            Controls.Add(panel2);
            Controls.Add(rdbCustom);
            Controls.Add(rdbRandomUS);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fUpdateFullname";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreateChannels";
            Load += fCreateChannels_load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Label label2;
        private RichTextBox txtListFirtname;
        private Label lbListUser;
        private RadioButton rdbCustom;
        private RadioButton rdbRandomUS;
        private Panel panel2;
        private Label label1;
        private RichTextBox txtLastname;
        private Label label3;
        private RadioButton rdbVN;
        private GroupBox groupBox1;
        private Panel panel3;
        private RichTextBox txtListBio;
        private Label label5;
        private Label label4;
        private CheckBox ckbUpdateBio;
    }
}