using CharlieBackend.Application.Interfaces.Shared;
using System;

namespace CharlieBackend.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}