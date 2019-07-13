namespace Tsys.net.Models.GroupRecords
{
    public struct POSDataCodeModel
    {
        private string Group3VersionNumber => "027";

        public string POSDataCode { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{POSDataCode}";
        }
    }
}