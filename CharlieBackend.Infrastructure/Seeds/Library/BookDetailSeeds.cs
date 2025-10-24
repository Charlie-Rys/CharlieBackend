using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Infrastructure.Seeds.Library
{
    public static class BookDetailSeeds
    {
        public static BookDetail[] BookDetailsList = new BookDetail[]
        {
            new BookDetail
            {
                Id = 1,
                BookId = 1, 
                Genre = "Dystopian",
                Language = "English",
                Publisher = "Secker & Warburg"
            },
            new BookDetail
            {
                Id = 2,
                BookId = 2, 
                Genre = "Fantasy",
                Language = "English",
                Publisher = "Bloomsbury"
            },
            new BookDetail
            {
                Id = 3,
                BookId = 3, 
                Genre = "Romance / Psychological Fiction",
                Language = "Japanese",
                Publisher = "Kodansha"
            }
        };
    }
}
