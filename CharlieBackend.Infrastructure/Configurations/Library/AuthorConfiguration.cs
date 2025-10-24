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
            TableShortName = "Authors";
            TableName = $"{TableNamePrefix}_{TableShortName}";

            builder.ToTable(TableName);

            builder.HasKey(a => a.Id)
                   .HasName($"{UniquePrefix}_{TableShortName}_Id");

            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.Property(a => a.BirthDate)
                .HasColumnType(DefaultDateTime)
                .HasDefaultValueSql(DefaultDateNow);

            // Relationships
            builder.HasMany(a => a.AuthorDetails)
                   .WithOne(d => d.Author)
                   .HasForeignKey(d => d.AuthorId)
                   .HasConstraintName($"{ConstraintPrefix}_{TableShortName}_AuthorDetail");

            builder.HasMany(a => a.Books)
                   .WithOne(b => b.Author)
                   .HasForeignKey(b => b.AuthorId)
                   .HasConstraintName($"{ConstraintPrefix}_{TableShortName}_Book");



            builder.HasData(AuthorSeeds.AuthorList);
        }
    }
}

