using Contracts.Domain.Core.Models;

namespace Contracts.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T :  Entity
    {

    }
}
