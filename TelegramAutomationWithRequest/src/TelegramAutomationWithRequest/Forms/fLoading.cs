using System.Runtime.InteropServices;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fLoading : Form
    {
        private PictureBox pictureBox;

        public fLoading()
        {
            InitializeForm();
            HideCloseButton();
            CenterToScreen();
        }

        private void InitializeForm()
        {
           Size = new System.Drawing.Size(80, 80);
            FormBorderStyle = FormBorderStyle.None; // Loại bỏ các nút điều khiển form

            pictureBox = new PictureBox
            {
                Image = Properties.Resources.Loading80, // Thay "LoadingGif" bằng tên của hình ảnh GIF trong resources của bạn
                SizeMode = PictureBoxSizeMode.CenterImage,
                Dock = DockStyle.Fill
            };

            Controls.Add(pictureBox);
        }

        private void HideCloseButton()
        {
            const int WS_SYSMENU = 0x80000;
            const int WS_MINIMIZEBOX = 0x20000;

            // Loại bỏ nút Close và nút Minimize
            int style = (int)NativeMethods.GetWindowLong(this.Handle, NativeMethods.GWL_STYLE);
            style = style & ~WS_SYSMENU & ~WS_MINIMIZEBOX;
            NativeMethods.SetWindowLong(this.Handle, NativeMethods.GWL_STYLE, (IntPtr)style);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x200; // Cho phép tắt Alt+F4 để đóng form
                return cp;
            }
        }
        public static class NativeMethods
        {
            public const int GWL_STYLE = -16;

            [DllImport("user32.dll")]
            public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll")]
            public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BringToFront();
            Refresh();
        }

        public void StartLoading()
        {
            Show();
            BringToFront();
            Refresh();
        }

        public void StopLoading()
        {
            Hide();
        }
    }

}
