using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Attributes
{
    public enum FieldFormat
    {
        /// <summary>
        /// Alpha-numberic
        /// </summary>
        AN,

        /// <summary>
        /// Numeric
        /// </summary>
        NUM,

        /// <summary>
        /// ASCII
        /// </summary>
        ASCII
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class FieldFormatAttribute : Attribute
    {
        private readonly FieldFormat fieldFormat;

        public FieldFormatAttribute(FieldFormat fieldFormat)
        {
            this.fieldFormat = fieldFormat;
        }

        public FieldFormatAttribute()
        {
            this.fieldFormat = FieldFormat.AN;
        }

        public FieldFormat FieldFormat => fieldFormat;
    }
}