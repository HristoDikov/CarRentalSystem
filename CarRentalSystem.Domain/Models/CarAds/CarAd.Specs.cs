using FakeItEasy;
using FluentAssertions;
using Xunit;

namespace CarRentalSystem.Domain.Models.CarAds
{
    public class CarAdSpecs
    {
        [Fact]
        public void ChangeAvailabilityShouldMutateIsAvailable() 
        {
            // Act

            var carAd = A.Dummy<CarAd>();

            // Arrange

            carAd.ChangeAvailability();

            //Assert

            carAd.IsAvailable.Should().BeFalse();
        }
    }
}
