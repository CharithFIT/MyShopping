using Catalog.Data.Data;
using Catalog.Data.Entities;
using MongoDB.Driver;

namespace Catalog.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext catalogContext;

        public ProductRepository(ICatalogContext catalogContext)
        {
            this.catalogContext = catalogContext ?? throw new ArgumentNullException(nameof(catalogContext));
        }

        public async Task CreateProductAsync(Product product, CancellationToken cancellationToken = default)
        {
            await this.catalogContext.Products
                .InsertOneAsync(product, new InsertOneOptions { BypassDocumentValidation = false }, cancellationToken);
        }

        public async Task DeleteProductAsync(int id, CancellationToken cancellationToken = default)
        {
            await this.catalogContext.Products
                .DeleteOneAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<Product> GetProductAysnc(int id, CancellationToken cancellationToken = default)
        {
            return await this.catalogContext.Products
                .Find(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
        {
            return await this.catalogContext.Products
                .Find(_ => true)
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string catagory, CancellationToken cancellationToken = default)
        {
            return await this.catalogContext.Products
                .Find(p => string.Equals(p.Category, catagory, StringComparison.InvariantCulture))
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Product>> GetProductsByName(string name, CancellationToken cancellationToken = default)
        {
            return await this.catalogContext.Products
                 .Find(p => string.Equals(p.Name, name, StringComparison.InvariantCulture))
                 .ToListAsync(cancellationToken);
        }

        public async Task UpdateProductAsync(Product product, CancellationToken cancellationToken = default)
        {
            await this.catalogContext.Products
                .ReplaceOneAsync(p => p.Id == product.Id, product, new ReplaceOptions { IsUpsert = false }, cancellationToken);
        }
    }
}
