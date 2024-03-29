﻿namespace CarRentalSystem.Domain.Models.CarAds
{
    using Exceptions;
    using Common;
    using static ModelConstants.Options;

    public class Options : ValueObject
    {
        internal Options(bool hasClimateControl, int numberOfSeats, TransmissonType transmissonType) 
        {
            this.Validate(numberOfSeats);

            this.HasClimateControl = hasClimateControl;
            this.NumberOfSeats = numberOfSeats;
            this.TransmissionType = transmissonType;
        }

        private Options(bool hasClimateControl, int numberOfSeats)
        {
            this.HasClimateControl = hasClimateControl;
            this.NumberOfSeats = numberOfSeats;

            this.TransmissionType = null!;
        }

        public bool HasClimateControl { get; }
        public int NumberOfSeats { get; }
        public TransmissonType TransmissionType { get; }

        private void Validate(int numberOfSeats)
        {
            Guard.AgainstOutOfRange<InvalidOptionsException>(
                numberOfSeats, 
                MinNumberOfSeats, 
                MaxNumberOfSeats, 
                nameof(this.NumberOfSeats));
        }
    }
}