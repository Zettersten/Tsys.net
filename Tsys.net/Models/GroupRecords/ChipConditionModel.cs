namespace Tsys.net.Models.GroupRecords
{
    public struct ChipConditionModel : IGroupRecord
    {
        public static ChipConditionModel Empty
        {
            get
            {
                return new ChipConditionModel();
            }
        }

        public string ChipConditionCode { get; set; }

        public string Group3VersionNumber => "011";

        public override string ToString()
        {
            if (ChipConditionCode == null)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}{ChipConditionCode}";
        }
    }
}