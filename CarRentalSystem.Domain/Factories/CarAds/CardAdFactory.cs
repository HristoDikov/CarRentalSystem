using CarRentalSystem.Domain.Exceptions;
using CarRentalSystem.Domain.Models.CarAds;

namespace CarRentalSystem.Domain.Factories.CarAds
{
    public class CardAdFactory : ICarAdFactory
    {

        private Manufacturer carAdManufacturer = default!;
        private string carAdModel = default!;
        private Category carAdCategory = default!;
        private string carAdImageUrl = default!;
        private decimal carAdPricePerDay = default!;
        private Options carAdOptions = default!;

        private bool manufacturerSet = false;
        private bool categorySet = false;
        private bool optionsSet = false;

        public ICarAdFactory WithCategory(string name, string description)
            => this.WithCategory(new Category(name, description));

        public ICarAdFactory WithCategory(Category category)
        {
            this.carAdCategory = category;
            this.categorySet = true;

            return this;
        }

        public ICarAdFactory WithImageUrl(string imageUrl)
        {
            this.carAdImageUrl = imageUrl;
            return this;
        }

        public ICarAdFactory WithManufacturer(string name)
            => this.WithManufacturer(new Manufacturer(name));

        public ICarAdFactory WithManufacturer(Manufacturer manufacturer)
        {
            this.carAdManufacturer = manufacturer;
            manufacturerSet = true;

            return this;
        }

        public ICarAdFactory WithModel(string model)
        {
            this.carAdModel = model;
            return this;
        }

        public ICarAdFactory WithOptions(bool hasClimateControl, int numberOfSeats, TransmissonType transmissonType)
            => this.WithOptions(new Options(hasClimateControl, numberOfSeats, transmissonType));

        public ICarAdFactory WithOptions(Options options)
        {
            this.carAdOptions = options;
            optionsSet = true;

            return this;
        }

        public ICarAdFactory WithPricePerDay(decimal pricePerDay)
        {
            this.carAdPricePerDay = pricePerDay;
            return this;
        }

        public CarAd Build()
        {
            if (!this.categorySet || !this.manufacturerSet || !this.optionsSet)
            {
               throw new InvalidCarAdExceptions("Manufacturer, category and options must have a value.");
            }

            return new CarAd(
               this.carAdManufacturer,
               this.carAdModel,
               this.carAdCategory,
               this.carAdImageUrl,
               this.carAdPricePerDay,
               this.carAdOptions,
               true);
        }
    }
}
