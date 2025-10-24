using System;
using System.Collections.Generic;
using CharlieBackend.Domain.Entities.Library;

namespace CharlieBackend.Infrastructure.Seeds.Library
{
    public static class BookDetailSeeds
    {
        public static List<BookDetail> BookDetailsList => new()
        {
            new BookDetail
            {
                Id = 1,
                BookId = 1,
                Genre = "Fantasy",
                PageCount = 320,
                Publisher = "Penguin Random House",
                Language = "English"
            },
            new BookDetail
            {
                Id = 2,
                BookId = 2,
                Genre = "Science Fiction",
                PageCount = 270,
                Publisher = "HarperCollins",
                Language = "English"
            }
        };
    }
}
