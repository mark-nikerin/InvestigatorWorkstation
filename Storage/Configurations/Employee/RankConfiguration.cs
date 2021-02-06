namespace Storage.Configurations.Employee
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class RankConfiguration : IEntityTypeConfiguration<Rank>
    {
        public void Configure(EntityTypeBuilder<Rank> builder)
        {  
            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Rank)
                .HasForeignKey(x => x.RankId)
                .IsRequired(true);

            builder.HasMany(x => x.EmployeeRankHistories)
                .WithOne(x => x.Rank)
                .HasForeignKey(x => x.RankId);
        }
    }
}
