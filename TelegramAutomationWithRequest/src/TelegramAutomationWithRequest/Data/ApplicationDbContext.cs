using Microsoft.EntityFrameworkCore;
using TelegramAutomationWithRequest.Entities;

namespace TelegramAutomationWithRequest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actions>()
                .HasKey(e => e.IdAction); // Xác định khóa chính là thuộc tính IdAction
            modelBuilder.Entity<Accounts>()
                .HasKey(e => e.IdAccount); // Xác định khóa chính là thuộc tính IdAccount
            modelBuilder.Entity<Filess>()
                .HasKey(e => e.IdFile); // Xác định khóa chính là thuộc tính IdFile
            modelBuilder.Entity<InteractAccounts>()
                .HasKey(e => e.IdInteractaccount); // Xác định khóa chính là thuộc tính IdInteractaccount
            modelBuilder.Entity<Scripts>()
                .HasKey(e => e.IdScript); // Xác định khóa chính là thuộc tính IdScript
            modelBuilder.Entity<Interacts>()
                .HasKey(e => e.IdInteract); // Xác định khóa chính là thuộc tính IdInteract

        }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Actions> Actions { get; set; }
        public DbSet<Filess> Files { get; set; }
        public DbSet<InteractAccounts> InteractAccounts { get; set; }
        public DbSet<Scripts> Scripts { get; set; }
        public DbSet<Interacts> Interacts { get; set; }
    }
}
