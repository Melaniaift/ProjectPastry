using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities.Mappings
{
    class DrinkMapping : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.ToTable("Drinks");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Price).HasColumnName("Price");
            builder.Property(c => c.IdImage).HasColumnName("IdImage");
            builder.Property(c => c.ImageDrink).HasColumnName("ImageDrink");
        }
    }
}