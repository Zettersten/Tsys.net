using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.SubfieldRecords
{
    public class ReversalAndCancelDataIIModel
    {
        public uint SystemTraceAuditNumber { get; set; }

        public NetworkIdentificationTypeModel NetworkIdentificationCode { get; set; }

        public static ReversalAndCancelDataIIModel NewReversalAndCancelDataII(uint traceNumber, NetworkIdentificationTypeModel networkIdentificationTypeModel)
        {
            return new ReversalAndCancelDataIIModel
            {
                SystemTraceAuditNumber = traceNumber,
                NetworkIdentificationCode = networkIdentificationTypeModel
            };
        }

        public static implicit operator ReversalAndCancelDataIIModel(string value)
        {
            return ReversalAndCancelDataIIModelExtensions.Deserialize<ReversalAndCancelDataIIModel>(value);
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}