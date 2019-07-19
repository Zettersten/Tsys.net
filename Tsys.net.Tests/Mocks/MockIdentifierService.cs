using Tsys.net.Models;
using Tsys.net.Models.GroupRecords;

namespace Tsys.net.Tests.Mocks
{
    public static class MockIdentifierService
    {
        public static CustomerAddressIdentifierModel MockCustomerAddressIdentifierModel()
        {
            return new CustomerAddressIdentifierModel
            {
                StreetAdress = "8320",
                ZipCode = "85284"
            };
        }

        public static CustomerIdentifierModel MockCustomerIdentifierModel()
        {
            return new CustomerIdentifierModel
            {
                AccountNumber = "4012888888881881",
                ExpDate = "0218"
            };
        }

        public static DeveloperModel MockDeveloperModel()
        {
            return new DeveloperModel()
            {
                DeveloperId = "7",
                VersionId = "014"
            };
        }

        public static TransactionFeeModel MockTransactionFeeModel()
        {
            return new TransactionFeeModel()
            {
                TransactionFeeAmount = 15
            };
        }

        public static TsysAuthenticationMessageModel MockTsysMessageModel()
        {
            return new TsysAuthenticationMessageModel
            {
                TimeZoneDifferential = 705,
                RecordFormat = "D",
                ApplicationType = "4",
                MessageDelimiter = ".",
                MerchantNumber = 999999999911,
                AcquirerBIN = "999995",
                StoreNumber = 0011,
                TerminalNumber = 9911,
                MerchantCategoryCode = 5999,
                IndustryCode = "D",
                MerchantName = "Internet Service Provider",
                CityCode = "543211420",
                MerchantState = "VA",
                CustomerServicePhoneNumber = "800-1234567",
                MerchantPhoneNumber = "800-1234567",
                CountryCode = 840,
                MerchantCity = "Gloucester",
                DeviceCode = "Q",
                MerchantStreetAddress = "8320 Smithonian Internation Cir.",
                CurrencyCode = 840,
                LanguageIndicator = "00",
                TransactionCode = "56",
                TransactionSequenceNumber = 1,
                RequestedACI = "Y",
                CardholderIdCode = "N",
                AccountDataSource = "@",
                TransactionAmount = 10000,
            };
        }
    }
}