using System.Collections.Generic;
using System;
using AspNetCoreHero.Abstractions.Domain;

namespace CharlieBackend.Domain.Entities.Library
{
    public class Book : AuditableEntity
    {
       
        public string Title { get; set; }
        public int AuthorId { get; set; }

        
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual Author Author { get; set; }

        
          public ICollection<BookDetail> BookDetail { get; set; }
    }
}
