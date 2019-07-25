using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class CardAcceptorDataFieldModelExtensions
    {
        public static CardAcceptorDataFieldModel Deserialize<T>(this string value, string transactionCodeTypeModel = TransactionCodeTypeModel.PurchaseCardNotPresent) where T : CardAcceptorDataFieldModel
        {
            var result = new CardAcceptorDataFieldModel
            {
                CustomerServicePhoneNumber = 0,
                MerchantCity = "",
                MerchantName = "",
                MerchantState = "",
                TicketNumber = ""
            };

            if (40 > value.Length)
            {
                return result;
            }

            result.MerchantName = value.Truncate(25);

            switch (transactionCodeTypeModel)
            {
                case TransactionCodeTypeModel.PurchaseCardNotPresent:
                case TransactionCodeTypeModel.PurchaseCardNotPresentRepeat:
                case TransactionCodeTypeModel.CreditAccountFundingOrPayment:
                case TransactionCodeTypeModel.CreditAccountFundingOrPaymentRepeat:
                case TransactionCodeTypeModel.CardholderFundsTransferCardNotPresent:
                case TransactionCodeTypeModel.CardholderFundsTransferCardNotPresentRepeat:

                    result.CustomerServicePhoneNumber = long.Parse(value.Substring(25, 38).Trim().Replace("-", string.Empty));

                    break;

                default:

                    result.MerchantCity = value.Substring(25, 38).Trim();

                    break;
            }

            result.MerchantState = value.Substring(38);

            return result;
        }

        public static string Serialize(this CardAcceptorDataFieldModel cardAcceptorDataField, string transactionCodeTypeModel = TransactionCodeTypeModel.PurchaseCardNotPresent)
        {
            string result = string.Empty;

            switch (transactionCodeTypeModel)
            {
                case TransactionCodeTypeModel.PurchaseCardNotPresent:
                case TransactionCodeTypeModel.PurchaseCardNotPresentRepeat:
                case TransactionCodeTypeModel.CreditAccountFundingOrPayment:
                case TransactionCodeTypeModel.CreditAccountFundingOrPaymentRepeat:
                case TransactionCodeTypeModel.CardholderFundsTransferCardNotPresent:
                case TransactionCodeTypeModel.CardholderFundsTransferCardNotPresentRepeat:

                    result =
                        FormatMerchantName(cardAcceptorDataField) +
                        cardAcceptorDataField.CustomerServicePhoneNumber.FormatPhoneNumber() +
                        FormatMerchantName(cardAcceptorDataField);

                    break;

                default:

                    result =
                        FormatMerchantName(cardAcceptorDataField) +
                        FormatMerchantCity(cardAcceptorDataField) +
                        FormatMerchantName(cardAcceptorDataField);

                    break;
            }

            return result;
        }

        public static string FormatMerchantName(this CardAcceptorDataFieldModel message)
        {
            string value = message.MerchantName.Truncate(25);

            return value.PadRight(25, ' ');
        }

        public static string FormatMerchantCity(this CardAcceptorDataFieldModel message)
        {
            string value = message.MerchantCity;

            return value.Truncate(13).Trim().PadRight(13, ' ');
        }

        public static string FormatMerchantState(this CardAcceptorDataFieldModel message)
        {
            string value = message.MerchantState;

            return $"{value}".Truncate(2).ToUpper();
        }
    }
}