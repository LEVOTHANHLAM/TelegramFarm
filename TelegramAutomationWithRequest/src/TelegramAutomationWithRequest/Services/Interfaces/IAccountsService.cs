using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Model;

namespace TelegramAutomationWithRequest.Services.Interfaces
{
    public interface IAccountsService
    {
        void CreateList(List<Accounts> accounts);
        AccountsModel? GetAccountByPhonenumber(string phonenumber);
        AccountsModel? GetAccountById(string id);
        List<AccountsModel> GetAll();
        bool DeleteList(List<string> idAccounts);
        bool UpdateFolder(List<string> idAccounts, string idFile);
        bool UpdateProxy(List<string> ids_proxies);
        bool UpdateAccountStatus(Guid idAccount, string status);
        bool UpdateCookies(Guid idAccount, AccountsModel model);
        bool UpdateInterac(Guid idAccount, string message);
        bool UpdateUsername(Guid idAccount, string username);
        bool UpdateFullname(Guid idAccount, string fullname);
        bool UpdateAccountSession(Guid idAccount, AccountsModel model);
        bool UpdateColumn<T>(Guid id, Expression<Func<Accounts, T>> columnExpression, T value);
        bool CheckIndex(string index);
        bool UpdateTowFA(Guid idAccount, string towFA);
    }
}
