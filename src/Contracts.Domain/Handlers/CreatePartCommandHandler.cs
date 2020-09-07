using System.Threading;
using System.Threading.Tasks;
using Contracts.Domain.Repositories;
using Contracts.Shared.Commands;
using MediatR;
using OperationResult;

namespace Contracts.Domain.Handlers
{
    public sealed class CreatePartCommandHandler : IRequestHandler<CreatePartCommand, Result>
    {
        private readonly IPartRepository _repository;

        public CreatePartCommandHandler(IPartRepository repository) => _repository = repository;

        public Task<Result> Handle(CreatePartCommand request, CancellationToken cancellationToken)
            => _repository.CreatePart(request.Part);
    }
}