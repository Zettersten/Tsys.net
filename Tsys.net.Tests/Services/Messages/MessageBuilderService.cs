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
    }
}