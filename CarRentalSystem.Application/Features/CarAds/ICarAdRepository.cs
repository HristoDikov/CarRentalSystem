namespace CarRentalSystem.Application.Features.CarAds
{
    using Contracts;
    using Features.CarAds.Queries.Search;
    using Domain.Models.CarAds;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ICarAdRepository : IRepository<CarAd>
    {
        Task<IEnumerable<CarAdListingModel>> GetCarAdListings(
            string? manufacturer = default,
            CancellationToken cancellationToken = default);

        Task<int> Total(CancellationToken cancellationToken = default);
    }
}
