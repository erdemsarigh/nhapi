namespace NHapi.Base.Log
{
    /// <summary>
    /// Placeholder for LogFactory to get project to compile.
    /// </summary>
    internal class LogFactory
    {
        #region Public Methods and Operators

        public static ILog GetLog(System.Type classType)
        {
            return new EntLibLogger();
        }

        public static ILog GetLog(System.String name)
        {
            return new EntLibLogger();
        }

        #endregion
    }
}