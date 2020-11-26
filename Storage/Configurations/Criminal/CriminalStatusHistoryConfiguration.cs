namespace Storage.Configurations.Criminal
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalStatusHistoryConfiguration : IEntityTypeConfiguration<CriminalStatusHistory>
    {
        public void Configure(EntityTypeBuilder<CriminalStatusHistory> builder)
        {
            builder.HasOne(x => x.Qualification)
                .WithMany(x => x.CriminalStatusHistories)
                .HasForeignKey(x => x.QualificationId)
                .IsRequired(false);

            builder.HasOne(x => x.CriminalStatus)
                .WithMany(x => x.CriminalStatusHistories)
                .HasForeignKey(x => x.CriminalStatusId)
                .IsRequired(true);

            builder.HasOne(x => x.ComplicityType)
                .WithMany(x => x.CriminalStatusHistories)
                .HasForeignKey(x => x.ComplicityTypeId)
                .IsRequired(true);

            builder.HasOne(x => x.Criminal)
                .WithMany(x => x.CriminalStatusHistories)
                .HasForeignKey(x => x.CriminalId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
