using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.Shared;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.GroupRecords
{
    public struct ProductParticipationModel : IGroupRecord
    {
        public string Group3VersionNumber => "026";

        public ProductParticipationGroupTypeModel ProductParticipationGroup { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Group3VersionNumber, ProductParticipationGroup, AsciiTable.FS);
        }
    }
}