using System;
using System.ComponentModel.DataAnnotations;

namespace TelegramAutomationWithRequest.Entities
{
    public class Scripts
    {
        [Key]
        public Guid IdScript { get; set; }
        public string? Name { get; set; }
        public string? Configuration { get; set; }
    }
}
