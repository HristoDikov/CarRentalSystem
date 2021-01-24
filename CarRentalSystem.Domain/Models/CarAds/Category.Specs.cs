namespace CarRentalSystem.Domain.Models.CarAds
{
    using Exceptions;
    using FluentAssertions;
    using System;
    using Xunit;
    public class CategorySpecs
    {
        [Fact]
        public void ValidCategoryShouldNotThrowException()
        {
            // Act

            Action act = () => new Category("SomeCategory", "SomeDescription");

            // Assert

            act.Should().NotThrow<InvalidCarAdExceptions>();
        }

        [Fact]
        public void InvalidCategoryNameShouldThrowException()
        {
            // Act

            Action act = () => new Category("", "SomeDescr");

            //Assert

            act.Should().Throw<InvalidCarAdExceptions>();
        }
    }
}
