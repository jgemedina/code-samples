using CacheCow.Server;

using LogsMonitor.Core.Model;

namespace LogsMonitor.Host.CacheComponents
{
    internal sealed class ActivityLogEntryETagExtractor : ITimedETagExtractor<ActivityLogEntry>
    {
        public TimedEntityTagHeaderValue Extract(ActivityLogEntry viewModel)
        {
            throw new System.NotImplementedException();
        }

        public TimedEntityTagHeaderValue Extract(object viewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}