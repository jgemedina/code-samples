using System;
using System.Collections.Generic;

using LogsMonitor.Core.Model;
using LogsMonitor.Core.Abstractions;

namespace LogsMonitor.Service
{
    public sealed class ActivityLogsService : IActivityLogsService
    {
        private readonly IActivityLogsRepository _logsRepository;

        public ActivityLogsService(IActivityLogsRepository logsRepository)
        {
            _logsRepository = logsRepository ?? throw new ArgumentNullException(nameof(logsRepository));
        }

        public IEnumerable<ActivityLogEntry> GetActivityLogs() => _logsRepository.GetActivityLogs();
    }
}