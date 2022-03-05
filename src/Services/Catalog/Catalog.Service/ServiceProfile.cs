using AutoMapper;
using Catalog.Data.Entities;
using Catalog.Service.Dtos;

namespace Catalog.Service
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
