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

namespace CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged
{
    public class GetAllAuthorDetailQuery : IRequest<PaginatedResult<GetAllAuthorDetailResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllAuthorDetailQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllAuthorDetailQueryHandler : IRequestHandler<GetAllAuthorDetailQuery, PaginatedResult<GetAllAuthorDetailResponse>>
    {
        private readonly IAuthorDetailRepository _repository;

        public GetAllAuthorDetailQueryHandler(IAuthorDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllAuthorDetailResponse>> Handle(GetAllAuthorDetailQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<AuthorDetail, GetAllAuthorDetailResponse>> expression = e => new GetAllAuthorDetailResponse
            {
                Id = e.Id,
                AuthorId = e.AuthorId,
                Biography = e.Biography,
                Website =   e.Website,
                SocialMediaHandle = e.SocialMediaHandle,
                Awards = e.Awards,


            };
            var paginatedList = await _repository.authorDetail
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}
