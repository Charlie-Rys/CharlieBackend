using CharlieBackend.Application.Features.Brands.Commands.Create;
using CharlieBackend.Application.Features.Brands.Queries.GetAllCached;
using CharlieBackend.Application.Features.Brands.Queries.GetById;
using CharlieBackend.Domain.Entities.Catalog;
using AutoMapper;

namespace CharlieBackend.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}