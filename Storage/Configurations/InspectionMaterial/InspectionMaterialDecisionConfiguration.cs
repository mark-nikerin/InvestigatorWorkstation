namespace Storage.Configurations.InspectionMaterial
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class InspectionMaterialDecisionConfiguration : IEntityTypeConfiguration<InspectionMaterialDecision>
    {
        public void Configure(EntityTypeBuilder<InspectionMaterialDecision> builder)
        {
            builder.HasMany(x => x.InspectionMaterialMovements)
                .WithOne(x => x.InspectionMaterialDecision)
                .HasForeignKey(x => x.InspectionMaterialDecisionId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
