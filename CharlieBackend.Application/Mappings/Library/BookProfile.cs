using AutoMapper;
using CharlieBackend.Application.Features.Library.Authors.Commands.Create;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Authors.Queries.GetById;
using CharlieBackend.Application.Features.Library.Books.Commands.Create;
using CharlieBackend.Application.Features.Library.Books.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.Books.Queries.GetById;
using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Mappings.Library
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<CreateBookCommand, Book>().ReverseMap();
            CreateMap<GetBookByIdResponse, Book>().ReverseMap();
            CreateMap<GetAllBookResponse, Book>().ReverseMap();
            CreateMap<CreateBookCommand, List<Book>>().ReverseMap();
        }
    }
}
