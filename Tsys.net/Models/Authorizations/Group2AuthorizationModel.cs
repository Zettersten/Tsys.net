using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.Authorizations
{
    public class Group2AuthorizationModel
    {
        /// <summary>
        /// 0, 7 A/N
        /// </summary>
        public ReversalAndCancelDataIIModel ReversalAndCancelData { get; set; }

        /// <summary>
        /// (SharingGroup) This one to 30-character field contains a listing of direct debit and EBT networks that a POS
	    /// device can access. This field should be configured as a parameter
        /// </summary>
        public string SharingGroup { get; set; }

        /// <summary>
        /// 0, 9 NUM
        /// </summary>
        public long MerchantABANumber { get; set; }

        /// <summary>
        /// 0, 4 A/N
        /// </summary>
        public string MerchantSettlementAgentNo { get; set; }

        /// <summary>
        /// 6 NUM
        /// </summary>
        public uint AgentBankNumber { get; set; }

        /// <summary>
        /// 6 NUM
        /// </summary>
        public uint AgentChainNumber { get; set; }

        /// <summary>
        /// 3 NUM
        /// </summary>
        public uint BatchNumber { get; set; }

        /// <summary>
        /// 1 A/N
        /// </summary>
        public ReimbursementAttributeTypeModel ReimbursementAttribute { get; set; }

        /// <summary>
        /// 0, 12 A/N YYMMDDhhmmss
        /// </summary>
        public string OriginalPurchaseData { get; set; }

        public static Group2AuthorizationModel NewG2AuthorizationMessageRequest(ReversalAndCancelDataIIModel reversalAndCancelData, string sharingGroup, long abaNumber, string settlmentAgent, uint agentBank, uint agentChain, uint batchNumber, ReimbursementAttributeTypeModel reimbursementAttribute, string purchaserData)
        {
            var result = new Group2AuthorizationModel();

            if (string.IsNullOrEmpty(reversalAndCancelData.ToString()))
            {
                result.ReversalAndCancelData = ReversalAndCancelDataIIModel.NewReversalAndCancelDataII(UintExtensions.GenerateSystemTraceAuditNumber(), NetworkIdentificationTypeModel.SpaceOrEmptyNetworkId);
            }
            else
            {
                result.ReversalAndCancelData = reversalAndCancelData;
            }

            if (string.IsNullOrEmpty(sharingGroup))
            {
                result.SharingGroup = "VNGK7F3EHYL8MIQZW";
            }
            else
            {
                result.SharingGroup = sharingGroup;
            }

            result.MerchantABANumber = abaNumber;

            if (string.IsNullOrEmpty(settlmentAgent))
            {
                result.MerchantSettlementAgentNo = "V040";
            }
            else
            {
                result.MerchantSettlementAgentNo = settlmentAgent;
            }

            result.AgentBankNumber = agentBank;
            result.AgentChainNumber = agentChain;
            result.BatchNumber = batchNumber;
            result.ReimbursementAttribute = reimbursementAttribute;
            result.OriginalPurchaseData = purchaserData;

            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.CopyToBuffer(false, ref sb);
            return sb.ToString();
        }

        public string ToString(bool isPosCheck)
        {
            var sb = new StringBuilder();
            this.CopyToBuffer(isPosCheck, ref sb);
            return sb.ToString();
        }
    }
}