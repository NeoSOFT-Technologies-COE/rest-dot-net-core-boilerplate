﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GloboTicket.TicketManagement.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Scrum.Demo.Persistence.Configurations
{
    [ExcludeFromCodeCoverage]
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Not necessary if naming conventions are followed in model
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.CreatedBy)
                .HasColumnType("nvarchar(450)");

            builder
                .Property(b => b.LastModifiedBy)
                .HasColumnType("nvarchar(450)");

            builder
                .Property(b => b.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
        }
    }
}
