namespace TelegramAutomationWithRequest.Forms
{
    partial class fUpdateBio
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
            txtListBio = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
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
            bunifuCustomLabel1.Text = "Change Bio";
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
            btnCancel.Location = new Point(297, 386);
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
            btnAdd.Location = new Point(171, 386);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtListBio
            // 
            txtListBio.Location = new Point(26, 68);
            txtListBio.Margin = new Padding(4, 3, 4, 3);
            txtListBio.Name = "txtListBio";
            txtListBio.Size = new Size(528, 277);
            txtListBio.TabIndex = 250;
            txtListBio.Text = "";
            txtListBio.WordWrap = false;
            txtListBio.TextChanged += txtListBio_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 348);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(283, 15);
            label5.TabIndex = 249;
            label5.Text = "Each content on a separate line with Spintax support";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 247;
            label4.Text = "Bio Details (0):";
            // 
            // fUpdateBio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 443);
            Controls.Add(label5);
            Controls.Add(txtListBio);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fUpdateBio";
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
        private RichTextBox txtListBio;
        private Label label5;
        private Label label4;
    }
}