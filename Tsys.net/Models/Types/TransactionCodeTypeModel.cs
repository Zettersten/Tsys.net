using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct TransactionCodeTypeModel
    {
        public const string Purchase = "54";
        public const string PurchaseRepeat = "64";
        public const string CashAdvance = "55";
        public const string CashAdvanceRepeat = "65";
        public const string PurchaseCardNotPresent = "56";
        public const string PurchaseCardNotPresentRepeat = "66";
        public const string QuasiCash = "57";
        public const string QuasiCashRepeat = "67";
        public const string CardAuthentication = "58";
        public const string CardAuthenticationRepeat = "68";
        public const string OnlineAuthorizationReversal = "59";
        public const string OnlineAuthorizationReversalRepeat = "69";
        public const string StoreAndForwardAuthorizationReversal = "5A";
        public const string StoreAndForwardAuthorizationReversalRepeat = "6A";
        public const string BillPayTransaction = "5B";
        public const string BillPayTransactionRepeat = "6B";
        public const string CreditAdvice = "5C";
        public const string CreditAccountFundingOrPayment = "5G";
        public const string CreditAccountFundingOrPaymentRepeat = "6G";
        public const string CardNotPresentCreditAccountFundingOrPayment = "5H";
        public const string CardNotPresentCreditAccountFundingOrPaymentRepeat = "6H";
        public const string CardPresentCreditCardholderFundsTransfer = "5J";
        public const string CardPresentCreditCardholderFundsTransferRepeat = "6J";
        public const string CardholderFundsTransferCardNotPresent = "5K";
        public const string CardholderFundsTransferCardNotPresentRepeat = "6K";
        public const string CreditStoredValueBalanceInquiry = "5L";
        public const string CreditStoredValueBalanceInquiryRepeat = "6L";
        public const string HealthcareEligibilityInquiry = "5M";
        public const string HealthcareEligibilityInquiryRepeat = "6M";
        public const string BalanceInquiryReversal = "5N";
        public const string BalanceInquiryReversalRepeat = "6N";
        public const string ProductEligibilityInquiry = "5P";
        public const string TokenRequest = "5T";
        public const string CheckGuarantee = "70";
        public const string PosCheckConversionWithGuarantee = "76";
        public const string PosCheckConversionWithVerification = "77";
        public const string PosCheckConversionOnly = "78";
        public const string PosCheckReversalConversionWithGuarantee = "79";
        public const string PosCheckReversalConversionWithVerification = "7A";
        public const string PosCheckReversalConversionOnly = "7B";
        public const string PrivateLabelPurchase = "84";
        public const string PrivateLabelCashAdvance = "85";
        public const string PrivateLabelCardNotPresent = "86";
        public const string PrivateLabelQuasiCash = "87";
        public const string PrivateLabelCardAuthentication = "88";
        public const string FoodStampsReturnEbt = "92";
        public const string DirectDebitPurchase = "93";
        public const string DirectDebitPurchaseReturn = "94";
        public const string CashBenefitsCashWithdrawalEbt = "96";
        public const string FoodStampPurchaseEbt = "98";
        public const string DirectDebitBalanceInquiry = "9A";
        public const string DebitBillPaymentTransaction = "9B";
        public const string PinlessDebitBillPaymentTransaction = "9C";
        public const string FoodStampsElectronicVoucherEbt = "9E";
        public const string EbtCashBenefitsPurchaseOrPurchaseWithCashBack = "9F";
        public const string DebitAccountFundingPurchase = "9G";
        public const string DebitAccountFundingReturn = "9H";
        public const string DebitCardholderFundsTransfer = "9J";
        public const string DebitFundsTransferReturn = "9K";
        public const string EbtFoodStampBalanceInquiry = "9L";
        public const string EbtCashBenefitsBalanceInquiry = "9M";
        public const string ChipCardTransactionAdviceRecordLimitedAvailability = "A0";
        public const string AutomaticReversalDirectDebitPurchase = "A3";
        public const string AutomaticReversalDirectDebitPurchaseReturn = "A4";
        public const string AutomaticReversalInterlinkDirectDebitCancel = "A5";
        public const string ATMCashDisbursement = "B1";
        public const string ATMBalanceInquiry = "B2";
        public const string ATMDeposit = "B3";
        public const string ATMCardholderAccountTransfer = "B4";
        public const string ATMCashDisbursementReversal = "C1";
        public const string ATMDepositReversal = "C3";
        public const string ATMCardholderAccountTransferReversal = "C4";
        public const string ATMAdjustmentUpCredit = "C8";
        public const string ATMAdjustmentDownDebit = "C9";
        public const string GiftCardCloseCard = "G2";
        public const string GiftCardBalanceInquiry = "G3";
        public const string GiftCardPurchaseRedemption = "G4";
        public const string GiftCardReturnRefund = "G5";
        public const string GiftCardAddValueLoadCard = "G6";
        public const string GiftCardDecreaseValueUnloadCard = "G7";
        public const string GiftCardStandAloneTip = "GB";
        public const string GiftCardIssueGiftCard = "GC";
        public const string GiftCardIssueVirtualGiftCard = "GD";
        public const string GiftCardMerchantInitiatedCancel = "GE";
        public const string GiftCardMerchantInitiatedReversal = "GF";
        public const string GiftCardCashBack = "GG";
        public const string Q1PrepaidCardActivation = "P1";
        public const string Q2PrepaidCardActivationReversal = "P2";
        public const string Q3PrepaidCardLoad = "P3";
        public const string Q4PrepaidCardLoadReversal = "P4";
        public const string PrepaidCardActivation = "R1";
        public const string PrepaidCardActivationReversal = "R2";
        public const string PrepaidCardLoad = "R3";
        public const string PrepaidCardLoadReversal = "R4";
        public const string TerminalAuthentication = "TA";
        public const string TerminalDeactivation = "TD";
        public const string CreditReturn = "CR";
        public const string AccountFundingCreditReturn = "FR";
        public const string CardholderFundsTransferCreditReturn = "TR";
        private readonly string value;

        public TransactionCodeTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator TransactionCodeTypeModel(string value)
        {
            return new TransactionCodeTypeModel(value);
        }

        public static bool operator ==(TransactionCodeTypeModel firstValue, string secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator !=(TransactionCodeTypeModel firstValue, string secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator ==(string firstValue, TransactionCodeTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public static bool operator !=(string firstValue, TransactionCodeTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case Purchase:
                    return nameof(Purchase);

                case PurchaseRepeat:
                    return nameof(PurchaseRepeat);

                case CashAdvance:
                    return nameof(CashAdvance);

                case CashAdvanceRepeat:
                    return nameof(CashAdvanceRepeat);

                case PurchaseCardNotPresent:
                    return nameof(PurchaseCardNotPresent);

                case PurchaseCardNotPresentRepeat:
                    return nameof(PurchaseCardNotPresentRepeat);

                case QuasiCash:
                    return nameof(QuasiCash);

                case QuasiCashRepeat:
                    return nameof(QuasiCashRepeat);

                case CardAuthentication:
                    return nameof(CardAuthentication);

                case CardAuthenticationRepeat:
                    return nameof(CardAuthenticationRepeat);

                case OnlineAuthorizationReversal:
                    return nameof(OnlineAuthorizationReversal);

                case OnlineAuthorizationReversalRepeat:
                    return nameof(OnlineAuthorizationReversalRepeat);

                case StoreAndForwardAuthorizationReversal:
                    return nameof(StoreAndForwardAuthorizationReversal);

                case StoreAndForwardAuthorizationReversalRepeat:
                    return nameof(StoreAndForwardAuthorizationReversalRepeat);

                case BillPayTransaction:
                    return nameof(BillPayTransaction);

                case BillPayTransactionRepeat:
                    return nameof(BillPayTransactionRepeat);

                case CreditAdvice:
                    return nameof(CreditAdvice);

                case CreditAccountFundingOrPayment:
                    return nameof(CreditAccountFundingOrPayment);

                case CreditAccountFundingOrPaymentRepeat:
                    return nameof(CreditAccountFundingOrPaymentRepeat);

                case CardNotPresentCreditAccountFundingOrPayment:
                    return nameof(CardNotPresentCreditAccountFundingOrPayment);

                case CardNotPresentCreditAccountFundingOrPaymentRepeat:
                    return nameof(CardNotPresentCreditAccountFundingOrPaymentRepeat);

                case CardPresentCreditCardholderFundsTransfer:
                    return nameof(CardPresentCreditCardholderFundsTransfer);

                case CardPresentCreditCardholderFundsTransferRepeat:
                    return nameof(CardPresentCreditCardholderFundsTransferRepeat);

                case CardholderFundsTransferCardNotPresent:
                    return nameof(CardholderFundsTransferCardNotPresent);

                case CardholderFundsTransferCardNotPresentRepeat:
                    return nameof(CardholderFundsTransferCardNotPresentRepeat);

                case CreditStoredValueBalanceInquiry:
                    return nameof(CreditStoredValueBalanceInquiry);

                case CreditStoredValueBalanceInquiryRepeat:
                    return nameof(CreditStoredValueBalanceInquiryRepeat);

                case HealthcareEligibilityInquiry:
                    return nameof(HealthcareEligibilityInquiry);

                case HealthcareEligibilityInquiryRepeat:
                    return nameof(HealthcareEligibilityInquiryRepeat);

                case BalanceInquiryReversal:
                    return nameof(BalanceInquiryReversal);

                case BalanceInquiryReversalRepeat:
                    return nameof(BalanceInquiryReversalRepeat);

                case ProductEligibilityInquiry:
                    return nameof(ProductEligibilityInquiry);

                case TokenRequest:
                    return nameof(TokenRequest);

                case CheckGuarantee:
                    return nameof(CheckGuarantee);

                case PosCheckConversionWithGuarantee:
                    return nameof(PosCheckConversionWithGuarantee);

                case PosCheckConversionWithVerification:
                    return nameof(PosCheckConversionWithVerification);

                case PosCheckConversionOnly:
                    return nameof(PosCheckConversionOnly);

                case PosCheckReversalConversionWithGuarantee:
                    return nameof(PosCheckReversalConversionWithGuarantee);

                case PosCheckReversalConversionWithVerification:
                    return nameof(PosCheckReversalConversionWithVerification);

                case PosCheckReversalConversionOnly:
                    return nameof(PosCheckReversalConversionOnly);

                case PrivateLabelPurchase:
                    return nameof(PrivateLabelPurchase);

                case PrivateLabelCashAdvance:
                    return nameof(PrivateLabelCashAdvance);

                case PrivateLabelCardNotPresent:
                    return nameof(PrivateLabelCardNotPresent);

                case PrivateLabelQuasiCash:
                    return nameof(PrivateLabelQuasiCash);

                case PrivateLabelCardAuthentication:
                    return nameof(PrivateLabelCardAuthentication);

                case FoodStampsReturnEbt:
                    return nameof(FoodStampsReturnEbt);

                case DirectDebitPurchase:
                    return nameof(DirectDebitPurchase);

                case DirectDebitPurchaseReturn:
                    return nameof(DirectDebitPurchaseReturn);

                case CashBenefitsCashWithdrawalEbt:
                    return nameof(CashBenefitsCashWithdrawalEbt);

                case FoodStampPurchaseEbt:
                    return nameof(FoodStampPurchaseEbt);

                case DirectDebitBalanceInquiry:
                    return nameof(DirectDebitBalanceInquiry);

                case DebitBillPaymentTransaction:
                    return nameof(DebitBillPaymentTransaction);

                case PinlessDebitBillPaymentTransaction:
                    return nameof(PinlessDebitBillPaymentTransaction);

                case FoodStampsElectronicVoucherEbt:
                    return nameof(FoodStampsElectronicVoucherEbt);

                case EbtCashBenefitsPurchaseOrPurchaseWithCashBack:
                    return nameof(EbtCashBenefitsPurchaseOrPurchaseWithCashBack);

                case DebitAccountFundingPurchase:
                    return nameof(DebitAccountFundingPurchase);

                case DebitAccountFundingReturn:
                    return nameof(DebitAccountFundingReturn);

                case DebitCardholderFundsTransfer:
                    return nameof(DebitCardholderFundsTransfer);

                case DebitFundsTransferReturn:
                    return nameof(DebitFundsTransferReturn);

                case EbtFoodStampBalanceInquiry:
                    return nameof(EbtFoodStampBalanceInquiry);

                case EbtCashBenefitsBalanceInquiry:
                    return nameof(EbtCashBenefitsBalanceInquiry);

                case ChipCardTransactionAdviceRecordLimitedAvailability:
                    return nameof(ChipCardTransactionAdviceRecordLimitedAvailability);

                case AutomaticReversalDirectDebitPurchase:
                    return nameof(AutomaticReversalDirectDebitPurchase);

                case AutomaticReversalDirectDebitPurchaseReturn:
                    return nameof(AutomaticReversalDirectDebitPurchaseReturn);

                case AutomaticReversalInterlinkDirectDebitCancel:
                    return nameof(AutomaticReversalInterlinkDirectDebitCancel);

                case ATMCashDisbursement:
                    return nameof(ATMCashDisbursement);

                case ATMBalanceInquiry:
                    return nameof(ATMBalanceInquiry);

                case ATMDeposit:
                    return nameof(ATMDeposit);

                case ATMCardholderAccountTransfer:
                    return nameof(ATMCardholderAccountTransfer);

                case ATMCashDisbursementReversal:
                    return nameof(ATMCashDisbursementReversal);

                case ATMDepositReversal:
                    return nameof(ATMDepositReversal);

                case ATMCardholderAccountTransferReversal:
                    return nameof(ATMCardholderAccountTransferReversal);

                case ATMAdjustmentUpCredit:
                    return nameof(ATMAdjustmentUpCredit);

                case ATMAdjustmentDownDebit:
                    return nameof(ATMAdjustmentDownDebit);

                case GiftCardCloseCard:
                    return nameof(GiftCardCloseCard);

                case GiftCardBalanceInquiry:
                    return nameof(GiftCardBalanceInquiry);

                case GiftCardPurchaseRedemption:
                    return nameof(GiftCardPurchaseRedemption);

                case GiftCardReturnRefund:
                    return nameof(GiftCardReturnRefund);

                case GiftCardAddValueLoadCard:
                    return nameof(GiftCardAddValueLoadCard);

                case GiftCardDecreaseValueUnloadCard:
                    return nameof(GiftCardDecreaseValueUnloadCard);

                case GiftCardStandAloneTip:
                    return nameof(GiftCardStandAloneTip);

                case GiftCardIssueGiftCard:
                    return nameof(GiftCardIssueGiftCard);

                case GiftCardIssueVirtualGiftCard:
                    return nameof(GiftCardIssueVirtualGiftCard);

                case GiftCardMerchantInitiatedCancel:
                    return nameof(GiftCardMerchantInitiatedCancel);

                case GiftCardMerchantInitiatedReversal:
                    return nameof(GiftCardMerchantInitiatedReversal);

                case GiftCardCashBack:
                    return nameof(GiftCardCashBack);

                case Q1PrepaidCardActivation:
                    return nameof(Q1PrepaidCardActivation);

                case Q2PrepaidCardActivationReversal:
                    return nameof(Q2PrepaidCardActivationReversal);

                case Q3PrepaidCardLoad:
                    return nameof(Q3PrepaidCardLoad);

                case Q4PrepaidCardLoadReversal:
                    return nameof(Q4PrepaidCardLoadReversal);

                case PrepaidCardActivation:
                    return nameof(PrepaidCardActivation);

                case PrepaidCardActivationReversal:
                    return nameof(PrepaidCardActivationReversal);

                case PrepaidCardLoad:
                    return nameof(PrepaidCardLoad);

                case PrepaidCardLoadReversal:
                    return nameof(PrepaidCardLoadReversal);

                case TerminalAuthentication:
                    return nameof(TerminalAuthentication);

                case TerminalDeactivation:
                    return nameof(TerminalDeactivation);

                case CreditReturn:
                    return nameof(CreditReturn);

                case AccountFundingCreditReturn:
                    return nameof(AccountFundingCreditReturn);

                case CardholderFundsTransferCreditReturn:
                    return nameof(CardholderFundsTransferCreditReturn);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is TransactionCodeTypeModel model &&
                   value == model.value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }
}