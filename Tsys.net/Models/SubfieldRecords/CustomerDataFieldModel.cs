using Tsys.net.Extensions;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.SubfieldRecords
{
    public class CustomerDataFieldModel
    {
        public AccountDataSourceTypeModel AccountDataSource { get; set; }

        public string MSRTrack01DataWithoutSentinals { get; set; }

        public string MSRTrack02DataWithoutSentinals { get; set; }

        public string ManuallyEnteredAccountNumber { get; set; }

        public uint ManuallyEnteredExpirationMonth { get; set; }

        public uint ManuallyEnteredExpirationYear { get; set; }

        public string ManuallyEnteredVerificationCode { get; set; }

        public string EncryptedMSRTrackData { get; set; }

        public string MICRData { get; set; }

        public static CustomerDataFieldModel NewManuallyEnteredCustomerDataField(string accountDataSourceType, string pan, uint month, uint year, string securityCode)
        {
            return new CustomerDataFieldModel
            {
                AccountDataSource = accountDataSourceType,
                ManuallyEnteredAccountNumber = pan,
                ManuallyEnteredExpirationMonth = month,
                ManuallyEnteredExpirationYear = year,
                ManuallyEnteredVerificationCode = securityCode
            };
        }

        public static CustomerDataFieldModel NewCustomerDataField(string accountDataSourceType, string track1, string track2)
        {
            return new CustomerDataFieldModel
            {
                AccountDataSource = accountDataSourceType,
                MSRTrack01DataWithoutSentinals = track1,
                MSRTrack02DataWithoutSentinals = track2
            };
        }

        public static CustomerDataFieldModel NewEncryptedCustomerDataField(string accountDataSourceType, string trackData)
        {
            return new CustomerDataFieldModel
            {
                AccountDataSource = accountDataSourceType,
                EncryptedMSRTrackData = trackData,
            };
        }

        public static implicit operator CustomerDataFieldModel(string value)
        {
            return CustomerDataFieldModelExtensions.Deserialize<CustomerDataFieldModel>(value);
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}