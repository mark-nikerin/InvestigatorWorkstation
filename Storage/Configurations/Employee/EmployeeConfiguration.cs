namespace Storage.Configurations.Employee
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(x => x.Position)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.PositionId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.Rank)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.RankId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.PositionHistories)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.RankHistories)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.InspectionMaterialMovements)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.CriminalCaseMovements)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.CrimeReports)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.PreventiveMeasureDecisions)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
