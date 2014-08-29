namespace NHapi.Base
{
    using System;

    public class ConfigurationSettings
    {
        #region Public Properties

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