using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Domain.Entities.Library
{
    public class BookDetail : AuditableEntity
    {
       
        public int BookId { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }

        
        public Book Book { get; set; }
    }
}