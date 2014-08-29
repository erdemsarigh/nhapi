/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "RuleBinding.java".  Description: 
/// "An association between a type of item to be validated (eg a datatype or message) and a validation Rule." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2004.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>

namespace NHapi.Base.validation.impl
{
    /// <summary> An association between a type of item to be validated (eg a datatype or 
    /// message) and a validation <code>Rule</code>.  
    /// 
    /// </summary>
    /// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
    /// </author>
    /// <version>  $Revision: 1.3 $ updated on $Date: 2005/06/14 20:16:01 $ by $Author: bryan_tripp $
    /// </version>
    public class RuleBinding
    {
        #region Fields

        private bool myActiveFlag;

        private IRule myRule;

        private System.String myScope;

        private System.String myVersion;

        #endregion

        #region Constructors and Destructors

        /// <summary> Active by default.  
        /// 
        /// </summary>
        /// <param name="theVersion">see {@link #getVersion()}
        /// </param>
        /// <param name="theScope">see {@link #getScope()}
        /// </param>
        /// <param name="theRule">see {@link #getRule()}
        /// </param>
        public RuleBinding(System.String theVersion, System.String theScope, IRule theRule)
        {
            this.myActiveFlag = true;
            this.myVersion = theVersion;
            this.myScope = theScope;
            this.myRule = theRule;
        }

        #endregion

        #region Public Properties

        /// <returns> true if the binding is currently active
        /// </returns>
        /// <param name="isActive">true if the binding is currently active
        /// </param>
        public virtual bool Active
        {
            get
            {
                return this.myActiveFlag;
            }

            set
            {
                this.myActiveFlag = value;
            }
        }

        /// <returns> a <code>Rule</code> that applies to the associated version and scope
        /// </returns>
        public virtual IRule Rule
        {
            get
            {
                return this.myRule;
            }
        }

        /// <returns> the scope of item types to which the rule applies.  For <code>MessageRule</code>s
        /// this is the message type and trigger event, separated by a ^ (either value may be *, meaning 
        /// any).  For <code>PrimitiveTypeRule</code>s this is the datatype name (* means any).  For 
        /// <code>EncodingRule</code>s this is the encoding name (again, * means any).   
        /// </returns>
        public virtual System.String Scope
        {
            get
            {
                return this.myScope;
            }
        }

        /// <returns> the version to which the binding applies (* means all versions)
        /// </returns>
        public virtual System.String Version
        {
            get
            {
                return this.myVersion;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <param name="theType">an item description to be checked against getScope()  
        /// </param>
        /// <returns> true if the given type is within scope, ie if it matches getScope() or getScope() is * 
        /// </returns>
        public virtual bool appliesToScope(System.String theType)
        {
            return this.applies(this.Scope, theType);
        }

        /// <param name="theVersion">an HL7 version
        /// </param>
        /// <returns> true if this binding applies to the given version (ie getVersion() matches or is *)  
        /// </returns>
        public virtual bool appliesToVersion(System.String theVersion)
        {
            return this.applies(this.Version, theVersion);
        }

        #endregion

        #region Methods

        /// <summary> An abstraction of appliesToVersion() and appliesToScope(). 
        /// 
        /// </summary>
        /// <param name="theBindingData">
        /// </param>
        /// <param name="theItemData">
        /// </param>
        /// <returns>
        /// </returns>
        protected internal virtual bool applies(System.String theBindingData, System.String theItemData)
        {
            bool applies = false;
            if (theBindingData.Equals(theItemData) || theBindingData.Equals("*"))
            {
                applies = true;
            }
            return applies;
        }

        #endregion
    }
}