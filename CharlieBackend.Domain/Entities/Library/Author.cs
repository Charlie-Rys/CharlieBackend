using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Domain.Entities.Library
{
    public class Author : AuditableEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        
        public ICollection<AuthorDetail> AuthorDetails { get; set; }
        public ICollection<Book> Books { get; set; }


        
    }
}
