using Tsys.net.Models.Shared;

namespace Tsys.net.FieldValidators
{
    /// <summary>
    ///   Hex field formatter
    /// </summary>
    public class AsciiFieldValidator : IFieldValidator
    {
        /// <summary>
        ///   Description of the validator
        /// </summary>
        public string Description
        {
            get { return "acii"; }
        }

        /// <summary>
        ///   Validates the format of the given string value
        /// </summary>
        /// <param name = "value">Value to validate</param>
        /// <returns>true if valid, false otherwise</returns>
        public bool IsValid(string value)
        {
            if (value == AsciiTable.D || value == AsciiTable.ETB || value == AsciiTable.ETX || value == AsciiTable.FS || value == AsciiTable.GS || value == AsciiTable.SP || value == AsciiTable.STX || value == AsciiTable.US)
            {
                return true;
            }

            return false;
        }
    }
}