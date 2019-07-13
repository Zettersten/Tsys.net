namespace Tsys.net.Models.GroupRecords
{
    public struct CardVerificationModel
    {
        private string Group3VersionNumber => "039";

        public string CardholderVerificationMethod { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{CardholderVerificationMethod}";
        }
    }
}