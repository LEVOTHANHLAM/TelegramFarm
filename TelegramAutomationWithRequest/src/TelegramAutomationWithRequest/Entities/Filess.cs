using System;
using System.ComponentModel.DataAnnotations;

namespace TelegramAutomationWithRequest.Entities
{
    public class Filess
    {
        [Key]
        public Guid IdFile { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
    }
}
