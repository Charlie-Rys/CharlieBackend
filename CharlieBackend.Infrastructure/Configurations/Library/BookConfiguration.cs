using CharlieBackend.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CharlieBackend.Infrastructure.Seeds.Library;
using System;

namespace CharlieBackend.Infrastructure.Configurations.Library
{
    public class BookConfiguration : BaseModelConfig, IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            TableName = "Book";
            builder.ToTable(TableName);

            builder.Property(p => p.Id)
               .IsRequired();
          

            builder.Property(t => t.Title)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.AuthorId)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.ISBN)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(p => p.PublishDate)
                .HasColumnType(DefaultDateTime)
                .IsRequired(true);

        }
    }
}
