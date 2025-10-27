using AspNetCoreHero.Results;
using AutoMapper;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.Authors.Queries.GetById
{
    public class GetAuthorByIdQuery : IRequest<Result<GetAuthorByIdResponse>>
    {
        public int Id { get; set; }

        public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, Result<GetAuthorByIdResponse>>
        {
            private readonly IAuthorRepository _author;
            private readonly IMapper _mapper;

            public GetAuthorByIdQueryHandler(IAuthorRepository author, IMapper mapper)
            {
                _author = author;
                _mapper = mapper;
            }

            public async Task<Result<GetAuthorByIdResponse>> Handle(GetAuthorByIdQuery query, CancellationToken cancellationToken)
            {
                var author = await _author.GetByIdAsync(query.Id);
                var mappedauthor = _mapper.Map<GetAuthorByIdResponse>(author);
                return Result<GetAuthorByIdResponse>.Success(mappedauthor);
            }
        }
    }
}
