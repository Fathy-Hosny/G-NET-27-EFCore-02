using EventHub_EFCore_Assingnment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub_EFCore_Assingnment2.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.BadgeId);

            builder.Property(b => b.BadgeNumber)
                .IsRequired()
                .HasColumnType("Varchar(50)"); 

            builder.Property(b => b.IssuedDate)
                .HasColumnType("date"); 

            builder.Property(b => b.Tier)
                .HasColumnType("Varchar(20)");
        }
    }
}
