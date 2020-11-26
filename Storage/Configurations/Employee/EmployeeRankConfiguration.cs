namespace Storage.Configurations.Employee
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class EmployeeRankConfiguration : IEntityTypeConfiguration<EmployeeRank>
    {
        public void Configure(EntityTypeBuilder<EmployeeRank> builder)
        {  
            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Rank)
                .HasForeignKey(x => x.RankId)
                .IsRequired(true);  
        }
    }
}
