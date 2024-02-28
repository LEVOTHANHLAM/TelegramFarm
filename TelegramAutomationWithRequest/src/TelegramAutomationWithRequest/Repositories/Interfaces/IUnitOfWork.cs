using Microsoft.EntityFrameworkCore.Storage;

namespace TelegramAutomationWithRequest.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IUserRepository UserRepository { get; }
        IAccountsRepository AccountsRepository { get; }
        IActionsRepository ActionsRepository { get; }
        IFilessRepository FilessRepository { get; }
        IInteractAccountsRepository InteractAccountsRepository { get; }
        IInteractsRepository InteractsRepository { get; }
        IScriptsRepository ScriptsRepository { get; }

        void SaveChange();
        void SaveChangeAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task EndTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
