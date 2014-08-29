/// <summary> This class is based on the Iterators.FilterIterator class from
/// araSpect (araspect.sourceforge.net).  The original copyright follows ...
/// 
/// =================================================================
/// Copyright (c) 2001,2002 aragost ag, Zürich, Switzerland.
/// All rights reserved.
/// 
/// This software is provided 'as-is', without any express or implied
/// warranty. In no event will the authors be held liable for any
/// damages arising from the use of this software.
/// 
/// Permission is granted to anyone to use this software for any
/// purpose, including commercial applications, and to alter it and
/// redistribute it freely, subject to the following restrictions:
/// 
/// 1. The origin of this software must not be misrepresented; you
/// must not claim that you wrote the original software. If you
/// use this software in a product, an acknowledgment in the
/// product documentation would be appreciated but is not required.
/// 
/// 2. Altered source versions must be plainly marked as such, and
/// must not be misrepresented as being the original software.
/// 
/// 3. This notice may not be removed or altered from any source
/// distribution.
/// 
/// ==================================================================
/// 
/// Changes (c) 2003 University Health Network include the following:
/// - move to non-nested class
/// - collapse inherited method remove()
/// - accept iterator instead of object in constructor
/// - moved to HAPI package
/// - Predicate added as an inner class; also changed to an interface
/// 
/// These changes are distributed under the same terms as the original (above). 
/// </summary>

namespace NHapi.Base.Util
{
    /// <summary>
    /// Filter iterator class
    /// </summary>
    public class FilterIterator : System.Collections.IEnumerator
    {
        #region Fields

        private System.Collections.IEnumerator iter;

        private System.Object nextObject;

        private bool nextObjectSet;

        private FilterIterator.IPredicate predicate;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="iter"></param>
        /// <param name="predicate"></param>
        public FilterIterator(System.Collections.IEnumerator iter, FilterIterator.IPredicate predicate)
        {
            this.iter = iter;
            this.predicate = predicate;
        }

        #endregion

        #region Interfaces

        /// <summary>
        /// IPredicate interface
        /// </summary>
        public interface IPredicate
        {
            #region Public Methods and Operators

            /// <summary>
            /// Evaluate the object
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            bool evaluate(System.Object obj);

            #endregion
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The current item
        /// </summary>
        public virtual System.Object Current
        {
            get
            {
                if (!this.nextObjectSet)
                {
                    if (!this.setNextObject())
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                this.nextObjectSet = false;
                return this.nextObject;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Move next
        /// </summary>
        /// <returns></returns>
        public virtual bool MoveNext()
        {
            if (this.nextObjectSet)
            {
                return true;
            }
            return this.setNextObject();
        }

        /// <summary>
        /// Reset
        /// </summary>
        public virtual void Reset()
        {
        }

        /// <summary>Throws UnsupportedOperationException </summary>
        public virtual void remove()
        {
            throw new System.NotSupportedException();
        }

        #endregion

        #region Methods

        /// <summary> Set nextObject to the next object. If there are no more
        /// objects then return false. Otherwise, return true.
        /// </summary>
        private bool setNextObject()
        {
            while (this.iter.MoveNext())
            {
                System.Object object_Renamed = this.iter.Current;
                if (this.predicate.evaluate(object_Renamed))
                {
                    this.nextObject = object_Renamed;
                    this.nextObjectSet = true;
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}