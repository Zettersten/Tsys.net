namespace Tsys.net.Models.GroupRecords
{
    public struct POSDataCodeModel : IGroupRecord
    {
        public static POSDataCodeModel Empty
        {
            get
            {
                return new POSDataCodeModel();
            }
        }

        public string POSDataCode { get; set; }

        public string Group3VersionNumber => "027";

        public override string ToString()
        {
            if (POSDataCode == null)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{POSDataCode}";
        }
    }
}