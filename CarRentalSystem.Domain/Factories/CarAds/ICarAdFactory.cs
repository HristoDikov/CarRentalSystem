namespace CarRentalSystem.Domain.Factories.CarAds
{
    using CarRentalSystem.Domain.Models.CarAds;
    public interface ICarAdFactory : IFactory<CarAd>
    {
        public ICarAdFactory WithManufacturer(string name);

        public ICarAdFactory WithManufacturer(Manufacturer manufacturer);

        public ICarAdFactory WithModel(string model);

        public ICarAdFactory WithCategory(string name, string description);

        public ICarAdFactory WithCategory(Category category);

        public ICarAdFactory WithImageUrl(string imageUrl);

        public ICarAdFactory WithPricePerDay(decimal pricePerDay);

        public ICarAdFactory WithOptions(
            bool hasClimateControl,
            int numberOfSeats,
            TransmissonType transmissonType);

        public ICarAdFactory WithOptions(Options options);
    }
}
