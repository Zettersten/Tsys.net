using System.Linq;
using Tsys.net.Models;
using Tsys.net.Models.Shared;

namespace Tsys.net.Extensions
{
    public static class CustomerIdentifierExtensions
    {
        public static string FormatCustomerDataField(this CustomerIdentifierModel customer)
        {
            string value = customer.ToString();

            value = value
                .Replace("=", AsciiTable.D)
                .Replace("^", AsciiTable.US);

            return value;
        }

        public static string FormatCustomerStreetAddress(this CustomerAddressIdentifierModel customer)
        {
            string value = customer.StreetAdress;

            string digitsAndSpacesOnly = new string(value.Where(x => char.IsDigit(x) || char.IsWhiteSpace(x)).ToArray());

            if (digitsAndSpacesOnly.Length <= 20)
            {
                return digitsAndSpacesOnly.Trim();
            }

            return digitsAndSpacesOnly.Substring(0, 20).Trim();
        }

        public static string FormatCustomerZipCode(this CustomerAddressIdentifierModel customer)
        {
            string value = customer.ZipCode;

            return $"{value}";
        }
    }
}