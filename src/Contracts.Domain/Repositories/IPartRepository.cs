using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts.Domain.Models;
using OperationResult;

namespace Contracts.Domain.Repositories
{
    public interface IPartRepository
    {
        Result<List<PartViewModel>> GetParts();
        Result<PartViewModel> GetPartById(int id);
        Task CreatePart(PartViewModel part);
    }
}
