using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.Books.Queries.GetById
{
    public class GetBookByIdResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }


        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
