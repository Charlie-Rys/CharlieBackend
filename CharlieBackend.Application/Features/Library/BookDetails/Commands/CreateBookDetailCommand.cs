using AspNetCoreHero.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.BookDetails.Commands
{
    public class CreateBookDetailCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
    }
}
