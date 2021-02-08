namespace Storage.Configurations.InspectionMaterial
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class InspectionMaterialConfiguration : IEntityTypeConfiguration<InspectionMaterial>
    {
        public void Configure(EntityTypeBuilder<InspectionMaterial> builder)
        {
            builder.HasOne(x => x.Qualification)
                .WithMany(x => x.InspectionMaterials)
                .HasForeignKey(x => x.QualificationId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.InspectionMaterialMovements)
                .WithOne(x => x.InspectionMaterial)
                .HasForeignKey(x => x.InspectionMaterialId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.InspectionPeriodExtensions)
                .WithOne(x => x.InspectionMaterial)
                .HasForeignKey(x => x.InspectionMaterialId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
