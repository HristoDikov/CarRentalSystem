namespace CarRentalSystem.Domain.Models.CarAds
{
    using CarRentalSystem.Domain.Common;
    using CarRentalSystem.Domain.Exceptions;

    using static ModelConstants.Common;
    class CarAd : Entity<int>, IAggregateRoot
    {
        public CarAd(Manufacturer manufacturer,
            string model,
            Category category,
            string imageUr,
            decimal pricePerDay,
            Options options,
            bool isAvailable)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Category = category;
            this.ImageUrl = imageUr;
            this.PricePerDay = pricePerDay;
            this.Options = options;
            this.IsAvailable = isAvailable;
        }

        public Manufacturer Manufacturer { get; }

        public string Model { get; }

        public Category Category { get; }

        public string ImageUrl { get; }

        public decimal PricePerDay { get; set; }

        public Options Options { get; }

        public bool IsAvailable { get; private set; }

        private void ChangeAvailability() => this.IsAvailable = !this.IsAvailable;

        private void Validate(string model, string imageUrl, decimal pricePerDay)
        {
            Guard.ForStringLength<InvalidCarAdExceptions>(model,
                MinNameLength,
                MaxNameLength,
                nameof(this.Model));

            Guard.ForValidUrl<InvalidCarAdExceptions>(
                imageUrl,
                nameof(this.ImageUrl));

            Guard.AgainstOutOfRange<InvalidCarAdExceptions>(
                pricePerDay,
                Zero,
                decimal.MaxValue,
                nameof(this.PricePerDay));
        }
    }
}
