using Contracts.Domain.Models;
using MediatR;
using OperationResult;

namespace Contracts.Shared.Commands
{
    public sealed class GetAllPartsCommand : IRequest<Result<Domain.Models.Part>>
    {
        public GetAllPartsCommand()
        {
        }
    }
}
