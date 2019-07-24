using System;
using System.Text;
using Tsys.net.Extensions;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.Authorizations
{
    public class Group1AuthorizationModel
    {
        /// <summary>
        /// #1 A/N 4.67 (CreditCardAuthorizationRequest)
        /// </summary>
        public string RecordFormat { get; set; }

        /// <summary>
        /// #1 A/N 4.9 (MultipleAuthorizationsPerConnectionFullDuplexInterleaved)
        /// </summary>
        public ApplicationIndicatorTypeModel ApplicationType { get; set; }

        /// <summary>
        /// #1 A/N 4.62 (MessageDelimiter)
        /// </summary>
        public MessageDelimiterTypeModel MessageDelimiter { get; set; }

        /// <summary>
        /// #6 NUM 4.2 (999995)
        /// </summary>
        public uint AcquirerBIN { get; set; }

        /// <summary>
        /// #12 NUM 4.59 (999999999911)
        /// </summary>
        public uint MerchantNumber { get; set; }

        /// <summary>
        /// #4 NUM 4.81 (1515)
        /// </summary>
        public uint StoreNumber { get; set; }

        /// <summary>
        /// #4 NUM 4.84 (5999)
        /// </summary>
        public uint TerminalNumber { get; set; }

        /// <summary>
        /// #1 A/N 4.34 (ReservedForThirdPartyDevelopers)
        /// </summary>
        public DeviceCodeTypeModel DeviceCode { get; set; }

        /// <summary>
        /// #1 A/N 4.46 (UnknownOrUnsure)
        /// </summary>
        public IndustryCodeTypeModel IndustryCode { get; set; }

        /// <summary>
        /// #3 NUM 4.30 (UsdUnitedStatesUsDollar)
        /// </summary>
        public CurrencyCodeTypeModel CurrencyCode { get; set; }

        /// <summary>
        /// #3 NUM 4.28 (UnitedStates)
        /// </summary>
        public CountryCodeTypeModel CountryCode { get; set; }

        /// <summary>
        /// #9 A/N 4.25 City Code must be one of the following three formats...
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// #2 NUM 4.51 (English)
        /// </summary>
        public LanguageIndicatorTypeModel LanguageIndicator { get; set; }

        /// <summary>
        /// #3 NUM 4.86 (705 EASTERN)
        /// </summary>
        public TimeZoneDifferentialModel TimeZoneDiff { get; set; }

        /// <summary>
        /// #4 NUM 4.57
        /// </summary>
        public MerchantCategoryTypeModel MerchantCategoryCode { get; set; }

        /// <summary>
        /// #1 A/N 4.69 (DeviceIsCpsMeritCapableOrCreditOrOffline)
        /// </summary>
        public RequestAciTypeModel RequestedACI { get; set; }

        /// <summary>
        /// #4 NUM 4.92
        /// </summary>
        public uint TransactionSequenceNumber { get; set; }

        /// <summary>
        /// #2 A/N 4.89 (Purchase)
        /// </summary>
        public TransactionCodeTypeModel TransactionCode { get; set; }

        /// <summary>
        /// #1 A/N 4.23
        /// </summary>
        public CardholderIdCodeTypeModel CardholderIdentificationCode { get; set; }

        /// <summary>
        /// #1 A/N 4.1
        /// </summary>
        public AccountDataSourceTypeModel AccountDataSource { get; set; }

        /// <summary>
        /// #1 - 79 A/N 4.31
        /// </summary>
        public CustomerDataFieldModel CustomerData { get; set; }

        /// <summary>
        /// #0, 128 A/N 4.43
        /// </summary>
        public CustomerIdentificationDataFieldModel CardholderIdentificationData { get; set; }

        /// <summary>
        /// #0, 6 NUM 4.66 used for Check Authorizations and Private Label
        /// </summary>
        public ReceivingInstitutionIdTypeModel ReceivingInstitutionId { get; set; }

        /// <summary>
        /// #1 - 12 NUM 4.88
        /// </summary>
        public long TransactionAmount { get; set; }

        /// <summary>
        /// #0, 12 NUM 4.76
        /// </summary>
        public long SecondaryAmount { get; set; }

        /// <summary>
        /// #0, 4 A/N 4.54
        /// </summary>
        public MarketSpecificDataFieldModel MarketSpecificData { get; set; }

        /// <summary>
        /// #0, 40 A/N 4.17
        /// </summary>
        public CardAcceptorDataFieldModel CardAcceptorData { get; set; }

        /// <summary>
        /// #15 A/N 4.75 see Transaction ID in G1 Auth Response
        /// </summary>
        public string ReversalAndIncrementalTransactionId { get; set; }

        /// <summary>
        /// #0, 30 A/N 4.73
        /// </summary>
        public ReversalAndCancelDataIModel ReversalAndCancelData { get; set; }

        public static Group1AuthorizationModel NewG1AuthorizationMessageRequest(uint acquirerBin, TransactionCodeTypeModel transactionCodeType, uint transactionSequence, long amount, long cashback)
        {
            return new Group1AuthorizationModel
            {
                RecordFormat = transactionCodeType.IsDebitCardTransaction() ? RecordFormatTypeModel.DebitEbtRequest : RecordFormatTypeModel.CreditCardAuthorizationRequest,
                ApplicationType = ApplicationIndicatorTypeModel.MultipleAuthorizationsPerConnectionFullDuplexInterleaved,
                MessageDelimiter = MessageDelimiterTypeModel.DefaultDelimiter,
                AcquirerBIN = acquirerBin,
                TransactionCode = transactionCodeType,
                TransactionSequenceNumber = transactionSequence,
                TransactionAmount = amount,
                SecondaryAmount = cashback,
                MarketSpecificData = MarketSpecificDataFieldModel.NewMarketSpecificDataFieldModel(PrestigiousPropertyTypeModel.AutoRentalOrNonParticipatingProperty, MarketSpecificDataTypeModel.OtherIndustries, 0),
                ReversalAndCancelData = ReversalAndCancelDataIModel.NewReversalAndCancelDataI("      ", DateTimeOffset.Now, UintExtensions.GenerateRetrievalReferenceNumber(0))
            };
        }

        public override string ToString()
        {
            var sb = new StringBuilder(512);

            this.CopyToBuffer(ref sb);

            return sb.ToString();
        }
    }
}