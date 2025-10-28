using CharlieBackend.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharlieBackend.Infrastructure.Seeds.Library;

namespace CharlieBackend.Infrastructure.Configurations.Library
{
    public class AuthorConfiguration : BaseModelConfig, IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            TableName = "author";
            builder.ToTable(TableName);

            builder.Property(p => p.Id)
               .IsRequired();

            builder.Property(t => t.FirstName)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.LastName)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.BirthDate)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

        }
    }
}

