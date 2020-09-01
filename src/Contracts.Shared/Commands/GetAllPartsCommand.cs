using Contracts.Shared.Dtos;
using MediatR;
using OperationResult;

namespace Contracts.Shared.Commands
{
    public sealed class GetAllPartsCommand : IRequest<Result<PartDto>>
    {
        public GetAllPartsCommand()
        {
        }
    }
}
