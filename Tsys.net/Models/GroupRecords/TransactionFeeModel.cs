using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public class TransactionFeeModel : GroupRecord
    {
        public TransactionFeeModel()
        {
            Group3VersionNumber = "025";
        }

        /// <summary>
        /// Transaction Fee Amount is used in PIN POS and credit transactions to carry the acquirerassessed
        /// surcharge for informational purposes only(see Table 4.46 for record format and
        /// version number). This field can be zero length or nine alphanumeric characters in length.The
        /// format of the nine characters is “annnnnnnn” where “a” is either “D” for debit or “C” for
        /// credit and where “nnnnnnnn” is the numeric fee amount with the decimal implied.Example:
        /// “D00000150” is a $1.50 transaction fee amount debited to the cardholder's account.
        /// </summary>
        public string TransactionFeeAmount { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{TransactionFeeAmount}{AsciiTable.FS}";
        }
    }
}