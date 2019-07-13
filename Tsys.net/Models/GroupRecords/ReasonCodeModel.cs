namespace Tsys.net.Models.GroupRecords
{
    public class ReasonCodeModel : GroupRecord
    {
        public ReasonCodeModel()
        {
            Group3VersionNumber = "056";
        }

        public int MessageReasonCode { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{MessageReasonCode}";
        }
    }
}