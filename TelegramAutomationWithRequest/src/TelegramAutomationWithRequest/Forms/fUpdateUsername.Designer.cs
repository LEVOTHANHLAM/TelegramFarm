namespace TelegramAutomationWithRequest.Forms
{
    partial class fUpdateUsername
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
            txtListUsername = new RichTextBox();
            lbListUser = new Label();
            rdbCustom = new RadioButton();
            rdbRandom = new RadioButton();
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
            panel1.Controls.Add(bunifuCustomLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 38);
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
            bunifuCustomLabel1.Size = new Size(470, 38);
            bunifuCustomLabel1.TabIndex = 14;
            bunifuCustomLabel1.Text = "Change Username";
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
            btnCancel.Location = new Point(241, 350);
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
            btnAdd.Location = new Point(115, 350);
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
            label2.Location = new Point(57, 316);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 245;
            label2.Text = "(Each content on a separate line)";
            // 
            // txtListUsername
            // 
            txtListUsername.Location = new Point(61, 123);
            txtListUsername.Margin = new Padding(4, 3, 4, 3);
            txtListUsername.Name = "txtListUsername";
            txtListUsername.Size = new Size(348, 190);
            txtListUsername.TabIndex = 244;
            txtListUsername.Text = "";
            txtListUsername.WordWrap = false;
            txtListUsername.TextChanged += txtListUser_TextChanged;
            // 
            // lbListUser
            // 
            lbListUser.AutoSize = true;
            lbListUser.Location = new Point(57, 98);
            lbListUser.Margin = new Padding(4, 0, 4, 0);
            lbListUser.Name = "lbListUser";
            lbListUser.Size = new Size(112, 15);
            lbListUser.TabIndex = 243;
            lbListUser.Text = "New Usernames (0):";
            // 
            // rdbCustom
            // 
            rdbCustom.AutoSize = true;
            rdbCustom.Location = new Point(61, 66);
            rdbCustom.Name = "rdbCustom";
            rdbCustom.Size = new Size(67, 19);
            rdbCustom.TabIndex = 262;
            rdbCustom.Text = "Custom";
            rdbCustom.UseVisualStyleBackColor = true;
            rdbCustom.CheckedChanged += rdbCustom_CheckedChanged;
            // 
            // rdbRandom
            // 
            rdbRandom.AutoSize = true;
            rdbRandom.Checked = true;
            rdbRandom.Location = new Point(241, 66);
            rdbRandom.Name = "rdbRandom";
            rdbRandom.Size = new Size(70, 19);
            rdbRandom.TabIndex = 261;
            rdbRandom.TabStop = true;
            rdbRandom.Text = "Random";
            rdbRandom.UseVisualStyleBackColor = true;
            rdbRandom.CheckedChanged += rdbRandom_CheckedChanged;
            // 
            // fUpdateUsername
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 407);
            Controls.Add(rdbCustom);
            Controls.Add(rdbRandom);
            Controls.Add(label2);
            Controls.Add(txtListUsername);
            Controls.Add(lbListUser);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fUpdateUsername";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreateChannels";
            Load += fCreateChannels_load;
            panel1.ResumeLayout(false);
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
        private RichTextBox txtListUsername;
        private Label lbListUser;
        private RadioButton rdbCustom;
        private RadioButton rdbRandom;
    }
}