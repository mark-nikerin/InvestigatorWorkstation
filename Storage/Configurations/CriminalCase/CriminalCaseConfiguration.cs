namespace Storage.Configurations.CriminalCase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalCaseConfiguration : IEntityTypeConfiguration<CriminalCase>
    {
        public void Configure(EntityTypeBuilder<CriminalCase> builder)
        {
            builder.HasOne(x => x.CriminalCaseAuthority)
                .WithMany(x => x.CriminalCases)
                .HasForeignKey(x => x.CriminalCaseAuthorityId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.InvestigationPeriodExtensions)
                .WithOne(x => x.CriminalCase)
                .HasForeignKey(x => x.CriminalCaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.CriminalCaseMovements)
                .WithOne(x => x.CriminalCase)
                .HasForeignKey(x => x.CriminalCaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Criminals)
               .WithMany(x => x.CriminalCases);
        }
    }
}
