using System.Collections.Generic;

namespace LogsMonitor.Core.Abstractions
{
    using Model;
    
    public interface IActivityLogsService
    {
        IEnumerable<ActivityLogEntry> GetActivityLogs();
    }
}