using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using TelegramAutomationWithRequest.Services.Interfaces;
using TelegramAutomationWithRequest.Model;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Services
{
    public class FilesService : IFilesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FilesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool Create(string name)
        {
            try
            {
                var newFile = new Filess();
                newFile.Name = name;
                newFile.IdFile = Guid.NewGuid();
                newFile.Active = 1;
                _unitOfWork.FilessRepository.Create(newFile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                var _id = new Guid(id);
                var accs = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdFile == _id).ToList();
                if (accs.Any())
                {
                    _unitOfWork.AccountsRepository.DeleteList(accs);
                }
                var folder = _unitOfWork.FilessRepository.FindByCondition(x => x.IdFile == _id).FirstOrDefault();
                if (folder != null)
                {
                    _unitOfWork.FilessRepository.Delete(folder);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }

        public List<FilesModel> GetAll()
        {
            var filesses = _unitOfWork.FilessRepository.FindAll();
            if (filesses == null)
            {
                // Xử lý khi filesses là null
                return null;
            }
            var data = filesses.Select(p => _mapper.Map<FilesModel>(p)).ToList();
            return data;
        }

        public Filess? GetByName(string name)
        {
            return _unitOfWork.FilessRepository.FindByCondition(x => x.Name == name).FirstOrDefault();
        }
    }
}
