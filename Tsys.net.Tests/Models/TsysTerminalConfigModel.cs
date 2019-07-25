using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Tests.Models
{
    public class TsysTerminalConfigModel
    {
        public uint AcquirerBin { get; set; }
        public long MerchantNumber { get; set; }
        public uint StoreNumber { get; set; }
        public uint TerminalNumber { get; set; }
        public uint TerminalIdNumber { get; set; }
        public DeviceCodeTypeModel DeviceCode { get; set; }
        public IndustryCodeTypeModel IndustryCode { get; set; }
        public CurrencyCodeTypeModel CurrencyCode { get; set; }
        public CountryCodeTypeModel CountryCode { get; set; }
        public string CityCode { get; set; }
        public LanguageIndicatorTypeModel LanguageIndicator { get; set; }
        public TimeZoneDifferentialModel TimeZoneDiff { get; set; }
        public MerchantCategoryTypeModel MerchantCategoryCode { get; set; }
        public RequestAciTypeModel RequestedACI { get; set; }
        public uint TransactionSequenceNumber { get; set; }
        public uint AgentBankNumber { get; set; }
        public uint AgentChainNumber { get; set; }
        public uint BatchNumber { get; set; }
        public uint MerchantLocalTelephoneNo { get; set; }
        public long CardholderServiceTelephoneNo { get; set; }
        public string MerchantCity { get; set; }
        public string MerchantName { get; set; }
        public string MerchantState { get; set; }
        public string MerchantLocationNumber { get; set; }
        public string PosDataCodeProfile { get; set; }
    }
}