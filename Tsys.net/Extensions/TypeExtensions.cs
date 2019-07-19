using System;
using System.Collections.Generic;
using System.Reflection;
using Tsys.net.Attributes;
using Tsys.net.Models.Shared;

namespace Tsys.net.Extensions
{
    public static class TypeExtensions
    {
        public static Dictionary<PropertyInfo, MessageFieldAttributes> GetTypeAndCustomAttributes(this Type type)
        {
            var fieldAssemblyTable = new Dictionary<PropertyInfo, MessageFieldAttributes>();

            foreach (var prop in type.GetProperties())
            {
                var fieldLength = prop.GetCustomAttribute(MessageFieldAttributes.FieldLengthAttribute);
                var fieldGroup = prop.GetCustomAttribute(MessageFieldAttributes.FieldGroupAttribute);
                var fieldFormat = prop.GetCustomAttribute(MessageFieldAttributes.FieldFormatAttribute);
                var fieldDesc = prop.GetCustomAttribute(MessageFieldAttributes.FieldDescriptionAttribute);

                if (fieldDesc == null || fieldFormat == null || fieldLength == null || fieldGroup == null)
                {
                    continue;
                }

                fieldAssemblyTable.Add(prop, new MessageFieldAttributes
                {
                    FieldGroup = (FieldGroupAttribute)fieldGroup,
                    FieldDescription = (FieldDescriptionAttribute)fieldDesc,
                    FieldLength = (FieldLengthAttribute)fieldLength,
                    FieldFormat = (FieldFormatAttribute)fieldFormat
                });
            }

            return fieldAssemblyTable;
        }

        public static bool TryConvert(this object input, out string output)
        {
            try
            {
                output = Convert.ToString(input);

                if (string.IsNullOrEmpty(output))
                {
                    output = null;
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                output = null;
                return false;
            }
        }
    }
}