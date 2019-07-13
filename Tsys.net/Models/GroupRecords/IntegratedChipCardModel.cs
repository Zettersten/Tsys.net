using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public struct IntegratedChipCardModel
    {
        private string Group3VersionNumber => "055";

        public string TlvEMVTagData { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{TlvEMVTagData}{AsciiTable.FS}";
        }
    }
}