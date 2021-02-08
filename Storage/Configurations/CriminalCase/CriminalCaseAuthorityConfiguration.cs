namespace Storage.Configurations.CriminalCase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Storage.Models;

    public class CriminalCaseAuthorityConfiguration : IEntityTypeConfiguration<CriminalCaseAuthority>
    {
        public void Configure(EntityTypeBuilder<CriminalCaseAuthority> builder)
        {
            builder.HasMany(x => x.CriminalCases)
               .WithOne(x => x.CriminalCaseAuthority)
               .HasForeignKey(x => x.CriminalCaseAuthorityId);
        }
    }
}
