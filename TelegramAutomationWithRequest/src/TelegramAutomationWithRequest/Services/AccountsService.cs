using AutoMapper;
using Serilog;
using System.Linq.Expressions;
using System.Reflection;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Model;
using TelegramAutomationWithRequest.Repositories.Interfaces;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Services
{
    public class AccountsService : IAccountsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AccountsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateList(List<Accounts> accounts)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(CreateList)}, accounts {accounts} ");
                _unitOfWork.AccountsRepository.CreateList(accounts);
                _unitOfWork.SaveChange();
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(CreateList)}");
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }

        }

        public bool DeleteList(List<string> idAccounts)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(DeleteList)}, Idaccounts {idAccounts} ");
                var listAccount = new List<Accounts>();
                foreach (var id in idAccounts)
                {
                    var _id = new Guid(id);
                    var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == _id).FirstOrDefault();
                    if (acc != null)
                    {
                        listAccount.Add(acc);
                    }
                }
                if (listAccount.Count > 0)
                {
                    _unitOfWork.AccountsRepository.DeleteList(listAccount);
                    _unitOfWork.SaveChange();
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(DeleteList)}");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }

        public List<AccountsModel> GetAll()
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(GetAll)} ");
                var source = _unitOfWork.AccountsRepository.FindAll().ToList();

                List<AccountsModel> list = new List<AccountsModel>();
                foreach (var account in source)
                {
                    var acc = new AccountsModel
                    {
                        IdAccount = account.IdAccount.ToString(),
                        PhoneNumber = account.PhoneNumber,
                        Password = account.Password,
                        UserName = account.UserName,
                        Proxy = account.Proxy,
                        FullName = account.FullName,
                        Avatar = account.Avatar,
                        AppId = account.AppId,
                        AppHash = account.AppHash,
                        Session = account.Session,
                        Cookie = account.Cookie,
                        UserAgent = account.UserAgent,
                        IdFile = account.IdFile,
                        Note = account.Note,
                        Interac = account.Interac,
                        Info = account.Info,
                        DateImport = account.DateImport,
                        Activiti = account.Activiti,
                        DateDelete = account.DateDelete,
                        Status = account.Status,
                        Device = account.Device,
                        FolderName = "",
                        IsUsing = false
                    };
                    list.Add(acc);
                }

                //data = source.Select(p => _mapper.Map<AccountsModel>(p)).ToList();
                Log.Information($"Start {nameof(AccountsService)}, params: {list.Count} ");
                var folder = _unitOfWork.FilessRepository.FindAll().ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].FolderName = folder.Where(x => x.IdFile == list[i].IdFile).Select(i => i.Name).FirstOrDefault();
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(GetAll)} return {list.Count}");
                return list;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return null;
            }

        }
        public bool CheckIndex(string index)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(CheckIndex)}, index; {index}");
                var result = _unitOfWork.AccountsRepository.FindByCondition(x => x.Device == index).FirstOrDefault();
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(CheckIndex)} return {result}");
                if (result == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Information($"{nameof(AccountsService)}, params:  {nameof(CheckIndex)}, error; {ex.Message}, Exception; {ex}");
                return false;
            }

        }
        public AccountsModel? GetById(string id)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(GetById)}, id {id} ");
                var result = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == new Guid(id)).FirstOrDefault();
                var acc = new AccountsModel
                {
                    IdAccount = result.IdAccount.ToString(),
                    PhoneNumber = result.PhoneNumber,
                    Password = result.Password,
                    UserName = result.UserName,
                    Proxy = result.Proxy,
                    FullName = result.FullName,
                    Avatar = result.Avatar,
                    AppId = result.AppId,
                    AppHash = result.AppHash,
                    Session = result.Session,
                    Cookie = result.Cookie,
                    UserAgent = result.UserAgent,
                    IdFile = result.IdFile,
                    Note = result.Note,
                    Interac = result.Interac,
                    Info = result.Info,
                    DateImport = result.DateImport,
                    Activiti = result.Activiti,
                    DateDelete = result.DateDelete,
                    Status = result.Status,
                    Device = result.Device,
                    FolderName = "",
                    IsUsing = false
                };
               // var data = _mapper.Map<AccountsModel>(result);
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(GetById)}, return {result}");
                return acc;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return null;
            }

        }

        public AccountsModel? GetAccountByPhonenumber(string phonenumber)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(GetAccountByPhonenumber)}, email {phonenumber} ");
                var result = _unitOfWork.AccountsRepository.FindByCondition(x => x.PhoneNumber == phonenumber).FirstOrDefault();
                var acc = new AccountsModel
                {
                    IdAccount = result.IdAccount.ToString(),
                    PhoneNumber = result.PhoneNumber,
                    Password = result.Password,
                    UserName = result.UserName,
                    Proxy = result.Proxy,
                    FullName = result.FullName,
                    Avatar = result.Avatar,
                    AppId = result.AppId,
                    AppHash = result.AppHash,
                    Session = result.Session,
                    Cookie = result.Cookie,
                    UserAgent = result.UserAgent,
                    IdFile = result.IdFile,
                    Note = result.Note,
                    Interac = result.Interac,
                    Info = result.Info,
                    DateImport = result.DateImport,
                    Activiti = result.Activiti,
                    DateDelete = result.DateDelete,
                    Status = result.Status,
                    Device = result.Device,
                    FolderName = "",
                    IsUsing = false
                };

               // var data = _mapper.Map<AccountsModel>(result);
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(GetAccountByPhonenumber)}, return {result}");
                return acc;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return null;
            }
            return null;
        }

        public bool UpdateFolder(List<string> idAccounts, string idFile)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateFolder)}, idAccounts  {idAccounts}, idFile {idFile} ");
                var listAccount = new List<Accounts>();
                var _idFile = new Guid(idFile);
                foreach (var id in idAccounts)
                {
                    var _id = new Guid(id);
                    var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == _id).FirstOrDefault();
                    if (acc != null)
                    {
                        acc.IdFile = _idFile;
                        _unitOfWork.AccountsRepository.Update(acc);
                    }
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateFolder)}");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }
        public bool UpdateProxy(List<string> ids_proxies)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateProxy)}, ids_proxies  {ids_proxies} ");
                if (ids_proxies.Any())
                {
                    foreach (var item in ids_proxies)
                    {
                        var items = item.Split('|');
                        var id = new Guid(items[0]);
                        if (!string.IsNullOrEmpty(items[1]))
                        {
                            var proxy = items[1];
                            var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == id).FirstOrDefault();
                            if (acc != null)
                            {
                                acc.Proxy = proxy;
                                _unitOfWork.AccountsRepository.Update(acc);
                            }
                        }
                    }
                    Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateProxy)}");
                    return true;
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateProxy)}");
                return false;

            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }
        public bool UpdateCookies(Guid idAccount, AccountsModel model)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateCookies)}, idAccount  {idAccount}, folder {model.Cookie} ");
                if (!string.IsNullOrEmpty(model.Cookie) && !string.IsNullOrEmpty(model.UserAgent))
                {
                    var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                    if (acc != null)
                    {
                        acc.Cookie = model.Cookie;
                        acc.UserAgent = model.UserAgent;
                        _unitOfWork.AccountsRepository.Update(acc);
                    }
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateCookies)}");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);

                return false;
            }
        }

        public bool UpdateAccountStatus(Guid idAccount, string status)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateAccountStatus)}, idAccount  {idAccount}, status {status} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                if (acc != null)
                {
                    acc.Info = status;
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateAccountStatus)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }
        public bool UpdateAccountSession(Guid idAccount, AccountsModel model)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateAccountSession)}, idAccount  {idAccount} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                if (acc != null)
                {
                    acc.Password = model.Password;
                    acc.Session = model.Session;
                    acc.AppId = model.AppId;
                    acc.AppHash = model.AppHash;
                    acc.Proxy = model.Proxy;
                    acc.Info = model.Info;
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateAccountSession)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }
        public bool UpdateInterac(Guid idAccount, string message)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateInterac)}, idAccount  {idAccount}, message {message} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                if (acc != null)
                {
                    acc.Interac = message;
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateInterac)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }

        public bool UpdateUsername(Guid idAccount, string username)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateUsername)}, idAccount  {idAccount}, message {username} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                if (acc != null)
                {
                    acc.UserName = username;
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateUsername)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }
        public bool UpdateTowFA(Guid idAccount, string towFA)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateTowFA)}, idAccount  {idAccount}, message {towFA} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                if (acc != null)
                {
                    acc.Password = towFA;
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateTowFA)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }

        public bool UpdateFullname(Guid idAccount, string fullname)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateFullname)}, idAccount  {idAccount}, message {fullname} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == idAccount).FirstOrDefault();
                if (acc != null)
                {
                    acc.FullName = fullname;
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateFullname)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }
        public bool UpdateColumn<T>(Guid id, Expression<Func<Accounts, T>> columnExpression, T value)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(UpdateColumn)}, idAccount  {id}, columnName {columnExpression.Body}, value {value} ");
                var acc = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == id).FirstOrDefault();
                if (acc != null)
                {
                    var memberExpr = (MemberExpression)columnExpression.Body;
                    var propInfo = (PropertyInfo)memberExpr.Member;
                    propInfo.SetValue(acc, value);
                    _unitOfWork.AccountsRepository.Update(acc);
                }
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(UpdateColumn)}, acc {acc} ");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return false;
            }
        }

        public AccountsModel? GetAccountById(string id)
        {
            try
            {
                Log.Information($"Start {nameof(AccountsService)}, params:  {nameof(GetById)}, id {id} ");
                var result = _unitOfWork.AccountsRepository.FindByCondition(x => x.IdAccount == new Guid(id)).FirstOrDefault();
                var acc = new AccountsModel
                {
                    IdAccount = result.IdAccount.ToString(),
                    PhoneNumber = result.PhoneNumber,
                    Password = result.Password,
                    UserName = result.UserName,
                    Proxy = result.Proxy,
                    FullName = result.FullName,
                    Avatar = result.Avatar,
                    AppId = result.AppId,
                    AppHash = result.AppHash,
                    Session = result.Session,
                    Cookie = result.Cookie,
                    UserAgent = result.UserAgent,
                    IdFile = result.IdFile,
                    Note = result.Note,
                    Interac = result.Interac,
                    Info = result.Info,
                    DateImport = result.DateImport,
                    Activiti = result.Activiti,
                    DateDelete = result.DateDelete,
                    Status = result.Status,
                    Device = result.Device,
                    FolderName = "",
                    IsUsing = false
                };
                Log.Information($"End {nameof(AccountsService)}, params; {nameof(GetById)}, return {result}");
                return acc;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return null;
            }
        }
    }
}
