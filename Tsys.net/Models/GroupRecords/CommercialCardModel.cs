using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.GroupRecords
{
    public struct CommercialCardModel : IGroupRecord
    {
        public const string CommercialCardRequestIndicator = "!010";

        public string Group3VersionNumber => "001";

        public override string ToString()
        {
            return string.Format("{0}{1}", Group3VersionNumber, CommercialCardRequestIndicator);
        }
    }
}