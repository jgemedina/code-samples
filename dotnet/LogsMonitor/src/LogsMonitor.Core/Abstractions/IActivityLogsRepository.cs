using System.Collections.Generic;

namespace LogsMonitor.Core.Abstractions
{
    using Model;

    public interface IActivityLogsRepository
    {
        IEnumerable<ActivityLogEntry> GetActivityLogs();
    }
}