using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Infrastructure.Seeds.Library
{
    public static class AuthorDetailSeeds
    {
        public static AuthorDetail[] AuthorDetailList = new AuthorDetail[]
        {
            new AuthorDetail
            {
                Id = 1,
                AuthorId = 1,
                Biography = "English novelist and essayist, journalist and critic.",
                Website = "https://georgeorwell.org",
                SocialMediaHandle = "@orwell_official",
                Awards = "Prometheus Hall of Fame Award"
            },
            new AuthorDetail
            {
                Id = 2,
                AuthorId = 2,
                Biography = "British author, best known for the Harry Potter series.",
                Website = "https://jkrowling.com",
                SocialMediaHandle = "@jk_rowling",
                Awards = "Hugo Award, British Book Award"
            },
            new AuthorDetail
            {
                Id = 3,
                AuthorId = 3,
                Biography = "Japanese writer known for surreal and melancholic novels.",
                Website = "https://harukimurakami.com",
                SocialMediaHandle = "@murakami_haruki",
                Awards = "Franz Kafka Prize"
            }
        };
    }
}
