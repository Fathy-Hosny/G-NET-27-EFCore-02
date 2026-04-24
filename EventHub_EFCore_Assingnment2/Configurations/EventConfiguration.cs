using System;
using System.Collections.Generic;
using System.Text;
using EventHub_EFCore_Assingnment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub_EFCore_Assingnment2.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.EventId);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasColumnType("Varchar(200)");

            builder.Property(e => e.Description)
                .HasColumnType("Varchar(max)");

            builder.Property(e => e.StartDate)
                .HasColumnType("datetime2");

            builder.Property(e => e.EndDate)
                .HasColumnType("datetime2");

      
            builder.Property(e => e.MaxAttendees)
                .HasField("_maxAttendees")
                .HasColumnType("int");

        
            builder.HasOne(e => e.ParentEvent)
                .WithMany()
                .HasForeignKey(e => e.ParentEventId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}