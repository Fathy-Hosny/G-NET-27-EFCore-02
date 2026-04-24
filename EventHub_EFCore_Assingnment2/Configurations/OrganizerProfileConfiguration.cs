using EventHub_EFCore_Assingnment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub_EFCore_Assingnment2.Configurations
{
    public class OrganizerProfileConfiguration:IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p => p.ProfileId);

        
            builder.Property(p => p.Bio)
                .HasMaxLength(500)
                .HasColumnType("Varchar(500)");

            builder.Property(p => p.WebsiteUrl)
                .HasMaxLength(250)
                .HasColumnType("varchar(250)"); 

            builder.Property(p => p.LogoPath)
                .HasMaxLength(255)
                .HasColumnType("Varchar(255)");

     
            builder.HasOne(p => p.Organizer)
                .WithOne(o => o.Profile)
                .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
