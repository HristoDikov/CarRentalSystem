namespace CarRentalSystem.Domain.Models.Dealer
{
    using Exceptions;
    using Common;

    using static ModelConstants.PhoneNumber;

    public class PhoneNumber : ValueObject
    {
        internal PhoneNumber(string number)
        {
            this.Validate(number);

            if (!number.StartsWith(PhoneNumberFirstSymbol))
            {
                throw new InvalidPhoneNumberException($"Phone number must start with a '{PhoneNumberFirstSymbol}'.");
            }
        }


        private void Validate(string phoneNumber)
      => Guard.ForStringLength<InvalidPhoneNumberException>(
          phoneNumber,
          MinPhoneNumberLength,
          MaxPhoneNumberLength,
          nameof(PhoneNumber));
    }
}
