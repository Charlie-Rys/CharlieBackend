using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Infrastructure.Seeds.Library
{
    public static class AuthorSeeds
    {
        public static Author[] AuthorList = new Author[]
        {
            new Author
            {
                Id = 1,
                FirstName = "George",
                LastName = "Orwell",
                BirthDate = new DateTime(1903, 6, 25)
            },
            new Author
            {
                Id = 2,
                FirstName = "J.K.",
                LastName = "Rowling",
                BirthDate = new DateTime(1965, 7, 31)
            },
            new Author
            {
                Id = 3,
                FirstName = "Haruki",
                LastName = "Murakami",
                BirthDate = new DateTime(1949, 1, 12)
            }
        };
    }
}
