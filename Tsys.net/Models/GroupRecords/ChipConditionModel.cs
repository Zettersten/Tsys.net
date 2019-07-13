namespace Tsys.net.Models.GroupRecords
{
    public class ChipConditionModel : GroupRecord
    {
        public ChipConditionModel()
        {
            Group3VersionNumber = "011";
        }

        public string ChipConditionCode { get; set; }

        public override string ToString()
        {
            return $"{Group3VersionNumber}{ChipConditionCode}";
        }
    }
}