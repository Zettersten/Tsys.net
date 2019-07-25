using System.Collections.Generic;
using Tsys.net.Extensions;
using Tsys.net.Models.Authorizations;
using Tsys.net.Models.GroupRecords;
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

        public static Group1AuthorizationModel Group1Authorization_Retail
        {
            get
            {
                //testcase* TsysTransactionTestCase,
                //customeraccountdata *CustomerDataField,
                //cardholderidentification* CardholderIdentificationDataField) *AuthorizationMessageRequest {
                //G1:= NewG1AuthorizationMessageRequest(term.AcquirerBIN, testcase.TransactionCode, term.TransactionSequenceNumber, testcase.Amount, testcase.Cashback)
                //G1.SetTerminalIdentification(term.MerchantNumber, term.StoreNumber, term.TerminalNumber, term.DeviceCode, term.IndustryCode, term.MerchantCategoryCode)
                //G1.SetTerminalLocale(term.CurrencyCode, term.CountryCode, term.LanguageIndicator, term.CityCode, term.TimeZoneDiff)
                //G1.SetCardAcceptorData(term.MerchantName, term.MerchantCity, term.MerchantState, "", term.CardholderServiceTelephoneNo)
                //G1.SetCardholderData(customeraccountdata, cardholderidentification)
                //g3records:= CreateStandardGroup3Elements(term, G1.AccountDataSource, G1.CardholderIdentificationCode, customeraccountdata.AccountNumber(), customeraccountdata.ManuallyEnteredVerificationCode)
                //return NewAuthorizationMessageRequest("", G1, nil, g3records)

                var group1Auth = Group1AuthorizationModel
                   .NewG1AuthorizationMessageRequest(
                      acquirerBin: Retail.AcquirerBin,
                      transactionCodeType: TransactionCodeTypeModel.Purchase,
                      transactionSequence: Retail.TransactionSequenceNumber,
                      amount: 8800,
                      cashback: 0
                   );

                group1Auth
                    .SetTerminalIdentification(
                        merchantNumber: Retail.MerchantNumber,
                        storeNumber: Retail.StoreNumber,
                        terminalNumber: Retail.TerminalIdNumber,
                        deviceCode: Retail.DeviceCode,
                        industryCode: Retail.IndustryCode,
                        merchantCategory: Retail.MerchantCategoryCode
                     );

                //cc := ParseCreditCard("%B4123456789012349^MAVERICK INTERNATIONAL VSA^17121010000000000000000?;4123456789012349=171210100000000000?
                group1Auth
                    .SetTerminalLocale(
                        currency: Retail.CurrencyCode, // CurrencyCodeTypeModel.UnitedStatesUsDollar,
                        countryCode: Retail.CountryCode, // CountryCodeTypeModel.UnitedStates,
                        languageIndicator: Retail.LanguageIndicator, // LanguageIndicatorTypeModel.English,
                        zipCode: Retail.CityCode, // "22030",
                        timeZonDifferential: Retail.TimeZoneDiff // TimeZoneDifferentialModel.NewTimeZoneDifferential(TimeZoneDirectionTypeModel.HoursBehindGMTWithDaylightSavings, 5)
                     );

                var customerAccountData = CustomerDataFieldModel
                    .NewManuallyEnteredCustomerDataField(
                       accountDataSourceType: AccountDataSourceTypeModel.ManuallyKeyedTerminalHasNoCardReadingCapability,
                       pan: Visa.AccountNumber,
                       month: uint.Parse(Visa.Expiration.Substring(0, 2)),
                       year: uint.Parse(Visa.Expiration.Substring(2, 2)),
                       securityCode: Visa.SecurityCode
                    );

                var cardholderIdentification = CustomerIdentificationDataFieldModel
                    .NewCardholderIdentificationDataField(
                        cardHolderIdCode: CardholderIdCodeTypeModel.CardNotPresentIncludesEcomAndFullAvsData,
                        street: Visa.AVSStreet,
                        zipCode: Visa.AVSZip,
                        pin: "",
                        dukpt: ""
                     );

                group1Auth
                    .SetCardholderData(
                        customerData: customerAccountData,
                        cardholderIdentification: cardholderIdentification
                    );

                group1Auth
                    .SetCardAcceptorData(
                        name: Retail.MerchantName,
                        city: Retail.MerchantCity,
                        state: Retail.MerchantState,
                        ticket: "",
                        phone: Retail.CardholderServiceTelephoneNo
                    );

                return group1Auth;
            }
        }

        public static List<IGroupRecord> StandardGroup3Records(string cvv)
        {
            var g3records = new List<IGroupRecord>
            {
                new CommercialCardModel()
            };

            if (!string.IsNullOrEmpty(cvv))
            {
                g3records.Add(new CardVerificationCodeModel
                {
                    VerificationCode = VerificationCodeDesiredResponseTypeModel.EnhancedResponseRequested
                });
            }

            g3records.Add(DeveloperModel.Empty);

            var additionalAmounts = new AdditionalAmountsModel
            {
                AdditionalAmount1 = AdditionalAmountInfoModel.NewAdditionalAmountInfo(AdditionalAmountAccountTypeModel.CreditCardAccount, AdditionalAmountTypeModel.DepositAccountAvailableBalance, CurrencyCodeTypeModel.UnitedStatesUsDollar, AdditionalAmountSignTypeModel.PositiveBalance, 0),
                AdditionalAmount2 = AdditionalAmountInfoModel.NewAdditionalAmountInfo(AdditionalAmountAccountTypeModel.CreditCardAccount, AdditionalAmountTypeModel.DepositAccountAvailableBalance, CurrencyCodeTypeModel.UnitedStatesUsDollar, AdditionalAmountSignTypeModel.PositiveBalance, 0),
                AdditionalAmount3 = AdditionalAmountInfoModel.NewAdditionalAmountInfo(AdditionalAmountAccountTypeModel.CreditCardAccount, AdditionalAmountTypeModel.DepositAccountAvailableBalance, CurrencyCodeTypeModel.UnitedStatesUsDollar, AdditionalAmountSignTypeModel.PositiveBalance, 0),
                AdditionalAmount4 = AdditionalAmountInfoModel.NewAdditionalAmountInfo(AdditionalAmountAccountTypeModel.CreditCardAccount, AdditionalAmountTypeModel.DepositAccountAvailableBalance, CurrencyCodeTypeModel.UnitedStatesUsDollar, AdditionalAmountSignTypeModel.PositiveBalance, 0)
            };

            g3records.Add(additionalAmounts);

            g3records.Add(new ProductParticipationModel
            {
                ProductParticipationGroup = ProductParticipationGroupTypeModel.MerchandiseAndCashOverMustBeFullyApprovedOrDeclined
            });

            // if visa
            //if card.Visa == issuer && 0 < len(r.XID) && 0 < len(r.CAVV) {
            //    g3records = append(g3records, NewG3v017Visa3dSecurEcomVerificationRequest(r.XID, r.CAVV).String())
            //}

            // if mastercard
            //if card.Mastercard == issuer && 0 < len(r.UCAF) {
            //    g3records = append(g3records, NewG3v019MastercardUniversalCardholderAuthenticationRequest(UcafDataWasPopulated, r.UCAF).String())
            //}

            return g3records;
        }
    }
}