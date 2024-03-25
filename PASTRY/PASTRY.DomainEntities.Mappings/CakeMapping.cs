using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PASTRY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities.Mappings
{
    class CakeMapping : IEntityTypeConfiguration<Cake>
    {
        public void Configure(EntityTypeBuilder<Cake> builder)
        {
            builder.ToTable("Cakes");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Price).HasColumnName("Price");
            builder.Property(c => c.Weight).HasColumnName("Weight");
            builder.Property(c => c.IdImage).HasColumnName("IdImage");
            builder.Property(c => c.ImageCake).HasColumnName("ImageCake");
        }
    }
}
