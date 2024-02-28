using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Model;

namespace TelegramAutomationWithRequest.Services.Interfaces
{
    public interface IFilesService
    {
        Filess? GetByName(string name);
        bool Create(string name);
        List<FilesModel> GetAll();
        bool Delete(string id);
    }
}
