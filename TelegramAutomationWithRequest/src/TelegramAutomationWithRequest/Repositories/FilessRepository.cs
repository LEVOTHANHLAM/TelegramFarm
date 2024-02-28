using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Entities;
using TelegramAutomationWithRequest.Repositories.Interfaces;

namespace TelegramAutomationWithRequest.Repositories
{
    public class FilessRepository : GenericRepository<Filess>, IFilessRepository
    {
        public FilessRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
