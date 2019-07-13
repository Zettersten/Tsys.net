namespace Tsys.net.Models
{
    public struct TransactionIdentifierModel
    {
        public uint CurrencyCode { get; set; }

        public string LanguageIndicator { get; set; }

        public uint TransactionSequenceNumber { get; set; }

        public uint RetreivalReferenceNumber { get; set; }

        public string ReturnedAci { get; set; }

        public string RequestedACI { get; set; }

        public string ApprovalCode { get; set; }

        public string LocalTransactionDate { get; set; }

        public string LocalTransactionTime { get; set; }

        public string TransactionCode { get; set; }

        public string TransactionIndentifier { get; set; }

        public string CardholderIdCode { get; set; }

        public string CardholderIdData { get; set; }

        public string CardAcceptorData { get; set; }

        public string AccountDataSource { get; set; }

        public string AddressVerificationData { get; set; }

        public ulong TransactionAmount { get; set; }

        public ulong SecondaryAmount { get; set; }

        public ulong SettlementAmount { get; set; }

        public ulong TotalAuthorizedAmount { get; set; }

        public string PrestigiousPropertyIndicator { get; set; }

        public string MarketSpecificDataId { get; set; }

        public uint StayOfDuration { get; set; }
    }
}