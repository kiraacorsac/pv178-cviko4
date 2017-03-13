using System;

namespace Params
{
    /// <summary>
    /// simple class that represents log event
    /// </summary>
    public class EventLog
    {
        public string EventDescription { get; private set; }
        public DateTime LoggeDateTime { get; private set; }

        public EventLog(string description, DateTime logTime)
        {
            this.EventDescription = description ?? "General event has occurred at: ";
            this.LoggeDateTime = logTime;
        }
    }
}
