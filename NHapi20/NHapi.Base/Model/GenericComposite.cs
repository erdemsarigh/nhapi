namespace NHapi.Base.Model
{
    /// <summary> An unspecified Composite datatype that has an undefined number of components, each 
    /// of which is a Varies.  
    /// This is used to store Varies data, when the data type is unknown.  It is also 
    /// used to store unrecognized message constituents.  
    /// </summary>
    /// <author>  Bryan Tripp
    /// </author>
    public class GenericComposite : AbstractType, IComposite
    {
        #region Fields

        private System.Collections.ArrayList components;

        private IMessage message;

        #endregion

        #region Constructors and Destructors

        /// <summary>Creates a new instance of GenericComposite </summary>
        public GenericComposite(IMessage message)
            : base(message)
        {
            this.message = message;
            this.components = new System.Collections.ArrayList(20);
        }

        #endregion

        #region Public Properties

        /// <summary> Returns an array containing the components of this field.</summary>
        public virtual IType[] Components
        {
            get
            {
                IType[] ret = new IType[this.components.Count];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (IType)this.components[i];
                }
                return ret;
            }
        }

        /// <summary>Returns the name of the type (used in XML encoding and profile checking)  </summary>
        public override System.String TypeName
        {
            get
            {
                return "UNKNOWN";
            }
        }

        #endregion

        #region Public Indexers

        /// <summary> Returns the single component of this composite at the specified position (starting at 0) - 
        /// Creates it (and any nonexistent components before it) if necessary.  
        /// </summary>
        public virtual IType this[int index]
        {
            get
            {
                for (int i = this.components.Count; i <= index; i++)
                {
                    this.components.Add(new Varies(this.message));
                }
                return (IType)this.components[index];
            }
        }

        #endregion
    }
}