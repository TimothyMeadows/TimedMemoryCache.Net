using System;
using System.Collections.Generic;
using System.Text;

namespace TimedMemoryCache.Net
{
    public delegate void TimeoutCallback(TimedMemoryCache source, string key, dynamic value, long timeout);
}
