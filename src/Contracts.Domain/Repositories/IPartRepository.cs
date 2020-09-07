using System.Collections.Generic;
using Contracts.Shared.Dtos;
using OperationResult;

namespace Contracts.Domain.Repositories
{
    public interface IPartRepository
    {
        Result<List<PartDto>> GetParts();
        Result<PartDto> GetPartById(int id);
        Result CreatePart(PartDto part);
    }
}
