using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts.Domain.Repositories;
using Contracts.Shared;
using OperationResult;

namespace Contracts.Infra.Data.Repositories
{
    public sealed class PartRepository : IPartRepository
    {
        public Task CreatePart(PartViewModel part)
        {
            throw new System.NotImplementedException();
        }

        public Result<PartViewModel> GetPartById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Result<List<PartViewModel>> GetParts()
        {
            throw new System.NotImplementedException();
        }
    }
}
