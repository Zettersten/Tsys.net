using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.SubfieldRecords;

namespace Tsys.net.Models.GroupRecords
{
    public struct AdditionalAmountsModel : IGroupRecord
    {
        public string Group3VersionNumber => "022";

        public AdditionalAmountInfoModel AdditionalAmount1 { get; set; }

        public AdditionalAmountInfoModel AdditionalAmount2 { get; set; }

        public AdditionalAmountInfoModel AdditionalAmount3 { get; set; }

        public AdditionalAmountInfoModel AdditionalAmount4 { get; set; }

        public override string ToString()
        {
            if (
                (AdditionalAmount1 == null || AdditionalAmount1.Amount == 0) ||
                (AdditionalAmount2 == null || AdditionalAmount2.Amount == 0) ||
                (AdditionalAmount3 == null || AdditionalAmount2.Amount == 0) ||
                (AdditionalAmount4 == null || AdditionalAmount4.Amount == 0)
            )
            {
                return string.Format("{0}", Group3VersionNumber);
            }

            return string.Format("{0}{1}{2}{3}{4}", Group3VersionNumber, AdditionalAmount1, AdditionalAmount2, AdditionalAmount3, AdditionalAmount4);
        }
    }
}