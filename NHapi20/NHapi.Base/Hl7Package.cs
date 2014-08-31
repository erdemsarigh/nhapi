namespace NHapi.Base
{
    /// <summary>   A hl 7 package. </summary>
    internal class Hl7Package
    {
        #region Fields

        /// <summary>   Name of the package. </summary>
        private string _packageName;

        /// <summary>   The version. </summary>
        private string _version;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the Hl7Package class. </summary>
        ///
        /// <param name="packageName">  The name of the package. </param>
        /// <param name="version">      The version. </param>

        public Hl7Package(string packageName, string version)
        {
            this._version = version;
            this._packageName = packageName;
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets the name of the event mapping resource. </summary>
        ///
        /// <value> The name of the event mapping resource. </value>

        public string EventMappingResourceName
        {
            get
            {
                return this._packageName + ".EventMapping.EventMap.properties";
            }
        }

        /// <summary>   Gets the name of the package. </summary>
        ///
        /// <value> The name of the package. </value>

        public string PackageName
        {
            get
            {
                return this._packageName;
            }
        }

        /// <summary>   Gets or sets the version. </summary>
        ///
        /// <value> The version. </value>

        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        #endregion
    }
}