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
        [Fact(DisplayName = "7.1.1.2 - Retail/restaurant - manual AVS - request")]
        public void D_Format_Authorization_Request_Message_Retail_And_Restaurant()
        {
            MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();
            TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();
            CustomerIdentifierModel customer = MockIdentifierService.MockCustomerIdentifierModel();
            CustomerAddressIdentifierModel address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            net.Services.Messages.MessageBuilderService messageService = MockMessageService.MockMessageBuilderService();

            DeveloperModel developer = MockIdentifierService.MockDeveloperModel();

            string result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address, developer);

            Assert.Contains("@", result);

            int expected = 64;
            int actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }
    }
}