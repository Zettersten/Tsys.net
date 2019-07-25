using Tsys.net.Models.Shared;

namespace Tsys.net.Models.GroupRecords
{
    public struct IntegratedChipCardModel : IGroupRecord
    {
        public static IntegratedChipCardModel Empty
        {
            get
            {
                return new IntegratedChipCardModel();
            }
        }

        public string Group3VersionNumber => "055";

        public string TlvEMVTagData { get; set; }

        public override string ToString()
        {
            if (TlvEMVTagData == null)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{TlvEMVTagData}{AsciiTable.FS}";
        }
    }
}