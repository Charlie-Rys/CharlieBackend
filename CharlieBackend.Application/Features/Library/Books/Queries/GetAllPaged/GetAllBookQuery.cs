using AspNetCoreHero.Results;
using CharlieBackend.Application.Extensions;
using CharlieBackend.Application.Features.Library.BookDetails.Queries;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Domain.Entities.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.Books.Queries.GetAllPaged
{
    public class GetAllBookQuery : IRequest<PaginatedResult<GetAllBookResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllBookQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, PaginatedResult<GetAllBookResponse>>
    {
        private readonly IBookRepository _repository;

        public GetAllBookQueryHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllBookResponse>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Book, GetAllBookResponse>> expression = e => new GetAllBookResponse
            {
                Id = e.Id,
                Title = e.Title,
                AuthorId = e.AuthorId,
                ISBN = e.ISBN,
                PublishDate = e.PublishDate,



            };
            var paginatedList = await _repository.Book
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}
