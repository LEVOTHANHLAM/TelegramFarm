using static System.Net.Mime.MediaTypeNames;

namespace TelegramAutomationWithRequest.Helper
{
    public static class WaitingDialog
    {
        private static Form waitingForm;

        public static async Task ShowWaitingDialogAsync(string message, Func<Task> action)
        {
            waitingForm = new Form
            {
                Text = "Please wait",
                Size = new System.Drawing.Size(300, 100),
                StartPosition = FormStartPosition.CenterScreen, // Đặt vị trí xuất hiện giữa màn hình
                FormBorderStyle = FormBorderStyle.FixedDialog, // Chặn người dùng tương tác với cửa sổ chính
                ControlBox = false // Ẩn các nút điều khiển cửa sổ
            };

            Label label = new Label
            {
                Text = message,
                Dock = DockStyle.Top
            };

            ProgressBar progressBar = new ProgressBar
            {
                Style = ProgressBarStyle.Marquee,
                Dock = DockStyle.Bottom
            };

            waitingForm.Controls.Add(progressBar);
            waitingForm.Controls.Add(label);
            waitingForm.Show();
            // Chạy action trong một task riêng biệt
            await Task.Run(action);

            waitingForm.Close();
        }
    }
}
