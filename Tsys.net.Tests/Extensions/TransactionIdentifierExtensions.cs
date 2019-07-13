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
            Models.TransactionIdentifierModel transaction = MockIdentifierService.MockTransactionIdentifierModel();

            string expected = "0001";
            string actual = transaction.FormatTransactionSequenceNumber();

            Assert.Equal(expected, actual);
        }
    }
}