namespace Tsys.net.Models.Constants
{
    public struct MessageConstants
    {
        /// <summary>
        /// Credit Card Authorization request messages (Groups I and III)
        /// </summary>
        public const string CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE = "D";

        /// <summary>
        /// Encrypted Credit Card Authorization request messages (Group I and III)
        /// </summary>
        public const string ENCRYPTED_CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE = "W";

        /// <summary>
        /// Credit Card authorization response messages (Groups I and III)
        /// </summary>
        public const string CREDIT_CARD_AUTHORIZATION_RESPONSE_MESSAGE = "E";

        /// <summary>
        /// Single authorization per connection (“Single-Trans.”)
        /// </summary>
        public const string SINGLE_AUTHORIZATION_PER_CONNECTION = "0";

        /// <summary>
        /// Multiple authorizations per connection, single-threaded (“Multi- Trans.”)
        /// </summary>
        public const string MULTIPLE_AUTHORIZATION_PER_CONNECTION = "2";

        /// <summary>
        /// Multiple authorizations per connection, full-duplex (“Interleaved”)
        /// </summary>
        public const string INTERLEAVED_AUTHORIZATION_PER_CONNECTION = "4";

        /// <summary>
        /// The message delimiter separates the record format and application type designators from the
        /// body of the message(see Table 4.5, Table 4.4, Table 4.6 for record formats and version
        /// numbers). The message delimiter is defined as a “.” (Hex 2E or Decimal 46-character).
        /// </summary>
        public const string MessageDelimiter = ".";

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
        public struct TimeZoneDifferential
        {
            public const uint EST = 705;

            public const uint CST = 706;

            public const uint MST = 707;

            public const uint PST = 708;
        }
    }
}