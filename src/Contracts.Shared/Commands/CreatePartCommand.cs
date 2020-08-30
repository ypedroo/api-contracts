using MediatR;
using OperationResult;

namespace Contracts.Shared.Commands
{
    public sealed class CreatePartCommand : IRequest<Result<PartViewModel>>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Cpf { get; }
        public string Email { get; }
        public string Phone { get; }

        public CreatePartCommand(PartViewModel part)
        {
            FirstName = part.FirstName;
            LastName = part.LastName;
            Cpf = part.Cpf;
            Email = part.Email;
            Phone = part.Phone;
        }
    }
}