using static Tsys.net.Formatters.Formatters;

namespace Tsys.net.FieldFormatters
{
    /// <summary>
    ///   Variable length formatter
    /// </summary>
    public struct VariableLengthFormatter
    {
        private readonly int _lengthIndicator;
        private readonly int _maxLength;

        /// <summary>
        ///   Variable length field formatter
        /// </summary>
        /// <param name = "lengthIndicator">Length of the length indicator</param>
        /// <param name = "maxLength">Maximum length of the field</param>
        /// <param name = "lengthFormatter">The field formatter used to pack the field</param>
        public VariableLengthFormatter(int lengthIndicator, int maxLength)
        {
            _lengthIndicator = lengthIndicator;
            _maxLength = maxLength;
            LengthOfLengthIndicator = Ascii.GetPackedLength(_lengthIndicator);
        }

        /// <summary>
        ///   Get the length of the packed length indicator
        /// </summary>
        public int LengthOfLengthIndicator { get; private set; }

        /// <summary>
        ///   The maximum length of the field displayed as a string for descriptors
        /// </summary>
        public string MaxLength
        {
            get { return ".." + _maxLength; }
        }

        /// <summary>
        ///   Check the length of the field is valid
        /// </summary>
        /// <param name = "packedLength">the packed length of the field</param>
        /// <returns>true if valid, false otherwise</returns>
        public bool IsValidLength(int packedLength)
        {
            return packedLength <= _maxLength;
        }
    }
}