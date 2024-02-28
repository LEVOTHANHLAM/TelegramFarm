using OpenQA.Selenium;
using WTelegram;

namespace TelegramAutomationWithRequest.Model
{
    public class DevicesModel
    {
        public Client Client { get; set; }
        public string IdAccount {  get; set; }  
        public IWebDriver ChromeDriver { get; set; }
        public int Repeat { get; set; }
        public string? Status { get; set; }
        public string? Proxy { get; set; }
        public int Index { get; set; }
    }
}
