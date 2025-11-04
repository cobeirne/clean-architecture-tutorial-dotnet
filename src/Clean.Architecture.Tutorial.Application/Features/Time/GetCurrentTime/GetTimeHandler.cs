using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Clean.Architecture.Tutorial.Application.Features.Time.GetCurrentTime
{
    public sealed class GetTimeHandler : IRequestHandler<GetTimeQuery, TimeDto>
    {
        // Example of injecting dependencies (e.g., logging, repos) if needed
        public Task<TimeDto> Handle(GetTimeQuery request, CancellationToken ct)
        {
            // Pretend to consult a service; keep it simple for the demo
            var now = request.Timezone?.ToUpperInvariant() switch
            {
                "UTC" or "Z" => DateTimeOffset.UtcNow,
                _ => DateTimeOffset.Now // your server’s local time
            };

            var result = new TimeDto(
                Timezone: string.IsNullOrWhiteSpace(request.Timezone) ? "Local" : request.Timezone,
                Now: now,
                Source: "MediatR handler"
            );

            return Task.FromResult(result);
        }
    }
}
