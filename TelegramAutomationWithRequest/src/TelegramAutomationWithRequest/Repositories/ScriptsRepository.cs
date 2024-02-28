using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Repositories
{
    public class ScriptsRepository : GenericRepository<Scripts>, IScriptsRepository
    {
        public ScriptsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
