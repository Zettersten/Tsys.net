using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.GroupRecords
{
    public struct CardVerificationCodeModel : IGroupRecord
    {
        public string Group3VersionNumber => "007";

        public string SecurityCode { get; set; }

        public VerificationCodeDesiredResponseTypeModel VerificationCode { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Group3VersionNumber, VerificationCode);
        }
    }
}