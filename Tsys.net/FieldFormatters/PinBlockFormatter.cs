using static Tsys.net.Formatters.Formatters;

namespace Tsys.net.FieldFormatters
{
    /// <summary>
    ///   Class dealing with creating an ISO-0 PIN Block
    /// </summary>
    public class PinBlockFormatter
    {
        /// <summary>
        ///   Creates a clear PIN block of the given PAN and PIN
        /// </summary>
        /// <param name = "pan">Primary Account Number</param>
        /// <param name = "pin">Personal Identification Number</param>
        /// <returns>Clear PIN Block</returns>
        public string CreatePinBlock(string pan, string pin)
        {
            string line1 = pin.Length.ToString().PadLeft(2, '0') + pin;
            line1 = line1.PadRight(16, 'F');

            string line2 = string.Format("0000{0}", pan.Substring(pan.Length - 13, 12));

            byte[] byte1 = Binary.GetBytes(line1);
            byte[] byte2 = Binary.GetBytes(line2);

            var result = new byte[8];

            for (int i = 0; i < 8; i++)
            {
                result[i] = (byte)(byte1[i] ^ byte2[i]);
            }

            return Binary.GetString(result);
        }
    }
}