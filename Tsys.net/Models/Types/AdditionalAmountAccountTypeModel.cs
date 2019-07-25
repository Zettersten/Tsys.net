using System;

namespace Tsys.net.Models.Types
{
    public struct AdditionalAmountAccountTypeModel
    {
        public const uint AccountNotSpecified = 0;
        public const uint SavingsAccount = 10;
        public const uint CheckingAccount = 20;
        public const uint CreditCardAccount = 30;
        public const uint UniversalAccount = 40;
        public const uint StoredValueAccount = 60;
        public const uint CashBenefitsAccount = 96; // (for use by Electronic Benefits Transfer transactions only)
        public const uint FoodStampsAccount = 98; // (for use by Electronic Benefits Transfer transactions only)
        private readonly uint value;

        public AdditionalAmountAccountTypeModel(uint value)
        {
            this.value = value;
        }

        public static implicit operator AdditionalAmountAccountTypeModel(uint value)
        {
            return new AdditionalAmountAccountTypeModel(value);
        }

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case AccountNotSpecified:
                    return nameof(AccountNotSpecified);

                case SavingsAccount:
                    return nameof(SavingsAccount);

                case CheckingAccount:
                    return nameof(CheckingAccount);

                case CreditCardAccount:
                    return nameof(CreditCardAccount);

                case UniversalAccount:
                    return nameof(UniversalAccount);

                case StoredValueAccount:
                    return nameof(StoredValueAccount);

                case CashBenefitsAccount:
                    return nameof(CashBenefitsAccount);

                case FoodStampsAccount:
                    return nameof(FoodStampsAccount);

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