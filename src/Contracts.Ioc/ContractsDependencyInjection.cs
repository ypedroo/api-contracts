using System.Reflection;
using AutoMapper;
using Contracts.Domain.MappingProfiles;
using Contracts.Domain.Repositories;
using Contracts.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Contracts.Ioc
{
    public static class ContractsDependencyInjection
    {
        public static void AddContractsConfigurations(this IServiceCollection services)
        {
            services.AddTransient<IPartRepository, PartRepository>();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(PartMappingProfile)));
        }
    }
}