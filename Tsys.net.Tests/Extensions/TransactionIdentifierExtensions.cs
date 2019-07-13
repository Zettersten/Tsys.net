using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Tests.Mocks;
using Xunit;

namespace Tsys.net.Tests.Extensions
{
    [Collection("0.0.0")]
    public class TransactionIdentifierExtensions
    {

        [Fact(DisplayName = "5.32.2 Merchant phone number")]
        public void Should_Format_transaction_sequence_number()
        {
            var transaction = MockIdentifierService.MockTransactionIdentifierModel();

            var expected = "0001";
            var actual = transaction.FormatTransactionSequenceNumber();

            Assert.Equal(expected, actual);
        }
    }
}
