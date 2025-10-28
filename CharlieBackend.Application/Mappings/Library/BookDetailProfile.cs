using AutoMapper;
using CharlieBackend.Application.Features.Library.AuthorDetails.Commands;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetById;
using CharlieBackend.Application.Features.Library.BookDetails.Commands;
using CharlieBackend.Application.Features.Library.BookDetails.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Library.BookDetails.Queries.GetById;
using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Mappings.Library
{
    public class BookDetailProfile : Profile
    {
        public BookDetailProfile()
        {
            CreateMap<GetBookDetailByIdResponse, BookDetail>().ReverseMap();
            CreateMap<GetAllBookDetailResponse, BookDetail>().ReverseMap();
            CreateMap<CreateBookDetailCommand, BookDetail>().ReverseMap();
        }
    }
}
