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
            TableShortName = "AuthorDetails";
            TableName = $"{TableNamePrefix}_{TableShortName}";

            builder.ToTable(TableName);

            builder.HasKey(ad => ad.Id)
                   .HasName($"{UniquePrefix}_{TableShortName}_Id");

            builder.Property(ad => ad.Biography)
                .HasColumnType(DefaultTextLong);

            builder.Property(ad => ad.Website)
                .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.Property(ad => ad.SocialMediaHandle)
                .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.Property(ad => ad.Awards)
                .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.HasOne(ad => ad.Author)
                .WithMany(a => a.AuthorDetails)
                .HasForeignKey(ad => ad.AuthorId)
                .HasConstraintName($"{ConstraintPrefix}_{TableShortName}_Author");




            builder.HasData(AuthorDetailSeeds.AuthorDetailList);
        }
    }
}
