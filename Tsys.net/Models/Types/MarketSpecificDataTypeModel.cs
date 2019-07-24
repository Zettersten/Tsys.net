using System;

namespace Tsys.net.Models.Types
{
    public class MarketSpecificDataTypeModel
    {
        public const string MarketSpecificAutoRental = "A";
        public const string MarketSpecificBillPayment = "B";
        public const string MarketSpecificEcommerceTransactionAggregation = "E";
        public const string HotelLodging = "H";
        public const string B2BInvoicePayments = "J";
        public const string MarketSpecificHealthCare = "M";
        public const string MarketSpecificFailedMarket = "N";
        public const string MarketSpecificTransit = "T";
        public const string OtherIndustries = " ";
        private readonly string value;

        public MarketSpecificDataTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator MarketSpecificDataTypeModel(string value)
        {
            return new MarketSpecificDataTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case MarketSpecificAutoRental:
                    return nameof(MarketSpecificAutoRental);

                case MarketSpecificBillPayment:
                    return nameof(MarketSpecificBillPayment);

                case MarketSpecificEcommerceTransactionAggregation:
                    return nameof(MarketSpecificEcommerceTransactionAggregation);

                case HotelLodging:
                    return nameof(HotelLodging);

                case B2BInvoicePayments:
                    return nameof(B2BInvoicePayments);

                case MarketSpecificHealthCare:
                    return nameof(MarketSpecificHealthCare);

                case MarketSpecificFailedMarket:
                    return nameof(MarketSpecificFailedMarket);

                case MarketSpecificTransit:
                    return nameof(MarketSpecificTransit);

                case OtherIndustries:
                    return nameof(OtherIndustries);

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