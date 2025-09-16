using CityinBooking.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityinBoooking.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<SubAgency> SubAgencies { get; set; }
        public DbSet<Markup> Markups { get; set; }
        public DbSet<MarkupAgency> MarkupAgencies { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountAgency> DiscountAgencies { get; set; }
        public DbSet<VoidService> VoidServices { get; set; }
        public DbSet<VoidServiceAgency> VoidServiceAgencies { get; set; }
        public DbSet<WalletSetting> WalletSetting { get; set; }
        public DbSet<WalletTransaction> WalletTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}