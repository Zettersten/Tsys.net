using System.Linq;
using Tsys.net.Models;

namespace Tsys.net.Extensions
{
    public static class MerchantIdentifierExtensions
    {
        public static string FormatMerchantName(this MerchantIdentifierModel merchant)
        {
            string value = merchant.MerchantName.Truncate(25);

            return value.PadRight(25, ' ');
        }

        public static string FormatMerchantCity(this MerchantIdentifierModel merchant)
        {
            string value = merchant.MerchantCity;

            return value.Truncate(13).Trim().PadRight(13, ' ');
        }

        public static string FormatMerchantNumber(this MerchantIdentifierModel merchant)
        {
            long value = merchant.MerchantNumber;

            return $"{value}".PadLeft(12, '0');
        }

        public static string FormatMerchantState(this MerchantIdentifierModel merchant)
        {
            string value = merchant.MerchantState;

            return $"{value}".Truncate(2).ToUpper();
        }

        public static string FormatStoreNumber(this MerchantIdentifierModel merchant)
        {
            int value = merchant.StoreNumber;

            return $"{value}".PadLeft(4, '0');
        }

        public static string FormatCityCode(this MerchantIdentifierModel merchant)
        {
            string value = merchant.CityCode;

            return $"{value}".PadRight(9, ' ');
        }

        public static string FormatStreetAddress(this MerchantIdentifierModel merchant)
        {
            string value = merchant.MerchantStreetAddress;
            string digitsAndSpacesOnly = new string(value.Where(x => char.IsDigit(x) || char.IsWhiteSpace(x)).ToArray());

            return digitsAndSpacesOnly.Truncate(20).Trim();
        }

        public static string FormatMerchantEmailAddress(this MerchantIdentifierModel merchant)
        {
            string value = merchant.MerchantEmail;

            return value.Truncate(20).Trim();
        }

        public static string FormatCustomerServicePhoneNumber(this MerchantIdentifierModel merchant)
        {
            string value = merchant.CustomerServicePhoneNumber;

            return value.FormatPhoneNumber();
        }

        public static string FormatMerchantPhoneNumber(this MerchantIdentifierModel merchant)
        {
            string value = merchant.MerchantPhoneNumber;

            return value.FormatPhoneNumber();
        }
    }
}