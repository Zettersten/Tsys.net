using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.SubfieldRecords;

namespace Tsys.net.Extensions
{
    public static class TimeZonDifferentialModelExtensions
    {
        public static string Serialize(this TimeZoneDifferentialModel timeZoneDifferential)
        {
            return string.Format("{0}{1}", timeZoneDifferential.TimeZoneDirection, timeZoneDifferential.TimeZoneDifference.ToString().PadLeft(2, '0'));
        }

        public static TimeZoneDifferentialModel Deserialize(string value)
        {
            var result = new TimeZoneDifferentialModel();

            if (3 > value.Length)
            {
                return result;
            }

            result.TimeZoneDirection = uint.Parse(value.Truncate(1));
            result.TimeZoneDifference = uint.Parse(value.Substring(1));

            return result;
        }
    }
}