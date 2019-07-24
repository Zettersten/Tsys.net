using System.Text;
using Tsys.net.Models.Authorizations;
using Tsys.net.Models.Shared;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class Group1AuthorizationModelExtensions
    {
        public static bool IsEcomOrMotoTransaction(this Group1AuthorizationModel group1Authorization)
        {
            return (AccountDataSourceTypeModel.ManuallyKeyedTerminalHasNoCardReadingCapability == group1Authorization.AccountDataSource) &&
                   (TransactionCodeTypeModel.PurchaseCardNotPresent == group1Authorization.TransactionCode || TransactionCodeTypeModel.PurchaseCardNotPresentRepeat == group1Authorization.TransactionCode);
        }

        public static void SetTerminalIdentification(this Group1AuthorizationModel group1Authorization, uint merchantNumber, uint storeNumber, uint terminalNumber, DeviceCodeTypeModel deviceCode, IndustryCodeTypeModel industryCode, MerchantCategoryTypeModel merchantCategory)
        {
            group1Authorization.MerchantNumber = merchantNumber;
            group1Authorization.StoreNumber = storeNumber;
            group1Authorization.TerminalNumber = terminalNumber;
            group1Authorization.DeviceCode = deviceCode;
            group1Authorization.MerchantCategoryCode = merchantCategory;
            group1Authorization.IndustryCode = industryCode;
            group1Authorization.RequestedACI = RequestAciTypeModel.DeviceIsCpsMeritCapableOrCreditOrOffline;
        }

        public static void SetTerminalLocale(this Group1AuthorizationModel group1Authorization, CurrencyCodeTypeModel currency, CountryCodeTypeModel countryCode, LanguageIndicatorTypeModel languageIndicator, string zipCode, TimeZoneDifferentialModel timeZonDifferential)
        {
            group1Authorization.CurrencyCode = currency;
            group1Authorization.CountryCode = countryCode;
            group1Authorization.CityCode = zipCode;
            group1Authorization.LanguageIndicator = languageIndicator;
            group1Authorization.TimeZoneDiff = timeZonDifferential;
        }

        public static void SetCardholderData(this Group1AuthorizationModel group1Authorization, CustomerDataFieldModel customerData, CustomerIdentificationDataFieldModel cardholderIdentification)
        {
            group1Authorization.CardholderIdentificationCode = cardholderIdentification.CardholderIdCode;
            group1Authorization.AccountDataSource = customerData.AccountDataSource;
            group1Authorization.CustomerData = customerData;
            group1Authorization.CardholderIdentificationData = cardholderIdentification;
        }

        public static void SetCardAcceptorData(this Group1AuthorizationModel group1Authorization, string name, string city, string state, uint ticket, string phone)
        {
            group1Authorization.CardAcceptorData = CardAcceptorDataFieldModel.NewCardAcceptorDataField(name, city, state, ticket, phone);
        }

        public static void SetMarketAndCardAcceptorData(this Group1AuthorizationModel group1Authorization, MarketSpecificDataFieldModel marketSpecificData, CardAcceptorDataFieldModel cardAcceptorData)
        {
            group1Authorization.MarketSpecificData = marketSpecificData;
            group1Authorization.CardAcceptorData = cardAcceptorData;
        }

        public static void CopyToBuffer(this Group1AuthorizationModel group1Authorization, ref StringBuilder buffer)
        {
            buffer
                .AppendFormat("{0}", group1Authorization.RecordFormat)
                .AppendFormat("{0}", group1Authorization.ApplicationType)
                .AppendFormat("{0}", group1Authorization.MessageDelimiter)
                .AppendFormat("{0:000000}", group1Authorization.AcquirerBIN)
                .AppendFormat("{0:000000000000}", group1Authorization.MerchantNumber)
                .AppendFormat("{0:0000}", group1Authorization.StoreNumber)
                .AppendFormat("{0:0000}", group1Authorization.TerminalNumber)
                .AppendFormat("{0}", group1Authorization.DeviceCode)
                .AppendFormat("{0}", group1Authorization.IndustryCode)
                .AppendFormat("{0:000}", group1Authorization.CurrencyCode)
                .AppendFormat("{0:000}", group1Authorization.CountryCode)
                .AppendFormat("{0}", group1Authorization.CityCode.FormatCityCode())
                .AppendFormat("{0:00}", group1Authorization.LanguageIndicator)
                .AppendFormat("{0:000}", group1Authorization.TimeZoneDiff)
                .AppendFormat("{0:0000}", group1Authorization.MerchantCategoryCode)
                .AppendFormat("{0}", group1Authorization.RequestedACI)
                .AppendFormat("{0:0000}", group1Authorization.TransactionSequenceNumber)
                .AppendFormat("{0}", group1Authorization.TransactionCode)
                .AppendFormat("{0}", group1Authorization.CardholderIdentificationCode)
                .AppendFormat("{0}", group1Authorization.AccountDataSource);

            /**
             * NOTE:
             *  all request messages have same exact Group I structure up to this point...(first 64 bytes only)
             */

            buffer
                .Append(group1Authorization.CustomerData)
                .Append(AsciiTable.FS)
                .Append(group1Authorization.CardholderIdentificationData)
                .Append(AsciiTable.FS);

            if (group1Authorization.ReceivingInstitutionId != ReceivingInstitutionIdTypeModel.SpaceOrEmptyReceivingInst)
            {
                buffer.AppendFormat("{0:000000}", group1Authorization.ReceivingInstitutionId);
            }

            buffer
                .Append(AsciiTable.FS)
                .AppendFormat("{0:000000000000}", group1Authorization.TransactionAmount)
                .Append(AsciiTable.FS);

            if (group1Authorization.TransactionCode == TransactionCodeTypeModel.DirectDebitPurchase)
            {
                buffer.AppendFormat("{0:000000000000}", group1Authorization.SecondaryAmount);
            }

            buffer.Append(AsciiTable.FS);

            switch (group1Authorization.IndustryCode.ToString())
            {
                case IndustryCodeTypeModel.AutoRental:
                case IndustryCodeTypeModel.HotelAndLodging:
                    buffer.Append(group1Authorization.MarketSpecificData);
                    break;

                default:
                    break;
            }

            buffer
                .Append(AsciiTable.FS)
                .AppendFormat("{0}", group1Authorization.CardAcceptorData.ToString(group1Authorization.TransactionCode))
                .Append(AsciiTable.FS)
                .AppendFormat("{0}", group1Authorization.ReversalAndIncrementalTransactionId)
                .Append(AsciiTable.FS);

            if (group1Authorization.TransactionCode.IsReturnOrReversal() || group1Authorization.TransactionCode.IsDebitCardTransaction())
            {
                buffer.AppendFormat("{0}", group1Authorization.TransactionCode);
            }

            buffer.Append(AsciiTable.FS);
        }
    }
}