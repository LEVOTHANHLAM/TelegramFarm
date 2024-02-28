namespace TelegramAutomationWithRequest.Forms
{
    public partial class fInput : Form
    {
        public fInput(string text = "Inport Code")
        {
            InitializeComponent();
            bunifuCustomLabel1.Text = text;
        }
        public string Code;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Code = txtNameFolder.Text.Trim();
            Close();
        }
    }
}
