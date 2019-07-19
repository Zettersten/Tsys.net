using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tsys.net.Extensions;
using Tsys.net.Models.Exceptions;
using Tsys.net.Models.Shared;

namespace Tsys.net.Services.Attributes
{
    public class AttributeInspectorService<T> where T : struct
    {
        private readonly int fieldCount;
        private readonly Dictionary<PropertyInfo, MessageFieldAttributes> fields;
        private readonly bool isZeroIndexed;
        private readonly int largestFieldOrder;
        private readonly int lowestFieldOrder;
        private readonly Type messageInstanceType;
        private T messageInstance;

        public AttributeInspectorService(T message)
        {
            this.messageInstance = message;
            this.messageInstanceType = this.messageInstance.GetType();
            this.fields = messageInstanceType.GetTypeAndCustomAttributes();
            this.fieldCount = fields.Count;

            if (fieldCount == 0)
            {
                throw new TsysException("This message/struct did not contain any annotations.");
            }

            this.largestFieldOrder = fields
                .OrderByDescending(x => x.Value.FieldDescription.Order)
                .First()
                .Value.FieldDescription.Order;

            this.lowestFieldOrder = fields
                .OrderBy(x => x.Value.FieldDescription.Order)
                .First()
                .Value.FieldDescription.Order;

            this.isZeroIndexed = false;

            if (lowestFieldOrder == 0)
            {
                isZeroIndexed = true;
            }

            if (largestFieldOrder > (isZeroIndexed ? fieldCount : fieldCount + 1))
            {
                throw new TsysException("This message/struct contains a field with an order greater than the amount of fields specified.");
            }
        }

        public string BuildMessage()
        {
            var layout = new string[fieldCount];

            AttributeInspectorToken token = null;

            for (int i = 0; i < fieldCount; i++)
            {
                var index = (isZeroIndexed ? i : i + 1);

                var resultingToken = GetValueAtPosition(token, index);

                if (resultingToken == null)
                {
                    continue;
                }

                token = resultingToken;
                layout[i] = token.Value;
            }

            return string.Join(string.Empty, layout);
        }

        public string Test()
        {
            return string.Empty;
        }

        private AttributeInspectorToken GetValueAtPosition(AttributeInspectorToken previous, int position)
        {
            try
            {
                var currentField = fields.First(x => x.Value.FieldDescription.Order.Equals(position));
                var obj = currentField.Key.GetValue(messageInstance);

                if (!obj.TryConvert(out string rawValue))
                {
                    return null;
                }

                return MessageFormattingExtensions.FormatField(new AttributeInspectorToken
                {
                    Description = currentField.Value.FieldDescription.Content,
                    Reference = currentField.Value.FieldDescription.Reference,
                    Order = currentField.Value.FieldDescription.Order,
                    Property = currentField.Key,
                    Attributes = currentField.Value,
                    RawValue = rawValue
                }, previous);
            }
            catch
            {
                return null;
            }
        }
    }

    public class AttributeInspectorToken
    {
        public MessageFieldAttributes Attributes { get; set; }
        public string Description { get; set; }

        public int Order { get; set; }

        public PropertyInfo Property { get; set; }

        public string RawValue { get; set; }

        public string Reference { get; set; }

        public string Value { get; set; }
    }
}