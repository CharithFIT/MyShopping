using AutoMapper;
using Catalog.Data.Entities;
using Catalog.Data.Repositories;
using Catalog.Service.Dtos;

namespace Catalog.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<ProductDto>> GetProductsAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Product> products = await this.productRepository.GetProductsAsync(cancellationToken);

            List<ProductDto> productDtos = products.Select(p => this.mapper.Map<ProductDto>(p)).ToList();

            return productDtos;
        }
    }
}
