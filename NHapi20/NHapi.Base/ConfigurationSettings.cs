namespace NHapi.Base
{
    using System;

    /// <summary>   A configuration settings. </summary>
    public class ConfigurationSettings
    {
        #region Public Properties

        /// <summary>   Gets the connection string. </summary>
        ///
        /// <value> The connection string. </value>

        public static string ConnectionString
        {
            get
            {
                string conn = "";
                string connFromConfig = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
                if (connFromConfig != null && connFromConfig.Length > 0)
                {
                    conn = connFromConfig;
                }
                return conn;
            }
        }

        /// <summary>   Gets a value indicating whether this object use factory. </summary>
        ///
        /// <value> true if use factory, false if not. </value>

        public static bool UseFactory
        {
            get
            {
                bool useFactory = false;
                string useFactoryFromConfig = System.Configuration.ConfigurationManager.AppSettings["UseFactory"];
                if (useFactoryFromConfig != null && useFactoryFromConfig.Length > 0)
                {
                    useFactory = Convert.ToBoolean(useFactoryFromConfig);
                }
                return useFactory;
            }
        }

        #endregion
    }
}