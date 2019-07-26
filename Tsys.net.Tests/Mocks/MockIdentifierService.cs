using Tsys.net.Models;
using Tsys.net.Models.GroupRecords;

namespace Tsys.net.Tests.Mocks
{
    public static class MockIdentifierService
    {
        public static DeveloperModel MockDeveloperModel()
        {
            return new DeveloperModel()
            {
                DeveloperId = "7",
                VersionId = "014"
            };
        }

        public static MerchantIdentifierModel MockMerchantIdentifierModel_ETS1()
        {
            return new MerchantIdentifierModel
            {
                MerchantNumber = 394750535319,
                AcquirerBIN = 433066,
                StoreNumber = 7619,
                TerminalNumber = 3268,
                MerchantCategoryCode = 8999,
                IndustryCode = "R",
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CustomerServicePhoneNumber = "800-1234567",
                MerchantPhoneNumber = "800-1234567",
                CountryCode = 840,
                MerchantCity = "Gloucester",
                DeviceCode = "Q",
                MerchantEmail = "customer@mycompanydomain.com",
                MerchantStreetAddress = "8320 Smithonian Internation Cir.",
            };
        }

        public static MerchantIdentifierModel MockMerchantIdentifierModel_ETS2()
        {
            return new MerchantIdentifierModel
            {
                MerchantNumber = 888000000835,
                AcquirerBIN = 999995,
                StoreNumber = 5999,
                TerminalNumber = 1515,
                MerchantCategoryCode = 5999,
                IndustryCode = "R",
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CustomerServicePhoneNumber = "800-1234567",
                MerchantPhoneNumber = "800-1234567",
                CountryCode = 840,
                MerchantCity = "Gloucester",
                DeviceCode = "Q",
                MerchantEmail = "customer@mycompanydomain.com",
                MerchantStreetAddress = "8320 Smithonian Internation Cir.",
            };
        }

        public static MerchantIdentifierModel MockMerchantIdentifierModel_ETS3()
        {
            return new MerchantIdentifierModel
            {
                MerchantNumber = 000000000002,
                AcquirerBIN = 433066,
                StoreNumber = 0002,
                TerminalNumber = 7858,
                MerchantCategoryCode = 5045,
                IndustryCode = "R",
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CustomerServicePhoneNumber = "800-1234567",
                MerchantPhoneNumber = "800-1234567",
                CountryCode = 840,
                MerchantCity = "Gloucester",
                DeviceCode = "Q",
                MerchantEmail = "customer@mycompanydomain.com",
                MerchantStreetAddress = "8320 Smithonian Internation Cir.",
            };
        }

        public static TransactionIdentifierModel MockTransactionIdentifierModel()
        {
            return new TransactionIdentifierModel
            {
                CurrencyCode = 840,
                LanguageIndicator = "00",
                TransactionCode = "56",
                TransactionSequenceNumber = 1,
                RequestedACI = "Y",
                CardholderIdCode = "N",
                AccountDataSource = "@",
                TransactionAmount = 100,
            };
        }

        public static CustomerIdentifierModel MockCustomerIdentifierModel()
        {
            return new CustomerIdentifierModel
            {
                AccountNumber = "4744780151055662",
                ExpDate = "0523"
            };
        }

        public static CustomerAddressIdentifierModel MockCustomerAddressIdentifierModel()
        {
            return new CustomerAddressIdentifierModel
            {
                StreetAdress = "19515",
                ZipCode = "20147"
            };
        }
    }
}