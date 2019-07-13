namespace Tsys.net.Models.GroupRecords
{
    public struct ReversalRequestModel
    {
        private string Group3VersionNumber => "033";

        /// <summary>
        /// This code can be present in the reversal request for MasterCard transactions to signify the reason for the reversal.
        /// </summary>
        public int AdjustmentResponseCode { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{AdjustmentResponseCode}";
        }
    }
}