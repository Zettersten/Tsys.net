namespace Tsys.net.Models.GroupRecords
{
    public struct ReasonCodeModel
    {
        private string Group3VersionNumber => "056";

        public int MessageReasonCode { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{MessageReasonCode}";
        }
    }
}