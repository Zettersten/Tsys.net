namespace Tsys.net.Models.GroupRecords
{
    public class CardVerificationModel : GroupRecord
    {
        public CardVerificationModel()
        {
            Group3VersionNumber = "039";
        }

        public string CardholderVerificationMethod { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{CardholderVerificationMethod}";
        }
    }
}