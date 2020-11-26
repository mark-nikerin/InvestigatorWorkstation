namespace Storage.Configurations.Criminal
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalStatusConfiguration : IEntityTypeConfiguration<CriminalStatus>
    {
        public void Configure(EntityTypeBuilder<CriminalStatus> builder)
        {
            builder.HasMany(x => x.Criminals)
                .WithOne(x => x.CriminalStatus)
                .HasForeignKey(x => x.CriminalStatusId)
                .IsRequired(true);

            builder.HasMany(x => x.CriminalStatusHistories)
                .WithOne(x => x.CriminalStatus)
                .HasForeignKey(x => x.CriminalStatusId)
                .IsRequired(true);
        }
    }
}
