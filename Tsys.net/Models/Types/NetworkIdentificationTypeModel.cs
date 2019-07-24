using System;

namespace Tsys.net.Models.Types
{
    public struct NetworkIdentificationTypeModel
    {
        public const string SpaceOrEmptyNetworkId = " ";
        public const string EftIllinois = "1";
        public const string AlaskaOption = "3";
        public const string VisaCheckCardII = "5";
        public const string ShazamITS = "7";
        public const string MaestroNetwork = "8";
        public const string Transfund = "A";
        public const string MellonSpecial = "B";
        public const string Alert = "C";
        public const string Accel = "E";
        public const string MagicLine = "F";
        public const string Interlink = "G";
        public const string Tyme = "H";
        public const string Most = "I";
        public const string Gulfnet = "J";
        public const string EbtNetwork = "K";
        public const string Pulse = "L";
        public const string Bankmate = "M";
        public const string CashStation = "N";
        public const string StarWestExplore = "Q";
        public const string MoneyStation = "S";
        public const string Affn = "U";
        public const string VisaNetwork = "V";
        public const string StarSoutheastHonor = "W";
        public const string Infyank24nyce = "Y";
        public const string StarNortheastMac = "Z";
        private readonly string value;

        public NetworkIdentificationTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator NetworkIdentificationTypeModel(string value)
        {
            return new NetworkIdentificationTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case SpaceOrEmptyNetworkId:
                    return nameof(SpaceOrEmptyNetworkId);

                case EftIllinois:
                    return nameof(EftIllinois);

                case AlaskaOption:
                    return nameof(AlaskaOption);

                case VisaCheckCardII:
                    return nameof(VisaCheckCardII);

                case ShazamITS:
                    return nameof(ShazamITS);

                case MaestroNetwork:
                    return nameof(MaestroNetwork);

                case Transfund:
                    return nameof(Transfund);

                case MellonSpecial:
                    return nameof(MellonSpecial);

                case Alert:
                    return nameof(Alert);

                case Accel:
                    return nameof(Accel);

                case MagicLine:
                    return nameof(MagicLine);

                case Interlink:
                    return nameof(Interlink);

                case Tyme:
                    return nameof(Tyme);

                case Most:
                    return nameof(Most);

                case Gulfnet:
                    return nameof(Gulfnet);

                case EbtNetwork:
                    return nameof(EbtNetwork);

                case Pulse:
                    return nameof(Pulse);

                case Bankmate:
                    return nameof(Bankmate);

                case CashStation:
                    return nameof(CashStation);

                case StarWestExplore:
                    return nameof(StarWestExplore);

                case MoneyStation:
                    return nameof(MoneyStation);

                case Affn:
                    return nameof(Affn);

                case VisaNetwork:
                    return nameof(VisaNetwork);

                case StarSoutheastHonor:
                    return nameof(StarSoutheastHonor);

                case Infyank24nyce:
                    return nameof(Infyank24nyce);

                case StarNortheastMac:
                    return nameof(StarNortheastMac);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }

        public override string ToString()
        {
            return value;
        }
    }
}