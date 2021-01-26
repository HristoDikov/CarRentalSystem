namespace CarRentalSystem.Infrastructure.Persistence
{
    using CarRentalSystem.Infrastructure.Persistance;
    using Microsoft.EntityFrameworkCore;

    internal class CarRentalDbInitializer : IInitializer
    {
        private readonly CarRentalDbContext db;

        public CarRentalDbInitializer(CarRentalDbContext db) => this.db = db;

        public void Initialize() => this.db.Database.Migrate();
    }
}
