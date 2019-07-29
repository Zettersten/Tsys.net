using System;
using System.Collections.Generic;
using Tsys.net.Extensions;
using Tsys.net.Models;
using Tsys.net.Models.Constants;
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
                StoreNumber = ("PROD_MERCHANT_STORE_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                MerchantCategoryCode = ("PROD_MERCHANT_CATEGORY_CODES").GetEnviromentVariablesAt<uint>(0),
                IndustryCode = "R",
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CountryCode = 840,
                MerchantCity = "Gloucester",
                CustomerServicePhoneNumber = "800-1234567",
                MerchantPhoneNumber = "800-1234567",
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
                StoreNumber = ("PROD_MERCHANT_STORE_NUMBERS").GetEnviromentVariablesAt<uint>(1),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(1),
                MerchantCategoryCode = ("PROD_MERCHANT_CATEGORY_CODES").GetEnviromentVariablesAt<uint>(1),
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
                StoreNumber = ("PROD_MERCHANT_STORE_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                MerchantCategoryCode = ("PROD_MERCHANT_CATEGORY_CODES").GetEnviromentVariablesAt<uint>(2),
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

        public static BatchHeaderIdentifierModel MockBatchHeaderIdentifierModel_ETS1()
        {
            return new BatchHeaderIdentifierModel
            {
                AquirerBin = ("PROD_MERCHANT_BINS").GetEnviromentVariablesAt<uint>(0),
                AgentBankNumber = ("PROD_MERCHANGE_BANK_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                AgentChainNumber = ("PROD_MERCHANGE_CHAIN_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                BatchNumber = 1,
                BatchTransmissionDate = DateTime.Now.ToString("MMdd"),
                BlockingIndicator = 0,
                CurrencyCode = 840,
                LanguageIndicator = 0,
                DeviceCode = 'Q',
                IndustryCode = 'R',
                MerchantNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<ulong>(0),
                StoreNumber = ("PROD_MERCHANT_STORE_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                TimeZoneDifferential = MessageConstants.TimeZoneDifferential.EST
            };
        }

        public static BatchHeaderIdentifierModel MockBatchHeaderIdentifierModel_ETS2()
        {
            return new BatchHeaderIdentifierModel
            {
                AquirerBin = ("PROD_MERCHANT_BINS").GetEnviromentVariablesAt<uint>(0),
                AgentBankNumber = ("PROD_MERCHANGE_BANK_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                AgentChainNumber = ("PROD_MERCHANGE_CHAIN_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                BatchNumber = 1,
                BatchTransmissionDate = DateTime.Now.ToString("MMdd"),
                BlockingIndicator = 0,
                CurrencyCode = 840,
                LanguageIndicator = 0,
                DeviceCode = 'Q',
                IndustryCode = 'R',
                MerchantNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<ulong>(0),
                StoreNumber = ("PROD_MERCHANT_STORE_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                TimeZoneDifferential = MessageConstants.TimeZoneDifferential.EST
            };
        }

        public static BatchHeaderIdentifierModel MockBatchHeaderIdentifierModel_ETS3()
        {
            return new BatchHeaderIdentifierModel
            {
                AquirerBin = ("PROD_MERCHANT_BINS").GetEnviromentVariablesAt<uint>(2),
                AgentBankNumber = ("PROD_MERCHANGE_BANK_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                AgentChainNumber = ("PROD_MERCHANGE_CHAIN_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                BatchNumber = 1,
                BatchTransmissionDate = DateTime.Now.ToString("MMdd"),
                BlockingIndicator = 0,
                CurrencyCode = 840,
                LanguageIndicator = 0,
                DeviceCode = 'Q',
                IndustryCode = 'R',
                MerchantNumber = ("PROD_MERCHANT_NUMBERS").GetEnviromentVariablesAt<ulong>(2),
                StoreNumber = ("PROD_MERCHANT_STORE_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                TerminalNumber = ("PROD_MERCHANT_TERMINAL_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                TimeZoneDifferential = MessageConstants.TimeZoneDifferential.EST
            };
        }

        public static BatchProfileIdentifierModel MockBatchProfileIdentifierModel_ETS1()
        {
            return new BatchProfileIdentifierModel
            {
                MerchantCategoryCode = ("PROD_MERCHANT_CATEGORY_CODES").GetEnviromentVariablesAt<uint>(0),
                TerminalIdNumber = ("PROD_MERCHANT_V_NUMBERS").GetEnviromentVariablesAt<ulong>(0),
                MerchantLocationNumber = ("PROD_MERCHANT_LOCATION_NUMBERS").GetEnviromentVariablesAt<uint>(0),
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CountryCode = 840,
                MerchantCity = "Gloucester"
            };
        }

        public static BatchProfileIdentifierModel MockBatchProfileIdentifierModel_ETS2()
        {
            return new BatchProfileIdentifierModel
            {
                MerchantCategoryCode = ("PROD_MERCHANT_CATEGORY_CODES").GetEnviromentVariablesAt<uint>(1),
                TerminalIdNumber = ("PROD_MERCHANT_V_NUMBERS").GetEnviromentVariablesAt<ulong>(1),
                MerchantLocationNumber = ("PROD_MERCHANT_LOCATION_NUMBERS").GetEnviromentVariablesAt<uint>(1),
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CountryCode = 840,
                MerchantCity = "Gloucester"
            };
        }

        public static BatchProfileIdentifierModel MockBatchProfileIdentifierModel_ETS3()
        {
            return new BatchProfileIdentifierModel
            {
                MerchantCategoryCode = ("PROD_MERCHANT_CATEGORY_CODES").GetEnviromentVariablesAt<uint>(2),
                TerminalIdNumber = ("PROD_MERCHANT_V_NUMBERS").GetEnviromentVariablesAt<ulong>(2),
                MerchantLocationNumber = ("PROD_MERCHANT_LOCATION_NUMBERS").GetEnviromentVariablesAt<uint>(2),
                MerchantName = "ETS CORPORATION",
                CityCode = "20147",
                MerchantState = "VA",
                CountryCode = 840,
                MerchantCity = "Gloucester"
            };
        }

        public static BatchTrailerIdentifierModel MockBatchTrailerIdentifierModel_ETS1()
        {
            return new BatchTrailerIdentifierModel
            {
                BatchTransmissionDate = DateTime.Now.ToString("MMdd"),
                BatchNumber = 1,
                BatchRecordCount = 4,
                BatchHashingTotal = 100,
                CashBackTotal = 0,
                BatchNetDeposit = 100
            };
        }

        public static BatchTrailerIdentifierModel MockBatchTrailerIdentifierModel_ETS2()
        {
            return new BatchTrailerIdentifierModel
            {
                BatchTransmissionDate = DateTime.Now.ToString("MMdd"),
                BatchNumber = 1,
                BatchRecordCount = 4,
                BatchHashingTotal = 100,
                CashBackTotal = 0,
                BatchNetDeposit = 100
            };
        }

        public static BatchTrailerIdentifierModel MockBatchTrailerIdentifierModel_ETS3()
        {
            return new BatchTrailerIdentifierModel
            {
                BatchTransmissionDate = DateTime.Now.ToString("MMdd"),
                BatchNumber = 1,
                BatchRecordCount = 4,
                BatchHashingTotal = 100,
                CashBackTotal = 0,
                BatchNetDeposit = 100
            };
        }

        public static BatchTransactionIdentifierModel MockBatchTransactionIdentifierModel_ETS1(string approvalCode, string transactionId, string validationCode, string transDate, string transTime, char avsResult = '0', string responseCode = "00")
        {
            return new BatchTransactionIdentifierModel
            {
                TransactionCode = "56",
                CardholderIdentificationCode = '@',
                AccountDataSource = '@',
                CardholderAccountNumber = ("PROD_CC_VISA").GetEnviromentVariable<string>(),
                RequestedACI = 'Y',
                ReturnedACI = 'A',
                AuthorizationSourceCode = ' ',
                TransactionSequenceNumber = 1,
                ResponseCode = responseCode,
                ApprovalCode = approvalCode,
                LocalTransactionDate = transDate ?? DateTime.Now.ToString("MMdd"),
                LocalTransactionTime = transTime ?? DateTime.Now.ToString("hhmmss"),
                AVSResultCode = avsResult,
                TransactionIdentifier = transactionId,
                ValidationCode = validationCode,
                VoidIndicator = ' ',
                TransactionStatusCode = 0,
                ReimbursementAttribute = '0',
                SettlementAmount = 100,
                AuthorizedAmount = 100,
                TotalAuthorizedAmount = 100,
                TransactionFee = 50
            };
        }

        public static BatchTransactionIdentifierModel MockBatchTransactionIdentifierModel_ETS2(string approvalCode, string transactionId, string validationCode, string transDate, string transTime, char avsResult = '0', string responseCode = "00")
        {
            return new BatchTransactionIdentifierModel
            {
                TransactionCode = "56",
                CardholderIdentificationCode = '@',
                AccountDataSource = '@',
                CardholderAccountNumber = ("PROD_CC_VISA").GetEnviromentVariable<string>(),
                RequestedACI = 'Y',
                ReturnedACI = 'A',
                AuthorizationSourceCode = ' ',
                TransactionSequenceNumber = 1,
                ResponseCode = responseCode,
                ApprovalCode = approvalCode,
                LocalTransactionDate = transDate ?? DateTime.Now.ToString("MMdd"),
                LocalTransactionTime = transTime ?? DateTime.Now.ToString("hhmmss"),
                AVSResultCode = avsResult,
                TransactionIdentifier = transactionId,
                ValidationCode = validationCode,
                VoidIndicator = ' ',
                TransactionStatusCode = 0,
                ReimbursementAttribute = '0',
                SettlementAmount = 100,
                AuthorizedAmount = 100,
                TotalAuthorizedAmount = 100,
                TransactionFee = 50
            };
        }

        public static BatchTransactionIdentifierModel MockBatchTransactionIdentifierModel_ETS3(string approvalCode, string transactionId, string validationCode, string transDate, string transTime, char avsResult = '0', string responseCode = "00")
        {
            return new BatchTransactionIdentifierModel
            {
                TransactionCode = "56",
                CardholderIdentificationCode = '@',
                AccountDataSource = '@',
                CardholderAccountNumber = ("PROD_CC_VISA").GetEnviromentVariable<string>(),
                RequestedACI = 'Y',
                ReturnedACI = 'A',
                AuthorizationSourceCode = ' ',
                TransactionSequenceNumber = 1,
                ResponseCode = responseCode,
                ApprovalCode = approvalCode,
                LocalTransactionDate = transDate ?? DateTime.Now.ToString("MMdd"),
                LocalTransactionTime = transTime ?? DateTime.Now.ToString("hhmmss"),
                AVSResultCode = avsResult,
                TransactionIdentifier = transactionId,
                ValidationCode = validationCode,
                VoidIndicator = ' ',
                TransactionStatusCode = 0,
                ReimbursementAttribute = '0',
                SettlementAmount = 100,
                AuthorizedAmount = 100,
                TotalAuthorizedAmount = 100,
                TransactionFee = 0
            };
        }

        public static BatchIdentifierModel MockBatchIdentifierModel_ETS1(string approvalCode, string transactionId, string validationCode, string transDate, string transTime, char avsResult = '0', string responseCode = "00")
        {
            return new BatchIdentifierModel
            {
                BatchHeader = MockBatchHeaderIdentifierModel_ETS1(),
                BatchProfile = MockBatchProfileIdentifierModel_ETS1(),
                BatchTrailer = MockBatchTrailerIdentifierModel_ETS1(),
                BatchTransactions = new List<BatchTransactionIdentifierModel>
                {
                    MockBatchTransactionIdentifierModel_ETS1(approvalCode, transactionId, validationCode, transDate, transTime, avsResult, responseCode)
                }
            };
        }

        public static BatchIdentifierModel MockBatchIdentifierModel_ETS2(string approvalCode, string transactionId, string validationCode, string transDate, string transTime, char avsResult = '0', string responseCode = "00")
        {
            return new BatchIdentifierModel
            {
                BatchHeader = MockBatchHeaderIdentifierModel_ETS2(),
                BatchProfile = MockBatchProfileIdentifierModel_ETS2(),
                BatchTrailer = MockBatchTrailerIdentifierModel_ETS2(),
                BatchTransactions = new List<BatchTransactionIdentifierModel>
                {
                    MockBatchTransactionIdentifierModel_ETS2(approvalCode, transactionId, validationCode, transDate, transTime, avsResult, responseCode)
                }
            };
        }

        public static BatchIdentifierModel MockBatchIdentifierModel_ETS3(string approvalCode, string transactionId, string validationCode, string transDate, string transTime, char avsResult = '0', string responseCode = "00")
        {
            return new BatchIdentifierModel
            {
                BatchHeader = MockBatchHeaderIdentifierModel_ETS3(),
                BatchProfile = MockBatchProfileIdentifierModel_ETS3(),
                BatchTrailer = MockBatchTrailerIdentifierModel_ETS3(),
                BatchTransactions = new List<BatchTransactionIdentifierModel>
                {
                    MockBatchTransactionIdentifierModel_ETS3(approvalCode, transactionId, validationCode, transDate, transTime, avsResult, responseCode)
                }
            };
        }
    }
}