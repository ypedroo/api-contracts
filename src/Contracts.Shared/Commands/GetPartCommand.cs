using Contracts.Domain.Models;
using MediatR;
using OperationResult;

namespace Contracts.Shared.Commands
{
    public sealed class GetPartCommand : IRequest<Result<Domain.Models.Part>>
    {
        public int Id { get; }
        public GetPartCommand(int id) => Id = id;
    }
}
