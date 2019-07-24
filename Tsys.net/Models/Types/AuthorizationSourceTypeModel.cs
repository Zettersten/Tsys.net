using System;

namespace Tsys.net.Models.Types
{
    public struct AuthorizationSourceTypeModel
    {
        public const string SpaceOrEmptyAuthorizationSource = " ";
        public const string StipStandinProcessingTimeoutResponse = "1";
        public const string StipAmountBelowIssuerLimit = "2";
        public const string StipIssuerInSuppressInquiryMode = "3";
        public const string DirectConnectIssuerGeneratedResponse = "4";
        public const string IssuerGeneratedResponse = "5";
        public const string OffLineApprovalPosDeviceGenerated = "6";
        public const string AcquirerApprovalBase1Unavailable = "7";
        public const string AcquirerApprovalOfReferral = "8";
        public const string CreditRefundOrNonauthorizedTransactions = "9";
        public const string ThirdPartyAuthorizingAgentPosCheckService = "A";
        public const string ReferralAuthorizationCodeManuallyKeyed = "D";
        public const string OffLineApprovalAuthorizationCodeManuallyKeyed = "E";
        public const string CafisInterfaceOffLinePostAuthJapanAcquirerServicesJas = "F";
        public const string IssuerApprovalPostAuth = "G";
        private readonly string value;

        public AuthorizationSourceTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator AuthorizationSourceTypeModel(string value)
        {
            return new AuthorizationSourceTypeModel(value);
        }

        public static bool operator ==(AuthorizationSourceTypeModel firstValue, string secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator !=(AuthorizationSourceTypeModel firstValue, string secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator ==(string firstValue, AuthorizationSourceTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public static bool operator !=(string firstValue, AuthorizationSourceTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case SpaceOrEmptyAuthorizationSource:
                    return nameof(SpaceOrEmptyAuthorizationSource);

                case StipStandinProcessingTimeoutResponse:
                    return nameof(StipStandinProcessingTimeoutResponse);

                case StipAmountBelowIssuerLimit:
                    return nameof(StipAmountBelowIssuerLimit);

                case StipIssuerInSuppressInquiryMode:
                    return nameof(StipIssuerInSuppressInquiryMode);

                case DirectConnectIssuerGeneratedResponse:
                    return nameof(DirectConnectIssuerGeneratedResponse);

                case IssuerGeneratedResponse:
                    return nameof(IssuerGeneratedResponse);

                case OffLineApprovalPosDeviceGenerated:
                    return nameof(OffLineApprovalPosDeviceGenerated);

                case AcquirerApprovalBase1Unavailable:
                    return nameof(AcquirerApprovalBase1Unavailable);

                case AcquirerApprovalOfReferral:
                    return nameof(AcquirerApprovalOfReferral);

                case CreditRefundOrNonauthorizedTransactions:
                    return nameof(CreditRefundOrNonauthorizedTransactions);

                case ThirdPartyAuthorizingAgentPosCheckService:
                    return nameof(ThirdPartyAuthorizingAgentPosCheckService);

                case ReferralAuthorizationCodeManuallyKeyed:
                    return nameof(ReferralAuthorizationCodeManuallyKeyed);

                case OffLineApprovalAuthorizationCodeManuallyKeyed:
                    return nameof(OffLineApprovalAuthorizationCodeManuallyKeyed);

                case CafisInterfaceOffLinePostAuthJapanAcquirerServicesJas:
                    return nameof(CafisInterfaceOffLinePostAuthJapanAcquirerServicesJas);

                case IssuerApprovalPostAuth:
                    return nameof(IssuerApprovalPostAuth);

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
            return obj is AuthorizationSourceTypeModel model &&
                   value == model.value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }
}