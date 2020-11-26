namespace Storage.Configurations.InspectionMaterial
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class InspectionPeriodExtensionConfiguration : IEntityTypeConfiguration<InspectionPeriodExtension>
    {
        public void Configure(EntityTypeBuilder<InspectionPeriodExtension> builder)
        {
            builder.HasOne(x => x.InspectionMaterial)
                .WithMany(x => x.InspectionPeriodExtensions)
                .HasForeignKey(x => x.InspectionMaterialId)
                .IsRequired(true); 
        }
    }
}
