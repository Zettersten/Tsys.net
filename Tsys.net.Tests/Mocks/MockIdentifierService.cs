using System.Collections.Generic;
using Tsys.net.Models.Authorizations;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;
using Tsys.net.Tests.Models;

namespace Tsys.net.Tests.Mocks
{
    public static class MockIdentifierService
    {
        public static TsysTestCardModel AmericanExpress = new TsysTestCardModel
        {
            AccountNumber = "371449635392376",
            Expiration = "1220",
            SecurityCode = "9997",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "371449635392376=201210100000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel AmericanExpress02 = new TsysTestCardModel
        {
            AccountNumber = "374245455400001",
            Expiration = "1216",
            SecurityCode = "9997",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "374245455400001=161220110091234500000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel Diners = new TsysTestCardModel
        {
            AccountNumber = "30551555151618",
            Expiration = "1220",
            SecurityCode = "996",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "30551555151618=201210100000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel Discover = new TsysTestCardModel
        {
            AccountNumber = "6011000993026909",
            Expiration = "1220",
            SecurityCode = "996",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "6011000993026909=201210100000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel JCB = new TsysTestCardModel
        {
            AccountNumber = "3530142019945859",
            Expiration = "1220",
            SecurityCode = "996",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "3530142019945859=201210100000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel MasterCard = new TsysTestCardModel
        {
            AccountNumber = "5499740000000057",
            Expiration = "1220",
            SecurityCode = "998",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "5499740000000057=201210100000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel Visa = new TsysTestCardModel
        {
            AccountNumber = "4012000098765439",
            Expiration = "1220",
            SecurityCode = "999",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "4012000098765439=20121011796251900000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static TsysTestCardModel Visa8888 = new TsysTestCardModel
        {
            AccountNumber = "4012881888818888",
            Expiration = "0616",
            SecurityCode = "999",
            MagneticStripeTrackI = "",
            MagneticStripeTrackII = "4012881888818888=16061011796251900000",
            AVSStreet = "",
            AVSZip = "85284"
        };

        public static List<TsysTestCardModel> TestCardList = new List<TsysTestCardModel> {
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 01^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 02^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 03^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 04^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 05^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 06^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 07^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            },
            new TsysTestCardModel
            {
                AccountNumber = "4761739001010010",
                Expiration = "1220",
                SecurityCode = "999",
                MagneticStripeTrackI = "B4761739001010010^VISA ACQUIRER TEST CARD 08^20122011143800780000000",
                MagneticStripeTrackII = "4761739001010010=20122011143878089",
                AVSStreet = "",
                AVSZip = ""
            }
        };

        public static TsysTerminalConfigModel Retail = new TsysTerminalConfigModel
        {
            AcquirerBin = 999995,
            MerchantNumber = 888000000835,
            StoreNumber = 5999,
            TerminalIdNumber = 1515,
            TerminalNumber = 71004052,
            DeviceCode = DeviceCodeTypeModel.ReservedForThirdPartyDevelopers,
            IndustryCode = IndustryCodeTypeModel.Retail,
            CurrencyCode = CurrencyCodeTypeModel.UnitedStatesUsDollar,
            CountryCode = CountryCodeTypeModel.UnitedStates,
            CityCode = "20165",
            LanguageIndicator = LanguageIndicatorTypeModel.English,
            TimeZoneDiff = TimeZoneDifferentialModel.NewTimeZoneDifferential(TimeZoneDirectionTypeModel.HoursBehindGMTWithDaylightSavings, 5),
            MerchantCategoryCode = MerchantCategoryTypeModel.MiscellaneousAndSpecialtyRetailStores,
            RequestedACI = RequestAciTypeModel.DeviceIsCpsMeritCapableOrCreditOrOffline,
            TransactionSequenceNumber = 1,
            AgentBankNumber = 0,
            AgentChainNumber = 111111,
            BatchNumber = 1,
            MerchantLocalTelephoneNo = 0,
            CardholderServiceTelephoneNo = 8664445555,
            MerchantCity = "STERLING",
            MerchantName = "ETS CORP",
            MerchantState = "VA",
            MerchantLocationNumber = "00001",
            PosDataCodeProfile = ""
        };

        public static TsysTerminalConfigModel EmvRetail = new TsysTerminalConfigModel
        {
            AcquirerBin = 468852,
            MerchantNumber = 888000000136,
            StoreNumber = 136,
            TerminalIdNumber = 2291,
            TerminalNumber = 71132645,
            DeviceCode = DeviceCodeTypeModel.EMVModeContactAndOrContactlessTerminal,
            IndustryCode = IndustryCodeTypeModel.Retail,
            CurrencyCode = CurrencyCodeTypeModel.UnitedStatesUsDollar,
            CountryCode = CountryCodeTypeModel.UnitedStates,
            CityCode = "20165",
            LanguageIndicator = LanguageIndicatorTypeModel.English,
            TimeZoneDiff = TimeZoneDifferentialModel.NewTimeZoneDifferential(TimeZoneDirectionTypeModel.HoursBehindGMTWithDaylightSavings, 5),
            MerchantCategoryCode = MerchantCategoryTypeModel.MiscellaneousAndSpecialtyRetailStores,
            RequestedACI = RequestAciTypeModel.DeviceIsCpsMeritCapableOrCreditOrOffline,
            TransactionSequenceNumber = 1,
            AgentBankNumber = 0,
            AgentChainNumber = 0,
            BatchNumber = 1,
            MerchantLocalTelephoneNo = 0,
            CardholderServiceTelephoneNo = 8664445555,
            MerchantCity = "STERLING",
            MerchantName = "ETS CORP",
            MerchantState = "VA",
            MerchantLocationNumber = "00001",
            PosDataCodeProfile = ""
        };

        public static TsysTerminalConfigModel CardPresentRetail = new TsysTerminalConfigModel
        {
            AcquirerBin = 999995,
            MerchantNumber = 999999999911,
            StoreNumber = 11,
            TerminalIdNumber = 9911,
            TerminalNumber = 71004052,
            DeviceCode = DeviceCodeTypeModel.ReservedForThirdPartyDevelopers,
            IndustryCode = IndustryCodeTypeModel.Retail,
            CurrencyCode = CurrencyCodeTypeModel.UnitedStatesUsDollar,
            CountryCode = CountryCodeTypeModel.UnitedStates,
            CityCode = "20165",
            LanguageIndicator = LanguageIndicatorTypeModel.English,
            TimeZoneDiff = TimeZoneDifferentialModel.NewTimeZoneDifferential(TimeZoneDirectionTypeModel.HoursBehindGMTWithDaylightSavings, 5),
            MerchantCategoryCode = MerchantCategoryTypeModel.MiscellaneousAndSpecialtyRetailStores,
            RequestedACI = RequestAciTypeModel.DeviceIsCpsMeritCapableOrCreditOrOffline,
            TransactionSequenceNumber = 1,
            AgentBankNumber = 0,
            AgentChainNumber = 0,
            BatchNumber = 1,
            MerchantLocalTelephoneNo = 0,
            CardholderServiceTelephoneNo = 8664445555,
            MerchantCity = "STERLING",
            MerchantName = "ETS CORP",
            MerchantState = "VA",
            MerchantLocationNumber = "00001",
            PosDataCodeProfile = ""
        };

        public static TsysTerminalConfigModel ETSCorpAR = new TsysTerminalConfigModel
        {
            AcquirerBin = 433066,
            MerchantNumber = 000000000001,
            StoreNumber = 7001,
            TerminalIdNumber = 6546,
            TerminalNumber = 75548359,
            DeviceCode = DeviceCodeTypeModel.EMVModeContactAndOrContactlessTerminal,
            IndustryCode = IndustryCodeTypeModel.Retail,
            CurrencyCode = CurrencyCodeTypeModel.UnitedStatesUsDollar,
            CountryCode = CountryCodeTypeModel.UnitedStates,
            CityCode = "20147",
            LanguageIndicator = LanguageIndicatorTypeModel.English,
            TimeZoneDiff = TimeZoneDifferentialModel.NewTimeZoneDifferential(TimeZoneDirectionTypeModel.HoursBehindGMTWithDaylightSavings, 5),
            MerchantCategoryCode = MerchantCategoryTypeModel.ProfessionalServicesNotElsewhereDefined,
            RequestedACI = RequestAciTypeModel.DeviceIsCpsMeritCapableOrCreditOrOffline,
            TransactionSequenceNumber = 1,
            AgentBankNumber = 0,
            AgentChainNumber = 0,
            BatchNumber = 1,
            MerchantLocalTelephoneNo = 0,
            CardholderServiceTelephoneNo = 8008347790,
            MerchantCity = "ASHBURN",
            MerchantName = "ETS CORP AR",
            MerchantState = "VA",
            MerchantLocationNumber = "00001",
            PosDataCodeProfile = ""
        };

        public static Group1AuthorizationModel Group1Authorization_ETSCorpAR
        {
            get
            {
                var authMessage = Group1AuthorizationModel
                    .NewG1AuthorizationMessageRequest(
                        acquirerBin: ETSCorpAR.AcquirerBin,
                        transactionCodeType: "",
                        transactionSequence: "",
                        amount: "",
                        cashback: ""
                    );

                return authMessage;
            }
        }
    }
}