using Catalog.Data.Entities;

namespace Catalog.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default);

        Task<Product> GetProductAysnc(int id, CancellationToken cancellationToken = default);

        Task<IEnumerable<Product>> GetProductsByName(string name, CancellationToken cancellationToken = default);

        Task<IEnumerable<Product>> GetProductsByCategory(string catagory, CancellationToken cancellationToken = default);

        Task CreateProductAsync(Product product, CancellationToken cancellationToken = default);

        Task UpdateProductAsync(Product product, CancellationToken cancellationToken = default);

        Task DeleteProductAsync(int id, CancellationToken cancellationToken = default);
    }
}
