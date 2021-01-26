namespace CarRentalSystem.Web.Features
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Domain.Models.CarAds;
    using System.Linq;
    using Application.Contracts;
    using Microsoft.Extensions.Options;
    using Application;

    [ApiController]
    [Route("[controller]")]
    public class CarAdsController : ControllerBase
    {
        private readonly IRepository<CarAd> carAds;
        private readonly IOptions<ApplicationSettings> settings;

        public CarAdsController(IRepository<CarAd> carAds, IOptions<ApplicationSettings> settings)
        {
            this.carAds = carAds;
            this.settings = settings;
        }

        [HttpGet]
        public object Get() => new
        {
            Settings = this.settings,
            CarAds = this.carAds
            .All()
            .Where(c => c.IsAvailable)
            .ToList()
        };
    }
}
