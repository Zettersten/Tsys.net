using System.Collections.Generic;
using Tsys.net.Extensions;
using Tsys.net.Models.Shared;
using static Tsys.net.Models.Shared.AsciiTable;

namespace Tsys.net.Models
{
    /// <summary>
    /// Example:
    ///     <STX>K1.ZH@@@@47170000006000000000803510386380010001QF8400070507260010<ETB>
    ///     <STX>K1.ZP@@@@84020169____5812REGENCY_AT_DOMINION_VALLEHAYMARKET____VA0000175593022<ETB>
    ///     <STX>K1.ZD@@@B54 @HxxxxxxxxxxxxxxxxxxxxxxYA_000100035722072514572100725MDJW1T4KV_______000000000000001000000000001000000000000<ETB>
    ///     <STX>K1.ZD@@@B54 @HxxxxxxxxxxxxxxxxxxxxxxYA_00020006183S072518501200725MCWD2V4MF_______000000000001936000000001936000000000000<ETB>
    ///     <STX>K1.ZD@@`F56N @xxxxxxxxxxxxxxxxxxxxxxYA_00030001018P0725191920Y0725MCWZJY7O0_______000000000341366000000341366000000000000000000341366Z_________________________00001<ETB>
    ///     <STX>K1.ZT@@@@0726001000000006000000000034330300000000000000000000000000343303<ETX>
    /// </summary>
    public class BatchIdentifierModel
    {
        public BatchHeaderIdentifierModel BatchHeader { get; set; }

        public BatchProfileIdentifierModel BatchProfile { get; set; }

        public List<BatchTransactionIdentifierModel> BatchTransactions { get; set; } = new List<BatchTransactionIdentifierModel>();

        public BatchTrailerIdentifierModel BatchTrailer { get; set; }

        public override string ToString()
        {
            if (BatchTransactions.Count == 0)
            {
                return string.Empty;
            }

            string batchTransaction = string.Empty;

            foreach (var transaction in BatchTransactions)
            {
                batchTransaction += $"{STX}{transaction}{ETB}";
            }

            var message = $"{BatchHeader}{ETB}{STX}{BatchProfile}{ETB}{batchTransaction}{STX}{BatchTrailer}";

            return (STX + message + ETX) + (message + ETX).GetLRC();
        }
    }
}