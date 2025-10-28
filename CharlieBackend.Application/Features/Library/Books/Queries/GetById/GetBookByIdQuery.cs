using AspNetCoreHero.Results;
using AutoMapper;
using CharlieBackend.Application.Features.Library.BookDetails.Queries.GetById;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Domain.Entities.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.Books.Queries.GetById
{
    public class GetBookByIdQuery : IRequest<Result<GetBookByIdResponse>>
    {
        public int Id { get; set; }

        public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, Result<GetBookByIdResponse>>
        {
            private readonly IBookRepository _Book;
            private readonly IMapper _mapper;

            public GetBookByIdQueryHandler(IBookRepository Book, IMapper mapper)
            {
                _Book = Book;
                _mapper = mapper;
            }

            public async Task<Result<GetBookByIdResponse>> Handle(GetBookByIdQuery query, CancellationToken cancellationToken)
            {
                var Book = await _Book.GetByIdAsync(query.Id);
                var mappedBook = _mapper.Map<GetBookByIdResponse>(Book);
                return Result<GetBookByIdResponse>.Success(mappedBook);
            }
        }
    }
}
