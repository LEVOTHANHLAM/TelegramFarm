using System;
using System.ComponentModel.DataAnnotations;

namespace TelegramAutomationWithRequest.Entities
{
    public class InteractAccounts
    {
        [Key]
        public Guid IdInteractaccount { get; set; }
        public Guid? IdAccount { get; set; }
        public Guid? IdAction { get; set; }
        public string? Configuration { get; set; }
    }
}
