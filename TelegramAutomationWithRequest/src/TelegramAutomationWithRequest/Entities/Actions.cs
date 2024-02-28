using System;
using System.ComponentModel.DataAnnotations;

namespace TelegramAutomationWithRequest.Entities
{
    public class Actions
    {
        [Key]
        public Guid IdAction { get; set; }
        public Guid? IdScript { get; set; }
        public string? Name { get; set; }
        public string? Configuration { get; set; }
        public string? ListCheckbox { get; set; }
    }
}
