using Contracts.Domain.Core.Models;
using Contracts.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Contracts.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public T Get()
        {
            throw new System.NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
