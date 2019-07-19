using System;
using Tsys.net.Extensions;

namespace Tsys.net.Formatters
{
    /// <summary>
    ///   Binary FIeld Formatter
    /// </summary>
    public class BinaryFormatter : IFormatter
    {
        /// <summary>
        ///   Format the string and return as an encoded byte array
        /// </summary>
        /// <param name = "value">value to format</param>
        /// <returns>Encoded byte array</returns>
        public byte[] GetBytes(string value)
        {
            if (!value.IsHex())
            {
                throw new FormatException("Value is not valid HEX");
            }

            var numberChars = value.Length;
            var bytes = new byte[numberChars / 2];

            for (var i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(value.Substring(i, 2), 16);
            }

            return bytes;
        }

        /// <summary>
        ///   Gets the packed length of the data given the unpacked length
        /// </summary>
        /// <param name = "unpackedLength">Unpacked length</param>
        /// <returns>Packed length of the data</returns>
        public int GetPackedLength(int unpackedLength)
        {
            if (unpackedLength % 2 != 0)
            {
                return (unpackedLength + 1) / 2;
            }

            return unpackedLength / 2;
        }

        /// <summary>
        ///   Takes the byte array and converts it to a string for use
        /// </summary>
        /// <param name = "data">Data to convert</param>
        /// <returns>Converted data</returns>
        public string GetString(byte[] data)
        {
            var hex = BitConverter.ToString(data);
            return hex.Replace("-", string.Empty);
        }

        /// <summary>
        ///   Takes the byte array and converts it to a string for use
        /// </summary>
        /// <param name = "data">Data to convert</param>
        /// <returns>Converted data</returns>
        public string GetString(byte data)
        {
            return GetString(new byte[] { data });
        }
    }
}