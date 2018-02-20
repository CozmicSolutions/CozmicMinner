namespace CozmicMinner
{
    internal class ServerAddressGenerator
    {
        #region Private Fields

        private static string AddressTemplate = "{0}.{1}.org:{2}";

        #endregion Private Fields

        // "eu1.ethermine.org:4444";
        #region Public Methods

        public static string PopulateAddress(Regions reg, int port)
        {
            return string.Format(AddressTemplate, reg.ToString(), TextStatic.HostAddress, port);
        }

        #endregion Public Methods
    }
}