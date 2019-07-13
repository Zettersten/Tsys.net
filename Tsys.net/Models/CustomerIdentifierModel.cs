using Tsys.net.Models.Shared;

namespace Tsys.net.Models
{
    public struct CustomerIdentifierModel
    {
        public string FullTrack1 { get; set; }

        public string FullTrack2 { get; set; }

        public string AccountNumber { get; set; }

        public string ExpDate { get; set; }

        public string StreetAdress { get; set; }

        public string ZipCode { get; set; }

        public override string ToString()
        {
            if (AccountNumber != null)
            {
                return $"{AccountNumber}{AsciiTable.FS}{ExpDate}{AsciiTable.FS}";
            }

            if (FullTrack1 != null)
            {
                return FullTrack1;
            }

            return FullTrack2;
        }
    }
}