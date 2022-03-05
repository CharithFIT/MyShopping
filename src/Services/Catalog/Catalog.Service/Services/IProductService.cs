using Catalog.Service.Dtos;

namespace Catalog.Service.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetProductsAsync(CancellationToken cancellationToken = default);
    }
}
