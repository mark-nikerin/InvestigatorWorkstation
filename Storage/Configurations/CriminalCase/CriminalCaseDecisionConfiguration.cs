namespace Storage.Configurations.CriminalCase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalCaseDecisionConfiguration : IEntityTypeConfiguration<CriminalCaseDecision>
    {
        public void Configure(EntityTypeBuilder<CriminalCaseDecision> builder)
        {
            builder.HasMany(x => x.CriminalCaseMovements)
               .WithOne(x => x.Decision)
               .HasForeignKey(x => x.DecisionId)
               .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
