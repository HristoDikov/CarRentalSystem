namespace CarRentalSystem.Infrastructure.Persistance.Configuration
{
    using CarRentalSystem.Infrastructure.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder.
                HasOne(u => u.Dealer)
                .WithOne()
                .HasForeignKey<User>("DealerId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
