using CharlieBackend.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CharlieBackend.Infrastructure.Seeds.Library;

namespace CharlieBackend.Infrastructure.Configurations.Library
{
    public class BookDetailConfiguration : BaseModelConfig, IEntityTypeConfiguration<BookDetail>
    {
        public BookDetailConfiguration()
        {
        }
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            TableShortName = "BookDetail";
            TableName = $"{TableNamePrefix}_{TableShortName}";

            builder.ToTable(TableName);

            builder.HasKey(bd => bd.Id)
                   .HasName($"{UniquePrefix}_{TableShortName}_Id");

            builder.Property(bd => bd.Genre)
                   .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.Property(bd => bd.Language)
                   .HasMaxLength((int)EnumColumnLength.VARCHARDEFAULT);

            builder.Property(bd => bd.Publisher)
                   .HasMaxLength((int)EnumColumnLength.VARCHAR200);

            builder.HasOne(bd => bd.Book)
                   .WithMany(b => b.BookDetails) 
                   .HasForeignKey(bd => bd.BookId)
                   .HasConstraintName($"{ConstraintPrefix}_{TableShortName}_Book");

            builder.HasData(BookDetailSeeds.BookDetailsList); 
        }
    }
}
