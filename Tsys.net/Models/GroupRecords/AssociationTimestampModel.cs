namespace Tsys.net.Models.GroupRecords
{
    public struct AssociationTimestampModel : IGroupRecord
    {
        public static AssociationTimestampModel Empty
        {
            get
            {
                return new AssociationTimestampModel
                {
                    IsEmpty = true
                };
            }
        }

        public bool IsEmpty { get; set; }

        public string Group3VersionNumber => "050";

        public override string ToString()
        {
            if (IsEmpty)
            {
                return string.Empty;
            }

            return $"{Group3VersionNumber}";
        }
    }
}