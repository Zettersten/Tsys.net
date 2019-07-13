namespace Tsys.net.Models.Shared
{
    public static class TsysMessageHelper
    {
        /// <summary>
        /// The message delimiter separates the record format and application type designators from the
        /// body of the message(see Table 4.5, Table 4.4, Table 4.6 for record formats and version
        /// numbers). The message delimiter is defined as a “.” (Hex 2E or Decimal 46-character).
        /// </summary>
        public static string MessageDelimiter = ".";

        /// <summary>
        /// This field contains a three-character numeric code used to calculate the local time within the
        /// TSYS Acquiring Solutions authorization system(see Table 4.5 for record format and version
        /// number). The differential is calculated by the signing member or processor, providing the
        /// standard local time zone differential from Greenwich Mean Time(GMT). The first character
        /// numeric specifies the direction of the differential and offset increment as well as whether
        /// daylight savings is observed, and the last two-character numeric specify the magnitude of the
        /// differential.For example, Virginia would be 705, California would be 708, and Arizona would
        /// be 107 (daylight savings not observed). Table 5.76 provides a brief summary of the Time Zone
        /// Differential codes.
        /// ===
        /// 705 - EST
        /// 706 - CST
        /// 707 - MST
        /// 708 - PST
        /// </summary>
        public const int TimeZoneDifferential = 705;

        /// <summary>
        /// Build start of TSYS message
        /// </summary>
        /// <param name="applicationType">
        /// The TSYS Acquiring Solutions authorization system supports a number of communication
        /// interface applications (see Table 4.5, Table 4.4 for record formats and version numbers).
        /// These applications include:
        /// </param>
        /// <param name="recordFormat">
        /// This one-character field identifies the message format with the TSYS Acquiring Solutions
        /// system(see Table 4.5, Table 4.4, Table 4.6 for record formats and version numbers). The
        /// second-generation authorization format is specified by placing one of the defined values in the
        /// record format field.Table 5.67 provides a brief summary of the current formats.
        /// </param>
        /// <returns></returns>
        public static string StartMessage(string applicationType, string recordFormat)
        {
            return $"{recordFormat}{applicationType}{MessageDelimiter}";
        }

        /// <summary>
        /// Build end of TSYS message
        /// </summary>
        /// <param name="message">TSYS message body</param>
        /// <returns></returns>
        public static string EndMessage(string message)
        {
            return $"{AsciiTable.STX}{message}{AsciiTable.ETX}{GetLRC(message + AsciiTable.ETX)}";
        }

        /// <summary>
        /// Used to calculate end message sentinal
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static char GetLRC(string message)
        {
            var lrc = char.MinValue;
            var chars = message.ToCharArray();

            foreach (char c in chars)
            {
                lrc ^= c;
            }

            return (lrc);
        }
    }
}