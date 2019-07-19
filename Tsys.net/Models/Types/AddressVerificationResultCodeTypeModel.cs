using System;

namespace Tsys.net.Models.Types
{
    public struct AddressVerificationResultCodeTypeModel
    {
        public const string ApprovedAddressVerificationNotRequested_0 = "0";
        public const string AddressMatchAddressMatchOnly_A = "A";
        public const string AddressMatchStreetAddressMatchInternational_B = "B";
        public const string ServUnavailableStreetAndPostalCodeNotVerified_C = "C";
        public const string ExactMatchStreetAddressMatch_D = "D";
        public const string ExactMatchStreetAddressAndPostalCodeMatch_F = "F";
        public const string VerUnavailableIssuerDoesNotParticipate_G = "G";
        public const string VerUnavailable_I = "I";
        public const string ExactMatchStreetAddressMatchInternational_M = "M";
        public const string NoMatchNoAddressOrZIPMatch_N = "N";
        public const string ZipMatchPostalCodesMatchInternational_P = "P";
        public const string RetryIssuerSystemUnavailable_R = "R";
        public const string ServUnavailableServiceNotSupported_S = "S";
        public const string VerUnavailableAddressUnavailable_U = "U";
        public const string ZipMatchNineCharacterNumericZIPMatchOnly_W = "W";
        public const string ExactMatchExactMatchNineCharacterNumericZIP_X = "X";
        public const string ExactMatchExactMatchFiveCharacterNumericZIP_Y = "Y";
        public const string ZipMatchFiveCharacterNumericZIPMatchOnly_Z = "Z";
        public const string CardholderNameAndZIPMatchAMEXOnly_1 = "1";
        public const string CardholderNameAddressAndZIPMatchAMEXOnly_2 = "2";
        public const string CardholderNameAndAddressMatchAMEXOnly_3 = "3";
        public const string CardholderNameMatchAMEXOnly_4 = "4";
        public const string CardholderNameIncorrectZIPMatchAMEXOnly_5 = "5";
        public const string CardholderNameIncorrectAddressAndZIPMatchAMEXOnly_6 = "6";
        public const string CardholderNameIncorrectAddressMatchAMEXOnly_7 = "7";
        public const string CardholderAllDoNotMatchAMEXOnly_8 = "8";

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case ApprovedAddressVerificationNotRequested_0:
                    return nameof(ApprovedAddressVerificationNotRequested_0);

                case AddressMatchAddressMatchOnly_A:
                    return nameof(AddressMatchAddressMatchOnly_A);

                case AddressMatchStreetAddressMatchInternational_B:
                    return nameof(AddressMatchStreetAddressMatchInternational_B);

                case ServUnavailableStreetAndPostalCodeNotVerified_C:
                    return nameof(ServUnavailableStreetAndPostalCodeNotVerified_C);

                case ExactMatchStreetAddressMatch_D:
                    return nameof(ExactMatchStreetAddressMatch_D);

                case ExactMatchStreetAddressAndPostalCodeMatch_F:
                    return nameof(ExactMatchStreetAddressAndPostalCodeMatch_F);

                case VerUnavailableIssuerDoesNotParticipate_G:
                    return nameof(VerUnavailableIssuerDoesNotParticipate_G);

                case VerUnavailable_I:
                    return nameof(VerUnavailable_I);

                case ExactMatchStreetAddressMatchInternational_M:
                    return nameof(ExactMatchStreetAddressMatchInternational_M);

                case NoMatchNoAddressOrZIPMatch_N:
                    return nameof(NoMatchNoAddressOrZIPMatch_N);

                case ZipMatchPostalCodesMatchInternational_P:
                    return nameof(ZipMatchPostalCodesMatchInternational_P);

                case RetryIssuerSystemUnavailable_R:
                    return nameof(RetryIssuerSystemUnavailable_R);

                case ServUnavailableServiceNotSupported_S:
                    return nameof(ServUnavailableServiceNotSupported_S);

                case VerUnavailableAddressUnavailable_U:
                    return nameof(VerUnavailableAddressUnavailable_U);

                case ZipMatchNineCharacterNumericZIPMatchOnly_W:
                    return nameof(ZipMatchNineCharacterNumericZIPMatchOnly_W);

                case ExactMatchExactMatchNineCharacterNumericZIP_X:
                    return nameof(ExactMatchExactMatchNineCharacterNumericZIP_X);

                case ExactMatchExactMatchFiveCharacterNumericZIP_Y:
                    return nameof(ExactMatchExactMatchFiveCharacterNumericZIP_Y);

                case ZipMatchFiveCharacterNumericZIPMatchOnly_Z:
                    return nameof(ZipMatchFiveCharacterNumericZIPMatchOnly_Z);

                case CardholderNameAndZIPMatchAMEXOnly_1:
                    return nameof(CardholderNameAndZIPMatchAMEXOnly_1);

                case CardholderNameAddressAndZIPMatchAMEXOnly_2:
                    return nameof(CardholderNameAddressAndZIPMatchAMEXOnly_2);

                case CardholderNameAndAddressMatchAMEXOnly_3:
                    return nameof(CardholderNameAndAddressMatchAMEXOnly_3);

                case CardholderNameMatchAMEXOnly_4:
                    return nameof(CardholderNameMatchAMEXOnly_4);

                case CardholderNameIncorrectZIPMatchAMEXOnly_5:
                    return nameof(CardholderNameIncorrectZIPMatchAMEXOnly_5);

                case CardholderNameIncorrectAddressAndZIPMatchAMEXOnly_6:
                    return nameof(CardholderNameIncorrectAddressAndZIPMatchAMEXOnly_6);

                case CardholderNameIncorrectAddressMatchAMEXOnly_7:
                    return nameof(CardholderNameIncorrectAddressMatchAMEXOnly_7);

                case CardholderAllDoNotMatchAMEXOnly_8:
                    return nameof(CardholderAllDoNotMatchAMEXOnly_8);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }
    }
}