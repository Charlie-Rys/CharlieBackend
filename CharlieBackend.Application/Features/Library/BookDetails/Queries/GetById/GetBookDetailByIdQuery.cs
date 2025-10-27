using AspNetCoreHero.Results;
using AutoMapper;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetById;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.BookDetails.Queries.GetById
{
    public class GetBookDetailByIdQuery : IRequest<Result<GetBookDetailByIdResponse>>
    {
        public int Id { get; set; }

        public class GetBookDetailByIdQueryHandler : IRequestHandler<GetBookDetailByIdQuery, Result<GetBookDetailByIdResponse>>
        {
            private readonly IBookDetailRepository _bookDetail;
            private readonly IMapper _mapper;

            public GetBookDetailByIdQueryHandler(IBookDetailRepository bookDetail, IMapper mapper)
            {
                _bookDetail = bookDetail;
                _mapper = mapper;
            }

            public async Task<Result<GetBookDetailByIdResponse>> Handle(GetBookDetailByIdQuery query, CancellationToken cancellationToken)
            {
                var bookDetail = await _bookDetail.GetByIdAsync(query.Id);
                var mappedbookDetail = _mapper.Map<GetBookDetailByIdResponse>(bookDetail);
                return Result<GetBookDetailByIdResponse>.Success(mappedbookDetail);
            }
        }
    }
}
