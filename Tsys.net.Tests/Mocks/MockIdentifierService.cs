using System;
using Tsys.net.Extensions;
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
                MerchantNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<ulong>(0),
                AcquirerBIN = ("PROD_MERCHANT_BINS").GetEnviromentVariablesAt<uint>(0),
                StoreNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(0),
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
                MerchantNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<ulong>(1),
                AcquirerBIN = ("PROD_MERCHANT_BINS").GetEnviromentVariablesAt<uint>(1),
                StoreNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<uint>(1),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(1),
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
                MerchantNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<ulong>(2),
                AcquirerBIN = ("PROD_MERCHANT_BINS").GetEnviromentVariablesAt<uint>(2),
                StoreNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(2),
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
                AccountNumber = ("PROD_CC_VISA").GetEnviromentVariable<string>(),
                ExpDate = ("PROD_CC_VISA_EXP").GetEnviromentVariable<string>()
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