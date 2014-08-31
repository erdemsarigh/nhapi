namespace NHapi.Base.Log
{
    /// <summary>   Placeholder for LogFactory to get project to compile. </summary>
    internal class LogFactory
    {
        #region Public Methods and Operators

        /// <summary>   Gets a log. </summary>
        ///
        /// <param name="classType">    Type of the class. </param>
        ///
        /// <returns>   The log. </returns>

        public static ILog GetLog(System.Type classType)
        {
            return new EntLibLogger();
        }

        /// <summary>   Gets a log. </summary>
        ///
        /// <param name="name"> The name. </param>
        ///
        /// <returns>   The log. </returns>

        public static ILog GetLog(System.String name)
        {
            return new EntLibLogger();
        }

        #endregion
    }
}