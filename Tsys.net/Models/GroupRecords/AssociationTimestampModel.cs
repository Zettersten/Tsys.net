namespace Tsys.net.Models.GroupRecords
{
    public class AssociationTimestampModel : GroupRecord
    {
        public AssociationTimestampModel()
        {
            Group3VersionNumber = "050";
        }

        public override string ToString()
        {
            return $"{Group3VersionNumber}";
        }
    }
}