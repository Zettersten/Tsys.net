using System;

namespace Tsys.net.Models.Types
{
    public struct RecordFormatTypeModel
    {
        public const string CreditCardAuthorizationRequest = "D";
        public const string CreditCardAuthorizationResponse = "E";
        public const string DebitEbtRequest = "T";
        public const string DebitEbtResponse = "U";
        public const string DebitEbtConfirmation = "V";
        public const string Settlement = "K";
        public const string PekExchangeRequest = "P";
        public const string KeepAlive = "A";
        public const string Iso8583 = "I";

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case CreditCardAuthorizationRequest:
                    return nameof(CreditCardAuthorizationRequest);

                case CreditCardAuthorizationResponse:
                    return nameof(CreditCardAuthorizationResponse);

                case DebitEbtRequest:
                    return nameof(DebitEbtRequest);

                case DebitEbtResponse:
                    return nameof(DebitEbtResponse);

                case DebitEbtConfirmation:
                    return nameof(DebitEbtConfirmation);

                case Settlement:
                    return nameof(Settlement);

                case PekExchangeRequest:
                    return nameof(PekExchangeRequest);

                case KeepAlive:
                    return nameof(KeepAlive);

                case Iso8583:
                    return nameof(Iso8583);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }
    }
}