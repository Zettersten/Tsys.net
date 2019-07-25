using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct CardIssuerTypeModel
    {
        public const string EmptyCardType = " ";
        public const string Amex = "A";
        public const string Delta = "T";
        public const string Diners = "D";
        public const string Ets = "G";
        public const string Discover = "I";
        public const string Electron = "E";
        public const string Jcb = "J";
        public const string Laser = "L";
        public const string Mastercard = "M";
        public const string Maestro = "O";
        public const string Switch = "W";
        public const string Solo = "S";
        public const string Transax = "X";
        public const string Visa = "V";
        public const string Unrecognized = "U";
        private readonly string value;

        public CardIssuerTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator CardIssuerTypeModel(string value)
        {
            return new CardIssuerTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case EmptyCardType:
                    return nameof(EmptyCardType);

                case Amex:
                    return nameof(Amex);

                case Delta:
                    return nameof(Delta);

                case Diners:
                    return nameof(Diners);

                case Ets:
                    return nameof(Ets);

                case Discover:
                    return nameof(Discover);

                case Electron:
                    return nameof(Electron);

                case Jcb:
                    return nameof(Jcb);

                case Laser:
                    return nameof(Laser);

                case Mastercard:
                    return nameof(Mastercard);

                case Maestro:
                    return nameof(Maestro);

                case Switch:
                    return nameof(Switch);

                case Solo:
                    return nameof(Solo);

                case Transax:
                    return nameof(Transax);

                case Visa:
                    return nameof(Visa);

                case Unrecognized:
                    return nameof(Unrecognized);

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