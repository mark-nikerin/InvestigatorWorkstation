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
                .IsRequired(false);

            builder.HasOne(x => x.CriminalCase)
                .WithMany(x => x.CriminalCaseMovements)
                .HasForeignKey(x => x.CriminalCaseId)
                .IsRequired(false); 

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.CriminalCaseMovements)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired(false);
        }
    }
}
