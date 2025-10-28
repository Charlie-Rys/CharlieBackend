using AspNetCoreHero.Results;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CharlieBackend.Domain.Entities.Library;

namespace CharlieBackend.Application.Features.Library.Books.Commands.Delete
{
    public class DeleteBookCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Result<int>>
        {
            private readonly IBookRepository _Book;
            private readonly IUnitOfWork _unitOfWork;

            public DeleteBookCommandHandler(IBookRepository Book, IUnitOfWork unitOfWork)
            {
                _Book = Book;
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<int>> Handle(DeleteBookCommand command, CancellationToken cancellationToken)
            {
                var Book = await _Book.GetByIdAsync(command.Id);
                await _Book.DeleteAsync(Book);
                await _unitOfWork.Commit(cancellationToken);
                return Result<int>.Success(Book.Id);
            }
        }
    }
}
