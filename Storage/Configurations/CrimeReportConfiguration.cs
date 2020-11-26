namespace Storage.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CrimeReportConfiguration : IEntityTypeConfiguration<CrimeReport>
    {
        public void Configure(EntityTypeBuilder<CrimeReport> builder)
        {
            builder.HasOne(x => x.Qualification)
                .WithMany(x => x.CrimeReports)
                .HasForeignKey(x => x.QualificationId)
                .IsRequired(false);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.CrimeReports)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired(true);
        }
    }
}
