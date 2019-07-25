using System;

namespace Tsys.net.Models.Types
{
    public struct AdditionalAmountSignTypeModel
    {
        public const string PositiveBalance = "C";
        public const string NegativeBalance = "D";
        private readonly string value;

        public AdditionalAmountSignTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator AdditionalAmountSignTypeModel(string value)
        {
            return new AdditionalAmountSignTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case PositiveBalance:
                    return nameof(PositiveBalance);

                case NegativeBalance:
                    return nameof(NegativeBalance);

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