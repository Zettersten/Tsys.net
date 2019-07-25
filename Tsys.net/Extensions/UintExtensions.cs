using System;
using System.Diagnostics;
using System.Globalization;

namespace Tsys.net.Extensions
{
    public static class UintExtensions
    {
        public static uint GenerateRetrievalReferenceNumber(this uint value)
        {
            if (value == 0)
            {
                value = GenerateSystemTraceAuditNumber();
            }

            return value;
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