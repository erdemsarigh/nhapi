namespace NHapi.Base
{
    using System.Collections.Generic;

    /// <summary>   An event mapper. </summary>
    internal class EventMapper
    {
        #region Static Fields

        /// <summary>   The instance. </summary>
        private static readonly EventMapper _instance = new EventMapper();

        #endregion

        #region Fields

        /// <summary>   The map. </summary>
        private System.Collections.Hashtable _map = new System.Collections.Hashtable();

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the EventMapper class. </summary>
        static EventMapper()
        {
        }

        /// <summary>
        /// Prevents a default instance of the EventMapper class from being created.
        /// </summary>

        private EventMapper()
        {
            IList<Hl7Package> packages = PackageManager.Instance.GetAllPackages();
            foreach (Hl7Package package in packages)
            {
                System.Reflection.Assembly assembly = null;
                try
                {
                    assembly = System.Reflection.Assembly.Load(package.PackageName);
                }
                catch (System.IO.FileNotFoundException)
                {
                    //Just skip, this assembly is not used
                }

                System.Collections.Specialized.NameValueCollection structures =
                    new System.Collections.Specialized.NameValueCollection();
                if (assembly != null)
                {
                    structures = this.GetAssemblyEventMapping(assembly, package);
                }
                this._map[package.Version] = structures;
            }
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets the instance. </summary>
        ///
        /// <value> The instance. </value>

        public static EventMapper Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>   Gets the maps. </summary>
        ///
        /// <value> The maps. </value>

        public System.Collections.Hashtable Maps
        {
            get
            {
                return this._map;
            }
        }

        #endregion

        #region Methods

        /// <summary>   Gets assembly event mapping. </summary>
        ///
        /// <param name="assembly"> The assembly. </param>
        /// <param name="package">  The package. </param>
        ///
        /// <returns>   The assembly event mapping. </returns>

        private System.Collections.Specialized.NameValueCollection GetAssemblyEventMapping(
            System.Reflection.Assembly assembly,
            Hl7Package package)
        {
            System.Collections.Specialized.NameValueCollection structures =
                new System.Collections.Specialized.NameValueCollection();
            using (System.IO.Stream inResource = assembly.GetManifestResourceStream(package.EventMappingResourceName))
            {
                if (inResource != null)
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(inResource))
                    {
                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            if ((line.Length > 0) && ('#' != line[0]))
                            {
                                string[] lineElements = line.Split(' ', '\t');
                                structures.Add(lineElements[0], lineElements[1]);
                            }
                            line = sr.ReadLine();
                        }
                    }
                }
            }
            return structures;
        }

        #endregion
    }
}