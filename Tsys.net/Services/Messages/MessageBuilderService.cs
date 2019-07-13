using Microsoft.Extensions.Logging;
using System;
using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Models;
using Tsys.net.Models.GroupRecords;
using Tsys.net.Models.Shared;

namespace Tsys.net.Services.Messages
{
    public class MessageBuilderService
    {
        /// <summary>
        /// Credit Card Authorization request messages (Groups I and III)
        /// </summary>
        private const string CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE = "D";

        /// <summary>
        /// Encrypted Credit Card Authorization request messages (Group I and III)
        /// </summary>
        private const string ENCRYPTED_CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE = "W";

        /// <summary>
        /// Credit Card authorization response messages (Groups I and III)
        /// </summary>
        private const string CREDIT_CARD_AUTHORIZATION_RESPONSE_MESSAGE = "E";

        /// <summary>
        /// Single authorization per connection (“Single-Trans.”)
        /// </summary>
        private const string SINGLE_AUTHORIZATION_PER_CONNECTION = "0";

        /// <summary>
        /// Multiple authorizations per connection, single-threaded (“Multi- Trans.”)
        /// </summary>
        private const string MULTIPLE_AUTHORIZATION_PER_CONNECTION = "2";

        /// <summary>
        /// Multiple authorizations per connection, full-duplex (“Interleaved”)
        /// </summary>
        private const string INTERLEAVED_AUTHORIZATION_PER_CONNECTION = "4";

        private readonly ILogger<MessageBuilderService> logger;

        public MessageBuilderService(ILogger<MessageBuilderService> logger)
        {
            this.logger = logger;
        }

        public string BuildManualAVSRequestMessage(MerchantIdentifierModel merchant, TransactionIdentifierModel transaction, CustomerIdentifierModel customer, CustomerAddressIdentifierModel address)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder
                .Append(TsysMessageHelper.StartMessage(INTERLEAVED_AUTHORIZATION_PER_CONNECTION, CREDIT_CARD_AUTHORIZATION_REQUEST_MESSAGE))
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
                .Append(TsysMessageHelper.TimeZoneDifferential)
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
                .Append(AsciiTable.FS);

            string developer = new DeveloperModel()
            {
                DeveloperId = "7",
                VersionId = "014"
            }.ToString();

            stringBuilder.Append(developer);

            string result = TsysMessageHelper.EndMessage(stringBuilder.ToString());

            logger.LogInformation(result);

            return result;
        }

        public (MerchantIdentifierModel merchant, TransactionIdentifierModel transaction, CustomerIdentifierModel customer, CustomerAddressIdentifierModel address) ReverseBuildManualAVSRequestMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}