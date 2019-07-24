using System;

namespace Tsys.net.Models.Types
{
    public struct ReimbursementAttributeTypeModel
    {
        public const string EbtNonDebitOrNonInterlinkDebit = "0";
        public const string PreexistingQualifiedInterlinkSuperMarketMerchant = "W";
        public const string PreexistingQualifiedInterlinkRetailMerchant = "X";
        public const string QualifiedInterlinkSuperMarketMerchant = "Y";
        public const string StandardInterlinkRetailMerchant = "Z";
        private readonly string value;

        public ReimbursementAttributeTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator ReimbursementAttributeTypeModel(string value)
        {
            return new ReimbursementAttributeTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case EbtNonDebitOrNonInterlinkDebit:
                    return nameof(EbtNonDebitOrNonInterlinkDebit);

                case PreexistingQualifiedInterlinkSuperMarketMerchant:
                    return nameof(PreexistingQualifiedInterlinkSuperMarketMerchant);

                case PreexistingQualifiedInterlinkRetailMerchant:
                    return nameof(PreexistingQualifiedInterlinkRetailMerchant);

                case QualifiedInterlinkSuperMarketMerchant:
                    return nameof(QualifiedInterlinkSuperMarketMerchant);

                case StandardInterlinkRetailMerchant:
                    return nameof(StandardInterlinkRetailMerchant);

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