namespace CarRentalSystem.Infrastructure.Persistance.Repositories
{
    using CarRentalSystem.Application.Contracts;
    using CarRentalSystem.Domain.Common;
    using System.Linq;

    internal abstract class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        private readonly CarRentalDbContext db;

        protected DataRepository(CarRentalDbContext db) => this.db = db;

        protected IQueryable<TEntity> All() => this.db.Set<TEntity>();
    }
}
