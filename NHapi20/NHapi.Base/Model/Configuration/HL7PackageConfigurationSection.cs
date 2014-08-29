namespace NHapi.Base.Model.Configuration
{
    using System;
    using System.Configuration;

    public class HL7PackageConfigurationSection : ConfigurationSection
    {
        #region Public Properties

        [ConfigurationProperty("", IsDefaultCollection = true)]
        public HL7PackageCollection Packages
        {
            get
            {
                return (HL7PackageCollection)this[""];
            }
        }

        #endregion
    }

    public class HL7PackageCollection : ConfigurationElementCollection
    {
        #region Public Properties

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        #endregion

        #region Properties

        protected override string ElementName
        {
            get
            {
                return "HL7Package";
            }
        }

        #endregion

        #region Methods

        protected override ConfigurationElement CreateNewElement()
        {
            return new HL7PackageElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            if ((element) is HL7PackageElement)
            {
                HL7PackageElement el = (HL7PackageElement)element;

                return el.Name;
            }

            throw new ArgumentException("The specified element is not of the correct type.");
        }

        #endregion
    }

    public class HL7PackageElement : ConfigurationElement
    {
        #region Public Properties

        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return this["name"].ToString();
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("version", IsKey = true, IsRequired = true)]
        public string Version
        {
            get
            {
                return this["version"].ToString();
            }
            set
            {
                this["version"] = value;
            }
        }

        #endregion
    }
}