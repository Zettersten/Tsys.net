using Microsoft.Extensions.Logging;
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

        public string BuildManualAVSRequestMessage(TsysAuthenticationMessageModel transaction, CustomerIdentifierModel customer, CustomerAddressIdentifierModel address, DeveloperModel developer, TransactionFeeModel transactionFee)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string result = stringBuilder
                .BeginTsysMessage(MessageConstants.INTERLEAVED_AUTHORIZATION_PER_CONNECTION, MessageConstants.CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE)
                .Append(transaction.AcquirerBIN)
                .Append(transaction.FormatMerchantNumber())
                .Append(transaction.FormatStoreNumber())
                .Append(transaction.TerminalNumber)
                .Append(transaction.DeviceCode)
                .Append(transaction.IndustryCode)
                .Append(transaction.CurrencyCode)
                .Append(transaction.CountryCode)
                .Append(transaction.FormatCityCode())
                .Append(transaction.LanguageIndicator)
                .Append(MessageConstants.TimeZoneDifferential.EST)
                .Append(transaction.MerchantCategoryCode)
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
                .Append(transaction.FormatMerchantName())
                .Append(transaction.FormatMerchantCity())
                .Append(transaction.FormatMerchantState())
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(AsciiTable.FS)
                .Append(developer)
                .Append(AsciiTable.GS)
                .Append(transactionFee)
                .EndTsysMessage();

            logger.LogInformation(result);

            return result;
        }
    }
}