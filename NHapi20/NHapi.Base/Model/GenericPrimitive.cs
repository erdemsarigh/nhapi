namespace NHapi.Base.Model
{
    /// <summary>
    /// An unspecified Primitive datatype that imposes no constraints on its string value.  This is
    /// used to store Varies data, when the data type is unknown.  It is also used to store
    /// unrecognized message constituents.  
    /// </summary>

    public class GenericPrimitive : AbstractPrimitive, IPrimitive
    {
        #region Fields

        /// <summary>   The value renamed. </summary>
        internal System.String value_Renamed = null;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates a new instance of GenericPrimitive. </summary>
        ///
        /// <param name="message">  The message. </param>

        public GenericPrimitive(IMessage message)
            : base(message)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>   Returns the name of the type (used in XML encoding and profile checking) </summary>
        ///
        /// <value> The name of the type. </value>

        public override System.String TypeName
        {
            get
            {
                return "UNKNOWN";
            }
        }

        /// <summary>   Returns a String representation of the value of this field. </summary>
        /// <summary>   Sets the value of this field if the given value is legal in the context of the
        ///             implementing class. </summary>
        ///
        /// <value> The value. </value>

        public override System.String Value
        {
            get
            {
                return this.value_Renamed;
            }

            set
            {
                this.value_Renamed = value;
            }
        }

        /// <summary>   Gets the version. </summary>
        ///
        /// <value> The version. </value>
        ///
        /// <seealso cref="NHapi.Base.Model.Primitive.getVersion()"/>

        public virtual System.String Version
        {
            get
            {
                return null;
            }
        }

        #endregion
    }
}