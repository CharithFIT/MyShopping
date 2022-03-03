using Catalog.Data.Entities;
using MongoDB.Driver;

namespace Catalog.Data.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
