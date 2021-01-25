
namespace CarRentalSystem.Infrastructure.Persistance.Repositories
{
    using CarRentalSystem.Application.Contracts;
    using CarRentalSystem.Domain.Common;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    internal class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        private readonly CarRentalDbContext db;

        public DataRepository(CarRentalDbContext db) => this.db = db;

        public IQueryable<TEntity> All() => this.db.Set<TEntity>();

        public Task<int> SaveChanges(CancellationToken cancellationToken = default)
            => this.db.SaveChangesAsync(cancellationToken);
    }
}
