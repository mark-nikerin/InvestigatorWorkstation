namespace Storage.Configurations.PreventiveMeasure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models.PreventiveMeasure;

    public class PreventiveMeasureDecisionConfiguration : IEntityTypeConfiguration<PreventiveMeasureDecision>
    {
        public void Configure(EntityTypeBuilder<PreventiveMeasureDecision> builder)
        {
            builder.HasOne(x => x.PreventiveMeasure)
                .WithMany(x => x.PreventiveMeasureDecisions)
                .HasForeignKey(x => x.PreventiveMeasureId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.Employee)
               .WithMany(x => x.PreventiveMeasureDecisions)
               .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.Criminal)
               .WithMany(x => x.PreventiveMeasureDecisions)
               .HasForeignKey(x => x.CriminalId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
