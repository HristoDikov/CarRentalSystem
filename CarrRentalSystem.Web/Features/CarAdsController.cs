namespace CarRentalSystem.Web.Features
{
    using Domain.Models.Dealer;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Domain.Models.CarAds;
    using System.Linq;

    [ApiController]
    [Route("[controller]")]
    public class CarAdsController : ControllerBase
    {
        private static readonly Dealer dealer = new Dealer("Dealer", "+123523523");

        [HttpGet]
        public IEnumerable<CarAd> Get() => dealer
            .CarAds
            .Where(c => c.IsAvailable);
    }
}
