using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct PrestigiousPropertyTypeModel
    {
        public const string AutoRentalOrNonParticipatingProperty = " ";
        public const string PropertyWith500Limit = "D";
        public const string PropertyWith1000Limit = "B";
        public const string PropertyWith1500Limit = "S";
        private readonly string value;

        public PrestigiousPropertyTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator PrestigiousPropertyTypeModel(string value)
        {
            return new PrestigiousPropertyTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case AutoRentalOrNonParticipatingProperty:
                    return nameof(AutoRentalOrNonParticipatingProperty);

                case PropertyWith500Limit:
                    return nameof(PropertyWith500Limit);

                case PropertyWith1000Limit:
                    return nameof(PropertyWith1000Limit);

                case PropertyWith1500Limit:
                    return nameof(PropertyWith1500Limit);

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