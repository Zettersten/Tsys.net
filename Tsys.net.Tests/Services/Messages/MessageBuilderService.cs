using System;
using Tsys.net.Models;
using Tsys.net.Models.GroupRecords;
using Tsys.net.Models.Shared;
using Tsys.net.Tests.Mocks;
using Xunit;

namespace Tsys.net.Tests.Services.Messages
{
    [Collection("7.1.1")]
    public class MessageBuilderService
    {
        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - request 1")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant1()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS1();
            TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();
            CustomerIdentifierModel customer = MockIdentifierService.MockCustomerIdentifierModel();
            CustomerAddressIdentifierModel address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            net.Services.Messages.MessageBuilderService messageService = MockMessageService.MockMessageBuilderService();

            DeveloperModel developer = MockIdentifierService.MockDeveloperModel();

            string result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address, developer);

            Console.WriteLine($"ETS1 ({merchant.AcquirerBIN})");
            Console.WriteLine(result);

            Assert.Contains("@", result);

            int expected = 64;
            int actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - request 2")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant2()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS2();
            TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();
            CustomerIdentifierModel customer = MockIdentifierService.MockCustomerIdentifierModel();
            CustomerAddressIdentifierModel address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            net.Services.Messages.MessageBuilderService messageService = MockMessageService.MockMessageBuilderService();

            DeveloperModel developer = MockIdentifierService.MockDeveloperModel();

            string result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address, developer);

            Console.WriteLine($"ETS2 ({merchant.AcquirerBIN})");
            Console.WriteLine(result);

            Assert.Contains("@", result);

            int expected = 64;
            int actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - request 3")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant3()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS3();
            TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();
            CustomerIdentifierModel customer = MockIdentifierService.MockCustomerIdentifierModel();
            CustomerAddressIdentifierModel address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            net.Services.Messages.MessageBuilderService messageService = MockMessageService.MockMessageBuilderService();

            DeveloperModel developer = MockIdentifierService.MockDeveloperModel();

            string result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address, developer);

            Console.WriteLine($"ETS3 ({merchant.AcquirerBIN})");
            Console.WriteLine(result);

            Assert.Contains("@", result);

            int expected = 64;
            int actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - settle request 1")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant_Settlement1()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS1();

            //ref: 920621605946
            BatchIdentifierModel batch = MockIdentifierService.MockBatchIdentifierModel_ETS1(
                approvalCode: "165448",
                transactionId: "389206789445548",
                validationCode: "Q4JR",
                transDate: "0725",
                transTime: "191755",
                avsResult: 'y'
            );

            Console.WriteLine($"ETS1 ({merchant.AcquirerBIN})");

            var result = batch.ToString();
            var dump = batch.ToDump();

            Console.WriteLine(result);
            Console.Write(dump);
        }

        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - settle request 2")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant_Settlement2()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS2();

            //ref: 920621500559
            BatchIdentifierModel batch = MockIdentifierService.MockBatchIdentifierModel_ETS2(
                approvalCode: "      ",
                transactionId: "",
                validationCode: "",
                transDate: "0725",
                transTime: "191755",
                avsResult: '0',
                responseCode: "B1"
            );

            Console.WriteLine($"ETS2 ({merchant.AcquirerBIN})");

            var result = batch.ToString();
            var dump = batch.ToDump();

            Console.WriteLine(result);
            Console.Write(dump);
        }

        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - settle request 3")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant_Settlement3()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS3();

            // E4.V00027858 000100113613072819213348EXACT MATCH     Y921001201299 389210056282395WFFP020M
            //ref: 920621410648
            BatchIdentifierModel batch = MockIdentifierService.MockBatchIdentifierModel_ETS3(
                approvalCode: "113613",
                transactionId: "389210056282395",
                validationCode: "B6FF",
                transDate: "0728",
                transTime: "192133",
                avsResult: 'Y'
            );

            Console.WriteLine($"ETS3 ({merchant.AcquirerBIN})");

            var result = batch.ToString();
            var dump = batch.ToDump();

            Console.WriteLine(result);
            Console.Write(dump);
        }

        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - settle request TEST")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant_Settlement_TEST()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel_ETS1();

            merchant.AcquirerBIN = 999995;
            merchant.MerchantNumber = 999999999911;
            merchant.StoreNumber = 0011;
            merchant.TerminalNumber = 9911;
            merchant.MerchantCategoryCode = 5999;
            merchant.IndustryCode = "D";
            merchant.CityCode = "543211420";

            TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();

            CustomerIdentifierModel customer = MockIdentifierService.MockCustomerIdentifierModel();

            customer.AccountNumber = "4012888888881881";
            customer.ExpDate = "0218";
            customer.StreetAdress = "8320";
            customer.ZipCode = "85284";

            CustomerAddressIdentifierModel address = MockIdentifierService.MockCustomerAddressIdentifierModel();

            address.StreetAdress = "8320";
            address.ZipCode = "85284";

            net.Services.Messages.MessageBuilderService messageService = MockMessageService.MockMessageBuilderService();
            DeveloperModel developer = MockIdentifierService.MockDeveloperModel();

            string result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address, developer);

            // (page: 8.1.1.11 - 325/430)
            // E4.N00119911 000100TAS844072819224357EXACT MATCH     Y921002500801 000000000019170VS5R020F
            // E4.N00119911 000100TAS918072819231245EXACT MATCH     Y921003501005 00000000001925872HC020025
            //ref: 921002500801
            BatchIdentifierModel batch = MockIdentifierService.MockBatchIdentifierModel_ETS3(
                approvalCode: "TAS918",
                transactionId: "000000000019258",
                validationCode: "72HC",
                transDate: "0728",
                transTime: "192312",
                avsResult: 'Y'
            );

            batch.BatchHeader.MerchantNumber = 999999999911;
            batch.BatchHeader.AquirerBin = 999995;
            batch.BatchHeader.StoreNumber = 0011;
            batch.BatchHeader.TerminalNumber = 9911;
            batch.BatchHeader.IndustryCode = 'D';
            batch.BatchProfile.MerchantCategoryCode = 5999;
            batch.BatchProfile.TerminalIdNumber = 00000001;
            batch.BatchHeader.BatchNumber = 2;
            batch.BatchTrailer.BatchNumber = 2;

            foreach (var trans in batch.BatchTransactions)
            {
                trans.CardholderAccountNumber = "4012888888881881";
                trans.TransactionFee = 50;
            }

            Console.WriteLine($"ETS3 ({merchant.AcquirerBIN})");

            var batchResult = batch.ToString();
            var dump = batch.ToDump();

            Console.WriteLine(batchResult);
            Console.Write(dump);
        }
    }
}