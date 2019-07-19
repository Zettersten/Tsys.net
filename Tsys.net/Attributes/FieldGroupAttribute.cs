using System;

namespace Tsys.net.Attributes
{
    public enum FieldGroup
    {
        GroupI = 1,
        GroupII = 2,
        GroupIII = 3
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class FieldGroupAttribute : Attribute
    {
        private readonly FieldGroup fieldGroup;

        public FieldGroupAttribute(FieldGroup fieldGroup)
        {
            this.fieldGroup = fieldGroup;
        }

        public FieldGroupAttribute()
        {
            this.fieldGroup = FieldGroup.GroupI;
        }

        public FieldGroup FieldGroup => fieldGroup;
    }
}