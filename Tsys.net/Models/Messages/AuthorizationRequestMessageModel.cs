using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Models.Authorizations;
using Tsys.net.Models.GroupRecords;
using Tsys.net.Models.Shared;

namespace Tsys.net.Models.Messages
{
    public struct AuthorizationRequestMessageModel
    {
        public string TransactionUuid { get; set; }

        public DateTimeOffset TransactionTime { get; set; }

        public Group1AuthorizationModel G1 { get; set; }

        public Group2AuthorizationModel G2 { get; set; }

        public string G3 { get; set; }

        public static AuthorizationRequestMessageModel NewAuthorizationMessageRequest(string id, Group1AuthorizationModel group1, Group2AuthorizationModel group2, List<IGroupRecord> group3s)
        {
            var result = new AuthorizationRequestMessageModel
            {
                TransactionUuid = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString("D") : id,
                TransactionTime = DateTimeOffset.UtcNow,
                G1 = group1,
                G2 = group2,
                G3 = string.Join(AsciiTable.GS, group3s.Select(x => x.ToString()))
            };

            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            this.CopyToBuffer(ref sb);

            return sb.ToString();
        }
    }
}