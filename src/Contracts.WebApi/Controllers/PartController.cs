﻿using System.Threading.Tasks;
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
    }
}
