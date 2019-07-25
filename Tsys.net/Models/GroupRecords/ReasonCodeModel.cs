namespace Tsys.net.Models.GroupRecords
{
    public struct ReasonCodeModel : IGroupRecord
    {
        public static ReasonCodeModel Empty
        {
            get
            {
                return new ReasonCodeModel();
            }
        }

        public int MessageReasonCode { get; set; }

        public string Group3VersionNumber => "056";

        public override string ToString()
        {
            if (MessageReasonCode == 0)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{MessageReasonCode}";
        }
    }
}