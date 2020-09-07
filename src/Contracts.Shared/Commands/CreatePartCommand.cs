using Contracts.Shared.Dtos;
using MediatR;
using OperationResult;

namespace Contracts.Shared.Commands
{
    public sealed class CreatePartCommand : IRequest<Result>
    {
        public PartDto Part { get; }

        public CreatePartCommand(PartDto request)
        {
            Part.FirstName = request.FirstName;
            Part.LastName = request.LastName;
            Part.Cpf = request.Cpf;
            Part.Email = request.Email;
            Part.Phone = request.Phone;
        }
    }
}