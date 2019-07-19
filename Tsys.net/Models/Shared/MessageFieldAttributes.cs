using System;
using Tsys.net.Attributes;

namespace Tsys.net.Models.Shared
{
    public class MessageFieldAttributes
    {
        public static Type FieldDescriptionAttribute = typeof(FieldDescriptionAttribute);

        public static Type FieldFormatAttribute = typeof(FieldFormatAttribute);

        public static Type FieldGroupAttribute = typeof(FieldGroupAttribute);

        public static Type FieldLengthAttribute = typeof(FieldLengthAttribute);

        public FieldDescriptionAttribute FieldDescription { get; set; }

        public FieldFormatAttribute FieldFormat { get; set; }

        public FieldGroupAttribute FieldGroup { get; set; }

        public FieldLengthAttribute FieldLength { get; set; }
    }
}