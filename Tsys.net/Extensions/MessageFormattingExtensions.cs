using System.Collections.Generic;
using System.Reflection;
using Tsys.net.Models.Exceptions;
using Tsys.net.Models.Shared;
using Tsys.net.Services.Attributes;
using static Tsys.net.FieldValidators.FieldValidators;

namespace Tsys.net.Extensions
{
    public static class MessageFormattingExtensions
    {
        public static AttributeInspectorToken FormatField(AttributeInspectorToken attributeInspectorToken, AttributeInspectorToken previousToken)
        {
            var attributes = attributeInspectorToken.Attributes;
            var property = attributeInspectorToken.Property;

            var isValid = true;
            var invalidDescription = string.Empty;

            switch (attributes.FieldFormat.FieldFormat)
            {
                case Attributes.FieldFormat.AN:
                    isValid = Ans.IsValid(attributeInspectorToken.RawValue);
                    invalidDescription = Ans.Description;
                    break;

                case Attributes.FieldFormat.NUM:
                    isValid = Num.IsValid(attributeInspectorToken.RawValue);
                    invalidDescription = Num.Description;
                    break;

                case Attributes.FieldFormat.ASCII:
                    isValid = Ascii.IsValid(attributeInspectorToken.RawValue);
                    invalidDescription = Ascii.Description;
                    break;
            }

            if (!isValid)
            {
                throw new TsysException($"Could not field validate '{invalidDescription}' with string '{attributeInspectorToken.RawValue}'. It did not meet the format criteria.");
            }

            var result = attributeInspectorToken.RawValue;

            if (!attributes.FieldLength.IsFixedLength)
            {
                result = result.Truncate(attributes.FieldLength.EndLength);

                if (attributes.FieldLength.ShouldPadLeft)
                {
                    result = result.PadLeft(attributes.FieldLength.EndLength, attributes.FieldLength.PadChar);
                }
                else
                {
                    result = result.PadRight(attributes.FieldLength.EndLength, attributes.FieldLength.PadChar);
                }
            }
            else
            {
                result = result.Truncate(attributes.FieldLength.FixedLength);

                if (attributes.FieldLength.ShouldPadLeft)
                {
                    result = result.PadLeft(attributes.FieldLength.FixedLength, attributes.FieldLength.PadChar);
                }
                else
                {
                    result = result.PadRight(attributes.FieldLength.FixedLength, attributes.FieldLength.PadChar);
                }
            }

            attributeInspectorToken.Value = result;

            return attributeInspectorToken;
        }
    }
}