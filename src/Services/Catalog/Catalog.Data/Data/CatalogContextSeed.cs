using Catalog.Data.Entities;
using MongoDB.Driver;

namespace Catalog.Data.Data
{
    public static class CatalogContextSeed<T> where T : class, ICatalogEntity
    {
        public static void SeedData(IMongoCollection<T> mongoCollection, IEnumerable<T> data)
        {
            bool existData = mongoCollection.Find<T>(t => true).Any();

            if (!existData)
            {
                mongoCollection.InsertManyAsync(data);
            }
        }

    }
}
