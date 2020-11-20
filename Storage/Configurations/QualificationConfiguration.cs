namespace Storage.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builder)
        {  
            builder.HasMany(x => x.CriminalCases)
                .WithOne(x => x.Qualification)
                .HasForeignKey(x => x.QualificationId)
                .IsRequired();

            builder.HasMany(x => x.CriminalStatusHistories)
                .WithOne(x => x.Qualification)
                .HasForeignKey(x => x.QualificationId)
                .IsRequired();

            builder.HasMany(x => x.InspectionMaterials)
                .WithOne(x => x.Qualification)
                .HasForeignKey(x => x.QualificationId)
                .IsRequired(); 
        }
    }
}
