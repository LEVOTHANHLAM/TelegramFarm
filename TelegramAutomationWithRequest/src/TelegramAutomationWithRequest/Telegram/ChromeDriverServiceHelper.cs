using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;
using OpenQA.Selenium.DevTools;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using WTelegram;

namespace TelegramAutomationWithRequest.Telegram
{
    public class ChromeDriverServiceHelper
    {
        public static IWebDriver NewChrome(string url, string? proxy, string userAgent, bool headless)
        {
            string proxyAddress = "";
            string proxyPort = "";
            string proxyUsername = "";
            string proxyPassword = "";
            if (!string.IsNullOrEmpty(proxy))
            {
                // Tách thông tin từ chuỗi proxy
                string[] parts = proxy.Split(':');
                if (parts.Length >= 2)
                {
                    proxyAddress = parts[0];
                    proxyPort = parts[1];
                }
                if (parts.Length >= 4)
                {
                    proxyUsername = parts[2];
                    proxyPassword = parts[3];
                }
            }
            ChromeOptions options = new ChromeOptions();
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            // Cấu hình proxy với username và password
            if (!string.IsNullOrEmpty(proxyAddress) && !string.IsNullOrEmpty(proxyPort) && !string.IsNullOrEmpty(proxyPassword) && !string.IsNullOrEmpty(proxyUsername))
            {
                if (int.TryParse(proxyPort, out int value))
                {
                    options.AddHttpProxy(proxyAddress, value, proxyUsername, proxyPassword);
                }
            }
            else if (!string.IsNullOrEmpty(proxyAddress) && !string.IsNullOrEmpty(proxyPort))
            {
                var result = $"{proxyAddress}:{proxyPassword}";
                //   options.AddArgument("--proxy-server=" + result);
                if (int.TryParse(proxyPort, out int value))
                {
                    options.AddHttpProxy(proxyAddress, value, proxyUsername, proxyPassword);
                }
            }
        //    options.AddArgument("--disable-extensions");

            options.AddArgument($"--user-agent={userAgent}");
            //Bạn có thể thiết lập kích thước cửa sổ của trình duyệt:
            options.AddArgument("--window-size=1920,1080");
            //Mở cửa sổ trình duyệt với kích thước lớn nhất:
            options.AddArgument("--start-maximized");
            //Sử dụng Chrome trong chế độ an toàn, ngăn chặn quảng cáo và phần mềm độc hại
            options.AddArgument("--safebrowsing-disable-download-protection");
            options.AddArgument("--safebrowsing-disable-extension-blacklist");
            options.AddArgument("--safebrowsing-manual-download-blacklist");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--ignore-certificate-errors");
            //Chế độ giả mạo một số thông tin như dữ liệu hệ điều hành, thông tin phần cứng
            options.AddArgument("--use-mock-keychain");
            options.AddArgument("--use-fake-device-for-media-stream");
            options.AddArgument("--use-fake-ui-for-media-stream");
            options.AddArgument("--disable-usb-keyboard-detect");
            //Thiết lập múi giờ của trình duyệt
            // Thêm tùy chọn headless để ẩn trình duyệt
            
            IWebDriver driver = new ChromeDriver(chromeDriverService, options);
            var devToolsSession = ((ChromeDriver)driver).GetDevToolsSession();

            driver.Navigate().GoToUrl(url);
            return driver;
        }
        public static IWebElement FindElementByXPath(IWebDriver driver, string xpath, int timeout = 60)
        {
            timeout = timeout * 1000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                try
                {
                    var result = driver.FindElement(By.XPath(xpath));
                    if (result != null)
                    {
                        return result;
                    }
                }
                catch (Exception)
                {


                }
                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop(); break;
                }
            }
            return null;
        }
        public static IWebElement FindElementById(IWebDriver driver, string id, int timeout = 60)
        {
            timeout = timeout * 1000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                try
                {
                    var result = driver.FindElement(By.Id(id));
                    if (result != null)
                    {
                        return result;
                    }
                }
                catch (Exception)
                {


                }
                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop(); break;
                }


            }
            return null;
        }
        public static IWebElement FindElementByClassname(IWebDriver driver, string className, int timeout = 60)
        {
            timeout = timeout * 1000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                try
                {
                    var result = driver.FindElement(By.ClassName(className));
                    if (result != null)
                    {
                        return result;
                    }
                }
                catch (Exception)
                {


                }
                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop(); break;
                }


            }
            return null;
        }
        public static IWebElement FindElementByCSS(IWebDriver driver, string css, int timeout = 60)
        {
            timeout = timeout * 1000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                try
                {
                    var result = driver.FindElement(By.CssSelector(css));
                    if (result != null)
                    {
                        return result;
                    }
                }
                catch (Exception)
                {


                }
                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop(); break;
                }


            }
            return null;
        }
        public static async Task<string> LoginTelegramWebClient(IWebDriver driver, Client client, string phone, string? password)
        {
            try
            {
                if (driver != null)
                {
                    try
                    {
                        bool result = false;
                        int index = 3;
                        while (index > 0)
                        {
                            index--;
                            // Nhấp vào nút "Log in by phone Number"
                            IWebElement loginButton = FindElementByXPath(driver, "//button[contains(text(), 'Log in by phone Number')]", 120);
                            if (loginButton != null)
                            {
                                loginButton.Click();
                                index = 0;
                                result = true;
                                break;
                            }
                            driver.Navigate().GoToUrl("https://web.telegram.org/a/");
                        }
                        if (result)
                        {
                            // Điền số điện thoại và nhấp vào nút "Next"
                            IWebElement phoneNumberInput = FindElementById(driver, "sign-in-phone-number");
                            if (phoneNumberInput != null)
                            {
                                phoneNumberInput.Clear();
                                phoneNumberInput.SendKeys(phone);
                                IWebElement nextButton = FindElementByXPath(driver, "//button[contains(text(), 'Next')]");
                                nextButton.Click();
                                IWebElement codeInput = FindElementById(driver, "sign-in-code");
                                if (codeInput != null)
                                {
                                    string code = string.Empty;
                                    for (index = 0; index < 5; index++)
                                    {
                                        code = await TelegramServices.GetCodeLogin(client);
                                        if (!string.IsNullOrEmpty(code))
                                        {
                                            break;
                                        }
                                    }
                                    if (!string.IsNullOrEmpty(code))
                                    {
                                        codeInput.SendKeys(code);
                                        IWebElement passwordInput = FindElementById(driver, "sign-in-password", 20);
                                        if (passwordInput != null)
                                        {
                                            passwordInput.SendKeys(password);
                                            IWebElement nextButtonPassword = FindElementByXPath(driver, "//button[contains(text(), 'Next')]");
                                            nextButtonPassword.Click();

                                        }
                                        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
                                        IWebElement submitButton = FindElementByCSS(driver, ".SearchInput");
                                        if (submitButton != null)
                                        {
                                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                            ReadOnlyCollection<object> localStorage = (ReadOnlyCollection<object>)js.ExecuteScript("return Object.keys(window.localStorage);");

                                            foreach (object item in localStorage)
                                            {
                                                string key = (string)item;
                                                string value = (string)js.ExecuteScript($"return window.localStorage.getItem('{key}');");
                                                keyValuePairs[key] = value;
                                            }
                                            string jsonString = JsonConvert.SerializeObject(keyValuePairs);
                                            return jsonString;
                                        }

                                    }
                                }
                            }
                        }
                    }
                    catch (NoSuchElementException ex)
                    {
                        Console.WriteLine("Element not found.");
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        public static async Task<string> RestoreTelegramWebClient(IWebDriver driver, string jsonString)
        {
            try
            {
                if (driver != null)
                {
                    bool result = false;
                    int index = 3;
                    while (index > 0)
                    {
                        index--;
                        // Nhấp vào nút "Log in by phone Number"
                        IWebElement loginButton = FindElementByXPath(driver, "//button[contains(text(), 'Log in by phone Number')]", 120);
                        if (loginButton != null)
                        {
                            loginButton.Click();
                            index = 0;
                            result = true;
                            break;
                        }
                        driver.Navigate().GoToUrl("https://web.telegram.org/a/");
                    }
                    if (result)
                    {
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript($"Object.entries({jsonString}).forEach(([key, value]) => localStorage.setItem(key, value));");
                        driver.Navigate().GoToUrl("https://web.telegram.org/a/");
                        for (index = 0; index < 3; index++)
                        {
                            IWebElement submitButton = FindElementByCSS(driver, ".SearchInput", 120);
                            if (submitButton != null)
                            {
                                IJavaScriptExecutor jshelper = (IJavaScriptExecutor)driver;
                                ReadOnlyCollection<object> localStorage = (ReadOnlyCollection<object>)jshelper.ExecuteScript("return Object.keys(window.localStorage);");
                                var stringValue = string.Empty;
                                Dictionary<string, string> keyValue = new Dictionary<string, string>();
                                foreach (object item in localStorage)
                                {
                                    string key = (string)item;
                                    string value = (string)js.ExecuteScript($"return window.localStorage.getItem('{key}');");
                                    keyValue[key] = value;
                                }
                                string json = JsonConvert.SerializeObject(keyValue);
                                return json;
                            }
                            driver.Navigate().GoToUrl("https://web.telegram.org/a/");
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
