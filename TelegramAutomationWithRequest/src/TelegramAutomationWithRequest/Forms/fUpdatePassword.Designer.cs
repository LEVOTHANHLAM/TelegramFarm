namespace TelegramAutomationWithRequest.Forms
{
    partial class fUpdatePassword
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
            rdbCustom = new RadioButton();
            rdbRandom = new RadioButton();
            txtCustom = new TextBox();
            panel2 = new Panel();
            label21 = new Label();
            nudTo = new NumericUpDown();
            nudFrom = new NumericUpDown();
            label16 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFrom).BeginInit();
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
            bunifuCustomLabel1.Text = "Change Password";
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
            btnCancel.Location = new Point(241, 139);
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
            btnAdd.Location = new Point(115, 139);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rdbCustom
            // 
            rdbCustom.AutoSize = true;
            rdbCustom.Location = new Point(26, 59);
            rdbCustom.Name = "rdbCustom";
            rdbCustom.Size = new Size(73, 19);
            rdbCustom.TabIndex = 262;
            rdbCustom.Text = "Custom :";
            rdbCustom.UseVisualStyleBackColor = true;
            rdbCustom.CheckedChanged += rdbCustom_CheckedChanged;
            // 
            // rdbRandom
            // 
            rdbRandom.AutoSize = true;
            rdbRandom.Checked = true;
            rdbRandom.Location = new Point(26, 100);
            rdbRandom.Name = "rdbRandom";
            rdbRandom.Size = new Size(70, 19);
            rdbRandom.TabIndex = 261;
            rdbRandom.TabStop = true;
            rdbRandom.Text = "Random";
            rdbRandom.UseVisualStyleBackColor = true;
            rdbRandom.CheckedChanged += rdbRandom_CheckedChanged;
            // 
            // txtCustom
            // 
            txtCustom.Location = new Point(105, 58);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(338, 23);
            txtCustom.TabIndex = 263;
            // 
            // panel2
            // 
            panel2.Controls.Add(label21);
            panel2.Controls.Add(nudTo);
            panel2.Controls.Add(nudFrom);
            panel2.Controls.Add(label16);
            panel2.Location = new Point(105, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 29);
            panel2.TabIndex = 264;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(10, 8);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(36, 15);
            label21.TabIndex = 267;
            label21.Text = "from:";
            // 
            // nudTo
            // 
            nudTo.Location = new Point(188, 3);
            nudTo.Margin = new Padding(4, 3, 4, 3);
            nudTo.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudTo.Name = "nudTo";
            nudTo.Size = new Size(65, 23);
            nudTo.TabIndex = 266;
            // 
            // nudFrom
            // 
            nudFrom.Location = new Point(73, 3);
            nudFrom.Margin = new Padding(4, 3, 4, 3);
            nudFrom.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudFrom.Name = "nudFrom";
            nudFrom.Size = new Size(65, 23);
            nudFrom.TabIndex = 265;
            // 
            // label16
            // 
            label16.Location = new Point(146, 5);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 18);
            label16.TabIndex = 269;
            label16.Text = "to";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fUpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 196);
            Controls.Add(txtCustom);
            Controls.Add(rdbCustom);
            Controls.Add(panel2);
            Controls.Add(rdbRandom);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fUpdatePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreateChannels";
            Load += fCreateChannels_load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFrom).EndInit();
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
        private RadioButton rdbCustom;
        private RadioButton rdbRandom;
        private TextBox txtCustom;
        private Panel panel2;
        private Label label21;
        private NumericUpDown nudTo;
        private NumericUpDown nudFrom;
        private Label label16;
    }
}