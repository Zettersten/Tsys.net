using System;

namespace Tsys.net.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class FieldLengthAttribute : Attribute
    {
        private readonly int beginLength;
        private readonly int endLength;
        private readonly int fixedLength;
        private readonly bool shouldPadLeft;
        private readonly char padChar;

        public FieldLengthAttribute()
        {
            this.fixedLength = 1;
            this.shouldPadLeft = true;
            this.padChar = ' ';
        }

        public FieldLengthAttribute(int fixedLength)
        {
            this.fixedLength = fixedLength;
            this.shouldPadLeft = true;
            this.padChar = ' ';
        }

        public FieldLengthAttribute(int beginLength, int endLength)
        {
            this.beginLength = beginLength;
            this.endLength = endLength;
            this.shouldPadLeft = true;
            this.padChar = ' ';
        }

        public FieldLengthAttribute(int fixedLength, bool shouldPadLeft)
        {
            this.fixedLength = fixedLength;
            this.shouldPadLeft = shouldPadLeft;
            this.padChar = ' ';
        }

        public FieldLengthAttribute(int beginLength, int endLength, bool shouldPadLeft)
        {
            this.beginLength = beginLength;
            this.endLength = endLength;
            this.shouldPadLeft = shouldPadLeft;
            this.padChar = ' ';
        }

        public FieldLengthAttribute(int fixedLength, bool shouldPadLeft, char padChar)
        {
            this.fixedLength = fixedLength;
            this.shouldPadLeft = shouldPadLeft;
            this.padChar = padChar;
        }

        public FieldLengthAttribute(int beginLength, int endLength, bool shouldPadLeft, char padChar)
        {
            this.beginLength = beginLength;
            this.endLength = endLength;
            this.shouldPadLeft = shouldPadLeft;
            this.padChar = padChar;
        }

        public int BeginLength => beginLength;

        public int EndLength => endLength;

        public int FixedLength => fixedLength;

        public bool IsFixedLength => (endLength == 0 && beginLength == 0);

        public bool ShouldPadLeft => shouldPadLeft;

        public char PadChar => padChar;
    }
}