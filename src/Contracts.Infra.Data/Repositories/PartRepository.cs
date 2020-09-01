using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts.Domain.Repositories;
using Contracts.Shared;
using OperationResult;

namespace Contracts.Infra.Data.Repositories
{
    public sealed class PartRepository : IPartRepository
    {
        public Task CreatePart(PartDto part)
        {
            throw new System.NotImplementedException();
        }

        public Result<PartDto> GetPartById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Result<List<PartDto>> GetParts()
        {
            throw new System.NotImplementedException();
        }
    }
}
