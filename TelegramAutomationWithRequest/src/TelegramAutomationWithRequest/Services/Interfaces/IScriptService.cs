using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramAutomationWithRequest.Entities;

namespace TelegramAutomationWithRequest.Services.Interfaces
{
    public interface IScriptService
    {
        bool Create(string Name);
        bool Update(string IdScript, string Configuration);
        List<Scripts>? GetAllScript();
        Scripts? GetById(string IdScript);
        void DeleteById(string IdScript);
    }
}
