using Tsys.net.Models.GroupRecords;

namespace Tsys.net.Models
{
    public class BatchBaseIdentifierModel
    {
        public char RecordFormat { get; } = 'K';

        public uint ApplicationType { get; } = 1;

        public char MessageDelimiter { get; } = '.';

        public char RoutingId { get; } = 'Z';

        public RecordTypeModel RecordType { get; set; }

        public string GetStartOfMessage()
        {
            return $"{RecordFormat}{ApplicationType}{MessageDelimiter}{RoutingId}{RecordType}";
        }
    }
}