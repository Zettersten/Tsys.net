using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public class AdditionalResponseDataModel : GroupRecord
    {
        public AdditionalResponseDataModel()
        {
            Group3VersionNumber = "057";
        }

        public string AdditionalResponseData { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{AdditionalResponseData}{AsciiTable.FS}";
        }
    }
}