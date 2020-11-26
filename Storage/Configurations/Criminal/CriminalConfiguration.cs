namespace Storage.Configurations.Criminal
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalConfiguration : IEntityTypeConfiguration<Criminal>
    {
        public void Configure(EntityTypeBuilder<Criminal> builder)
        {
            builder.HasOne(x => x.CriminalStatus)
               .WithMany(x => x.Criminals)
               .HasForeignKey(x => x.CriminalStatusId)
               .IsRequired(false);

            builder.HasMany(x => x.CriminalCases)
                .WithMany(x => x.Criminals);

            builder.HasMany(x => x.CriminalStatusHistories)
                .WithOne(x => x.Criminal)
                .HasForeignKey(x => x.CriminalId)
                .IsRequired(true);

            builder.HasMany(x => x.PreventiveMeasureDecisions)
               .WithOne(x => x.Criminal)
               .HasForeignKey(x => x.CriminalId)
               .IsRequired(true);
        }
    }
}
