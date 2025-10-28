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

namespace CharlieBackend.Application.Features.Library.Authors.Commands.Update
{
    public class UpdateAuthorCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, Result<int>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IAuthorRepository _author;

            public UpdateAuthorCommandHandler(IAuthorRepository author, IUnitOfWork unitOfWork)
            {
                _author = author;
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<int>> Handle(UpdateAuthorCommand command, CancellationToken cancellationToken)
            {
                var author = await _author.GetByIdAsync(command.Id);

                if (author == null)
                {
                    return Result<int>.Fail($"Purchase Order Not Found.");
                }
                else
                {

                    author.Id = command.Id;
                    author.FirstName = command.FirstName;
                    author.LastName = command.LastName;
                    author.BirthDate = command.BirthDate;       
                    

                    await _author.UpdateAsync(author);
                    await _unitOfWork.Commit(cancellationToken);
                    return Result<int>.Success(author.Id);
                }
            }
        }
    }
}
