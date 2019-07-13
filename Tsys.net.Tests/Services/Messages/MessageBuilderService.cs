using System;
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
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();
            Models.TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();
            Models.CustomerIdentifierModel customer = MockIdentifierService.MockCustomerIdentifierModel();
            Models.CustomerAddressIdentifierModel address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            net.Services.Messages.MessageBuilderService messageService = MockMessageService.MockMessageBuilderService();

            string result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address);

            Assert.Contains("@", result);

            int expected = 64;
            int actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }
    }
}