using Contracts.Shared.Settings;
using MongoDB.Driver;

namespace Contracts.Infra.Data.MongoDb
{
    public sealed class DataContext
    {
        private readonly IMongoDatabase _database;

        public DataContext(IMongoClient client, AppSettings settings)
            => _database = client.GetDatabase(settings.DatabaseName);

        public IMongoCollection<T> GetCollection<T>(string name) where T : class
            => _database.GetCollection<T>(name);
    }
}