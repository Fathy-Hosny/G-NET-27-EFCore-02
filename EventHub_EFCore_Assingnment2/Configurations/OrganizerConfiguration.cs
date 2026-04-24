using EventHub_EFCore_Assingnment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub_EFCore_Assingnment2.Configurations
{
    public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.HasKey(o => o.OrganizerId);

            builder.Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("Varchar"); 

            builder.Property(o => o.CompanyName)
                .HasMaxLength(150)
                .HasColumnType("Varchar"); 
            builder.Property(o => o.IsVerified)
                .HasColumnType("bit");

        }
    }
}
