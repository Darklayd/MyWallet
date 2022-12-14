//Тут ми описуєм нашу базуданих, підключаєм таблиці і їх налаштування, також додаєм сіди

using Core.Entities.CardEntity;
using Core.Entities.CashEntity;
using Core.Entities.TypesMoney;
using Core.Entities.WalletEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Cash> Cash { get; set; }
        public DbSet<TypeMoney> TypesMonies { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Seed().Wait();
            base.OnModelCreating(builder);
        }
    }
}
