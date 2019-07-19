using System;

namespace Tsys.net.Models.Types
{
    public struct IndustryCodeTypeModel
    {
        public const string AllTypesExceptHotelAndAuto = " ";
        public const string IndustryCodeUnknownOrUnsure = "0";
        public const string AutoRental = "A";
        public const string BankFinancialInstitution = "B";
        public const string DirectMarketing = "D";
        public const string FoodRestaurant = "F";
        public const string GroceryStoreSupermarket = "G";
        public const string HotelAndLodging = "H";
        public const string LimitedAmountTerminal = "L";
        public const string OilCompanyAutomatedFuelingSystem = "O";
        public const string PassengerTransport = "P";
        public const string Retail = "R";
        public const string Internet = "I";
        private readonly string value;

        public IndustryCodeTypeModel(string value)
        {
            this.value = value;
        }

        public static implicit operator IndustryCodeTypeModel(string value)
        {
            return new IndustryCodeTypeModel(value);
        }

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case AllTypesExceptHotelAndAuto:
                    return nameof(AllTypesExceptHotelAndAuto);

                case IndustryCodeUnknownOrUnsure:
                    return nameof(IndustryCodeUnknownOrUnsure);

                case AutoRental:
                    return nameof(AutoRental);

                case BankFinancialInstitution:
                    return nameof(BankFinancialInstitution);

                case DirectMarketing:
                    return nameof(DirectMarketing);

                case FoodRestaurant:
                    return nameof(FoodRestaurant);

                case GroceryStoreSupermarket:
                    return nameof(GroceryStoreSupermarket);

                case HotelAndLodging:
                    return nameof(HotelAndLodging);

                case LimitedAmountTerminal:
                    return nameof(LimitedAmountTerminal);

                case OilCompanyAutomatedFuelingSystem:
                    return nameof(OilCompanyAutomatedFuelingSystem);

                case PassengerTransport:
                    return nameof(PassengerTransport);

                case Retail:
                    return nameof(Retail);

                case Internet:
                    return nameof(Internet);

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