using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct TimeZoneDirectionTypeModel
    {
        public const uint HoursAheadOfGMT = 0;
        public const uint QuarterHoursAheadOfGMT = 2;
        public const uint QuarterHoursAheadOfGMTWithDaylightSavings = 4;
        public const uint HoursAheadOfGMTWithDaylightSavings = 6;
        public const uint HoursBehindGMT = 1;
        public const uint QuarterHoursBehindGMT = 3;
        public const uint QuarterHoursBehindGMTWithDaylightSavings = 5;
        public const uint HoursBehindGMTWithDaylightSavings = 7;

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case HoursAheadOfGMT:
                    return nameof(HoursAheadOfGMT);

                case QuarterHoursAheadOfGMT:
                    return nameof(QuarterHoursAheadOfGMT);

                case QuarterHoursAheadOfGMTWithDaylightSavings:
                    return nameof(QuarterHoursAheadOfGMTWithDaylightSavings);

                case HoursAheadOfGMTWithDaylightSavings:
                    return nameof(HoursAheadOfGMTWithDaylightSavings);

                case HoursBehindGMT:
                    return nameof(HoursBehindGMT);

                case QuarterHoursBehindGMT:
                    return nameof(QuarterHoursBehindGMT);

                case QuarterHoursBehindGMTWithDaylightSavings:
                    return nameof(QuarterHoursBehindGMTWithDaylightSavings);

                case HoursBehindGMTWithDaylightSavings:
                    return nameof(HoursBehindGMTWithDaylightSavings);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }
    }
}