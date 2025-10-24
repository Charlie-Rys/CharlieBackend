using System.Collections.Generic;
using System;

namespace CharlieBackend.Domain.Entities.Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual Author Author { get; set; }

        
        public virtual ICollection<BookDetail> BookDetails { get; set; }
    }
}
