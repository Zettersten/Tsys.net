namespace Tsys.net.Models
{
    public struct TransactionIdentifierModel
    {
        public int CurrencyCode { get; set; }
        
        public string LanguageIndicator { get; set; }

        public int TransactionSequenceNumber { get; set; }

        public int RetreivalReferenceNumber { get; set; }

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

        public long TransactionAmount { get; set; }

        public long SecondaryAmount { get; set; }

        public long SettlementAmount { get; set; }

        public long TotalAuthorizedAmount { get; set; }

        public string PrestigiousPropertyIndicator { get; set; }

        public string MarketSpecificDataId { get; set; }

        public int StayOfDuration { get; set; }
    }
}