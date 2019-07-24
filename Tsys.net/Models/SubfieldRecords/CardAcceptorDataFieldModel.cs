using Tsys.net.Extensions;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.SubfieldRecords
{
    public class CardAcceptorDataFieldModel
    {
        public string MerchantName { get; set; }

        public string MerchantCity { get; set; }

        public string MerchantState { get; set; }

        public uint TicketNumber { get; set; }

        public string CustomerServicePhoneNumber { get; set; }

        public static CardAcceptorDataFieldModel NewCardAcceptorDataField(string merchantName, string merchantCity, string merchantState, uint ticketNumber, string customerServicePhoneNumber)
        {
            return new CardAcceptorDataFieldModel
            {
                MerchantCity = merchantCity,
                MerchantName = merchantName,
                MerchantState = merchantState,
                CustomerServicePhoneNumber = customerServicePhoneNumber,
                TicketNumber = ticketNumber
            };
        }

        public static implicit operator CardAcceptorDataFieldModel(string value)
        {
            return CardAcceptorDataFieldModelExtensions.Deserialize<CardAcceptorDataFieldModel>(value);
        }

        public override string ToString()
        {
            return this.Serialize();
        }

        public string ToString(TransactionCodeTypeModel transactionTypeCode)
        {
            return this.Serialize(transactionTypeCode.ToString());
        }
    }
}