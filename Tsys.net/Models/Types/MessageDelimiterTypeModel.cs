namespace Tsys.net.Models.Types
{
    public struct MessageDelimiterTypeModel
    {
        public const string DefaultDelimiter = ".";

        private readonly string value;

        public MessageDelimiterTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator MessageDelimiterTypeModel(string value)
        {
            return new MessageDelimiterTypeModel(value);
        }

        public override string ToString()
        {
            return value;
        }
    }
}