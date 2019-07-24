using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class ReversalAndCancelDataIIModelExtensions
    {
        public static string Serialize(this ReversalAndCancelDataIIModel reversalAndCancelData)
        {
            if (reversalAndCancelData.SystemTraceAuditNumber == 0)
            {
                return string.Empty;
            }

            return string.Format("{0:000000}{1}", reversalAndCancelData.SystemTraceAuditNumber, reversalAndCancelData.NetworkIdentificationCode);
        }

        public static ReversalAndCancelDataIIModel Deserialize<T>(this string value) where T : ReversalAndCancelDataIIModel
        {
            var result = new ReversalAndCancelDataIIModel
            {
                SystemTraceAuditNumber = 0,
                NetworkIdentificationCode = NetworkIdentificationTypeModel.SpaceOrEmptyNetworkId
            };

            if (7 > value.Length)
            {
                return result;
            }

            result.SystemTraceAuditNumber = uint.Parse(value.Substring(0, 6));
            result.NetworkIdentificationCode = value.Substring(6);

            return result;
        }
    }
}