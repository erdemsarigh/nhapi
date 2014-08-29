namespace NHapi.Base
{
    using System.Collections.Generic;

    internal class EventMapper
    {
        #region Static Fields

        private static readonly EventMapper _instance = new EventMapper();

        #endregion

        #region Fields

        private System.Collections.Hashtable _map = new System.Collections.Hashtable();

        #endregion

        #region Constructors and Destructors

        static EventMapper()
        {
        }

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

        public static EventMapper Instance
        {
            get
            {
                return _instance;
            }
        }

        public System.Collections.Hashtable Maps
        {
            get
            {
                return this._map;
            }
        }

        #endregion

        #region Methods

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