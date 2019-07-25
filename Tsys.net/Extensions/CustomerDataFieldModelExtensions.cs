using Tsys.net.Extensions;
using Tsys.net.Models.Shared;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class CustomerDataFieldModelExtensions
    {
        public static string Serialize(this CustomerDataFieldModel model)
        {
            switch (model.AccountDataSource.ToString())
            {
                case AccountDataSourceTypeModel.MicrDataWasAcquiredByOcrReader:
                    return string.Format("{0}{1}{2}", AsciiTable.FS, AsciiTable.FS, model.MICRData);

                case AccountDataSourceTypeModel.FullMagneticStripeReadAndTransmitTrack1:

                    if (76 < model.MSRTrack01DataWithoutSentinals.Length)
                    {
                        return model.MSRTrack01DataWithoutSentinals.Truncate(76);
                    }
                    else if (0 < model.MSRTrack01DataWithoutSentinals.Length)
                    {
                        return model.MSRTrack01DataWithoutSentinals;
                    }

                    break;

                case AccountDataSourceTypeModel.FullMagneticStripeReadAndTransmitTrack2:
                case AccountDataSourceTypeModel.ChipCardReadDataCCPS:
                case AccountDataSourceTypeModel.ProximityPaymentUsingEmvRules:
                case AccountDataSourceTypeModel.ChipCardTransProcessedAsMagStripe_CardOrTerminalFailure:
                case AccountDataSourceTypeModel.ChipCardTransProcessedAsMagStripe_NoEmvAppOnTerminal:

                    if (37 < model.MSRTrack02DataWithoutSentinals.Length)
                    {
                        return model.MSRTrack02DataWithoutSentinals.Truncate(37).Replace("F", string.Empty);
                    }
                    else if (0 < model.MSRTrack02DataWithoutSentinals.Length)
                    {
                        return model.MSRTrack02DataWithoutSentinals.Replace("F", string.Empty);
                    }

                    break;
            }

            return string.Format("{0}{1}{2}{3}{4}", model.ManuallyEnteredAccountNumber, AsciiTable.FS, model.ManuallyEnteredExpirationMonth.ToString().PadLeft(2, '0'), model.ManuallyEnteredExpirationYear.ToString().PadLeft(2, '0'), AsciiTable.FS);
        }

        public static CustomerDataFieldModel Deserialize<T>(this string value, string accountDataSourceType = AccountDataSourceTypeModel.SpaceOrEmptyAccountDataSource) where T : CustomerDataFieldModel
        {
            var result = new CustomerDataFieldModel { AccountDataSource = accountDataSourceType };
            var dataFields = value.Split(AsciiTable.FS);

            switch (accountDataSourceType.ToString())
            {
                case AccountDataSourceTypeModel.MicrDataWasAcquiredByOcrReader:
                    break;

                case AccountDataSourceTypeModel.FullMagneticStripeReadAndTransmitTrack1:
                    result.MSRTrack01DataWithoutSentinals = dataFields[0];
                    break;

                case AccountDataSourceTypeModel.FullMagneticStripeReadAndTransmitTrack2:
                case AccountDataSourceTypeModel.ChipCardReadDataCCPS:
                case AccountDataSourceTypeModel.ProximityPaymentUsingEmvRules:
                case AccountDataSourceTypeModel.ChipCardTransProcessedAsMagStripe_CardOrTerminalFailure:
                case AccountDataSourceTypeModel.ChipCardTransProcessedAsMagStripe_NoEmvAppOnTerminal:
                    result.MSRTrack02DataWithoutSentinals = dataFields[0];
                    break;

                default:

                    if (1 < dataFields.Length)
                    {
                        result.ManuallyEnteredAccountNumber = dataFields[0];
                        result.ManuallyEnteredExpirationMonth = uint.Parse(dataFields[1].Substring(0, 2));
                        result.ManuallyEnteredExpirationYear = uint.Parse(dataFields[1].Substring(2, 2));
                    }

                    break;
            }

            return result;
        }

        public static CardIssuerTypeModel GetCardIssuerType(this CustomerDataFieldModel model)
        {
            var accountNumer = model.ManuallyEnteredAccountNumber.ToDigits();

            if (accountNumer.Length < 6)
            {
                return CardIssuerTypeModel.EmptyCardType;
            }

            var cardNumber = accountNumer.ToNumeric();

            if (cardNumber >= 400000 && cardNumber <= 499999)
            {
                return CardIssuerTypeModel.Visa;
            }
            else if ((cardNumber >= 510000 && cardNumber <= 559999) || (cardNumber >= 360000 && cardNumber <= 369999))
            {
                return CardIssuerTypeModel.Mastercard;
            }
            else if ((cardNumber >= 340000 && cardNumber <= 349999) || (cardNumber >= 370000 && cardNumber <= 379999))
            {
                return CardIssuerTypeModel.Amex;
            }
            else if (cardNumber >= 601100 && cardNumber <= 60119)
            {
                return CardIssuerTypeModel.Discover;
            }
            else if ((cardNumber >= 300000 && cardNumber <= 305999) || (cardNumber >= 380000 && cardNumber <= 389999))
            {
                return CardIssuerTypeModel.Diners;
            }
            else if (cardNumber >= 352800 && cardNumber <= 358999)
            {
                return CardIssuerTypeModel.Jcb;
            }
            else if (cardNumber == 627571)
            {
                return CardIssuerTypeModel.Ets;
            }
            else
            {
                return CardIssuerTypeModel.Unrecognized;
            }
        }
    }
}