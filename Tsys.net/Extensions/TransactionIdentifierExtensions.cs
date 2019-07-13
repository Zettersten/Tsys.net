﻿using Tsys.net.Models;

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
