﻿using System.Collections.Generic;

namespace FireEvents.Shared
{
    public interface IEventTracker
    {
        void SendEvent(string eventId);
        void SendEvent(string eventId, string paramName, string value);
        void SendEvent(string eventId, IDictionary<string, string> parameters);
    }
}