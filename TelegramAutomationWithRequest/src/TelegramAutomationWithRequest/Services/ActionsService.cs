using Microsoft.EntityFrameworkCore;
using TelegramAutomationWithRequest.Repositories.Interfaces;
using TelegramAutomationWithRequest.Services.Interfaces;
using TelegramAutomationWithRequest.Entities;

namespace TelegramAutomationWithRequest.Services
{
    public class ActionsService : IActionsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActionsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool CreateUpdate(string Name, string ScriptId, string Configuration)
        {
            try
            {
                var isExit = _unitOfWork.ActionsRepository.FindByCondition(x => x.Name == Name && x.IdScript == new Guid(ScriptId)).AsNoTracking().SingleOrDefault();
                if (isExit != null)
                {
                    isExit.Configuration = Configuration;
                    _unitOfWork.ActionsRepository.Update(isExit);

                }
                else
                {
                    var actions = new Actions();
                    actions.Name = Name;
                    actions.IdScript = new Guid(ScriptId);
                    actions.Configuration = Configuration;
                    actions.IdAction = Guid.NewGuid();
                    _unitOfWork.ActionsRepository.Create(actions);
                }

                //_unitOfWork.SaveChange();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public string GetDataActions(string Name, string ScriptId)
        {
            var actions = _unitOfWork.ActionsRepository.FindByCondition(x => x.Name == Name && x.IdScript == new Guid(ScriptId)).FirstOrDefault();
            var Configuration = actions != null ? actions.Configuration : "";
            return Configuration;
        }
    }
}
