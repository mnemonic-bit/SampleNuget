namespace SampleNuget
{
    /// <summary>
    /// Represents a pingable instance
    /// </summary>
    public sealed class Pingable
    {

        /// <summary>
        /// Returns the platform this library is referenced from.
        /// </summary>
        public string PlatformName
        {
            get
            {
#if NET8_0
                return ".NET 8";
#elif NET6_0
                return ".NET 6";
#elif NETSTANDARD2_0
                return ".NET Standard";
#else
                return "sdf";
#endif
            }
        }

        /// <summary>
        /// Returns true as kind of alive-sign.
        /// </summary>
        /// <returns></returns>
        public bool Pong()
        {
            return true;
        }
    }
}

