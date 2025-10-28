using AspNetCoreHero.Results;
using CharlieBackend.Application.Interfaces.Repositories;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.Authors.Commands.Delete
{
    public class DeleteAuthorCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, Result<int>>
        {
            private readonly IAuthorRepository _author;
            private readonly IUnitOfWork _unitOfWork;

            public DeleteAuthorCommandHandler(IAuthorRepository author, IUnitOfWork unitOfWork)
            {
                _author = author;
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<int>> Handle(DeleteAuthorCommand command, CancellationToken cancellationToken)
            {
                var author = await _author.GetByIdAsync(command.Id);
                await _author.DeleteAsync(author);
                await _unitOfWork.Commit(cancellationToken);
                return Result<int>.Success(author.Id);
            }
        }
    }
}
