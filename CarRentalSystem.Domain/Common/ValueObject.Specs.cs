namespace CarRentalSystem.Domain.Common
{
    using CarRentalSystem.Domain.Models.CarAds;
    using FluentAssertions;
    using Xunit;
    public class ValueObjectSpecs
    {
        [Fact]
        public void ValueObjectsWithEqualPropertiesShouldBeEqual()
        {
            // Arrange
            var first = new Options(true, 2, TransmissonType.Automatic);
            var second = new Options(true, 2, TransmissonType.Automatic);

            // Act
            var result = first == second;

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void ValueObjectsWithDifferentPropertiesShouldNotBeEqual()
        {
            // Arrange
            var first = new Options(true, 3, TransmissonType.Automatic);
            var second = new Options(false, 2, TransmissonType.Manual);

            // Act
            var result = first == second;

            // Assert
            result.Should().BeFalse();
        }
    }
}
