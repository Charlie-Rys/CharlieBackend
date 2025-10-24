using CharlieBackend.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CharlieBackend.Infrastructure.Seeds.Library;

namespace CharlieBackend.Infrastructure.Configurations.Library
{
    public class BookConfiguration : BaseModelConfig, IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            TableShortName = "Books";
            TableName = $"{TableNamePrefix}_{TableShortName}";

            builder.ToTable(TableName);

            builder.HasKey(b => b.Id)
                   .HasName($"{UniquePrefix}_{TableShortName}_Id");

            builder.Property(b => b.Title)
                   .HasMaxLength((int)EnumColumnLength.VARCHAR200)
                   .IsRequired();

            builder.Property(b => b.ISBN)
                   .HasMaxLength((int)EnumColumnLength.VARCHAR100)
                   .IsRequired();

            builder.Property(b => b.PublishDate)
                   .IsRequired();

            builder.HasOne(b => b.Author)
                   .WithMany(a => a.Books)
                   .HasForeignKey(b => b.AuthorId)
                   .HasConstraintName($"{ConstraintPrefix}_{TableShortName}_Author");

            builder.HasData(BookSeeds.BookList);
        }
    }
}
