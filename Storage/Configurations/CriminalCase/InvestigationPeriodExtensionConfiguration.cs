namespace Storage.Configurations.CriminalCase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class InvestigationPeriodExtensionConfiguration : IEntityTypeConfiguration<InvestigationPeriodExtension>
    {
        public void Configure(EntityTypeBuilder<InvestigationPeriodExtension> builder)
        {
            builder.HasOne(x => x.CriminalCase)
                .WithMany(x => x.InvestigationPeriodExtensions)
                .HasForeignKey(x => x.CriminalCaseId)
                .IsRequired(true);  
        }
    }
}
