using System;

namespace Tsys.net.Models.Types
{
    public struct RecordFormatTypeModel
    {
        public const char CreditCardAuthorizationRequest = 'D';
        public const char CreditCardAuthorizationResponse = 'E';
        public const char DebitEbtRequest = 'T';
        public const char DebitEbtResponse = 'U';
        public const char DebitEbtConfirmation = 'V';
        public const char Settlement = 'K';
        public const char PekExchangeRequest = 'P';
        public const char KeepAlive = 'A';
        public const char Iso8583 = 'I';
        private readonly char value;

        public RecordFormatTypeModel(char value)
        {
            this.value = value;
        }

        public static implicit operator RecordFormatTypeModel(char value)
        {
            return new RecordFormatTypeModel(value);
        }

        public static string GetName(char typeValue)
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

        public override string ToString()
        {
            return value.ToString();
        }
    }
}