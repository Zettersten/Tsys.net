using System;

namespace Tsys.net.Models.Types
{
    public struct RequestAciTypeModel
    {
        public const string DeviceIsNotCpsMeritCapableOrPosCheck = "N";
        public const string DeviceIsCpsMeritCapableOrCreditOrOffline = "Y";
        public const string CpsCapableManuallyKeyedOrMcTips = "P";
        public const string CpsCapableIncrementalAuthorizationRequest = "I";
        public const string RecurringOrInstallmentPayments = "R";
        private readonly string value;

        public RequestAciTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator RequestAciTypeModel(string value)
        {
            return new RequestAciTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case DeviceIsNotCpsMeritCapableOrPosCheck:
                    return nameof(DeviceIsNotCpsMeritCapableOrPosCheck);

                case DeviceIsCpsMeritCapableOrCreditOrOffline:
                    return nameof(DeviceIsCpsMeritCapableOrCreditOrOffline);

                case CpsCapableManuallyKeyedOrMcTips:
                    return nameof(CpsCapableManuallyKeyedOrMcTips);

                case CpsCapableIncrementalAuthorizationRequest:
                    return nameof(CpsCapableIncrementalAuthorizationRequest);

                case RecurringOrInstallmentPayments:
                    return nameof(RecurringOrInstallmentPayments);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}