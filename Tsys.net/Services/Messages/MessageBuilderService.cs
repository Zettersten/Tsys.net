using Microsoft.Extensions.Logging;
using System;
using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Models;
using Tsys.net.Models.Constants;
using Tsys.net.Models.GroupRecords;
using Tsys.net.Models.Shared;

namespace Tsys.net.Services.Messages
{
    public class MessageBuilderService
    {
        private readonly ILogger<MessageBuilderService> logger;

        public MessageBuilderService(ILogger<MessageBuilderService> logger)
        {
            this.logger = logger;
        }

        public string BuildManualAVSRequestMessage(MerchantIdentifierModel merchant, TransactionIdentifierModel transaction, CustomerIdentifierModel customer, CustomerAddressIdentifierModel address, DeveloperModel developer)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string result = stringBuilder
                .BeginTsysMessage(MessageConstants.INTERLEAVED_AUTHORIZATION_PER_CONNECTION, MessageConstants.CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE)
                .Append(merchant.AcquirerBIN)
                .Append(merchant.FormatMerchantNumber())
                .Append(merchant.FormatStoreNumber())
                .Append(merchant.TerminalNumber)
                .Append(merchant.DeviceCode)
                .Append(merchant.IndustryCode)
                .Append(transaction.CurrencyCode)
                .Append(merchant.CountryCode)
                .Append(merchant.FormatCityCode())
                .Append(transaction.LanguageIndicator)
                .Append(MessageConstants.TimeZoneDifferential.EST)
                .Append(merchant.MerchantCategoryCode)
                .Append(transaction.RequestedACI)
                .Append(transaction.FormatTransactionSequenceNumber())
                .Append(transaction.TransactionCode)
                .Append(transaction.CardholderIdCode)
                .Append(transaction.AccountDataSource)
                .Append(customer)
                .Append(AsciiTable.FS)
                .Append(address)
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(transaction.TransactionAmount)
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(merchant.FormatMerchantName())
                .Append(merchant.FormatMerchantCity())
                .Append(merchant.FormatMerchantState())
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(developer)
                .Append(AsciiTable.GS)
                .Append(new TransactionFeeModel { TransactionFeeAmount = "D00000050" })
                .EndTsysMessage();

            logger.LogInformation(result);

            return result;
        }

        public (MerchantIdentifierModel merchant, TransactionIdentifierModel transaction, CustomerIdentifierModel customer, CustomerAddressIdentifierModel address) ReverseBuildManualAVSRequestMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}