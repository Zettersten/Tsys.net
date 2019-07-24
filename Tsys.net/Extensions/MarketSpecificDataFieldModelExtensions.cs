using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class MarketSpecificDataFieldModelExtensions
    {
        public static MarketSpecificDataFieldModel Copy(this MarketSpecificDataFieldModel marketSpecificDataFieldModel)
        {
            return MarketSpecificDataFieldModel.NewMarketSpecificDataFieldModel(marketSpecificDataFieldModel.PrestigiousPropertyType, marketSpecificDataFieldModel.MarketSpecificDataType, marketSpecificDataFieldModel.StayOrRentalDuration);
        }

        public static MarketSpecificDataFieldModel Deserialize<T>(this string value) where T : MarketSpecificDataFieldModel
        {
            var result = new MarketSpecificDataFieldModel
            {
                MarketSpecificDataType = MarketSpecificDataTypeModel.OtherIndustries,
                PrestigiousPropertyType = PrestigiousPropertyTypeModel.AutoRentalOrNonParticipatingProperty,
                StayOrRentalDuration = 0
            };

            if (4 > value.Length)
            {
                return result;
            }

            result.PrestigiousPropertyType = value.Substring(0, 1);
            result.MarketSpecificDataType = value.Substring(1, 2);
            result.StayOrRentalDuration = uint.Parse(value.Substring(3));

            return result;
        }

        public static string Serialize(this MarketSpecificDataFieldModel marketSpecificDataFieldModel)
        {
            if (0 >= marketSpecificDataFieldModel.StayOrRentalDuration)
            {
                return string.Empty;
            }

            return string.Format("{0}{1}{2}", marketSpecificDataFieldModel.PrestigiousPropertyType, marketSpecificDataFieldModel.MarketSpecificDataType, marketSpecificDataFieldModel.StayOrRentalDuration.ToString().PadLeft(2, '0'));
        }
    }
}