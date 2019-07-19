using System;

namespace Tsys.net.Models.Types
{
    public struct AdditionalAmountSignTypeModel
    {
        public const string PositiveBalance = "C";
        public const string NegativeBalance = "D";

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
    }
}