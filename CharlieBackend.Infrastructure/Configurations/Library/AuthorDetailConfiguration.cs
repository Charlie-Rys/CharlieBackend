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
    public class AuthorDetailConfiguration : BaseModelConfig, IEntityTypeConfiguration<AuthorDetail>
    {
        public void Configure(EntityTypeBuilder<AuthorDetail> builder)
        {
            TableName = "authorDetail";
            builder.ToTable(TableName);

            builder.Property(p => p.Id)
               .IsRequired();

            builder.Property(t => t.Biography)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.Website)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.SocialMediaHandle)
                .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
                .IsRequired(true);

            builder.Property(t => t.Awards)
               .HasMaxLength((Int32)EnumColumnLength.VARCHAR200)
               .IsRequired(true);

        }
    }
}
