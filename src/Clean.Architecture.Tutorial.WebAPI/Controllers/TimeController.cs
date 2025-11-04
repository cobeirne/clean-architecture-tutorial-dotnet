using Clean.Architecture.Tutorial.Application.Features.Time;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.Tutorial.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TimeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Returns the current time via a MediatR query.
        /// </summary>
        /// <param name="tz">Timezone hint. Use 'UTC' for UTC; anything else uses server local time.</param>
        [HttpGet]
        [ProducesResponseType(typeof(TimeDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<TimeDto>> Get([FromQuery] string? tz, CancellationToken ct)
        {
            var result = await _mediator.Send(new GetTimeQuery(tz ?? ""), ct);

            return Ok(result);
        }
    }
}