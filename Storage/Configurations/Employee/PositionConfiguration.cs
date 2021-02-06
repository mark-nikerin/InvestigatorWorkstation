namespace Storage.Configurations.Employee
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {  
            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Position)
                .HasForeignKey(x => x.PositionId)
                .IsRequired(true);

            builder.HasMany(x => x.EmployeePositionHistories)
                .WithOne(x => x.Position)
                .HasForeignKey(x => x.PositionId); 
        }
    }
}
