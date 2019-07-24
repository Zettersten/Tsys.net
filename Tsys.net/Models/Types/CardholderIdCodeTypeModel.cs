using System;

namespace Tsys.net.Models.Types
{
    public struct CardholderIdCodeTypeModel
    {
        public const string SpaceOrEmptyCardholderId = " ";
        public const string PersonalIdentificationNumber32CharStaticKeyNonUsa = "A";
        public const string PinAtAutomatedDispensingMachine32CharStaticKey = "B";
        public const string SelfServiceLimitedAmountTerminalNoIdMethodAvailable = "C";
        public const string SelfServiceTerminalNoIdMethodAvailable = "D";
        public const string CustomerActivatedAutomatedFuelDispenserNoIdMethodAvailable = "E";
        public const string OfflinePinAuthenticationByIccChipCard = "F";
        public const string ClearTextPin = "G";
        public const string PinAtAutomatedDispensingMachine32CharDukpt = "J";
        public const string PersonalIdentificationNumber32CharDukpt = "K";
        public const string CardPresentUnableToReadMagStripeSendingAvsData = "M";
        public const string CardNotPresentIncludesEcomAndFullAvsData = "N";
        public const string NoCvmRequiredEMVContactOrContactless = "P";
        public const string PersonalIdentificationNumber32CharStaticKey = "S";
        public const string CardholderSignatureTerminalHasPinPad = "Z";
        public const string CardholderSignatureNoPinPadAvailable = "@";
        private readonly string value;

        public CardholderIdCodeTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator CardholderIdCodeTypeModel(string value)
        {
            return new CardholderIdCodeTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case SpaceOrEmptyCardholderId:
                    return nameof(SpaceOrEmptyCardholderId);

                case PersonalIdentificationNumber32CharStaticKeyNonUsa:
                    return nameof(PersonalIdentificationNumber32CharStaticKeyNonUsa);

                case PinAtAutomatedDispensingMachine32CharStaticKey:
                    return nameof(PinAtAutomatedDispensingMachine32CharStaticKey);

                case SelfServiceLimitedAmountTerminalNoIdMethodAvailable:
                    return nameof(SelfServiceLimitedAmountTerminalNoIdMethodAvailable);

                case SelfServiceTerminalNoIdMethodAvailable:
                    return nameof(SelfServiceTerminalNoIdMethodAvailable);

                case CustomerActivatedAutomatedFuelDispenserNoIdMethodAvailable:
                    return nameof(CustomerActivatedAutomatedFuelDispenserNoIdMethodAvailable);

                case OfflinePinAuthenticationByIccChipCard:
                    return nameof(OfflinePinAuthenticationByIccChipCard);

                case ClearTextPin:
                    return nameof(ClearTextPin);

                case PinAtAutomatedDispensingMachine32CharDukpt:
                    return nameof(PinAtAutomatedDispensingMachine32CharDukpt);

                case PersonalIdentificationNumber32CharDukpt:
                    return nameof(PersonalIdentificationNumber32CharDukpt);

                case CardPresentUnableToReadMagStripeSendingAvsData:
                    return nameof(CardPresentUnableToReadMagStripeSendingAvsData);

                case CardNotPresentIncludesEcomAndFullAvsData:
                    return nameof(CardNotPresentIncludesEcomAndFullAvsData);

                case NoCvmRequiredEMVContactOrContactless:
                    return nameof(NoCvmRequiredEMVContactOrContactless);

                case PersonalIdentificationNumber32CharStaticKey:
                    return nameof(PersonalIdentificationNumber32CharStaticKey);

                case CardholderSignatureTerminalHasPinPad:
                    return nameof(CardholderSignatureTerminalHasPinPad);

                case CardholderSignatureNoPinPadAvailable:
                    return nameof(CardholderSignatureNoPinPadAvailable);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}