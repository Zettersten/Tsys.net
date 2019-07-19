namespace Tsys.net.Models.GroupRecords
{
    public struct CardVerificationModel : IGroupRecord
    {
        public static CardVerificationModel Empty
        {
            get
            {
                return new CardVerificationModel();
            }
        }

        public string CardholderVerificationMethod { get; set; }

        public string Group3VersionNumber => "039";

        public override string ToString()
        {
            if (CardholderVerificationMethod == null)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{CardholderVerificationMethod}";
        }
    }
}