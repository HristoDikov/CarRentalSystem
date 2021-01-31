namespace CarRentalSystem.Web.Features
{
    using Microsoft.AspNetCore.Mvc;
    using Application.Features.CarAds.Queries.Search;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class CarAdsController : ApiController
    {
        [HttpGet]
        [Route(nameof(Get))]
        public async Task<ActionResult<SearchCarAdsOutputModel>> Get(
            [FromQuery] SearchCarAdsQuery query)
                => await this.Send(query);
    }
}
