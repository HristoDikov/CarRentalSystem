namespace CarRentalSystem.Web.Features
{
    using Domain.Models.Dealer;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Domain.Models.CarAds;
    using System.Linq;
    using Application.Contracts;

    [ApiController]
    [Route("[controller]")]
    public class CarAdsController : ControllerBase
    {
        private readonly IRepository<CarAd> carAds;

        public CarAdsController(IRepository<CarAd> carAds)
            => this.carAds = carAds;

        [HttpGet]
        public IEnumerable<CarAd> Get() => this.carAds
            .All()
            .Where(c => c.IsAvailable);
    }
}
