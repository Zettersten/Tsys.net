using System.Linq;
using Tsys.net.Models;

namespace Tsys.net.Extensions
{
    public static class MerchantIdentifierExtensions
    {
        public static string FormatMerchantName(this MerchantIdentifierModel merchant)
        {
            var value = merchant.MerchantName.Truncate(15);

            return value.PadRight(25, ' ');
        }

        public static string FormatMerchantCity(this MerchantIdentifierModel merchant)
        {
            var value = merchant.MerchantCity;

            if (value.Length <= 13)
            {
                return value.Trim().PadRight(13, ' ');
            }

            return value.Substring(0, 13).Trim().PadRight(13, ' ');
        }

        public static string FormatMerchantNumber(this MerchantIdentifierModel merchant)
        {
            var value = merchant.MerchantNumber;

            return $"{value}".PadLeft(12, '0');
        }

        public static string FormatStoreNumber(this MerchantIdentifierModel merchant)
        {
            var value = merchant.StoreNumber;

            return $"{value}".PadLeft(4, '0');
        }

        public static string FormatCityCode(this MerchantIdentifierModel merchant)
        {
            var value = merchant.CityCode;

            return $"{value}".PadRight(9, ' ');
        }

        public static string FormatStreetAddress(this MerchantIdentifierModel merchant)
        {
            var value = merchant.MerchantStreetAddress;

            var digitsAndSpacesOnly = new string(value.Where(x => char.IsDigit(x) || char.IsWhiteSpace(x)).ToArray());

            if (digitsAndSpacesOnly.Length <= 20)
            {
                return digitsAndSpacesOnly.Trim();
            }

            return digitsAndSpacesOnly.Substring(0, 20).Trim();
        }

        public static string FormatMerchantEmailAddress(this MerchantIdentifierModel merchant)
        {
            var value = merchant.MerchantEmail;

            return value.Substring(0, 20).Trim();
        }

        public static string FormatCustomerServicePhoneNumber(this MerchantIdentifierModel merchant)
        {
            var value = merchant.CustomerServicePhoneNumber;
            var digitsOnly = new string(value.Where(x => char.IsDigit(x)).ToArray());
            var phoneNumber = long.Parse(digitsOnly);

            return string.Format("{0:###-#######}", phoneNumber);
        }

        public static string FormatMerchantPhoneNumber(this MerchantIdentifierModel merchant)
        {
            var value = merchant.MerchantPhoneNumber;
            var digitsOnly = new string(value.Where(x => char.IsDigit(x)).ToArray());
            var phoneNumber = long.Parse(digitsOnly);

            return string.Format("{0:###-#######}", phoneNumber);
        }
    }
}
