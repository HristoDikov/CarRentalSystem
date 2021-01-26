namespace CarRentalSystem.Application.Contracts
{
    using Application.Common;
    using Application.Features.Identity;
    using System.Threading.Tasks;

    public interface IIdentity
    {
        Task<Result> Register(UserInputModel userInput);

        Task<Result<LoginOutputModel>> Login(UserInputModel userInput);
    }
}
