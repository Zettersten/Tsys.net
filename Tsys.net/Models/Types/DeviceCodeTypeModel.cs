using System;

namespace Tsys.net.Models.Types
{
    public struct DeviceCodeTypeModel
    {
        public const string UnknownOrUnsure = "O";
        public const string AutomatedTellerMachineATM = "B";
        public const string Pc = "C";
        public const string DialTerminal = "D";
        public const string ElectronicCashRegister = "E";
        public const string MobilePaymentAcceptance = "G";
        public const string TSYSHostedPayment = "H";
        public const string InStorePromotion = "I";
        public const string MultiPaymentAcceptance = "J";
        public const string MainFrame = "M";
        public const string PosPort = "P";
        public const string ReservedForThirdPartyDevelopers = "Q";
        public const string PosPortR = "R";
        public const string PosPartner = "S";
        public const string CounterPaymentAcceptance = "T";
        public const string WebPaymentAcceptance = "W";
        public const string EMVModeContactAndOrContactlessTerminal = "X";
        public const string SuppressPs2000MeritResponseFields = "Z";
        private readonly string value;

        public DeviceCodeTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator DeviceCodeTypeModel(string value)
        {
            return new DeviceCodeTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case UnknownOrUnsure:
                    return nameof(UnknownOrUnsure);

                case AutomatedTellerMachineATM:
                    return nameof(AutomatedTellerMachineATM);

                case Pc:
                    return nameof(Pc);

                case DialTerminal:
                    return nameof(DialTerminal);

                case ElectronicCashRegister:
                    return nameof(ElectronicCashRegister);

                case MobilePaymentAcceptance:
                    return nameof(MobilePaymentAcceptance);

                case TSYSHostedPayment:
                    return nameof(TSYSHostedPayment);

                case InStorePromotion:
                    return nameof(InStorePromotion);

                case MultiPaymentAcceptance:
                    return nameof(MultiPaymentAcceptance);

                case MainFrame:
                    return nameof(MainFrame);

                case PosPort:
                    return nameof(PosPort);

                case ReservedForThirdPartyDevelopers:
                    return nameof(ReservedForThirdPartyDevelopers);

                case PosPortR:
                    return nameof(PosPortR);

                case PosPartner:
                    return nameof(PosPartner);

                case CounterPaymentAcceptance:
                    return nameof(CounterPaymentAcceptance);

                case WebPaymentAcceptance:
                    return nameof(WebPaymentAcceptance);

                case EMVModeContactAndOrContactlessTerminal:
                    return nameof(EMVModeContactAndOrContactlessTerminal);

                case SuppressPs2000MeritResponseFields:
                    return nameof(SuppressPs2000MeritResponseFields);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }

        public override string ToString()
        {
            return value;
        }
    }
}