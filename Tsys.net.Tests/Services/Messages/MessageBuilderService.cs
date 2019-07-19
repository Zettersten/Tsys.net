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
            var message = MockIdentifierService.MockTsysMessageModel();
            var customer = MockIdentifierService.MockCustomerIdentifierModel();
            var address = MockIdentifierService.MockCustomerAddressIdentifierModel();
            var messageService = MockMessageService.MockMessageBuilderService();
            var developer = MockIdentifierService.MockDeveloperModel();
            var transactionFee = MockIdentifierService.MockTransactionFeeModel();

            var result = messageService
                .BuildManualAVSRequestMessage(message, customer, address, developer, transactionFee);

            Assert.Contains("@", result);

            int expected = 64;
            int actual = result.Split('@', StringSplitOptions.RemoveEmptyEntries)[0].Length;

            Assert.StartsWith(AsciiTable.STX, result);
            Assert.Equal(expected, actual);
        }
    }
}