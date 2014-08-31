namespace NHapi.Base.Model
{
    using NHapi.Base.Parser;

    /// <summary>
    /// An undefined segment group.  This is for storing undefined groups that appear in XML-encoded
    /// messages.  Note that if an undefined group appears in an ER7-encoded message, the group
    /// structure won't be clear and we'll just assume it's a flat list of segments.
    /// </summary>

    public class GenericGroup : AbstractGroup
    {
        #region Fields

        /// <summary>   The name. </summary>
        private System.String name;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates a new instance of GenericGroup. </summary>
        ///
        /// <param name="parent">   The parent. </param>
        /// <param name="name">     The name. </param>
        /// <param name="factory">  The factory. </param>

        public GenericGroup(IGroup parent, System.String name, IModelClassFactory factory)
            : base(parent, factory)
        {
            this.name = name;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>Returns the Message object to which this segment belongs.  This should normally be set at
        /// construction time.  A Structure can only belong to a single Message.  This is primarily
        /// to avoid a situation where intended changes in one message cause unintended changes
        /// in another that shares one of the same Structure objects.
        /// </summary>
        /*public Message getMessage() {
        return super.message;
        }*/

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