namespace TelegramAutomationWithRequest.Services.Interfaces
{
    public interface IpsHelper
    {
        bool RandomlySetJsonValueToXML(string pathToJsonFile, string pathToXMLFile);
        void GetSetFileXML(string pathFileXML, string nodeName, string valueXML);
        Task SetBuild(string folderPath, string pId);
    }
}
