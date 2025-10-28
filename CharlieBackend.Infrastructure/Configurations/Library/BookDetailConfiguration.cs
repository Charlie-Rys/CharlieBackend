using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::CharlieBackend.Domain.Entities.Library;
using global::CharlieBackend.Infrastructure.Seeds.Library;

    namespace CharlieBackend.Infrastructure.Configurations.Library
    {
    public class BookDetailConfiguration : BaseModelConfig, IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            TableName = "bookDetail";
            builder.ToTable(TableName);

            builder.Property(p => p.Id)
               .IsRequired();

            builder.Property(t => t.BookId)
                .HasMaxLength((Int32)EnumColumnLength.VARCHARDEFAULT)
                .IsRequired(true);

            builder.Property(t => t.Genre)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.PageCount)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.Publisher)
               .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
               .IsRequired(true);

            builder.Property(t => t.Language)
              .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
              .IsRequired(true);

        }
    }

}


