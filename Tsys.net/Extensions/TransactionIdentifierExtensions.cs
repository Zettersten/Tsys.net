using System.Linq;
using Tsys.net.Models;

namespace Tsys.net.Extensions
{
    public static class TransactionIdentifierExtensions
    {
        public static string FormatTransactionSequenceNumber(this TsysAuthenticationMessageModel message)
        {
            uint value = message.TransactionSequenceNumber;

            return $"{value}".PadLeft(4, '0');
        }

        public static string FormatMerchantName(this TsysAuthenticationMessageModel message)
        {
            string value = message.MerchantName.Truncate(25);

            return value.PadRight(25, ' ');
        }

        public static string FormatMerchantCity(this TsysAuthenticationMessageModel message)
        {
            string value = message.MerchantCity;

            return value.Truncate(13).Trim().PadRight(13, ' ');
        }

        public static string FormatMerchantNumber(this TsysAuthenticationMessageModel message)
        {
            ulong value = message.MerchantNumber;

            return $"{value}".PadLeft(12, '0');
        }

        public static string FormatMerchantState(this TsysAuthenticationMessageModel message)
        {
            string value = message.MerchantState;

            return $"{value}".Truncate(2).ToUpper();
        }

        public static string FormatStoreNumber(this TsysAuthenticationMessageModel message)
        {
            uint value = message.StoreNumber;

            return $"{value}".PadLeft(4, '0');
        }

        public static string FormatCityCode(this TsysAuthenticationMessageModel message)
        {
            string value = message.CityCode;

            return $"{value}".PadRight(9, ' ');
        }

        public static string FormatStreetAddress(this TsysAuthenticationMessageModel message)
        {
            string value = message.MerchantStreetAddress;
            string digitsAndSpacesOnly = new string(value.Where(x => char.IsDigit(x) || char.IsWhiteSpace(x)).ToArray());

            return digitsAndSpacesOnly.Truncate(20).Trim();
        }

        public static string FormatMerchantEmailAddress(this TsysAuthenticationMessageModel message)
        {
            string value = message.MerchantEmail;

            return value.Truncate(20).Trim();
        }

        public static string FormatCustomerServicePhoneNumber(this TsysAuthenticationMessageModel message)
        {
            string value = message.CustomerServicePhoneNumber;

            return value.FormatPhoneNumber();
        }

        public static string FormatMerchantPhoneNumber(this TsysAuthenticationMessageModel message)
        {
            string value = message.MerchantPhoneNumber;

            return value.FormatPhoneNumber();
        }
    }
}