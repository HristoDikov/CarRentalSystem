namespace CarRentalSystem.Infrastructure.Persistance
{
    using CarRentalSystem.Infrastructure.Identity;
    using Domain.Models.CarAds;
    using Domain.Models.Dealer;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    internal class CarRentalDbContext : IdentityDbContext<User>
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

            base.OnModelCreating(builder);
        }
    }
}
