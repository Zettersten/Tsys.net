using Tsys.net.Extensions;
using Tsys.net.Tests.Mocks;
using Xunit;

namespace Tsys.net.Tests.Extensions
{
    [Collection("0.0.0")]
    public class MerchantIdentifierExtensions
    {

        [Fact(DisplayName = "5.129 - Merchant number")]
        public void Should_Format_right_justified_and_zero_fill_merchant_number()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "000000000011";
            var actual = merchant.FormatMerchantNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.178 Store number")]
        public void Should_Format_right_justified_and_zero_fill_store_number()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "0011";
            var actual = merchant.FormatStoreNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.59 City code")]
        public void Should_Format_right_justified_and_space_fill_city_code()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "    20147";
            var actual = merchant.FormatCityCode();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.127 Merchant email")]
        public void Should_Format_left_justified_and_truncate_merchant_email()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "customer@mycompanydo"; // main.com
            var actual = merchant.FormatMerchantEmailAddress();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.133 Merchant street address")]
        public void Should_Format_left_justified_and_truncate_address()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "19515";
            var actual = merchant.FormatStreetAddress();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.2 Customer service phone number")]
        public void Should_Format_customer_service_phone_number()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "571-2869577";
            var actual = merchant.FormatCustomerServicePhoneNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.2 Merchant phone number")]
        public void Should_Format_merchant_phone_number()
        {
            var merchant = MockIdentifierService.MockMerchantIdentifierModel();

            var expected = "571-2869577";
            var actual = merchant.FormatMerchantPhoneNumber();

            Assert.Equal(expected, actual);
        }
    }
}
