using CharlieBackend.Application.Features.Products.Commands.Create;
using CharlieBackend.Application.Features.Products.Queries.GetAllCached;
using CharlieBackend.Application.Features.Products.Queries.GetAllPaged;
using CharlieBackend.Application.Features.Products.Queries.GetById;
using CharlieBackend.Domain.Entities.Catalog;
using AutoMapper;

namespace CharlieBackend.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}