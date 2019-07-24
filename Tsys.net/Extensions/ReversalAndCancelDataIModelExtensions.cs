using System;
using Tsys.net.Models.SubfieldRecords;

namespace Tsys.net.Extensions
{
    public static class ReversalAndCancelDataIModelExtensions
    {
        public static string Serialize(this ReversalAndCancelDataIModel reversalAndCancelDataI)
        {
            return string.Format
            (
                "{0}{1}{2}{3}{4}{5}{6}{7}",
                reversalAndCancelDataI.ApprovalCode.Truncate(6),
                reversalAndCancelDataI.LocalTransactionDate.Month.PadLeft(2, '0'),
                reversalAndCancelDataI.LocalTransactionDate.Day.PadLeft(2, '0'),
                reversalAndCancelDataI.LocalTransactionDate.Year.ToString().Substring(2),
                reversalAndCancelDataI.LocalTransactionDate.Hour.PadLeft(2, '0'),
                reversalAndCancelDataI.LocalTransactionDate.Minute.PadLeft(2, '0'),
                reversalAndCancelDataI.LocalTransactionDate.Second.PadLeft(2, '0'),
                reversalAndCancelDataI.RetrievalReferenceNumber.ToString().PadLeft(12, '0')
            );
        }

        public static ReversalAndCancelDataIModel Deserialize<T>(this string value) where T : ReversalAndCancelDataIModel
        {
            var result = new ReversalAndCancelDataIModel
            {
                LocalTransactionDate = DateTimeOffset.Now,
                RetrievalReferenceNumber = 0,
                ApprovalCode = ""
            };

            if (18 > value.Length)
            {
                return result;
            }

            result.ApprovalCode = value.Truncate(6);

            var dateTimeString = value.Substring(6, 18);
            var year = int.Parse(DateTime.Now.Year.ToString().Substring(0, 2) + dateTimeString.Substring(0, 2));
            var month = int.Parse(dateTimeString.Substring(2, 2));
            var day = int.Parse(dateTimeString.Substring(4, 2));
            var hour = int.Parse(dateTimeString.Substring(6, 2));
            var minutes = int.Parse(dateTimeString.Substring(8, 2));
            var seconds = int.Parse(dateTimeString.Substring(10, 2));

            result.LocalTransactionDate = new DateTimeOffset(year, month, day, hour, minutes, seconds, TimeSpan.Zero);

            if (30 > value.Length)
            {
                if (uint.TryParse(value.Substring(18, 30), out uint refResult))
                {
                    result.RetrievalReferenceNumber = refResult;
                }
            }

            return result;
        }
    }
}