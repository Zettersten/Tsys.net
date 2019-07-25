using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct UcafCollectionTypeModel
    {
        public const string UcafNotSupportedByMerchantWebsite = "0";
        public const string UcafSupportedButDataNotPopulated = "1";
        public const string UcafDataWasPopulated = "2";
        public const string VisaCavvDataPresent = "4";
        private readonly string value;

        public UcafCollectionTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator UcafCollectionTypeModel(string value)
        {
            return new UcafCollectionTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case UcafNotSupportedByMerchantWebsite:
                    return nameof(UcafNotSupportedByMerchantWebsite);

                case UcafSupportedButDataNotPopulated:
                    return nameof(UcafSupportedButDataNotPopulated);

                case UcafDataWasPopulated:
                    return nameof(UcafDataWasPopulated);

                case VisaCavvDataPresent:
                    return nameof(VisaCavvDataPresent);

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