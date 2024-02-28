using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Repositories
{
    public class ActionsRepository : GenericRepository<Actions>, IActionsRepository
    {
        public ActionsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
