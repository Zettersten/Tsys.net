using System.Text;
using Tsys.net.Models.Authorizations;
using Tsys.net.Models.Shared;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class Group2AuthorizationModelExtensions
    {
        public static void CopyToBuffer(this Group2AuthorizationModel group2Authorization, bool isPosCheck, ref StringBuilder buffer)
        {
            buffer
                .Append(AsciiTable.FS)
                .AppendFormat("{0}", group2Authorization.SharingGroup)
                .Append(AsciiTable.FS)
                .AppendFormat("{0:000000000}", group2Authorization.MerchantABANumber)
                .AppendFormat("{0:0000}", group2Authorization.MerchantSettlementAgentNo)
                .Append(AsciiTable.FS)
                .AppendFormat("{0:000000}", group2Authorization.AgentBankNumber)
                .AppendFormat("{0:000000}", group2Authorization.AgentChainNumber)
                .AppendFormat("{0:000}", group2Authorization.BatchNumber)
                .AppendFormat("{0}", group2Authorization.ReimbursementAttribute);

            if (!isPosCheck)
            {
                buffer.AppendFormat("{0}", group2Authorization.OriginalPurchaseData);
            }

            buffer.Append(AsciiTable.FS);

            if (!isPosCheck && group2Authorization.ReversalAndCancelData.SystemTraceAuditNumber > 0)
            {
                buffer = new StringBuilder(group2Authorization.ReversalAndCancelData.ToString() + buffer.ToString());

                return;
            }
        }
    }
}