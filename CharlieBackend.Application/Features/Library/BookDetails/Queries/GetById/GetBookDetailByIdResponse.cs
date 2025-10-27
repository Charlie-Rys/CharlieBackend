using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.BookDetails.Queries.GetById
{
    public class GetBookDetailByIdResponse
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
    }
}
