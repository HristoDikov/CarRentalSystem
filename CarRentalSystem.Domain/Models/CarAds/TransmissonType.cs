
namespace CarRentalSystem.Domain.Models.CarAds
{
    using Common;
    public class TransmissonType : Enumeration
    {
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