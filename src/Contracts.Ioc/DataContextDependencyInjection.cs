using Contracts.Infra.Data.MongoDb;
using Contracts.Shared.Settings;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Contracts.Ioc
{
    public static class DataContextDependencyInjection
    {
        public static void AddDataContext(this IServiceCollection services, AppSettings settings)
        {
            services.AddSingleton((IMongoClient)new MongoClient(settings.ConnectionString));
            services.AddSingleton<ContractsContext>();
        }
    }
}
