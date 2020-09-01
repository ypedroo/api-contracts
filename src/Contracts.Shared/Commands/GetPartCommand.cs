using Contracts.Shared.Dtos;
using MediatR;
using OperationResult;

namespace Contracts.Shared.Commands
{
    public sealed class GetPartCommand : IRequest<Result<PartDto>>
    {
        public int Id { get; }
        public GetPartCommand(int id) => Id = id;
    }
}
