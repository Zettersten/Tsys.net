using System.Linq;

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
            string digitsOnly = new string(value.Where(x => char.IsDigit(x)).ToArray());
            long phoneNumber = long.Parse(digitsOnly);

            return string.Format("{0:###-#######}", phoneNumber);
        }
    }
}