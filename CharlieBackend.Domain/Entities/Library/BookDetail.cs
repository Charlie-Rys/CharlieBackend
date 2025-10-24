using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Domain.Entities.Library
{
    public class BookDetail
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }

        public virtual Book Book { get; set; }
    }
}