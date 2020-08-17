using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OperationResult;

namespace Contracts.WebApi.Controllers
{
    public partial class ContractsControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;

        protected ContractsControllerBase(IMediator mediator)
            => _mediator = mediator;

        protected async Task<IActionResult> SendCommand<T>(IRequest<Result<T>> request)
            => await _mediator.Send(request).ConfigureAwait(false) switch
            {
                (true, var result, _) => Ok(result),
                (_, _, var error) => HandleError(error)
            };
        protected async Task<IActionResult> SendCommand(IRequest<Result> request, int statusCode = 200)
            => await _mediator.Send(request).ConfigureAwait(false) switch
            {
                (true, _) => StatusCode(statusCode),
                (_, var error) => HandleError(error)
            };

        private IActionResult HandleError(Exception error)
            => error switch
            {
                _ => BadRequest(new ErrorMessage(error.Message))
            };
    }
}