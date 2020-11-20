namespace Storage.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class PreventiveMeasureConfiguration : IEntityTypeConfiguration<PreventiveMeasure>
    {
        public void Configure(EntityTypeBuilder<PreventiveMeasure> builder)
        {
           /* builder.HasOne(x => x.PreventiveMeasureDecision)
                .WithMany(x => x.PreventiveMeasureDecision)
                .HasForeignKey(x => x.PreventiveMeasure)
                .IsRequired();

            builder.HasOne(x => x.Rank)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.RankId)
                .IsRequired();

            builder.HasMany(x => x.InspectionMaterialMovements)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();

            builder.HasMany(x => x.CriminalCaseMovements)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();

            builder.HasMany(x => x.CrimeReports)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();

            builder.HasMany(x => x.PreventiveMeasureDecisions)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();*/
        }
    }
}
