using System;

namespace G42.TimeProviders.Providers
{
    public class SystemUtcTimeProvider : ITimeProvider
    {
        public DateTime GetTime()
        {
            return DateTime.UtcNow;
        }
    }
}