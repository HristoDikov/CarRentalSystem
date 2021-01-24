namespace CarRentalSystem.Infrastructure.Persistance.Configuration
{
    using Domain.Models.CarAds;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static Domain.Models.ModelConstants.CarAd;
    using static Domain.Models.ModelConstants.Common;
    public class CarAdConfiguration : IEntityTypeConfiguration<CarAd>
    {
        public void Configure(EntityTypeBuilder<CarAd> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .HasOne(c => c.Manufacturer)
                .WithMany()
                .HasForeignKey("ManufacturerId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(c => c.Model)
                .IsRequired()
                .HasMaxLength(MaxModelLength);

            builder
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey("CategoryId");

            builder
               .Property(c => c.ImageUrl)
               .IsRequired()
               .HasMaxLength(MaxUrlLength);

            builder
               .Property(c => c.PricePerDay)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

            builder
                .OwnsOne(c => c.Options, o =>
                {
                    o.WithOwner();

                    o.Property(op => op.NumberOfSeats);
                    o.Property(op => op.HasClimateControl);

                    o.OwnsOne(
                        op => op.TransmissionType,
                        t =>
                        {
                            t.WithOwner();

                            t.Property(tr => tr.Value);
                        });
                });

            builder.
                Property(c => c.IsAvailable)
                .IsRequired();

        }
    }
}
