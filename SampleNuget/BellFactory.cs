namespace SampleNuget
{
    /// <summary>
    /// A factory which creates new instances of <see cref="IPingable"/>.
    /// </summary>
    public sealed class BellFactory
    {

        /// <summary>
        /// Creates a new instance which implements the <see cref="IPingable"/> interface.
        /// </summary>
        /// <returns></returns>
        public static IPingable CreatePingable()
        {
            return new Pingable();
        }

    }
}
