using Tsys.net.Models.Shared;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.GroupRecords
{
    public struct TransactionFeeModel : IGroupRecord
    {
        public static TransactionFeeModel Empty
        {
            get
            {
                return new TransactionFeeModel();
            }
        }

        /// <summary>
        /// Transaction Fee Amount is used in PIN POS and credit transactions to carry the acquirerassessed
        /// surcharge for informational purposes only(see Table 4.46 for record format and
        /// version number). This field can be zero length or nine alphanumeric characters in length.The
        /// format of the nine characters is “annnnnnnn” where “a” is either “D” for debit or “C” for
        /// credit and where “nnnnnnnn” is the numeric fee amount with the decimal implied.Example:
        /// “D00000150” is a $1.50 transaction fee amount debited to the cardholder's account.
        /// </summary>
        public long TransactionFeeAmount { get; set; }

        public bool IsCredit { get; set; }

        public string Group3VersionNumber => "025";

        public override string ToString()
        {
            if (TransactionFeeAmount == 0)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{(IsCredit ? AdditionalAmountSignTypeModel.PositiveBalance : AdditionalAmountSignTypeModel.NegativeBalance)}{TransactionFeeAmount.ToString().PadLeft(8, '0')}{AsciiTable.FS}";
        }
    }
}