namespace TelegramAutomationWithRequest.Forms
{
    partial class fLeaveChannels
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCountTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCountFrom).BeginInit();
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
            bunifuCustomLabel1.Text = "Leave Channels";
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
            btnCancel.Location = new Point(241, 370);
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
            btnAdd.Location = new Point(115, 370);
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
            label16.Location = new Point(266, 57);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 18);
            label16.TabIndex = 200;
            label16.Text = "to";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDelayTo
            // 
            nudDelayTo.Location = new Point(308, 55);
            nudDelayTo.Margin = new Padding(4, 3, 4, 3);
            nudDelayTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayTo.Name = "nudDelayTo";
            nudDelayTo.Size = new Size(65, 23);
            nudDelayTo.TabIndex = 197;
            // 
            // nudDelayFrom
            // 
            nudDelayFrom.Location = new Point(193, 55);
            nudDelayFrom.Margin = new Padding(4, 3, 4, 3);
            nudDelayFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDelayFrom.Name = "nudDelayFrom";
            nudDelayFrom.Size = new Size(65, 23);
            nudDelayFrom.TabIndex = 196;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 337);
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
            txtListChannels.Size = new Size(348, 190);
            txtListChannels.TabIndex = 244;
            txtListChannels.Text = "";
            txtListChannels.WordWrap = false;
            txtListChannels.TextChanged += txtListUser_TextChanged;
            // 
            // lbListUser
            // 
            lbListUser.AutoSize = true;
            lbListUser.Location = new Point(55, 126);
            lbListUser.Margin = new Padding(4, 0, 4, 0);
            lbListUser.Name = "lbListUser";
            lbListUser.Size = new Size(167, 15);
            lbListUser.TabIndex = 243;
            lbListUser.Text = "List of Channel Usernames (0):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 248;
            label1.Text = "Number of Channels:";
            // 
            // label4
            // 
            label4.Location = new Point(266, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 250;
            label4.Text = "to";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCountTo
            // 
            nudCountTo.Location = new Point(308, 85);
            nudCountTo.Margin = new Padding(4, 3, 4, 3);
            nudCountTo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCountTo.Name = "nudCountTo";
            nudCountTo.Size = new Size(65, 23);
            nudCountTo.TabIndex = 247;
            // 
            // nudCountFrom
            // 
            nudCountFrom.Location = new Point(193, 85);
            nudCountFrom.Margin = new Padding(4, 3, 4, 3);
            nudCountFrom.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCountFrom.Name = "nudCountFrom";
            nudCountFrom.Size = new Size(65, 23);
            nudCountFrom.TabIndex = 246;
            // 
            // fLeaveChannels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 427);
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
            Name = "fLeaveChannels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreateChannels";
            Load += fCreateChannels_load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCountTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCountFrom).EndInit();
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
    }
}