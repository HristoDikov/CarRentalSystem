namespace CarRentalSystem.Infrastructure.Persistance
{
    using Domain.Models.CarAds;
    using Domain.Models.Dealer;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    internal class CarRentalDbContext : DbContext
    {
        public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options)
            : base(options)
        {

        }

        public DbSet<CarAd> CarAds { get; set; } = default!;

        public DbSet<Category> Categories { get; set; } = default!;

        public DbSet<Manufacturer> Manufacturers { get; set; } = default!;

        public DbSet<Dealer> Dealers{ get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
