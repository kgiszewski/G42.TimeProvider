using System;

namespace G42.TimeProviders.Providers
{
    public class SpecificTimeProvider : ITimeProvider
    {
        private DateTime _dateTime;

        public SpecificTimeProvider(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public DateTime GetTime()
        {
            return _dateTime;
        }

        public void SetTime(DateTime time)
        {
            _dateTime = time;
        }
    }
}