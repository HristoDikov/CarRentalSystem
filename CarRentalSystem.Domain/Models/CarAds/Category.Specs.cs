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

            Action act = () => new Category("SomeCategory", "SomeDescriptionSomeDescriptionSomeDescription");

            // Assert

            act.Should().NotThrow<InvalidCarAdExceptions>();
        }

        [Fact]
        public void InvalidCategoryNameShouldThrowException()
        {
            // Act

            Action act = () => new Category("", "SomeDescrSomeDescriptionSomeDescriptionSomeDescription");

            //Assert

            act.Should().Throw<InvalidCarAdExceptions>();
        }
    }
}
