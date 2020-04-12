using Contracts.Domain.Core.Models;
using System.Collections.Generic;

namespace Contracts.Infra.Data.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        List<T> GetAll();
        T Get();
    }
}
