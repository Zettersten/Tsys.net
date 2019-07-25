using System;

namespace Tsys.net.Models.Types
{
    public struct ProductParticipationGroupTypeModel
    {
        /// <summary>
        /// Cash Over can be partially approved (Not applicable to merchandise-only merchants).
        /// </summary>
        public const string MerchandiseSalesCanBePartiallyApproved = "A";

        /// <summary>
        /// Cash Over must be fully approved or declined
        /// </summary>
        public const string MerchandiseOnlyCanBePartiallyApproved = "B";

        /// <summary>
        /// Cash Over can be partially approved (only if merchandise fully approved)
        /// </summary>
        public const string MerchandiseMustBeFullyApprovedOrDeclined = "C";

        /// <summary>
        /// Cash Over must be fully approved (if merchandise is approved) or declined
        /// </summary>
        public const string MerchandiseAndCashOverMustBeFullyApprovedOrDeclined = "D";

        private readonly string value;

        public ProductParticipationGroupTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator ProductParticipationGroupTypeModel(string value)
        {
            return new ProductParticipationGroupTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case MerchandiseSalesCanBePartiallyApproved:
                    return nameof(MerchandiseSalesCanBePartiallyApproved);

                case MerchandiseOnlyCanBePartiallyApproved:
                    return nameof(MerchandiseOnlyCanBePartiallyApproved);

                case MerchandiseMustBeFullyApprovedOrDeclined:
                    return nameof(MerchandiseMustBeFullyApprovedOrDeclined);

                case MerchandiseAndCashOverMustBeFullyApprovedOrDeclined:
                    return nameof(MerchandiseAndCashOverMustBeFullyApprovedOrDeclined);

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