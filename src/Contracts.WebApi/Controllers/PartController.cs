using System.Threading.Tasks;
using Contracts.Domain.Models;
using Contracts.Shared.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Contracts.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PartController : ContractsControllerBase
    {
        public PartController(IMediator mediator)
        : base(mediator)
        {
        }

        [HttpGet("info/partById")]
        public Task<IActionResult> GetPartById(int id)
            => SendCommand(new GetPartCommand(id));

        //doubt if query commands are the same with different methods check thiss

        [HttpGet("info/parts")]
        public Task<IActionResult> GetParts()
            => SendCommand(new GetAllPartsCommand());

        //Refactor part to view model object on shared
        [HttpPost("info/parts")]
        public Task<IActionResult> CreatePart(Part part)
            => SendCommand(new CreatePartCommand(part));
    }
}