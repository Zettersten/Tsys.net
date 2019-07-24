namespace Tsys.net.Formatters
{
    /// <summary>
    ///   Convenience class containing formatters
    /// </summary>
    public static class Formatters
    {
        /// <summary>
        ///   Get an ASCII Formatter
        /// </summary>
        public static IFormatter Ascii
        {
            get { return new AsciiFormatter(); }
        }
    }
}