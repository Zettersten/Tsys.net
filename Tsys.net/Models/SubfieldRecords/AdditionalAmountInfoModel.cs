using Tsys.net.Extensions;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.SubfieldRecords
{
    public class AdditionalAmountInfoModel
    {
        /// <summary>
        /// 2 NUM 4.9.1 First Additional Amount Account Type
        /// </summary>
        public AdditionalAmountAccountTypeModel AccountType { get; set; }

        /// <summary>
        ///  2 NUM 4.9.2 First Additional Amount Amount Type
        /// </summary>
        public AdditionalAmountTypeModel AmountType { get; set; }

        /// <summary>
        ///  3 NUM 4.9.3 First Additional Amount Currency Code
        /// </summary>
        public CurrencyCodeTypeModel CurrencyCode { get; set; }

        /// <summary>
        ///  1 ALPHA 4.9.4 First Additional Amount Sign
        /// </summary>
        public AdditionalAmountSignTypeModel Sign { get; set; }

        /// <summary>
        ///  12 N 4.9.5 First Additional Amount
        /// </summary>
        public long Amount { get; set; }

        public static implicit operator AdditionalAmountInfoModel(string value)
        {
            return AdditionalAmountInfoModelExtensions.Deserialize<AdditionalAmountInfoModel>(value);
        }

        public static AdditionalAmountInfoModel NewAdditionalAmountInfo(AdditionalAmountAccountTypeModel accountType, AdditionalAmountTypeModel type, CurrencyCodeTypeModel currency, AdditionalAmountSignTypeModel sign, long amount)
        {
            return new AdditionalAmountInfoModel
            {
                AccountType = accountType,
                AmountType = type,
                Amount = amount,
                CurrencyCode = currency,
                Sign = sign
            };
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}