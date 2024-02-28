namespace TelegramAutomationWithRequest.Forms
{
    partial class fAddFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddFile));
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            panel1 = new Panel();
            button1 = new Button();
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            btnCancel = new Button();
            btnAdd = new Button();
            txtNameFolder = new TextBox();
            label5 = new Label();
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
            panel1.Size = new Size(474, 38);
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
            button1.Location = new Point(436, 1);
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
            bunifuCustomLabel1.Size = new Size(474, 38);
            bunifuCustomLabel1.TabIndex = 14;
            bunifuCustomLabel1.Text = "Add Folder";
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
            btnCancel.Location = new Point(250, 120);
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
            btnAdd.Location = new Point(124, 120);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 33);
            btnAdd.TabIndex = 188;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNameFolder
            // 
            txtNameFolder.Location = new Point(178, 65);
            txtNameFolder.Margin = new Padding(4, 3, 4, 3);
            txtNameFolder.Name = "txtNameFolder";
            txtNameFolder.Size = new Size(226, 23);
            txtNameFolder.TabIndex = 190;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 69);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 191;
            label5.Text = "Folder Name:";
            // 
            // fAddFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 176);
            Controls.Add(txtNameFolder);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fAddFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddFile";
            Load += fAddFile_Load;
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
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private CheckBox ckbXoaAnhDaDung;
        private TextBox txtNameFolder;
        private Label label5;
    }
}