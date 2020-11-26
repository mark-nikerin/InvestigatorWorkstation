namespace Storage.Configurations.PreventiveMeasure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class PreventiveMeasureDecisionConfiguration : IEntityTypeConfiguration<PreventiveMeasureDecision>
    {
        public void Configure(EntityTypeBuilder<PreventiveMeasureDecision> builder)
        {
            builder.HasOne(x => x.PreventiveMeasure)
                .WithMany(x => x.PreventiveMeasureDecisions)
                .HasForeignKey(x => x.PreventiveMeasureId)
                .IsRequired(true);

            builder.HasOne(x => x.Employee)
               .WithMany(x => x.PreventiveMeasureDecisions)
               .HasForeignKey(x => x.EmployeeId)
               .IsRequired(true);

            builder.HasOne(x => x.Criminal)
               .WithMany(x => x.PreventiveMeasureDecisions)
               .HasForeignKey(x => x.CriminalId)
               .IsRequired(true);
        }
    }
}
