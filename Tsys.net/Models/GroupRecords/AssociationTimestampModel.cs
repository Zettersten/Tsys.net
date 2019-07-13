namespace Tsys.net.Models.GroupRecords
{
    public struct AssociationTimestampModel
    {
        private string Group3VersionNumber => "050";

        public override string ToString()
        {
            return $"{Group3VersionNumber}";
        }
    }
}