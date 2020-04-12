using MediatR;
using Flunt.Notifications;
using Flunt.Validations;

namespace Contracts.Domain.Core.Commands
{
    public class CommandBase : Notifiable, IValidatable, IRequest<CommandResult>
    {
        public virtual void Validate() { }
    }
}
