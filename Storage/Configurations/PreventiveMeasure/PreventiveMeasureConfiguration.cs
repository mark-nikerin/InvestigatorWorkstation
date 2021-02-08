namespace Storage.Configurations.PreventiveMeasure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models.PreventiveMeasure;

    public class PreventiveMeasureConfiguration : IEntityTypeConfiguration<PreventiveMeasure>
    {
        public void Configure(EntityTypeBuilder<PreventiveMeasure> builder)
        {
            builder.HasMany(x => x.PreventiveMeasureDecisions)
                .WithOne(x => x.PreventiveMeasure)
                .HasForeignKey(x => x.PreventiveMeasureId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
