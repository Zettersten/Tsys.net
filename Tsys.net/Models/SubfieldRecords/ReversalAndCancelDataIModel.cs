using System;
using System.Globalization;
using Tsys.net.Extensions;

namespace Tsys.net.Models.SubfieldRecords
{
    public class ReversalAndCancelDataIModel
    {
        public string ApprovalCode { get; set; }

        public DateTimeOffset LocalTransactionDate { get; set; }

        public uint RetrievalReferenceNumber { get; set; }

        public static ReversalAndCancelDataIModel NewReversalAndCancelDataI(string approvalCode, DateTimeOffset timeOffset, uint referenceNumber)
        {
            return new ReversalAndCancelDataIModel
            {
                ApprovalCode = approvalCode,
                LocalTransactionDate = timeOffset,
                RetrievalReferenceNumber = referenceNumber
            };
        }

        public static implicit operator ReversalAndCancelDataIModel(string value)
        {
            return ReversalAndCancelDataIModelExtensions.Deserialize<ReversalAndCancelDataIModel>(value);
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}