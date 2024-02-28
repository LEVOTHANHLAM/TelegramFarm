namespace TelegramAutomationWithRequest.Model
{
    public static class GlobalModel
    {
        public static List<DevicesModel> ListAccount = new List<DevicesModel>();
        public static List<string> ListScript = new List<string>();
        public static bool CheckDuplicate = true;

        public static string FileMessage = Path.Combine(Environment.CurrentDirectory, "Database\\FileMessage.txt");
        public static string FileFollow = Path.Combine(Environment.CurrentDirectory, "Database\\FileFollow.txt");
        public static List<string> ListUserMessage = new List<string>();
        public static List<string> ListUserFollow = new List<string>();
        public static string FileUsername { get; set; }
        public static List<string> ListUsername = new List<string>();
        /// <summary>
        /// ////////////////////////////////////////////////////
    }
}