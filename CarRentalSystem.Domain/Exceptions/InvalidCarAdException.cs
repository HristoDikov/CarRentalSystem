namespace CarRentalSystem.Domain.Exceptions
{
    public class InvalidCarAdExceptions : BaseDomainException
    {
        public InvalidCarAdExceptions()
        {
        }

        public InvalidCarAdExceptions(string message) => this.Message = message;
    }
}
