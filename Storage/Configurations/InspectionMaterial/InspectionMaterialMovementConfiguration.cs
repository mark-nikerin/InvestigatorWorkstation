namespace Storage.Configurations.InspectionMaterial
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class InspectionMaterialMovementConfiguration : IEntityTypeConfiguration<InspectionMaterialMovement>
    {
        public void Configure(EntityTypeBuilder<InspectionMaterialMovement> builder)
        {
            builder.HasOne(x => x.Employee)
                .WithMany(x => x.InspectionMaterialMovements)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired(true);

            builder.HasOne(x => x.InspectionMaterialDecision)
               .WithMany(x => x.InspectionMaterialMovements)
               .HasForeignKey(x => x.InspectionMaterialDecisionId)
               .IsRequired(true);

            builder.HasOne(x => x.InspectionMaterial)
               .WithMany(x => x.InspectionMaterialMovements)
               .HasForeignKey(x => x.InspectionMaterialId)
               .IsRequired(true);
        }
    }
}
