using System;

namespace Tsys.net.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class FieldDescriptionAttribute : Attribute
    {
        private readonly string content;
        private readonly int order;
        private readonly string reference;

        public FieldDescriptionAttribute(string content, string reference, int order)
        {
            this.content = content;
            this.reference = reference;
            this.order = order;
        }

        public string Content => content;

        public int Order => order;

        public string Reference => reference;
    }
}