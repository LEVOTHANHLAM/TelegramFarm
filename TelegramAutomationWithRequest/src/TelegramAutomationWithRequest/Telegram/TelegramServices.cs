using TelegramAutomationWithRequest.Helper;
using WTelegram;

namespace TelegramAutomationWithRequest.Telegram
{
    public class TelegramServices
    {
        public static async Task<string> GetCodeLogin(Client client)
        {
            try
            {
                var dialogs = await client.Messages_GetAllDialogs(null);
                for (int j = 0; j < dialogs.TotalCount; j++)
                {
                    if (dialogs.Messages[j].Peer.ID == 777000)
                    {
                        var sms = (TL.Message)dialogs.messages[j];
                        string body = sms.message;
                        RichTextBoxHelper.WriteLogRichTextBox($"{body}", 2);
                        string[] line = body.Split(':', '.', '\n', '\t', ' ');
                        foreach (var item in line)
                        {
                            if (item.Length == 11 || item.Length == 5 && !item.Contains("Login"))
                            {
                                string code = item;
                                return code;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
               
            }
            return null;
        }
    }
}
