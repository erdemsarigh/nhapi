namespace NHapi.Base.Model
{
    using System.Collections.Generic;

    /// <summary>   Abstract group item. </summary>
    public class AbstractGroupItem
    {
        #region Fields

        /// <summary>   The class. </summary>
        private System.Type _class;

        /// <summary>   true if this object is repeating. </summary>
        private bool _isRepeating;

        /// <summary>   true if this object is required. </summary>
        private bool _isRequired;

        /// <summary>   The name. </summary>
        private string _name;

        /// <summary>   The structures. </summary>
        private List<IStructure> _structures = new List<IStructure>();

        #endregion

        #region Constructors and Destructors

        /// <summary>   Constructor. </summary>
        ///
        /// <param name="name">         . </param>
        /// <param name="required">     . </param>
        /// <param name="repeating">    . </param>
        /// <param name="classType">    . </param>

        public AbstractGroupItem(string name, bool required, bool repeating, System.Type classType)
        {
            this._name = name;
            this._isRequired = required;
            this._isRepeating = repeating;
            this._class = classType;
        }

        #endregion

        #region Public Properties

        /// <summary>   The type of class. </summary>
        ///
        /// <value> The type of the class. </value>

        public System.Type ClassType
        {
            get
            {
                return this._class;
            }
        }

        /// <summary>   Is item repeating. </summary>
        ///
        /// <value> true if this object is repeating, false if not. </value>

        public bool IsRepeating
        {
            get
            {
                return this._isRepeating;
            }
        }

        /// <summary>   Is item required. </summary>
        ///
        /// <value> true if this object is required, false if not. </value>

        public bool IsRequired
        {
            get
            {
                return this._isRequired;
            }
        }

        /// <summary>   Name of the item. </summary>
        ///
        /// <value> The name. </value>

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>   The structures of the group item. </summary>
        ///
        /// <value> The structures. </value>

        public List<IStructure> Structures
        {
            get
            {
                return this._structures;
            }
        }

        #endregion

        #region Public Indexers

        /// <summary>   Structure indexer. </summary>
        ///
        /// <param name="index">    . </param>
        ///
        /// <returns>   The indexed item. </returns>

        public IStructure this[int index]
        {
            get
            {
                return this._structures[index];
            }
            set
            {
                if (index > 0 && !this._isRepeating)
                {
                    throw new HL7Exception(
                        "Cannot add multiple strucutres to " + this._name + ".  Item is non-repeating");
                }

                this._structures[index] = value;
            }
        }

        #endregion
    }
}