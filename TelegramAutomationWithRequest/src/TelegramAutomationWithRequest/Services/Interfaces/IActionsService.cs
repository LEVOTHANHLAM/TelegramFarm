namespace TelegramAutomationWithRequest.Services.Interfaces
{
    public interface IActionsService
    {
        string GetDataActions(string Name, string ScriptId);
        bool CreateUpdate(string Name, string ScriptId, string Configuration);
    }
}
