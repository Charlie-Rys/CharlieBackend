using AspNetCoreHero.Results;
using AutoMapper;
using CharlieBackend.Application.Features.Library.AuthorDetails.Commands;
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

namespace CharlieBackend.Application.Features.Library.Authors.Commands.Create
{
    public class CreateAuthorCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<CreateAuthorDetailCommand> AuthorDetails { get; set; }
    }


    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, Result<int>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateAuthorCommandHandler(IAuthorRepository author, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _authorRepository = author;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            await _authorRepository.InsertAsync(author);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(author.Id);
        }
    }

}
