using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public struct DeveloperModel : IGroupRecord
    {
        public static DeveloperModel Empty
        {
            get
            {
                return new DeveloperModel
                {
                    DeveloperId = "000136",
                    VersionId = "B290"
                };
            }
        }

        public string DeveloperId { get; set; }

        public string VersionId { get; set; }

        public string Group3VersionNumber => "020";

        public override string ToString()
        {
            if (DeveloperId == null || VersionId == null)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{DeveloperId}{VersionId}{AsciiTable.FS}{AsciiTable.FS}";
        }
    }
}