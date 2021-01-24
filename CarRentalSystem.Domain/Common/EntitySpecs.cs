namespace CarRentalSystem.Domain.Common
{
    using FluentAssertions;
    using Models.CarAds;
    using Xunit;
    public class EntitySpecs
    {
        [Fact]
        public void EntitiesWithEqualIdsShouldBeEqual() 
        {
            //Arrange
            var first = new Manufacturer("Manufacturer").SetId(1);
            var second = new Manufacturer("secondManufacturer").SetId(1);

            //Act
            var result = first == second;

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void EntitiesWithDifferentIdsShouldNotBeEqual()
        {
            //Arrange
            var first = new Manufacturer("Manufacturer").SetId(1);
            var second = new Manufacturer("secondManufacturer").SetId(2);

            //Act
            var result = first == second;

            //Assert
            result.Should().BeFalse();
        }

    }

    internal static class EntityExtensions
    {
        public static Entity<T> SetId<T>(this Entity<T> entity, int id)
            where T : struct
        {
            entity
                .GetType()
                .BaseType!
                .GetProperty(nameof(Entity<T>.Id))!
                .GetSetMethod(true)!
                .Invoke(entity, new object[] { id });

            return entity;
        }
    }
}
