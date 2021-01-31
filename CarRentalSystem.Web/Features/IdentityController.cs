namespace CarRentalSystem.Web.Features
{
    using System.Threading.Tasks;
    using Application;
    using Application.Features.Identity;
    using Application.Features.Identity.Commands.CreateUser;
    using Application.Features.Identity.Commands.LoginUser;
    using Web.Common;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class IdentityController : ApiController
    {
        private readonly IIdentity identity;

        public IdentityController(IIdentity identity) => this.identity = identity;

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult<Result>> Register(RegisterUserCommand command)
            => await this.Send(command);
       

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginOutputModel>> Login(LoginUserCommand command)
            => await this.Mediator.Send(command).ToActionResult();
    }
}
