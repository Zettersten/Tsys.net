namespace Tsys.net.Models
{
    public struct MerchantIdentifierModel
    {
        public uint AcquirerBIN { get; set; }

        public ulong MerchantNumber { get; set; }

        public uint StoreNumber { get; set; }

        public uint TerminalNumber { get; set; }

        public string DeviceCode { get; set; }

        public string IndustryCode { get; set; }

        public uint CountryCode { get; set; }

        public string CityCode { get; set; }

        public uint MerchantCategoryCode { get; set; }

        public string MerchantName { get; set; }

        public string MerchantCity { get; set; }

        public string MerchantState { get; set; }

        public string MerchantStreetAddress { get; set; }

        public string MerchantEmail { get; set; }

        public string CustomerServicePhoneNumber { get; set; }

        public string MerchantPhoneNumber { get; set; }
    }
}