using System;
using System.Collections.Generic;
using System.Text;
using EventHub_EFCore_Assingnment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub_EFCore_Assingnment2.Configurations
{
    public class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.HasKey(a => a.AttendeeId);

       
            builder.OwnsOne(a => a.HomeAddress, addr =>
            {
                addr.Property(p => p.Street).HasColumnType("Varchar(200)");
                addr.Property(p => p.City).HasColumnType("Varchar(100)");
                addr.Property(p => p.Country).HasColumnType("Varchar(100)");
                addr.Property(p => p.PostalCode).HasColumnType("Varchar(20)");
            });
        }
    }
}
