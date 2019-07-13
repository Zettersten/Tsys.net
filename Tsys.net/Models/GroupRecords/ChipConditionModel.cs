namespace Tsys.net.Models.GroupRecords
{
    public struct ChipConditionModel
    {
        private string Group3VersionNumber => "011";

        public string ChipConditionCode { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{ChipConditionCode}";
        }
    }
}