namespace NHapi.Base.Model
{
    /// <summary>
    /// An unspecified segment that has an undefined number of fields, each of which is a Varies.
    /// The primary intended use is to store data from Z segments.  More precisely, any unknown
    /// segment that is encountered during parsing will be handled with this class.  This includes
    /// segments that do not start with Z but nevertheless do not appear in the stated version of
    /// HL7.  Also, this class is not used to handle Z segments that have been explicitly defined and
    /// declared (see Parser.PackageList() ).  
    /// </summary>

    public class GenericSegment : AbstractSegment
    {
        #region Fields

        /// <summary>   The name. </summary>
        private System.String name;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates a new instance of GenericSegment. </summary>
        ///
        /// <param name="parent">   The parent. </param>
        /// <param name="name">     The name. </param>

        public GenericSegment(IGroup parent, System.String name)
            : base(parent, null)
        {
            this.name = name;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Returns the name specified at construction time. </summary>
        ///
        /// <returns>   The structure name. </returns>
        ///
        /// <seealso cref="Structure.getName()"/>

        public override System.String GetStructureName()
        {
            return this.name;
        }

        #endregion
    }
}