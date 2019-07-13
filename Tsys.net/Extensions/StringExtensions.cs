using System.Linq;
using System.Text;
using Tsys.net.Models.Constants;
using Tsys.net.Models.Shared;

namespace Tsys.net.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Get a substring of the first N characters.
        /// </summary>
        public static string Truncate(this string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }

            return source;
        }

        /// <summary>
        /// Takes a phone number of any format and produces ###-#######
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatPhoneNumber(this string value)
        {
            string[] countryCodesToRemove = new string[] { "+376", "+971", "+93", "+1268", "+1264", "+355", "+374", "+599", "+244", "+672", "+54", "+1684", "+43", "+61", "+297", "+994", "+387", "+1246", "+880", "+32", "+226", "+359", "+973", "+257", "+229", "+590", "+1441", "+673", "+591", "+55", "+1242", "+975", "+267", "+375", "+501", "+1", "+61", "+243", "+236", "+242", "+41", "+225", "+682", "+56", "+237", "+86", "+57", "+506", "+53", "+238", "+61", "+357", "+420", "+49", "+253", "+45", "+1767", "+1809", "+213", "+593", "+372", "+20", "+291", "+34", "+251", "+358", "+679", "+500", "+691", "+298", "+33", "+241", "+44", "+1473", "+995", "+233", "+350", "+299", "+220", "+224", "+240", "+30", "+502", "+1671", "+245", "+592", "+852", "+504", "+385", "+509", "+36", "+62", "+353", "+972", "+44", "+91", "+964", "+98", "+354", "+39", "+1876", "+962", "+81", "+254", "+996", "+855", "+686", "+269", "+1869", "+850", "+82", "+965", "+1345", "+7", "+856", "+961", "+1758", "+423", "+94", "+231", "+266", "+370", "+352", "+371", "+218", "+212", "+377", "+373", "+382", "+1599", "+261", "+692", "+389", "+223", "+95", "+976", "+853", "+1670", "+222", "+1664", "+356", "+230", "+960", "+265", "+52", "+60", "+258", "+264", "+687", "+227", "+234", "+505", "+31", "+47", "+977", "+674", "+683", "+64", "+968", "+507", "+51", "+689", "+675", "+63", "+92", "+48", "+508", "+870", "+1", "+351", "+680", "+595", "+974", "+40", "+381", "+7", "+250", "+966", "+677", "+248", "+249", "+46", "+65", "+290", "+386", "+421", "+232", "+378", "+221", "+252", "+597", "+239", "+503", "+963", "+268", "+1649", "+235", "+228", "+66", "+992", "+690", "+670", "+993", "+216", "+676", "+90", "+1868", "+688", "+886", "+255", "+380", "+256", "+1", "+598", "+998", "+39", "+1784", "+58", "+1284", "+1340", "+84", "+678", "+681", "+685", "+381", "+967", "+262", "+27", "+260", "+263" };

            foreach (string countryCode in countryCodesToRemove)
            {
                value = value.Replace(countryCode, string.Empty).Trim();
            }

            string digitsOnly = new string(value.Where(x => char.IsDigit(x)).ToArray());
            long phoneNumber = long.Parse(digitsOnly);

            return string.Format("{0:###-#######}", phoneNumber);
        }

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
        public static StringBuilder BeginTsysMessage(this StringBuilder stringBuilder, string applicationType, string recordFormat)
        {
            return stringBuilder.Append($"{recordFormat}{applicationType}{MessageConstants.MessageDelimiter}");
        }

        /// <summary>
        /// Build end of TSYS message
        /// </summary>
        /// <param name="stringBuilder">TSYS message body</param>
        /// <returns></returns>
        public static string EndTsysMessage(this StringBuilder stringBuilder)
        {
            return $"{AsciiTable.STX}{stringBuilder}{AsciiTable.ETX}{GetLRC(stringBuilder + AsciiTable.ETX)}";
        }

        /// <summary>
        /// Used to calculate end message sentinal
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static char GetLRC(this string message)
        {
            char lrc = char.MinValue;
            char[] chars = message.ToCharArray();

            foreach (char c in chars)
            {
                lrc ^= c;
            }

            return (lrc);
        }
    }
}