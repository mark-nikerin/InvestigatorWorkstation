namespace Storage.Configurations
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
                .IsRequired();
        }
    }
}
