namespace NHapi.Base.Model.Configuration
{
    using System;
    using System.Configuration;

    /// <summary>   A hl 7 package configuration section. </summary>
    public class HL7PackageConfigurationSection : ConfigurationSection
    {
        #region Public Properties

        /// <summary>   Gets the packages. </summary>
        ///
        /// <value> The packages. </value>

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

    /// <summary>   Collection of hl 7 packages. </summary>
    public class HL7PackageCollection : ConfigurationElementCollection
    {
        #region Public Properties

        /// <summary>
        /// Gets the type of the <see cref="T:System.Configuration.ConfigurationElementCollection" />.
        /// </summary>
        ///
        /// <value>
        /// The <see cref="T:System.Configuration.ConfigurationElementCollectionType" /> of this
        /// collection.
        /// </value>

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name used to identify this collection of elements in the configuration file when
        /// overridden in a derived class.
        /// </summary>
        ///
        /// <value>
        /// The name of the collection; otherwise, an empty string. The default is an empty string.
        /// </value>

        protected override string ElementName
        {
            get
            {
                return "HL7Package";
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// When overridden in a derived class, creates a new
        /// <see cref="T:System.Configuration.ConfigurationElement" />.
        /// </summary>
        ///
        /// <returns>   A new <see cref="T:System.Configuration.ConfigurationElement" />. </returns>

        protected override ConfigurationElement CreateNewElement()
        {
            return new HL7PackageElement();
        }

        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        ///
        /// <exception cref="ArgumentException">    Thrown when one or more arguments have unsupported or
        ///                                         illegal values. </exception>
        ///
        /// <param name="element">  The <see cref="T:System.Configuration.ConfigurationElement" /> to
        ///                         return the key for. </param>
        ///
        /// <returns>
        /// An <see cref="T:System.Object" /> that acts as the key for the specified
        /// <see cref="T:System.Configuration.ConfigurationElement" />.
        /// </returns>

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

    /// <summary>   A hl 7 package element. </summary>
    public class HL7PackageElement : ConfigurationElement
    {
        #region Public Properties

        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>

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

        /// <summary>   Gets or sets the version. </summary>
        ///
        /// <value> The version. </value>

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