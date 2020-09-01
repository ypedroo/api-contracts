using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts.Shared;
using OperationResult;

namespace Contracts.Domain.Repositories
{
    public interface IPartRepository
    {
        Result<List<PartDto>> GetParts();
        Result<PartDto> GetPartById(int id);
        Task CreatePart(PartDto part);
    }
}
