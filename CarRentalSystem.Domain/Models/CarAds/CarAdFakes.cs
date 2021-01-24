
namespace CarRentalSystem.Domain.Models.CarAds
{
    using FakeItEasy;
    using System;

    public class CarAdFakes
    {
        public class CarAdDummyFactory : IDummyFactory
        {
            public Priority Priority => Priority.Default;

            public bool CanCreate(Type type) => true;

            public object? Create(Type type)
                => new CarAd(
                    new Manufacturer("Some manifacturer"),
                    "Some model",
                    new Category("Category", "Some description"),
                    "https://somevalidUrl.bg",
                    200,
                    new Options(true, 5, TransmissonType.Manual),
                    true);
        }
    }
}
