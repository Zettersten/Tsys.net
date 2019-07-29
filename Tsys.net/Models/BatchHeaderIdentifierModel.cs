using System;
using Tsys.net.Extensions;
using Tsys.net.Models.GroupRecords;
using Tsys.net.Models.Shared;
using static Tsys.net.Models.Shared.AsciiTable;

namespace Tsys.net.Models
{
    public class BatchHeaderIdentifierModel : BatchBaseIdentifierModel
    {
        public BatchHeaderIdentifierModel()
        {
            RecordType = 'H';
        }

        public uint AquirerBin { get; set; }

        public uint AgentBankNumber { get; set; }

        public uint AgentChainNumber { get; set; }

        public ulong MerchantNumber { get; set; }

        public uint StoreNumber { get; set; }

        public uint TerminalNumber { get; set; }

        public char DeviceCode { get; set; }

        public char IndustryCode { get; set; }

        public uint CurrencyCode { get; set; }

        public uint LanguageIndicator { get; set; }

        public uint TimeZoneDifferential { get; set; }

        public string BatchTransmissionDate { get; set; }

        public uint BatchNumber { get; set; }

        public uint BlockingIndicator { get; set; }

        public override string ToString()
        {
            var rawMessage =
                $"{GetStartOfMessage()}" +
                $"{AquirerBin.TruncateLeft(6)}" +
                $"{AgentBankNumber.TruncateLeft(6)}" +
                $"{AgentChainNumber.TruncateLeft(6)}" +
                $"{MerchantNumber.TruncateLeft(12)}" +
                $"{StoreNumber.TruncateLeft(4)}" +
                $"{TerminalNumber.TruncateLeft(4)}" +
                $"{DeviceCode}" +
                $"{IndustryCode}" +
                $"{CurrencyCode.TruncateLeft(3)}" +
                $"{LanguageIndicator.TruncateLeft(2)}" +
                $"{TimeZoneDifferential.TruncateLeft(3)}" +
                $"{BatchTransmissionDate.TruncateLeft(4)}" +
                $"{BatchNumber.TruncateLeft(3)}" +
                $"{BlockingIndicator.TruncateLeft(1)}";

            var messageWithStartAndEndBlocks =
                $"{STX}" +
                $"{rawMessage}" +
                $"{ETB}";

            return messageWithStartAndEndBlocks + (rawMessage + ETB).GetLRC();
        }
    }

    public class BatchProfileIdentifierModel : BatchBaseIdentifierModel
    {
        public BatchProfileIdentifierModel()
        {
            RecordType = 'P';
        }

        public uint CountryCode { get; set; }

        public string CityCode { get; set; }

        public uint MerchantCategoryCode { get; set; }

        public string MerchantName { get; set; }

        public string MerchantCity { get; set; }

        public string MerchantState { get; set; }

        public uint MerchantLocationNumber { get; set; }

        public ulong TerminalIdNumber { get; set; }

        public override string ToString()
        {
            var rawMessage =
                $"{GetStartOfMessage()}" +
                $"{CountryCode.TruncateLeft(3)}" +
                $"{CityCode.TruncateRight(9, ' ')}" +
                $"{MerchantCategoryCode.TruncateLeft(4)}" +
                $"{MerchantName.TruncateRight(25, ' ')}" +
                $"{MerchantCity.TruncateRight(13, ' ')}" +
                $"{MerchantState.Truncate(2).ToUpper()}" +
                $"{MerchantLocationNumber.TruncateLeft(5)}" +
                $"{TerminalIdNumber.TruncateLeft(8)}";

            var messageWithStartAndEndBlocks =
                $"{STX}" +
                $"{rawMessage}" +
                $"{ETB}";

            return messageWithStartAndEndBlocks + (rawMessage + ETB).GetLRC();
        }
    }

    public class BatchTrailerIdentifierModel : BatchBaseIdentifierModel
    {
        public BatchTrailerIdentifierModel()
        {
            RecordType = 'T';
        }

        public string BatchTransmissionDate { get; set; }

        public uint BatchNumber { get; set; }

        public ulong BatchRecordCount { get; set; }

        public ulong BatchHashingTotal { get; set; }

        public ulong CashBackTotal { get; set; }

        public ulong BatchNetDeposit { get; set; }

        public override string ToString()
        {
            var rawMessage =
                $"{GetStartOfMessage()}" +
                $"{BatchTransmissionDate.TruncateLeft(4)}" +
                $"{BatchNumber.TruncateLeft(3)}" +
                $"{BatchRecordCount.TruncateLeft(9)}" +
                $"{BatchHashingTotal.TruncateLeft(16)}" +
                $"{CashBackTotal.TruncateLeft(16)}" +
                $"{BatchNetDeposit.TruncateLeft(16)}";

            var messageWithStartAndEndBlocks =
                $"{STX}" +
                $"{rawMessage}" +
                $"{ETX}";

            return messageWithStartAndEndBlocks + (rawMessage + ETX).GetLRC();
        }
    }

    public class BatchTransactionIdentifierModel : BatchBaseIdentifierModel
    {
        public BatchTransactionIdentifierModel()
        {
            RecordType = 'D';
        }

        public string TransactionCode { get; set; }

        public char CardholderIdentificationCode { get; set; }

        public char AccountDataSource { get; set; }

        public string CardholderAccountNumber { get; set; }

        public char RequestedACI { get; set; }

        public char ReturnedACI { get; set; }

        public char AuthorizationSourceCode { get; set; }

        public uint TransactionSequenceNumber { get; set; }

        public string ResponseCode { get; set; }

        public string ApprovalCode { get; set; }

        public string LocalTransactionDate { get; set; }

        public string LocalTransactionTime { get; set; }

        public char AVSResultCode { get; set; }

        public string TransactionIdentifier { get; set; }

        public string ValidationCode { get; set; }

        public char VoidIndicator { get; set; }

        public uint TransactionStatusCode { get; set; }

        public char ReimbursementAttribute { get; set; }

        public ulong SettlementAmount { get; set; }

        public ulong AuthorizedAmount { get; set; }

        public ulong GratuityAmount { get; set; }

        public ulong TotalAuthorizedAmount { get; set; }

        public char PurchaseIdentifierFormatCode { get; set; } = 'Z';

        public ulong TransactionFee { get; set; }

        public override string ToString()
        {
            // this.RecordType.SetGroups(3);

            if (TransactionFee > 0)
            {
                this.RecordType.SetGroups(23);
            }

            var rawMessage =
                $"{GetStartOfMessage()}" +
                $"{TransactionCode.Truncate(2)}" +
                $"{CardholderIdentificationCode}" +
                $"{AccountDataSource}" +
                $"{CardholderAccountNumber.TruncateRight(22, ' ')}" +
                $"{RequestedACI}" +
                $"{ReturnedACI}" +
                $"{AuthorizationSourceCode}" +
                $"{TransactionSequenceNumber.TruncateLeft(4)}" +
                $"{ResponseCode.Truncate(2)}" +
                $"{ApprovalCode.TruncateRight(6)}" +
                $"{LocalTransactionDate.TruncateLeft(4)}" +
                $"{LocalTransactionTime.TruncateLeft(6)}" +
                $"{AVSResultCode}" +
                $"{TransactionIdentifier.TruncateRight(15, ' ')}" +
                $"{ValidationCode.TruncateRight(4, ' ')}" +
                $"{VoidIndicator}" +
                $"{TransactionStatusCode.TruncateLeft(2)}" +
                $"{ReimbursementAttribute}" +
                $"{SettlementAmount.TruncateLeft(12)}" +
                $"{AuthorizedAmount.TruncateLeft(12)}";

            /**
             * Adding transaction fee
             */
            if (TransactionFee > 0)
            {
                const string tagSize = "18";
                const string tagName = "TFA";
                const string tagLength = "09";

                RecordTypeModel addendumModel = RecordTypeModel.DetailRecord;

                // addendumModel.SetGroups(3);
                addendumModel.SetGroups(41);

                var transactionFeeAddendum =
                    $"{addendumModel.ToStringWithoutHeader()}" +
                    $"{tagSize.TruncateLeft(4)}" +
                    $"{tagName}" +
                    $"{tagLength}" +
                    "D" +
                    $"{TransactionFee.TruncateLeft(8)}";

                rawMessage += transactionFeeAddendum;
            }

            var messageWithStartAndEndBlocks =
                $"{STX}" +
                $"{rawMessage}" +
                $"{ETB}";

            return messageWithStartAndEndBlocks + (rawMessage + ETB).GetLRC();
        }
    }
}