
namespace CarRentalSystem.Domain.Models.CarAds
{
    using Common;
    public class TransmissonType : Enumeration
    {
        public static readonly TransmissonType Manual = new TransmissonType(1, nameof(Manual));
        public static readonly TransmissonType Automatic = new TransmissonType(2, nameof(Automatic));

        private TransmissonType(int value)
            : this(value, FromValue<TransmissonType>(value).Name)
        {
        }

        private TransmissonType(int value, string name)
            : base(value, name)
        {
        }
    }
}