using AspNetCoreHero.Results;
using AutoMapper;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetById;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetById
{
    public class GetAuthorDetailByIdQuery : IRequest<Result<GetAuthorDetailByIdResponse>>
    {
        public int Id { get; set; }

        public class GetAuthorDetailByIdQueryHandler : IRequestHandler<GetAuthorDetailByIdQuery, Result<GetAuthorDetailByIdResponse>>
        {
            private readonly IAuthorDetailRepository _authorDetail;
            private readonly IMapper _mapper;

            public GetAuthorDetailByIdQueryHandler(IAuthorDetailRepository authorDetail, IMapper mapper)
            {
                _authorDetail = authorDetail;
                _mapper = mapper;
            }

            public async Task<Result<GetAuthorDetailByIdResponse>> Handle(GetAuthorDetailByIdQuery query, CancellationToken cancellationToken)
            {
                var authorDetail = await _authorDetail.GetByIdAsync(query.Id);
                var mappedauthorDetail = _mapper.Map<GetAuthorDetailByIdResponse>(authorDetail);
                return Result<GetAuthorDetailByIdResponse>.Success(mappedauthorDetail);
            }
        }
    }
}
