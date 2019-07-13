using Tsys.net.Extensions;
using Tsys.net.Models.Shared;

namespace Tsys.net.Models
{
    public class CustomerAddressIdentifierModel
    {
        public string StreetAdress { get; set; }

        public string ZipCode { get; set; }

        public override string ToString()
        {
            var address = this.FormatCustomerStreetAddress();
            var zip = this.FormatCustomerZipCode();

            if (address.Length + zip.Length > 28)
            {
                address = address.Substring(0, 28 - zip.Length);
            }

            return $"{address}{AsciiTable.SP}{zip}";
        }
    }
}