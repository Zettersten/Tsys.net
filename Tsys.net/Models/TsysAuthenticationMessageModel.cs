using Tsys.net.Attributes;

namespace Tsys.net.Models
{
    public struct TsysAuthenticationMessageModel
    {
        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Record Format", "6.158", 1)]
        public string RecordFormat { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Application Type", "6.23", 2)]
        public string ApplicationType { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Message Delimiter", "6.135", 3)]
        public string MessageDelimiter { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(6)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Acquirer BIN", "6.5", 4)]
        public string AcquirerBIN { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(12, true, '0')]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Merchant Number", "6.128", 5)]
        public ulong MerchantNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(4, true, '0')]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Store Number", "6.180", 6)]
        public uint StoreNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(12)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Terminal Number", "6.189", 7)]
        public uint TerminalNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Device Code", "6.73", 8)]
        public string DeviceCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Industry Code", "6.101", 9)]
        public string IndustryCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(3)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Country Code", "6.62", 10)]
        public uint CountryCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(9, false)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("City Code (ZIP)", "6.58", 11)]
        public string CityCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(4)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Merchant Category Code", "6.120", 12)]
        public uint MerchantCategoryCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(25, false)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Merchant Name", "6.36.1", 13)]
        public string MerchantName { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 13, false)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Merchant City", "6.36.2", 14)]
        public string MerchantCity { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 2)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Merchant State", "6.185", 15)]
        public string MerchantState { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 20)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Merchant Street Address", "6.132", 17)]
        public string MerchantStreetAddress { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 20)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Merchant Email", "6.126", 18)]
        public string MerchantEmail { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(13)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Customer Service Phone Number", "6.5", 19)]
        public string CustomerServicePhoneNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1, 10)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Merchant Phone Number", "6.129", 20)]
        public string MerchantPhoneNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(3)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Currency Code", "6.69", 21)]
        public uint CurrencyCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(2)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Language Indicator", "6.110", 22)]
        public string LanguageIndicator { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(3)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Time Zone Differential", "6.194", 23)]
        public int TimeZoneDifferential { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(4)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Transaction Sequence Number", "6.205", 24)]
        public uint TransactionSequenceNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(12)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Retrieval Reference Number (RRN)", "6.164", 25)]
        public uint RetrievalReferenceNumber { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Returned Aci", "6.165", 26)]
        public string ReturnedAci { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Requested ACI", "6.162", 27)]
        public string RequestedACI { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(6)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Approval Code", "6.166.1", 28)]
        public string ApprovalCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(6)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Local Transaction Date", "6.166.2", 29)]
        public string LocalTransactionDate { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(6)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Local Transaction Time", "6.166.3", 30)]
        public string LocalTransactionTime { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(2)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Transaction Code", "6.201", 31)]
        public string TransactionCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 15)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Transaction Indentifier", "6.204", 32)]
        public string TransactionIndentifier { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Cardholder Id Code", "6.49", 33)]
        public string CardholderIdCode { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(2, 26)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Card holder Id Data", "6.5", 34)]
        public string CardholderIdData { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(40)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Card Acceptor Data", "6.35", 35)]
        public string CardAcceptorData { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Account Data Source", "6.2", 36)]
        public string AccountDataSource { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 29)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Address Verification Data", "6.50", 37)]
        public string AddressVerificationData { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1, 12)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Transaction Amount", "6.199", 38)]
        public ulong TransactionAmount { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 12)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Secondary Amount", "6.170", 39)]
        public ulong SecondaryAmount { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1, 12)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Settlement Amount", "6.173", 40)]
        public ulong SettlementAmount { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(1, 12)]
        [FieldFormat(FieldFormat.NUM)]
        [FieldDescription("Total Authorized Amount", "6.199", 41)]
        public ulong TotalAuthorizedAmount { get; set; }

        [FieldGroup(FieldGroup.GroupI)]
        [FieldLength(0, 4)]
        [FieldFormat(FieldFormat.AN)]
        [FieldDescription("Market Specific Data", "6.116", 42)]
        public string MarketSpecificData { get; set; }
    }
}