using System;

namespace Tsys.net.Models.Types
{
    public struct AdditionalAmountTypeModel
    {
        public const string DepositAccountLedgerBalance = "01"; // Credit card account: Open to buy
        public const string DepositAccountAvailableBalance = "02"; // Credit card account: Credit limit
        public const string AmexPrepaidCard = "05"; // available amount remaining (Amex only)
        public const string AmountHealthcare = "4S"; // (Visa authorization request only)
        public const string AmountTransit = "4T"; // (Visa authorization request only)
        public const string AmountCoPayment = "3S";
        public const string OriginalAmount = "57";
        public const string PartialAuthorizedAmount = "10";
        public const string AmountPrescriptionRx = "4U"; // (Visa and MC authorization requests)
        public const string AmountVisionOptical = "4V"; // (Visa authorization request only)
        public const string AmountClinic = "4W"; // other qualified medical (Visa authorization request only)
        public const string AmountDental = "4X"; // (Visa authorization request only)
        public const string AmountCashOver = "80"; // Discover only
        public const string OriginalAmountCashOver = "81"; // Discover Only
        private readonly string value;

        public AdditionalAmountTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator AdditionalAmountTypeModel(string value)
        {
            return new AdditionalAmountTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case DepositAccountLedgerBalance:
                    return nameof(DepositAccountLedgerBalance);

                case DepositAccountAvailableBalance:
                    return nameof(DepositAccountAvailableBalance);

                case AmexPrepaidCard:
                    return nameof(AmexPrepaidCard);

                case AmountHealthcare:
                    return nameof(AmountHealthcare);

                case AmountTransit:
                    return nameof(AmountTransit);

                case AmountCoPayment:
                    return nameof(AmountCoPayment);

                case OriginalAmount:
                    return nameof(OriginalAmount);

                case PartialAuthorizedAmount:
                    return nameof(PartialAuthorizedAmount);

                case AmountPrescriptionRx:
                    return nameof(AmountPrescriptionRx);

                case AmountVisionOptical:
                    return nameof(AmountVisionOptical);

                case AmountClinic:
                    return nameof(AmountClinic);

                case AmountDental:
                    return nameof(AmountDental);

                case AmountCashOver:
                    return nameof(AmountCashOver);

                case OriginalAmountCashOver:
                    return nameof(OriginalAmountCashOver);

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