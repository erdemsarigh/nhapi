namespace NHapi.Base.Model
{
    /// <summary>
    /// A set of "extra" components (sub-components) that are not a standard part of a field
    /// (component) but have been added at runtime.  The purpose is to allow processing of locally-
    /// defined extensions to datatypes without the need for a custom message definition.  
    /// Extra components are not treated uniformly with standard components (e.g. they are not
    /// accessible through methods like Primitive.getValue() and Composite.getComponent()).  To do so
    /// would blur the distinction between primitive and composite types (i.e. leaf and non-leaf
    /// nodes), which seems nice and polymorphic for a moment but actually isn't helpful.  
    /// Furthermore, the auto-generated classes do not define accessors to extra components, because
    /// they are meant to encourage and enforce use of the standard message structure -- stepping
    /// outside the standard structure must be deliberate. Note that a uniformity of access to
    /// standard and extra components is provided by Terser.
    /// </summary>

    public class ExtraComponents
    {
        #region Fields

        /// <summary>   The comps. </summary>
        private System.Collections.ArrayList comps;

        /// <summary>   The message. </summary>
        private IMessage message;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates a new instance of ExtraComponents. </summary>
        ///
        /// <param name="message">  The message. </param>

        public ExtraComponents(IMessage message)
        {
            this.comps = new System.Collections.ArrayList();
            this.message = message;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>Returns the number of existing reps of a given extra component </summary>
        /*public int numReps(int comp) {
        return ((ArrayList) this.comps.get(comp)).size();
        }*/

        /// <summary>
        /// Returns the component at the given location, creating it and all preceeding components if
        /// necessary.  
        /// </summary>
        ///
        /// <param name="comp"> the extra component number starting at 0 (i.e. 0 is the first extra
        ///                     component) </param>
        ///
        /// <returns>   The component. </returns>

        public virtual Varies getComponent(int comp)
        {
            this.ensureComponentAndPredecessorsExist(comp);
            return (Varies)this.comps[comp];
        }

        /// <summary>   Returns the number of existing extra components. </summary>
        ///
        /// <returns>   The total number of components. </returns>

        public virtual int numComponents()
        {
            return this.comps.Count;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Checks that the component at the given location exists, and that all preceding components
        /// exist, creating any missing ones.  
        /// </summary>
        ///
        /// <param name="comp"> the extra component number starting at 0 (i.e. 0 is the first extra
        ///                     component) </param>

        private void ensureComponentAndPredecessorsExist(int comp)
        {
            for (int i = this.comps.Count; i <= comp; i++)
            {
                this.comps.Add(new Varies(this.message));
            }
            /*ArrayList reps = (ArrayList) this.comps.get(comp);
            for (int j = reps.size(); j <= rep; j++) {
            addRep(comp, j);
            }*/
        }

        #endregion

        /*private void addComp(int comp) {
        }*/

        /*private void addRep(int comp, int rep) {
        ArrayList l = (ArrayList) this.comps.get(comp);
        l.add(rep, new Varies());
        }*/
    }
}