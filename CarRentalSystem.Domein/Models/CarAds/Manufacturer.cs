
namespace CarRentalSystem.Domein.Models.CarAds
{
    using Exceptions;
    using Common;

    using static ModelConstants.Common;

    public class Manufacturer : Entity<int>
    {
        internal Manufacturer(string name)
        {
            this.Validate(name);
            this.Name = name;
        }

        public string Name { get; }

        private void Validate(string name)
        {
            Guard.ForStringLength<InvalidCarAdExceptions>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
    }
}