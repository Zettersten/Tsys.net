using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tsys.net.Models;
using Tsys.net.Models.Shared;

namespace Tsys.net.Extensions
{
    public static class TransactionIdentifierExtensions
    {
        public static string FormatTransactionSequenceNumber(this TransactionIdentifierModel transaction)
        {
            var value = transaction.TransactionSequenceNumber;

            return $"{value}".PadLeft(4, '0');
        }
    }
}
