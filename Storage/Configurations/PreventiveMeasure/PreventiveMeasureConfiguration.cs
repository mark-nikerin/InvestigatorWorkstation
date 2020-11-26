namespace Storage.Configurations.PreventiveMeasure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class PreventiveMeasureConfiguration : IEntityTypeConfiguration<PreventiveMeasure>
    {
        public void Configure(EntityTypeBuilder<PreventiveMeasure> builder)
        {
            builder.HasMany(x => x.PreventiveMeasureDecisions)
                .WithOne(x => x.PreventiveMeasure)
                .HasForeignKey(x => x.PreventiveMeasureId)
                .IsRequired(true);
        }
    }
}
