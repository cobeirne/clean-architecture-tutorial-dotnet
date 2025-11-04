using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Tutorial.Application.Features.Time.SetTimezone
{
    public sealed class SetTimezoneHandler : IRequestHandler<SetTimezoneCommand, SetTimezoneResult>
    {
        public Task<SetTimezoneResult> Handle(SetTimezoneCommand request, CancellationToken ct)
        {
            var tz = string.IsNullOrWhiteSpace(request.Timezone) ? "(empty)" : request.Timezone;

            // Log or debug the command
            Debug.WriteLine($"[SetTimezoneCommand] Received timezone '{tz}' at {DateTimeOffset.UtcNow:o}");

            var result = new SetTimezoneResult(
                Timezone: tz,
                ReceivedAt: DateTimeOffset.UtcNow,
                Message: "Timezone successfully written to Debug"
            );

            return Task.FromResult(result);
        }
    }
}
