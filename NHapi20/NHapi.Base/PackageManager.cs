namespace NHapi.Base
{
    using System.Collections.Generic;

    using NHapi.Base.Model.Configuration;

    /// <summary>   Manager for packages. </summary>
    internal class PackageManager
    {
        #region Static Fields

        /// <summary>   The instance. </summary>
        private static readonly PackageManager _instance = new PackageManager();

        #endregion

        #region Fields

        /// <summary>   The packages. </summary>
        private List<Hl7Package> _packages = new List<Hl7Package>();

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the PackageManager class. </summary>
        static PackageManager()
        {
        }

        /// <summary>
        /// Prevents a default instance of the PackageManager class from being created.
        /// </summary>

        private PackageManager()
        {
            this.LoadBaseVersions();
            this.LoadAdditionalVersions();
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets the instance. </summary>
        ///
        /// <value> The instance. </value>

        public static PackageManager Instance
        {
            get
            {
                return _instance;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Returns the package name for model elements of the given version - e.g.
        /// "NHapi.Base.Model.v24.".  This method is identical to <code>getVersionPackagePath(...)</code>
        /// except that path separators are replaced with dots.
        /// </summary>
        ///
        /// <param name="ver">  The version. </param>
        ///
        /// <returns>   The version package name. </returns>

        public static System.String GetVersionPackageName(System.String ver)
        {
            System.String path = GetVersionPackagePath(ver);
            System.String packg = path.Replace('/', '.');
            packg = packg.Replace('\\', '.');
            return packg;
        }

        /// <summary>
        /// Returns the path to the base package for model elements of the given version
        /// - e.g. "NHapi.Model.VXXX".
        /// This package should have the packages datatype, segment, group, and message under it. The
        /// path ends in with a slash.
        /// </summary>
        ///
        /// <param name="ver">  The version. </param>
        ///
        /// <returns>   The version package path. </returns>

        public static System.String GetVersionPackagePath(System.String ver)
        {
            System.Text.StringBuilder path = new System.Text.StringBuilder("NHapi.Model.V");
            char[] versionChars = new char[ver.Length];
            SupportClass.GetCharsFromString(ver, 0, ver.Length, versionChars, 0);
            for (int i = 0; i < versionChars.Length; i++)
            {
                if (versionChars[i] != '.')
                {
                    path.Append(versionChars[i]);
                }
            }
            path.Append("/");
            return path.ToString();
        }

        /// <summary>   Gets all packages. </summary>
        ///
        /// <returns>   all packages. </returns>

        public IList<Hl7Package> GetAllPackages()
        {
            return this._packages;
        }

        /// <summary>   Query if 'version' is valid version. </summary>
        ///
        /// <param name="version">  The version. </param>
        ///
        /// <returns>   true if valid version, false if not. </returns>

        public bool IsValidVersion(string version)
        {
            version = version.ToUpper().Trim();
            foreach (Hl7Package package in this._packages)
            {
                if (package.Version.ToUpper().Trim().Equals(version))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Methods

        /// <summary>   Loads additional versions. </summary>
        private void LoadAdditionalVersions()
        {
            HL7PackageConfigurationSection configSection =
                System.Configuration.ConfigurationManager.GetSection("Hl7PackageCollection") as
                    HL7PackageConfigurationSection;
            if (configSection != null)
            {
                foreach (HL7PackageElement package in configSection.Packages)
                {
                    this._packages.Insert(0, new Hl7Package(package.Name, package.Version));
                }
            }
        }

        /// <summary>   Loads base versions. </summary>
        private void LoadBaseVersions()
        {
            string[] versions = { "2.2", "2.3", "2.3.1", "2.4", "2.5", "2.5.1" };
            foreach (string version in versions)
            {
                string packageName = PackageManager.GetVersionPackageName(version);
                this._packages.Add(new Hl7Package(packageName, version));
            }
        }

        #endregion
    }
}