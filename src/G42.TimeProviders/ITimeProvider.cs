using System;

namespace G42.TimeProviders
{
    public interface ITimeProvider
    {
        DateTime GetTime();
    }
}