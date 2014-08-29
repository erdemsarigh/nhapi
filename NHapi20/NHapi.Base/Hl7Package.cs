namespace NHapi.Base
{
    internal class Hl7Package
    {
        #region Fields

        private string _packageName;

        private string _version;

        #endregion

        #region Constructors and Destructors

        public Hl7Package(string packageName, string version)
        {
            this._version = version;
            this._packageName = packageName;
        }

        #endregion

        #region Public Properties

        public string EventMappingResourceName
        {
            get
            {
                return this._packageName + ".EventMapping.EventMap.properties";
            }
        }

        public string PackageName
        {
            get
            {
                return this._packageName;
            }
        }

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