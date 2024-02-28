using AutoMapper;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Model;

namespace TelegramAutomationWithRequest.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Accounts, AccountsModel>()
                .ForMember(d => d.IdAccount, m => m.MapFrom(s => s.IdAccount.ToString()))
                .ForMember(d => d.DateImport, m => m.MapFrom(s => s.DateImport.Value.ToString("dd/MM/yyyy HH:mm:ss")));
            CreateMap<Filess, FilesModel>();
        }
    }
}
