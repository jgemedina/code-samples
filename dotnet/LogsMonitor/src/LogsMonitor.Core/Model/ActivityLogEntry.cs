using System;

namespace LogsMonitor.Core.Model
{
    public sealed class ActivityLogEntry
    {
        public ActivityLogEntry()
        {
            ID = Guid.NewGuid();
            EventTimestamp = DateTime.Now;
        }

        public Guid ID { get; private set; }
        public DateTime EventTimestamp { get; private set; }
        public string SystemArea { get; set; }
        public string UserAction { get; set; }
        public User Who { get; set; }
    }
}