using System;

namespace Tsys.net.Models.Types
{
    public struct VerificationCodePresenceTypeModel
    {
        public const uint VerificationCodeIntentionallyNotProvided = 0;
        public const uint VerificationCodePresent = 1;
        public const uint VerificationCodePresentButIllegible = 2;
        public const uint NoVerificationCodePresentOnCard = 9;
        private readonly uint value;

        public VerificationCodePresenceTypeModel(uint value)
        {
            this.value = value;
        }

        public static implicit operator VerificationCodePresenceTypeModel(uint value)
        {
            return new VerificationCodePresenceTypeModel(value);
        }

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case VerificationCodeIntentionallyNotProvided:
                    return nameof(VerificationCodeIntentionallyNotProvided);

                case VerificationCodePresent:
                    return nameof(VerificationCodePresent);

                case VerificationCodePresentButIllegible:
                    return nameof(VerificationCodePresentButIllegible);

                case NoVerificationCodePresentOnCard:
                    return nameof(NoVerificationCodePresentOnCard);

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