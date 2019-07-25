using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public struct AdditionalResponseDataModel : IGroupRecord
    {
        public static AdditionalResponseDataModel Empty
        {
            get
            {
                return new AdditionalResponseDataModel();
            }
        }

        public string AdditionalResponseData { get; set; }

        public string Group3VersionNumber => "057";

        public override string ToString()
        {
            if (AdditionalResponseData == null)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{AdditionalResponseData}{AsciiTable.FS}";
        }
    }
}