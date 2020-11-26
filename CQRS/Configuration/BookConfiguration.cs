using CQRS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Titulo)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(e => e.Edicao)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
