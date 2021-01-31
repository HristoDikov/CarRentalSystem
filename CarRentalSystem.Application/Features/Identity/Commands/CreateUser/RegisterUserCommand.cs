﻿namespace CarRentalSystem.Application.Features.Identity.Commands.CreateUser
{
    using Contracts;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class RegisterUserCommand : UserInputModel, IRequest<Result>
    {
        public RegisterUserCommand(string email, string password)
          : base(email, password)
        {
        }

        public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result>
        {
            private readonly IIdentity identity;

            public RegisterUserCommandHandler(IIdentity identity) => this.identity = identity;


            public async Task<Result> Handle(
                RegisterUserCommand request, 
                CancellationToken cancellationToken)
                => await this.identity.Register(request);
        }
    }
}
