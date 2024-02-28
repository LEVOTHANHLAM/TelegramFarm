﻿namespace TelegramAutomationWithRequest.Model
{
    public class AccountsModel
    {
        public string IdAccount { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? UserName { get; set; }
        public string? Proxy { get; set; }
        public string? FullName { get; set; }
        public string? Avatar { get; set; }
        public string? AppId { get; set; }
        public string? AppHash { get; set; }
        public string? Session { get; set; }
        public string? Cookie { get; set; }
        public string? UserAgent { get; set; }
        public Guid? IdFile { get; set; }
        public string? Note { get; set; }
        public string? Interac { get; set; }
        public string? Info { get; set; }
        public DateTime? DateImport { get; set; }
        public int? Activiti { get; set; }
        public DateTime? DateDelete { get; set; }
        public string? Status { get; set; }
        public string? Device { get; set; }
        public string? FolderName { get; set; }
        public bool IsUsing { get; set; } = false;
    }
    public class AccountSelectModel
    {
        public string IdAccount { get; set; }
        public bool IsUsing { get; set; } = false;
        public string? Proxy { get; set; }
        public int Repeat { get; set; }
    }
}
