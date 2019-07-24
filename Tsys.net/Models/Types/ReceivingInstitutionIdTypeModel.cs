using System;

namespace Tsys.net.Models.Types
{
    public struct ReceivingInstitutionIdTypeModel
    {
        public const uint SpaceOrEmptyReceivingInst = 0;
        public const uint Bankserv = 763057;
        public const uint CertegyEquifaxEast = 894400;
        public const uint CertegyEquifaxWest = 894300;
        public const uint CiticorpPrivateLabel = 911111;
        public const uint Efunds = 762135;
        public const uint IcsCbsNpc = 810000;
        public const uint RockyMountainRetailSystems = 763060;
        public const uint Scan = 813500;
        public const uint Telecheck = 861400;
        private readonly uint value;

        public ReceivingInstitutionIdTypeModel(uint value)
        {
            this.value = value;
        }

        public static implicit operator ReceivingInstitutionIdTypeModel(uint value)
        {
            return new ReceivingInstitutionIdTypeModel(value);
        }

        public static bool operator ==(ReceivingInstitutionIdTypeModel firstValue, uint secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator !=(ReceivingInstitutionIdTypeModel firstValue, uint secondValue)
        {
            return firstValue.value == secondValue;
        }

        public static bool operator ==(uint firstValue, ReceivingInstitutionIdTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public static bool operator !=(uint firstValue, ReceivingInstitutionIdTypeModel secondValue)
        {
            return firstValue == secondValue.value;
        }

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case SpaceOrEmptyReceivingInst:
                    return nameof(SpaceOrEmptyReceivingInst);

                case Bankserv:
                    return nameof(Bankserv);

                case CertegyEquifaxEast:
                    return nameof(CertegyEquifaxEast);

                case CertegyEquifaxWest:
                    return nameof(CertegyEquifaxWest);

                case CiticorpPrivateLabel:
                    return nameof(CiticorpPrivateLabel);

                case Efunds:
                    return nameof(Efunds);

                case IcsCbsNpc:
                    return nameof(IcsCbsNpc);

                case RockyMountainRetailSystems:
                    return nameof(RockyMountainRetailSystems);

                case Scan:
                    return nameof(Scan);

                case Telecheck:
                    return nameof(Telecheck);

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