using System;

namespace Tsys.net.Models.Types
{
    public struct ApplicationIndicatorTypeModel
    {
        public const uint SingleAuthorizationPerConnection = 0;

        public const uint SingleBatchPerConnection = 1;

        public const uint MutlipleAuthorizationsPerConnectionSingleThreaded = 2;

        public const uint MultipleBatchPerConnection = 3;

        public const uint MultipleAuthorizationsPerConnectionFullDuplexInterleaved = 4;

        public const uint VitalCentralDataCapture05 = 5;

        public const uint VitalCentralDataCapture06 = 6;

        public const uint Reserved = 9;

        private readonly uint value;

        public ApplicationIndicatorTypeModel(uint value)
        {
            this.value = value;
        }

        public static implicit operator ApplicationIndicatorTypeModel(uint value)
        {
            return new ApplicationIndicatorTypeModel(value);
        }

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case SingleAuthorizationPerConnection:
                    return nameof(SingleAuthorizationPerConnection);

                case SingleBatchPerConnection:
                    return nameof(SingleBatchPerConnection);

                case MutlipleAuthorizationsPerConnectionSingleThreaded:
                    return nameof(MutlipleAuthorizationsPerConnectionSingleThreaded);

                case MultipleBatchPerConnection:
                    return nameof(MultipleBatchPerConnection);

                case MultipleAuthorizationsPerConnectionFullDuplexInterleaved:
                    return nameof(MultipleAuthorizationsPerConnectionFullDuplexInterleaved);

                case VitalCentralDataCapture05:
                    return nameof(VitalCentralDataCapture05);

                case VitalCentralDataCapture06:
                    return nameof(VitalCentralDataCapture06);

                case Reserved:
                    return nameof(Reserved);

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