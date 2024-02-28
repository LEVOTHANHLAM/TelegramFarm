using Microsoft.EntityFrameworkCore.Storage;
using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Repositories.Interfaces;
using TelegramAutomationWithRequest.Repositories;

namespace TelegramAutomationWithRequest.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;


        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            AccountsRepository = new AccountsRepository(dbContext);
            ActionsRepository = new ActionsRepository(dbContext);
            FilessRepository = new FilessRepository(dbContext);
            InteractAccountsRepository = new InteractAccountsRepository(dbContext);
            InteractsRepository = new InteractsRepository(dbContext);
            ScriptsRepository = new ScriptsRepository(dbContext);


        }
        public IAccountsRepository AccountsRepository { get; private set; }

        public IActionsRepository ActionsRepository { get; private set; }

        public IFilessRepository FilessRepository { get; private set; }

        public IInteractAccountsRepository InteractAccountsRepository { get; private set; }

        public IInteractsRepository InteractsRepository { get; private set; }

        public IScriptsRepository ScriptsRepository { get; private set; }

        public void Dispose() => _dbContext.Dispose();

        public void SaveChange()
        {
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }
        public void SaveChangeAsync()
        {
            _dbContext.SaveChangesAsync();
        }
        public Task<IDbContextTransaction> BeginTransactionAsync() => _dbContext.Database.BeginTransactionAsync();

        public async Task EndTransactionAsync()
        {
            //await SaveChangesAsync();
            await _dbContext.Database.CommitTransactionAsync();
        }
        public Task RollbackTransactionAsync() => _dbContext.Database.RollbackTransactionAsync();

    }
}
