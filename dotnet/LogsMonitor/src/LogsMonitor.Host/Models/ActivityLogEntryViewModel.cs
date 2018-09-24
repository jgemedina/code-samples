using System;

namespace LogsMonitor.Host.Models
{
    public sealed class ActivityLogEntryViewModel
    {
        public string EventTimestamp { get; set; }

        public string UserIdentity { get; set; }

        public string SystemArea { get; set; }

        public string UserAction { get; set; }
    }
}