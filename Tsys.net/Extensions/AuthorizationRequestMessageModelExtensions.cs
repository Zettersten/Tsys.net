using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.Messages;
using Tsys.net.Models.Shared;

namespace Tsys.net.Extensions
{
    public static class AuthorizationRequestMessageModelExtensions
    {
        public static void CopyToBuffer(this AuthorizationRequestMessageModel requestMessageModel, ref StringBuilder buffer)
        {
            buffer
                .Append(AsciiTable.STX)
                .Append(requestMessageModel.G1);

            if (requestMessageModel.G2 != null)
            {
                buffer.Append(requestMessageModel.G2);
            }

            buffer
                .Append(requestMessageModel.G3)
                .Append(AsciiTable.ETX);

            var lrc = (buffer.ToString() + AsciiTable.ETX).GetLRC();

            buffer = new StringBuilder(buffer.ToString() + lrc);
        }
    }
}