using System;
using System.Collections.Generic;
using System.Text;

namespace Tsys.net.Models.Types
{
    public struct LanguageIndicatorTypeModel
    {
        public const uint English = 0;
        public const uint Spanish = 1;
        public const uint Portuguese = 2;
        public const uint Irish = 3;
        public const uint French = 4;
        public const uint German = 5;
        public const uint Italian = 6;
        public const uint Dutch = 7;
        private readonly uint value;

        public LanguageIndicatorTypeModel(uint value)
        {
            this.value = value;
        }

        public static implicit operator LanguageIndicatorTypeModel(uint value)
        {
            return new LanguageIndicatorTypeModel(value);
        }

        public static string GetName(uint typeValue)
        {
            switch (typeValue)
            {
                case English:
                    return nameof(English);

                case Spanish:
                    return nameof(Spanish);

                case Portuguese:
                    return nameof(Portuguese);

                case Irish:
                    return nameof(Irish);

                case French:
                    return nameof(French);

                case German:
                    return nameof(German);

                case Italian:
                    return nameof(Italian);

                case Dutch:
                    return nameof(Dutch);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}