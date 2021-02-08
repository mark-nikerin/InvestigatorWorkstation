namespace Storage.Configurations.Criminal
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class ComplicityTypeConfiguration : IEntityTypeConfiguration<ComplicityType>
    {
        public void Configure(EntityTypeBuilder<ComplicityType> builder)
        {
            builder.HasMany(x => x.CriminalStatusHistories)
                .WithOne(x => x.ComplicityType)
                .HasForeignKey(x => x.ComplicityTypeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
