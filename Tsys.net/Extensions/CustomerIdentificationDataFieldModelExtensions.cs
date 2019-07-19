using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class CustomerIdentificationDataFieldModelExtensions
    {
        public static string Serialize(this CustomerIdentificationDataFieldModel model)
        {
            switch (model.CardholderIdCode)
            {
                case CardholderIdCodeTypeModel.CardPresentUnableToReadMagStripeSendingAvsData:
                    return model.AVSZipCode;

                case CardholderIdCodeTypeModel.CardNotPresentIncludesEcomAndFullAvsData:
                    return string.Format("{0} {1}", model.AVSStreetAddress, model.AVSZipCode);

                case CardholderIdCodeTypeModel.PersonalIdentificationNumber32CharStaticKeyNonUsa:
                case CardholderIdCodeTypeModel.PinAtAutomatedDispensingMachine32CharStaticKey:
                case CardholderIdCodeTypeModel.PinAtAutomatedDispensingMachine32CharDukpt:
                    return string.Format("{0}{1}", model.EncryptedPinBlock, model.DUKPTValue);
            }

            return string.Empty;
        }

        public static CustomerIdentificationDataFieldModel Deserialize<T>(this string cardholderIdCodeType, string value) where T : CustomerIdentificationDataFieldModel
        {
            var result = new CustomerIdentificationDataFieldModel { CardholderIdCode = cardholderIdCodeType };

            switch (cardholderIdCodeType)
            {
                case CardholderIdCodeTypeModel.CardPresentUnableToReadMagStripeSendingAvsData:
                    result.AVSZipCode = value;
                    break;

                case CardholderIdCodeTypeModel.CardNotPresentIncludesEcomAndFullAvsData:

                    if (0 < value.Length)
                    {
                        var splitAvsValue = value.Split(" ");

                        if (splitAvsValue.Length == 1)
                        {
                            result.AVSZipCode = splitAvsValue[0];
                        }
                        else if (splitAvsValue.Length > 1)
                        {
                            result.AVSStreetAddress = splitAvsValue[0];
                            result.AVSZipCode = splitAvsValue[1];
                        }
                    }

                    break;

                case CardholderIdCodeTypeModel.PersonalIdentificationNumber32CharStaticKeyNonUsa:
                case CardholderIdCodeTypeModel.PinAtAutomatedDispensingMachine32CharStaticKey:
                case CardholderIdCodeTypeModel.PinAtAutomatedDispensingMachine32CharDukpt:

                    if (32 <= value.Length)
                    {
                        result.EncryptedPinBlock = value.Truncate(16);
                        result.DUKPTValue = value.Substring(16);
                    }

                    break;
            }

            return result;
        }
    }
}