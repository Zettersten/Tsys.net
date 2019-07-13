namespace Tsys.net.Models
{
    public struct MerchantIdentifierModel
    {
        public int AcquirerBIN { get; set; }

        public long MerchantNumber { get; set; }

        public int StoreNumber { get; set; }

        public int TerminalNumber { get; set; }

        public string DeviceCode { get; set; }

        public string IndustryCode { get; set; }

        public int CountryCode { get; set; }

        public string CityCode { get; set; }

        public int MerchantCategoryCode { get; set; }

        public string MerchantName { get; set; }

        public string MerchantCity { get; set; }

        public string MerchantState { get; set; }

        public string MerchantStreetAddress { get; set; }

        public string MerchantEmail { get; set; }

        public string CustomerServicePhoneNumber { get; set; }

        public string MerchantPhoneNumber { get; set; }
    }
}