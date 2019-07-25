using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct VerificationCodeDesiredResponseTypeModel
    {
        public const uint NormalResponseRequested = 0;
        public const uint EnhancedResponseRequested = 1;
        private readonly uint value;

        public VerificationCodeDesiredResponseTypeModel(uint value)
        {
            this.value = value;
        }

        public static implicit operator VerificationCodeDesiredResponseTypeModel(uint value)
        {
            return new VerificationCodeDesiredResponseTypeModel(value);
        }

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case NormalResponseRequested:
                    return nameof(NormalResponseRequested);

                case EnhancedResponseRequested:
                    return nameof(EnhancedResponseRequested);

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