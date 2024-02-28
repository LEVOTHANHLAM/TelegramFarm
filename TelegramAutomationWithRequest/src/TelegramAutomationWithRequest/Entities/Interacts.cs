using System;
using System.ComponentModel.DataAnnotations;

namespace TelegramAutomationWithRequest.Entities
{
    public class Interacts
    {
        [Key]
        public Guid IdInteract { get; set; }
        public string? Name { get; set; }
        public string? Configuration { get; set; }
        public string? Describe { get; set; }
    }
}
