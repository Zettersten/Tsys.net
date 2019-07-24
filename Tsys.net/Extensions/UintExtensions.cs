using System;
using System.Diagnostics;
using System.Globalization;

namespace Tsys.net.Extensions
{
    public static class UintExtensions
    {
        public static uint GenerateRetrievalReferenceNumber(this uint value)
        {
            var now = DateTime.UtcNow;
            var julianDate = new JulianCalendar();
            var julianDay = julianDate.GetDayOfYear(now);

            var refString = string.Format("{0}", now.Year.PadLeft(4, '0'), julianDay.PadLeft(3, '0'), value);
            var parsedRef = refString.Substring(3, 15).PadLeft(12, '0');

            return uint.Parse(parsedRef);
        }

        public static long GetNanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;

            return nano;
        }

        public static uint GenerateSystemTraceAuditNumber()
        {
            var nano = GetNanoTime();
            var trace = nano.ToString().Truncate(6);

            return uint.Parse(trace);
        }
    }
}