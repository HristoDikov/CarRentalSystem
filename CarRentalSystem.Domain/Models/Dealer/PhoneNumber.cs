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

            this.Number = number;
        }

        public string Number { get; }

        public static implicit operator string(PhoneNumber number) => number.Number;

        public static implicit operator PhoneNumber(string number) => new PhoneNumber(number);

        private void Validate(string phoneNumber)
      => Guard.ForStringLength<InvalidPhoneNumberException>(
          phoneNumber,
          MinPhoneNumberLength,
          MaxPhoneNumberLength,
          nameof(PhoneNumber));
    }
}
