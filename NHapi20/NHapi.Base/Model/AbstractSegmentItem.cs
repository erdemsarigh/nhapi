namespace NHapi.Base.Model
{
    using System.Collections.Generic;

    /// <summary>   An abstract segment item. </summary>
    internal class AbstractSegmentItem
    {
        #region Fields

        /// <summary>   The arguments. </summary>
        private List<object> _args = new List<object>();

        /// <summary>   The description. </summary>
        private string _description;

        /// <summary>   The fields. </summary>
        private List<IType> _fields = new List<IType>();

        /// <summary>   The length. </summary>
        private int _length = 0;

        /// <summary>   The maximum reps. </summary>
        private int _maxReps = -1;

        /// <summary>   true if required. </summary>
        private bool _required;

        /// <summary>   The type. </summary>
        private System.Type _type;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Constructor. </summary>
        ///
        /// <param name="t">                the class of the data for this field - this should inherit
        ///                                 from IType. </param>
        /// <param name="required">         whether a value for this field is required in order for the
        ///                                 segment to be valid. </param>
        /// <param name="maxReps">          the maximum number of repetitions - 0 implies that there is
        ///                                 no limit. </param>
        /// <param name="length">           the maximum length of each repetition of the field (in
        ///                                 characters) </param>
        /// <param name="constructorArgs">  an array of objects that will be used as constructor
        ///                                 arguments if new instances of this class are created (use
        ///                                 null for zero-arg constructor) </param>

        public AbstractSegmentItem(
            System.Type t,
            bool required,
            int maxReps,
            int length,
            System.Object[] constructorArgs)
            : this(t, required, maxReps, length, constructorArgs, string.Empty)
        {
        }

        /// <summary>   Constructor. </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="t">                the class of the data for this field - this should inherit
        ///                                 from IType. </param>
        /// <param name="required">         whether a value for this field is required in order for the
        ///                                 segment to be valid. </param>
        /// <param name="maxReps">          the maximum number of repetitions - 0 implies that there is
        ///                                 no limit. </param>
        /// <param name="length">           the maximum length of each repetition of the field (in
        ///                                 characters) </param>
        /// <param name="constructorArgs">  an array of objects that will be used as constructor
        ///                                 arguments if new instances of this class are created (use
        ///                                 null for zero-arg constructor) </param>
        /// <param name="description">      Description of the segment. </param>

        public AbstractSegmentItem(
            System.Type t,
            bool required,
            int maxReps,
            int length,
            System.Object[] constructorArgs,
            string description)
        {
            if (!typeof(IType).IsAssignableFrom(t))
            {
                throw new HL7Exception(
                    "Class " + t.FullName + " does not inherit from " + "NHapi.Base.Model.IType",
                    HL7Exception.APPLICATION_INTERNAL_ERROR);
            }

            this._type = t;
            this._required = required;
            this._maxReps = maxReps;
            if (constructorArgs != null)
            {
                this._args.AddRange(constructorArgs);
            }
            this._description = description;
        }

        #endregion

        #region Public Properties

        /// <summary>   Arguments to pass to a constructor for this field. </summary>
        ///
        /// <value> The arguments. </value>

        public object[] Args
        {
            get
            {
                return this._args.ToArray();
            }
        }

        /// <summary>   What is this field. </summary>
        ///
        /// <value> The description. </value>

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        /// <summary>   The IType of this field in the segment. </summary>
        ///
        /// <value> The type of the field. </value>

        public System.Type FieldType
        {
            get
            {
                return this._type;
            }
        }

        /// <summary>   Gets the fields. </summary>
        ///
        /// <value> The fields. </value>

        public IList<IType> Fields
        {
            get
            {
                return this._fields;
            }
        }

        /// <summary>   Is this a required field. </summary>
        ///
        /// <value> true if this object is required, false if not. </value>

        public bool IsRequired
        {
            get
            {
                return this._required;
            }
        }

        /// <summary>   What is the length in characters of the field. </summary>
        ///
        /// <value> The length. </value>

        public int Length
        {
            get
            {
                return this._length;
            }
        }

        /// <summary>   Maximum number of repetitions of this field. </summary>
        ///
        /// <value> The maximum repetitions. </value>

        public int MaxRepetitions
        {
            get
            {
                if (this._maxReps <= 0)
                {
                    return int.MaxValue;
                }
                return this._maxReps;
            }
            set
            {
                this._maxReps = value;
            }
        }

        #endregion

        #region Public Indexers

        /// <summary>   Return a specific repetition of this field. </summary>
        ///
        /// <param name="index">    . </param>
        ///
        /// <returns>   The indexed item. </returns>

        public IType this[int index]
        {
            get
            {
                return this._fields[index];
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Gets all fields as i type array. </summary>
        ///
        /// <returns>   An array of i type. </returns>

        public IType[] GetAllFieldsAsITypeArray()
        {
            IType[] fields = new IType[this._fields.Count];
            int i = 0;
            foreach (IType type in this._fields)
            {
                fields[i++] = type;
            }
            return fields;
        }

        #endregion
    }
}