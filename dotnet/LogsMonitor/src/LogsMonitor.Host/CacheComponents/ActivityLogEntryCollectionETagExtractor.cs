using System.Collections.Generic;

using CacheCow.Server;

using LogsMonitor.Core.Model;

namespace LogsMonitor.Host.CacheComponents
{
    internal sealed class ActivityLogEntryCollectionETagExtractor : ITimedETagExtractor<IEnumerable<ActivityLogEntry>>
    {
        public TimedEntityTagHeaderValue Extract(IEnumerable<ActivityLogEntry> viewModel)
        {
            throw new System.NotImplementedException();
        }

        public TimedEntityTagHeaderValue Extract(object viewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}