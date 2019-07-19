using Tsys.net.Extensions;

namespace Tsys.net.Models.SubfieldRecords
{
    public class CustomerIdentificationDataFieldModel
    {
        public string CardholderIdCode { get; set; }

        public string AVSStreetAddress { get; set; }

        public string AVSZipCode { get; set; }

        public string EncryptedPinBlock { get; set; }

        public string DUKPTValue { get; set; }

        public static CustomerIdentificationDataFieldModel NewCardholderIdentificationDataField(string cardHolderIdCode, string street, string zipCode, string pin, string dukpt)
        {
            return new CustomerIdentificationDataFieldModel
            {
                CardholderIdCode = cardHolderIdCode,
                AVSStreetAddress = street,
                AVSZipCode = zipCode,
                DUKPTValue = dukpt,
                EncryptedPinBlock = pin
            };
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}