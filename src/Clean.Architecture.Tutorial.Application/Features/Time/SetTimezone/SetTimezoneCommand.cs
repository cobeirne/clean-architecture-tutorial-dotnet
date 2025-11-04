using MediatR;

namespace Clean.Architecture.Tutorial.Application.Features.Time.SetTimezone;

// Command to post a timezone
public sealed record SetTimezoneCommand(string Timezone) : IRequest<SetTimezoneResult>;

// Result returned to API
public sealed record SetTimezoneResult(string Timezone, DateTimeOffset ReceivedAt, string Message);