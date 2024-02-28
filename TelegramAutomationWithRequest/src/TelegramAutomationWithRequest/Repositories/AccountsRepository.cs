using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Repositories
{
    public class AccountsRepository : GenericRepository<Accounts>, IAccountsRepository
    {
        public AccountsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
