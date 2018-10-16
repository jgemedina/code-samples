using System.Text;
using System.Security.Cryptography;

using CacheCow.Server;

namespace LogsMonitor.Host.CacheComponents
{
    using Models;

    internal sealed class ActivityLogEntryETagExtractor : ITimedETagExtractor<ActivityLogEntryViewModel>
    {
        public TimedEntityTagHeaderValue Extract(ActivityLogEntryViewModel viewModel)
        {
            var tagValue = new StringBuilder(32);
            /**
             * This is where we use a field from the instance to calculate the etag
             * 'EventTimestamp' is not a good example but just using it to fill in code.
             *
             * If this resource did change on the server, the etag calculated would eventually be
             * different from that cached on the client.
             *
             * This does not suffice the list but it would work if we retrieved a single
             * entry.
             */
            foreach (var b in SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(viewModel.EventTimestamp)))
            {
                tagValue.Append(b.ToString("x2"));
            }
            return new TimedEntityTagHeaderValue(tagValue.ToString());
        }

        public TimedEntityTagHeaderValue Extract(object viewModel) => Extract(viewModel as ActivityLogEntryViewModel);
    }
}