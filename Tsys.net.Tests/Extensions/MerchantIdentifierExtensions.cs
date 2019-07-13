using Tsys.net.Extensions;
using Tsys.net.Tests.Mocks;
using Xunit;

namespace Tsys.net.Tests.Extensions
{
    [Collection("0.0.0")]
    public class MerchantIdentifierExtensions
    {
        [Fact(DisplayName = "5.129 Merchant number")]
        public void Should_Format_right_justified_and_zero_fill_merchant_number()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "999999999911";
            string actual = merchant.FormatMerchantNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.178 Store number")]
        public void Should_Format_right_justified_and_zero_fill_store_number()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "0011";
            string actual = merchant.FormatStoreNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.59 City code")]
        public void Should_Format_right_justified_and_space_fill_city_code()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "543211420";
            string actual = merchant.FormatCityCode();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.3 Merchant state")]
        public void Should_Format_merchant_state()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "VA";
            string actual = merchant.FormatMerchantState();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.2 Merchant city")]
        public void Should_Format_merchant_city()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "Gloucester";
            string actual = merchant.FormatMerchantCity();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.1 Merchant name")]
        public void Should_Format_merchant_name()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "Internet Service Provider";
            string actual = merchant.FormatMerchantName();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.127 Merchant email")]
        public void Should_Format_left_justified_and_truncate_merchant_email()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "customer@mycompanydo"; // main.com
            string actual = merchant.FormatMerchantEmailAddress();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.133 Merchant street address")]
        public void Should_Format_left_justified_and_truncate_address()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "8320";
            string actual = merchant.FormatStreetAddress();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.2 Customer service phone number")]
        public void Should_Format_customer_service_phone_number()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "800-1234567";
            string actual = merchant.FormatCustomerServicePhoneNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "5.32.2 Merchant phone number")]
        public void Should_Format_merchant_phone_number()
        {
            Models.MerchantIdentifierModel merchant = MockIdentifierService.MockMerchantIdentifierModel();

            string expected = "800-1234567";
            string actual = merchant.FormatMerchantPhoneNumber();

            Assert.Equal(expected, actual);
        }
    }
}