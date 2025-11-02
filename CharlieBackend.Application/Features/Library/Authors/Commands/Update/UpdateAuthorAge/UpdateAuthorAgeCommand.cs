using AspNetCoreHero.Results;
using CharlieBackend.Application.Interfaces.Repositories;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Domain.Entities.Library;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.Authors.Commands.Update.UpdateAuthorAge
{
    public class UpdateAuthorAgeCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class UpdateAuthorAgeCommandHandler : IRequestHandler<UpdateAuthorAgeCommand, Result<int>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateAuthorAgeCommandHandler(IAuthorRepository author, IUnitOfWork unitOfWork)
        {
            _authorRepository = author;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(UpdateAuthorAgeCommand request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.Id);
            if (author == null)
                return await Result<int>.FailAsync("Author not found.");

            author.BirthDate = request.BirthDate;
            await _authorRepository.UpdateAsync(author);
            await _unitOfWork.Commit(cancellationToken);

            return await Result<int>.SuccessAsync(author.Id, "Author age updated successfully.");
        }
    }
}
