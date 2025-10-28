using AutoMapper;
using CharlieBackend.Application.Features.Library.AuthorDetails.Commands;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetById;
using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Mappings.Library
{
    public class AuthorDetailProfile : Profile
    {
        public AuthorDetailProfile()
        {
            CreateMap<GetAuthorDetailByIdResponse, AuthorDetail>().ReverseMap();
            CreateMap<GetAllAuthorDetailResponse, AuthorDetail>().ReverseMap();
            CreateMap<CreateAuthorDetailCommand, AuthorDetail>().ReverseMap();
        }
    }
}
