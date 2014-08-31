/* <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "AbstractType.java".  Description:
/// 
/// "An abstract Type that provides a default implementation of getName()" 
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
*/

namespace NHapi.Base.Model
{
    /// <summary>   An abstract Type that provides a default implementation of getName(). </summary>
    public class AbstractType : IType
    {
        #region Fields

        /// <summary>   The description. </summary>
        private string description;

        /// <summary>   The extra. </summary>
        private ExtraComponents extra;

        /// <summary>   The message. </summary>
        private IMessage message;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates a new instance of AbstractType. </summary>
        ///
        /// <param name="message">  message to which this type belongs. </param>

        public AbstractType(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>   Creates a new instance of AbstractType. </summary>
        ///
        /// <param name="message">      message to which this type belongs. </param>
        /// <param name="description">  The type description. </param>

        public AbstractType(IMessage message, string description)
        {
            this.extra = new ExtraComponents(message);
            this.description = description;
            this.message = message;
        }

        #endregion

        #region Public Properties

        /// <summary>   Return the description of the type. </summary>
        ///
        /// <value> The description. </value>

        public virtual string Description
        {
            get
            {
                return this.description;
            }
        }

        /// <summary>   Extra components. </summary>
        ///
        /// <value> The extra components. </value>

        public virtual ExtraComponents ExtraComponents
        {
            get
            {
                return this.extra;
            }
        }

        /// <summary>   Gets the message. </summary>
        ///
        /// <value> the message to which this Type belongs. </value>

        public virtual IMessage Message
        {
            get
            {
                return this.message;
            }
        }

        /// <summary>   Returns the name of the type (used in XML encoding and profile checking)   </summary>
        ///
        /// <value> The name of the type. </value>

        public virtual System.String TypeName
        {
            get
            {
                System.String longClassName = this.GetType().FullName;
                return longClassName.Substring(longClassName.LastIndexOf('.') + 1);
            }
        }

        #endregion
    }
}