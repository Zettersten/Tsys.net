using Tsys.net.Extensions;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.SubfieldRecords
{
    public class MarketSpecificDataFieldModel
    {
        public uint StayOrRentalDuration { get; set; }

        public PrestigiousPropertyTypeModel PrestigiousPropertyType { get; set; }

        public MarketSpecificDataTypeModel MarketSpecificDataType { get; set; }

        public static MarketSpecificDataFieldModel NewMarketSpecificDataFieldModel(PrestigiousPropertyTypeModel prestigiousPropertyType, MarketSpecificDataTypeModel marketSpecificDataType, uint rentalDuraction)
        {
            return new MarketSpecificDataFieldModel
            {
                PrestigiousPropertyType = prestigiousPropertyType,
                MarketSpecificDataType = marketSpecificDataType,
                StayOrRentalDuration = rentalDuraction
            };
        }

        public static implicit operator MarketSpecificDataFieldModel(string value)
        {
            return MarketSpecificDataFieldModelExtensions.Deserialize<MarketSpecificDataFieldModel>(value);
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}