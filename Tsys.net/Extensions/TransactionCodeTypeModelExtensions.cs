using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class TransactionCodeTypeModelExtensions
    {
        public static bool IsReturnOrReversal(this TransactionCodeTypeModel transactionCodeType)
        {
            switch (transactionCodeType.ToString())
            {
                case TransactionCodeTypeModel.OnlineAuthorizationReversal:
                case TransactionCodeTypeModel.OnlineAuthorizationReversalRepeat:
                case TransactionCodeTypeModel.StoreAndForwardAuthorizationReversal:
                case TransactionCodeTypeModel.StoreAndForwardAuthorizationReversalRepeat:
                case TransactionCodeTypeModel.BalanceInquiryReversal:
                case TransactionCodeTypeModel.BalanceInquiryReversalRepeat:
                case TransactionCodeTypeModel.PosCheckReversalConversionWithGuarantee:
                case TransactionCodeTypeModel.PosCheckReversalConversionWithVerification:
                case TransactionCodeTypeModel.PosCheckReversalConversionOnly:
                case TransactionCodeTypeModel.FoodStampsReturnEbt:
                case TransactionCodeTypeModel.DirectDebitPurchaseReturn:
                case TransactionCodeTypeModel.DebitAccountFundingReturn:
                case TransactionCodeTypeModel.DebitFundsTransferReturn:
                case TransactionCodeTypeModel.AutomaticReversalDirectDebitPurchase:
                case TransactionCodeTypeModel.AutomaticReversalDirectDebitPurchaseReturn:
                case TransactionCodeTypeModel.AutomaticReversalInterlinkDirectDebitCancel:
                case TransactionCodeTypeModel.ATMCashDisbursementReversal:
                case TransactionCodeTypeModel.ATMDepositReversal:
                case TransactionCodeTypeModel.ATMCardholderAccountTransferReversal:
                case TransactionCodeTypeModel.GiftCardReturnRefund:
                case TransactionCodeTypeModel.GiftCardMerchantInitiatedReversal:
                case TransactionCodeTypeModel.Q2PrepaidCardActivationReversal:
                case TransactionCodeTypeModel.Q4PrepaidCardLoadReversal:
                case TransactionCodeTypeModel.PrepaidCardActivationReversal:
                case TransactionCodeTypeModel.PrepaidCardLoadReversal:
                case TransactionCodeTypeModel.CreditReturn:
                case TransactionCodeTypeModel.AccountFundingCreditReturn:
                case TransactionCodeTypeModel.CardholderFundsTransferCreditReturn:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsDebitCardTransaction(this TransactionCodeTypeModel transactionCodeType)
        {
            switch (transactionCodeType.ToString())
            {
                case TransactionCodeTypeModel.FoodStampsReturnEbt:
                case TransactionCodeTypeModel.DirectDebitPurchase:
                case TransactionCodeTypeModel.DirectDebitPurchaseReturn:
                case TransactionCodeTypeModel.CashBenefitsCashWithdrawalEbt:
                case TransactionCodeTypeModel.FoodStampPurchaseEbt:
                case TransactionCodeTypeModel.DirectDebitBalanceInquiry:
                case TransactionCodeTypeModel.DebitBillPaymentTransaction:
                case TransactionCodeTypeModel.PinlessDebitBillPaymentTransaction:
                case TransactionCodeTypeModel.FoodStampsElectronicVoucherEbt:
                case TransactionCodeTypeModel.EbtCashBenefitsPurchaseOrPurchaseWithCashBack:
                case TransactionCodeTypeModel.DebitAccountFundingPurchase:
                case TransactionCodeTypeModel.DebitAccountFundingReturn:
                case TransactionCodeTypeModel.DebitCardholderFundsTransfer:
                case TransactionCodeTypeModel.DebitFundsTransferReturn:
                case TransactionCodeTypeModel.EbtFoodStampBalanceInquiry:
                case TransactionCodeTypeModel.EbtCashBenefitsBalanceInquiry:
                case TransactionCodeTypeModel.ChipCardTransactionAdviceRecordLimitedAvailability:
                case TransactionCodeTypeModel.AutomaticReversalDirectDebitPurchase:
                case TransactionCodeTypeModel.AutomaticReversalDirectDebitPurchaseReturn:
                case TransactionCodeTypeModel.AutomaticReversalInterlinkDirectDebitCancel:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsCreditCardTransaction(this TransactionCodeTypeModel transactionCodeType)
        {
            switch (transactionCodeType.ToString())
            {
                case TransactionCodeTypeModel.Purchase:
                case TransactionCodeTypeModel.PurchaseRepeat:
                case TransactionCodeTypeModel.CashAdvance:
                case TransactionCodeTypeModel.CashAdvanceRepeat:
                case TransactionCodeTypeModel.PurchaseCardNotPresent:
                case TransactionCodeTypeModel.PurchaseCardNotPresentRepeat:
                case TransactionCodeTypeModel.QuasiCash:
                case TransactionCodeTypeModel.QuasiCashRepeat:
                case TransactionCodeTypeModel.CardAuthentication:
                case TransactionCodeTypeModel.CardAuthenticationRepeat:
                case TransactionCodeTypeModel.OnlineAuthorizationReversal:
                case TransactionCodeTypeModel.OnlineAuthorizationReversalRepeat:
                case TransactionCodeTypeModel.StoreAndForwardAuthorizationReversal:
                case TransactionCodeTypeModel.StoreAndForwardAuthorizationReversalRepeat:
                case TransactionCodeTypeModel.BillPayTransaction:
                case TransactionCodeTypeModel.BillPayTransactionRepeat:
                case TransactionCodeTypeModel.CreditAdvice:
                case TransactionCodeTypeModel.CreditAccountFundingOrPayment:
                case TransactionCodeTypeModel.CreditAccountFundingOrPaymentRepeat:
                case TransactionCodeTypeModel.CardNotPresentCreditAccountFundingOrPayment:
                case TransactionCodeTypeModel.CardNotPresentCreditAccountFundingOrPaymentRepeat:
                case TransactionCodeTypeModel.CardPresentCreditCardholderFundsTransfer:
                case TransactionCodeTypeModel.CardPresentCreditCardholderFundsTransferRepeat:
                case TransactionCodeTypeModel.CardholderFundsTransferCardNotPresent:
                case TransactionCodeTypeModel.CardholderFundsTransferCardNotPresentRepeat:
                case TransactionCodeTypeModel.CreditStoredValueBalanceInquiry:
                case TransactionCodeTypeModel.CreditStoredValueBalanceInquiryRepeat:
                case TransactionCodeTypeModel.HealthcareEligibilityInquiry:
                case TransactionCodeTypeModel.HealthcareEligibilityInquiryRepeat:
                case TransactionCodeTypeModel.BalanceInquiryReversal:
                case TransactionCodeTypeModel.BalanceInquiryReversalRepeat:
                case TransactionCodeTypeModel.ProductEligibilityInquiry:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsGiftCardTransaction(this TransactionCodeTypeModel transactionCodeType)
        {
            switch (transactionCodeType.ToString())
            {
                case TransactionCodeTypeModel.GiftCardCloseCard:
                case TransactionCodeTypeModel.GiftCardBalanceInquiry:
                case TransactionCodeTypeModel.GiftCardPurchaseRedemption:
                case TransactionCodeTypeModel.GiftCardReturnRefund:
                case TransactionCodeTypeModel.GiftCardAddValueLoadCard:
                case TransactionCodeTypeModel.GiftCardDecreaseValueUnloadCard:
                case TransactionCodeTypeModel.GiftCardStandAloneTip:
                case TransactionCodeTypeModel.GiftCardIssueGiftCard:
                case TransactionCodeTypeModel.GiftCardIssueVirtualGiftCard:
                case TransactionCodeTypeModel.GiftCardMerchantInitiatedCancel:
                case TransactionCodeTypeModel.GiftCardMerchantInitiatedReversal:
                case TransactionCodeTypeModel.GiftCardCashBack:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsCheckTransaction(this TransactionCodeTypeModel transactionCodeType)
        {
            switch (transactionCodeType.ToString())
            {
                case TransactionCodeTypeModel.CheckGuarantee:
                case TransactionCodeTypeModel.PosCheckConversionWithGuarantee:
                case TransactionCodeTypeModel.PosCheckConversionWithVerification:
                case TransactionCodeTypeModel.PosCheckConversionOnly:
                case TransactionCodeTypeModel.PosCheckReversalConversionWithGuarantee:
                case TransactionCodeTypeModel.PosCheckReversalConversionWithVerification:
                case TransactionCodeTypeModel.PosCheckReversalConversionOnly:
                    return true;

                default:
                    return false;
            }
        }
    }
}