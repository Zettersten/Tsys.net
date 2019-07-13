using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public class IntegratedChipCardModel : GroupRecord
    {
        public IntegratedChipCardModel()
        {
            Group3VersionNumber = "055";
        }

        public string TlvEMVTagData { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{TlvEMVTagData}{AsciiTable.FS}";
        }
    }
}