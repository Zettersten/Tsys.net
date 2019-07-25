using System;
using Tsys.net.Models.Shared;
using Tsys.net.Models.SubfieldRecords;

namespace Tsys.net.Extensions
{
    public static class AdditionalAmountInfoModelExtensions
    {
        public static string Serialize(this AdditionalAmountInfoModel additionalAmountInfo)
        {
            return string.Format("{0:00}{1}{2}",
                additionalAmountInfo.AccountType, AsciiTable.FS,
                additionalAmountInfo.AmountType, AsciiTable.FS,
                additionalAmountInfo.CurrencyCode, AsciiTable.FS,
                additionalAmountInfo.Sign, AsciiTable.FS,
                additionalAmountInfo.Amount, AsciiTable.FS
            );
        }

        public static AdditionalAmountInfoModel Deserialize<T>(this string value) where T : AdditionalAmountInfoModel
        {
            throw new NotImplementedException();
        }
    }
}