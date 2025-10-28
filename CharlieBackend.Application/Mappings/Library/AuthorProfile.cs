using AutoMapper;
using CharlieBackend.Application.Features.Library.Authors.Commands.Create;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetById;
using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Mappings.Library
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<CreateAuthorCommand, Author>().ReverseMap();
            CreateMap<GetAuthorByIdResponse, Author>().ReverseMap();
            CreateMap<GetAllAuthorResponse, Author>().ReverseMap();
            CreateMap<CreateAuthorCommand, List<Author>>().ReverseMap();
        }
    }
}
