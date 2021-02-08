namespace Storage.Configurations.CriminalCase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalCaseMovementConfiguration : IEntityTypeConfiguration<CriminalCaseMovement>
    {
        public void Configure(EntityTypeBuilder<CriminalCaseMovement> builder)
        {
            builder.HasOne(x => x.Decision)
                .WithMany(x => x.CriminalCaseMovements)
                .HasForeignKey(x => x.DecisionId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.CriminalCase)
                .WithMany(x => x.CriminalCaseMovements)
                .HasForeignKey(x => x.CriminalCaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.CriminalCaseMovements)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
