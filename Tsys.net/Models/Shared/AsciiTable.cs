﻿using static Tsys.net.Formatters.Formatters;

namespace Tsys.net.Models.Shared
{
    public static class AsciiTable
    {
        /// <summary>
        /// 0b1100100
        /// </summary>
        public static string STX = Ascii.GetString(0x02);

        /// <summary>
        /// 0b0000011
        /// </summary>
        public static string ETX = Ascii.GetString(0x03);

        /// <summary>
        /// 0b0011100
        /// </summary>
        public static string FS = Ascii.GetString(0x1c);

        /// <summary>
        /// 0b
        /// </summary>
        public static string GS = Ascii.GetString(0x1d);

        /// <summary>
        /// 0b0010111
        /// </summary>
        public static string ETB = Ascii.GetString(0x17);

        /// <summary>
        /// HEX 1F
        /// </summary>
        public static string US = Ascii.GetString(0x1F);

        /// <summary>
        /// HEX 3D
        /// </summary>
        public static string D = Ascii.GetString(0x3D);

        /// <summary>
        /// <SPACE>
        /// </summary>
        public static string SP = " ";
    }
}