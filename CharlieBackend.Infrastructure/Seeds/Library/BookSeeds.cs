using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Infrastructure.Seeds.Library
{
    public static class BookSeeds
    {
        public static Book[] BookList = new Book[]
        {
            new Book
            {
                Id = 1,
                AuthorId = 1,
                Title = "1984",
                ISBN = "9780451524935",
                PublishDate = new DateTime(1949, 6, 8)
            },
            new Book
            {
                Id = 2,
                AuthorId = 2,
                Title = "Harry Potter and the Sorcerer’s Stone",
                ISBN = "9780590353427",
                PublishDate = new DateTime(1997, 6, 26)
            },
            new Book
            {
                Id = 3,
                AuthorId = 3,
                Title = "Norwegian Wood",
                ISBN = "9780375704024",
                PublishDate = new DateTime(1987, 9, 4)
            }
        };
    }
}
