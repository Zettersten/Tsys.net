using System;

namespace Tsys.net.Models.Types
{
    public struct AdllTypeModel
    {
        public const string SpaceOrEmptyAdll = " ";
        public const string PartialDownload = "P";
        public const string FullDownload = "F";

        public static string GetName(string typeValue)
        {
            switch (typeValue)
            {
                case FullDownload:
                    return nameof(FullDownload);

                case PartialDownload:
                    return nameof(PartialDownload);

                case SpaceOrEmptyAdll:
                    return nameof(SpaceOrEmptyAdll);

                default:
                    throw new ArgumentException(nameof(typeValue));
            }
        }
    }
}