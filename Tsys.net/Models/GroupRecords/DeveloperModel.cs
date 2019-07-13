using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public struct DeveloperModel
    {
        private string Group3VersionNumber => "020";

        public string DeveloperId { get; set; }

        public string VersionId { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{DeveloperId}{VersionId}{AsciiTable.FS}{AsciiTable.FS}";
        }
    }
}