namespace NHapi.Base.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Abstract group item
    /// </summary>
    public class AbstractGroupItem
    {
        #region Fields

        private System.Type _class;

        private bool _isRepeating;

        private bool _isRequired;

        private string _name;

        private List<IStructure> _structures = new List<IStructure>();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="required"></param>
        /// <param name="repeating"></param>
        /// <param name="classType"></param>
        public AbstractGroupItem(string name, bool required, bool repeating, System.Type classType)
        {
            this._name = name;
            this._isRequired = required;
            this._isRepeating = repeating;
            this._class = classType;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The type of class
        /// </summary>
        public System.Type ClassType
        {
            get
            {
                return this._class;
            }
        }

        /// <summary>
        /// Is item repeating
        /// </summary>
        public bool IsRepeating
        {
            get
            {
                return this._isRepeating;
            }
        }

        /// <summary>
        /// Is item required
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return this._isRequired;
            }
        }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// The structures of the group item
        /// </summary>
        public List<IStructure> Structures
        {
            get
            {
                return this._structures;
            }
        }

        #endregion

        #region Public Indexers

        /// <summary>
        /// Structure indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
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