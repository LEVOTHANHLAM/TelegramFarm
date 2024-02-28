using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Services
{
    public class ScriptService : IScriptService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ScriptService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Create(string Name)
        {
            var checkName = _unitOfWork.ScriptsRepository.FindByCondition(x => x.Name.ToLower() == Name.ToLower()).FirstOrDefault();
            if (checkName != null) return false;
            var script = new Scripts();
            script.Name = Name;
            script.IdScript = Guid.NewGuid();
            //script.Configuration = Configuration;
            _unitOfWork.ScriptsRepository.Create(script);
            _unitOfWork.SaveChange();
            return true;
        }

        public void DeleteById(string IdScript)
        {
            var _IdScript = new Guid(IdScript);
            var listAction = _unitOfWork.ActionsRepository.FindByCondition(x => x.IdScript == _IdScript).ToList();
            if (listAction != null && listAction.Count > 0)
            {
                _unitOfWork.ActionsRepository.DeleteList(listAction);
            }
            var isExit = _unitOfWork.ScriptsRepository.FindByCondition(x => x.IdScript == _IdScript).FirstOrDefault();
            if (isExit != null)
            {
                _unitOfWork.ScriptsRepository.Delete(isExit);
            }
        }

        public List<Scripts>? GetAllScript()
        {
            var scripts = _unitOfWork.ScriptsRepository.FindAll();
            if (scripts == null)
            {
                // Xử lý khi scripts là null
                return null;
            }

            return scripts.ToList();
        }

        public Scripts? GetById(string IdScript)
        {
            var _IdScript = new Guid(IdScript);
            return _unitOfWork.ScriptsRepository.FindByCondition(x => x.IdScript == _IdScript).FirstOrDefault();
        }

        public bool Update(string IdScript, string Configuration)
        {
            try
            {
                var _IdScript = new Guid(IdScript);
                var isExit = _unitOfWork.ScriptsRepository.FindByCondition(x => x.IdScript == _IdScript).SingleOrDefault();
                if (isExit != null)
                {
                    isExit.Configuration = Configuration;
                    _unitOfWork.ScriptsRepository.Update(isExit);

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
