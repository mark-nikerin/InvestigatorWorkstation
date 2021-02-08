using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Models;
using Storage.Models.Employee;

namespace Storage.Configurations.Employee
{
    public class RankConfiguration : IEntityTypeConfiguration<Rank>
    {
        public void Configure(EntityTypeBuilder<Rank> builder)
        {
            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Rank)
                .HasForeignKey(x => x.RankId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.EmployeeRankHistories)
                .WithOne(x => x.Rank)
                .HasForeignKey(x => x.RankId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
