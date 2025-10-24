using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Domain.Entities.Library
{
    public class AuthorDetail
    {
        public int Id { get; set; }           
        public int AuthorId { get; set; }          

        public string Biography { get; set; }
        public string Website { get; set; }
        public string SocialMediaHandle { get; set; }
        public string Awards { get; set; }

        
        public Author Author { get; set; }
    }
}
