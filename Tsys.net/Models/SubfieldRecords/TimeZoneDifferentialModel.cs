﻿using Tsys.net.Extensions;

namespace Tsys.net.Models.SubfieldRecords
{
    public class TimeZoneDifferentialModel
    {
        public uint TimeZoneDirection { get; set; }

        public uint TimeZoneDifference { get; set; }

        public static TimeZoneDifferentialModel NewTimeZoneDifferential(uint timeZoneDirection, uint zoneDiff)
        {
            return new TimeZoneDifferentialModel
            {
                TimeZoneDifference = zoneDiff,
                TimeZoneDirection = timeZoneDirection
            };
        }

        public static implicit operator TimeZoneDifferentialModel(string value)
        {
            return TimeZonDifferentialModelExtensions.Deserialize<TimeZoneDifferentialModel>(value);
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}