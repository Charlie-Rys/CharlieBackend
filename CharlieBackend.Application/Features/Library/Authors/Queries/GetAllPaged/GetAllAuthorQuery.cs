using AspNetCoreHero.Results;
using CharlieBackend.Application.Extensions;
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

namespace CharlieBackend.Application.Features.Library.Authors.Queries.GetAllPaged
{
    public class GetAllAuthorQuery : IRequest<PaginatedResult<GetAllAuthorResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllAuthorQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllAuthorQueryHandler : IRequestHandler<GetAllAuthorQuery, PaginatedResult<GetAllAuthorResponse>>
    {
        private readonly IAuthorRepository _repository;

        public GetAllAuthorQueryHandler(IAuthorRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllAuthorResponse>> Handle(GetAllAuthorQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Author, GetAllAuthorResponse>> expression = e => new GetAllAuthorResponse
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                BirthDate = e.BirthDate,
                

            };
            var paginatedList = await _repository.author
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}
