using System;

namespace Tsys.net.Models.Types
{
    public struct AccountDataSourceTypeModel
    {
        public const string SpaceOrEmptyAccountDataSource = " ";
        public const string BarCodeRead = "A";
        public const string MicrDataWasAcquiredByOcrReader = "B";
        public const string CheckImagingDevicePosCheckService = "C";
        public const string FullMagneticStripeReadAndTransmitTrack2 = "D";
        public const string ChipCardReadDataCCPS = "G";
        public const string FullMagneticStripeReadAndTransmitTrack1 = "H";
        public const string ManuallyKeyedChipCardReadCapableTerminal = "P";
        public const string ProximityPaymentUsingTrackDataRules = "Q";
        public const string ProximityPaymentUsingEmvRules = "R";
        public const string FullMagneticStripeReadChipCardCapableTerminal = "S";
        public const string ManuallyKeyedTrack2Capable = "T";
        public const string ManuallyKeyedTrack1Capable = "X";
        public const string ManuallyKeyedTerminalHasNoCardReadingCapability = "@";
        public const string ChipCardTransProcessedAsMagStripe_NoEmvAppOnTerminal = "W";
        public const string ChipCardTransProcessedAsMagStripe_CardOrTerminalFailure = "Z";
        private readonly string value;

        public AccountDataSourceTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator AccountDataSourceTypeModel(string value)
        {
            return new AccountDataSourceTypeModel(value);
        }

        public static bool operator ==(AccountDataSourceTypeModel firstValue, string secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator !=(AccountDataSourceTypeModel firstValue, string secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator ==(string firstValue, AccountDataSourceTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public static bool operator !=(string firstValue, AccountDataSourceTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case SpaceOrEmptyAccountDataSource:
                    return nameof(SpaceOrEmptyAccountDataSource);

                case BarCodeRead:
                    return nameof(BarCodeRead);

                case MicrDataWasAcquiredByOcrReader:
                    return nameof(MicrDataWasAcquiredByOcrReader);

                case CheckImagingDevicePosCheckService:
                    return nameof(CheckImagingDevicePosCheckService);

                case FullMagneticStripeReadAndTransmitTrack2:
                    return nameof(FullMagneticStripeReadAndTransmitTrack2);

                case ChipCardReadDataCCPS:
                    return nameof(ChipCardReadDataCCPS);

                case FullMagneticStripeReadAndTransmitTrack1:
                    return nameof(FullMagneticStripeReadAndTransmitTrack1);

                case ManuallyKeyedChipCardReadCapableTerminal:
                    return nameof(ManuallyKeyedChipCardReadCapableTerminal);

                case ProximityPaymentUsingTrackDataRules:
                    return nameof(ProximityPaymentUsingTrackDataRules);

                case ProximityPaymentUsingEmvRules:
                    return nameof(ProximityPaymentUsingEmvRules);

                case FullMagneticStripeReadChipCardCapableTerminal:
                    return nameof(FullMagneticStripeReadChipCardCapableTerminal);

                case ManuallyKeyedTrack2Capable:
                    return nameof(ManuallyKeyedTrack2Capable);

                case ManuallyKeyedTrack1Capable:
                    return nameof(ManuallyKeyedTrack1Capable);

                case ManuallyKeyedTerminalHasNoCardReadingCapability:
                    return nameof(ManuallyKeyedTerminalHasNoCardReadingCapability);

                case ChipCardTransProcessedAsMagStripe_NoEmvAppOnTerminal:
                    return nameof(ChipCardTransProcessedAsMagStripe_NoEmvAppOnTerminal);

                case ChipCardTransProcessedAsMagStripe_CardOrTerminalFailure:
                    return nameof(ChipCardTransProcessedAsMagStripe_CardOrTerminalFailure);

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