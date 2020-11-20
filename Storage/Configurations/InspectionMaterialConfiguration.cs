namespace Storage.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class InspectionMaterialConfiguration : IEntityTypeConfiguration<InspectionMaterial>
    {
        public void Configure(EntityTypeBuilder<InspectionMaterial> builder)
        {  
            builder.HasMany(x => x.InspectionMaterialMovements)
                .WithOne(x => x.InspectionMaterial)
                .HasForeignKey(x => x.InspectionMaterialId)
                .IsRequired();

            builder.HasMany(x => x.InspectionPeriodExtensions)
                .WithOne(x => x.InspectionMaterial)
                .HasForeignKey(x => x.InspectionMaterialId)
                .IsRequired(); 
        }
    }
}
