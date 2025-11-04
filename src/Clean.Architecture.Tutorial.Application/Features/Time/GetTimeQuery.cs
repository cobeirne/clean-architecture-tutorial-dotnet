using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Clean.Architecture.Tutorial.Application.Features.Time
{
    // Query (read-only request) returning a DTO
    public sealed record GetTimeQuery(string Timezone) : IRequest<TimeDto>;

    // Response DTO
    public sealed record TimeDto(string Timezone, DateTimeOffset Now, string Source);
}
