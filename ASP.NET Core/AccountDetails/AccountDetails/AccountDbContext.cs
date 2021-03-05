using AccountDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountDetails
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
    }
}
