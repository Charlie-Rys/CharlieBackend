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

namespace CharlieBackend.Application.Features.Library.Books.Commands.Update
{
    public class UpdateBookCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }


        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }

        public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, Result<int>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IBookRepository _Book;

            public UpdateBookCommandHandler(IBookRepository Book, IUnitOfWork unitOfWork)
            {
                _Book = Book;
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<int>> Handle(UpdateBookCommand command, CancellationToken cancellationToken)
            {
                var Book = await _Book.GetByIdAsync(command.Id);

                if (Book == null)
                {
                    return Result<int>.Fail($"Purchase Order Not Found.");
                }
                else
                {
                    Book.Id = command.Id;

                    Book.Title = command.Title;
                    Book.AuthorId = command.AuthorId;
                    Book.ISBN = command.ISBN;
                    Book.PublishDate = command.PublishDate;



                    await _Book.UpdateAsync(Book);
                    await _unitOfWork.Commit(cancellationToken);
                    return Result<int>.Success(Book.Id);
                }
            }
        }
    }
}
