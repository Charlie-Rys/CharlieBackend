using AspNetCoreHero.Results;
using AutoMapper;
using CharlieBackend.Application.Features.Library.Authors.Commands.Create;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Application.Interfaces.Repositories;
using CharlieBackend.Domain.Entities.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CharlieBackend.Application.Features.Library.AuthorDetails.Commands;
using CharlieBackend.Application.Features.Library.BookDetails.Commands;

namespace CharlieBackend.Application.Features.Library.Books.Commands.Create
{
    public class CreateBookCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }


        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<CreateBookDetailCommand> BookDetail { get; set; }
    }
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Result<int>>
    {
        private readonly IBookRepository _Book;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateBookCommandHandler(IBookRepository Book, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _Book = Book;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var Book = _mapper.Map<Book>(request);
            await _Book.InsertAsync(Book);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(Book.Id);
        }
    }
}
