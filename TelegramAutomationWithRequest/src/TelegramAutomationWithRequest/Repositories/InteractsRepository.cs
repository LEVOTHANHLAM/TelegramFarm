using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Repositories
{
    public class InteractsRepository : GenericRepository<Interacts>, IInteractsRepository
    {
        public InteractsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
