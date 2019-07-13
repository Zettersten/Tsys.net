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
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();
            var transaction = MockIdentifierService.MockTransactionIdentifierModel();
            var customer = MockIdentifierService.MockCustomerIdentifierModel();
            var address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            var messageService = MockMessageService.MockMessageBuilderService();

            var result = messageService
                .BuildManualAVSRequestMessage(merchant, transaction, customer, address);

            Assert.Contains("@", result);

            var expected = 64;
            var actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }
    }
}