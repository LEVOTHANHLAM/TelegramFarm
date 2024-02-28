using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Repositories
{
    public class InteractAccountsRepository : GenericRepository<InteractAccounts>, IInteractAccountsRepository
    {
        public InteractAccountsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
