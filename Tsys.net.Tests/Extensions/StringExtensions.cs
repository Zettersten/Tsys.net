using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Extensions;
using Xunit;

namespace Tsys.net.Tests.Extensions
{
    [Collection("0.0.0")]
    public class StringExtensions
    {
        [Fact(DisplayName = "0.0 Truncate string")]
        public void Should_truncate_string()
        {
            var itemToTest = "Erik Zettersten";

            var expected = "Erik";
            var actual = itemToTest.Truncate(4);

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "0.0 Format phone number")]
        public void Should_formate_string_as_phone_number()
        {
            var itemToTest = "(571) 286-9577";

            var expected = "571-2869577";
            var actual = itemToTest.FormatPhoneNumber();

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "0.0 Format phone number when phone has country code")]
        public void Should_formate_string_as_phone_number_when_phone_has_country_code()
        {
            var itemToTest = "+1 (571) 286-9577";

            var expected = "571-2869577";
            var actual = itemToTest.FormatPhoneNumber();

            Assert.Equal(expected, actual);
        }
    }
}
