using System.Collections.Generic;

using CacheCow.Server;

namespace LogsMonitor.Host.CacheComponents
{
    using Models;

    internal sealed class ActivityLogEntryCollectionETagExtractor : ITimedETagExtractor<IEnumerable<ActivityLogEntryViewModel>>
    {
        public TimedEntityTagHeaderValue Extract(IEnumerable<ActivityLogEntryViewModel> viewModel)
        {
            throw new System.NotImplementedException();
        }

        public TimedEntityTagHeaderValue Extract(object viewModel) => Extract(viewModel as IEnumerable<ActivityLogEntryViewModel>);
    }
}