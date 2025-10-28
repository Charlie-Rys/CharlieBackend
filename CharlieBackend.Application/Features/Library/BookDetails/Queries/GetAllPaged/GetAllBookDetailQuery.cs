using AspNetCoreHero.Results;
using CharlieBackend.Application.Extensions;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetAllPaged;
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

namespace CharlieBackend.Application.Features.Library.BookDetails.Queries.GetAllPaged
{
    public class GetAllBookDetailQuery : IRequest<PaginatedResult<GetAllBookDetailResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllBookDetailQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllBookDetailQueryHandler : IRequestHandler<GetAllBookDetailQuery, PaginatedResult<GetAllBookDetailResponse>>
    {
        private readonly IBookDetailRepository _repository;

        public GetAllBookDetailQueryHandler(IBookDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllBookDetailResponse>> Handle(GetAllBookDetailQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<BookDetail, GetAllBookDetailResponse>> expression = e => new GetAllBookDetailResponse
            {
                Id = e.Id,
                BookId = e.BookId,
                Genre = e.Genre,
                PageCount = e.PageCount,
                Publisher = e.Publisher,
                Language = e.Language,


            };
            var paginatedList = await _repository.bookDetail
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}
