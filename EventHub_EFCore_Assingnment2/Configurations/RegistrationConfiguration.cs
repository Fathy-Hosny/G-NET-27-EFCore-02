using EventHub_EFCore_Assingnment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub_EFCore_Assingnment2.Configurations
{
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => new { r.EventId, r.AttendeeId });

            builder.Property(r => r.Note)
                .HasColumnType("Varchar(500)");

            builder.Property(r => r.RegistrationDate)
                .HasColumnType("datetime2")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
