namespace CarRentalSystem.Domain.Factories.Dealers
{
    using CarRentalSystem.Domain.Models.Dealer;
    public interface IDealerFactory : IFactory<Dealer>
    {
        public IDealerFactory WithName(string name);

        public IDealerFactory WithPhoneNumber(string phoneNumber);

    }
}
