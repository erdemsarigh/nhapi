/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ValidationContextImpl.java".  Description: 
/// "A default implementation of ValidationContext." 
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
    using NHapi.Base.Model;

    /// <summary>   A default implementation of <code>ValidationContext</code>. </summary>
    public class ValidationContextImpl : IValidationContext
    {
        #region Fields

        /// <summary>   my encoding rule bindings. </summary>
        private System.Collections.IList myEncodingRuleBindings;

        /// <summary>   my message rule bindings. </summary>
        private System.Collections.IList myMessageRuleBindings;

        /// <summary>   my primitive rule bindings. </summary>
        private System.Collections.IList myPrimitiveRuleBindings;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the ValidationContextImpl class. </summary>
        public ValidationContextImpl()
        {
            this.myPrimitiveRuleBindings = new System.Collections.ArrayList(30);
            this.myMessageRuleBindings = new System.Collections.ArrayList(20);
            this.myEncodingRuleBindings = new System.Collections.ArrayList(10);
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets the encoding rule bindings. </summary>
        ///
        /// <value> a List of <code>RuleBinding</code>s for <code>EncodingRule</code>s. </value>

        public virtual System.Collections.IList EncodingRuleBindings
        {
            get
            {
                return this.myEncodingRuleBindings;
            }

            //    /**
            //     * @see NHapi.Base.validation.ValidationContext#getCheckPrimitivesOnSet()
            //     */
            //    public boolean getCheckPrimitivesOnSet() {
            //        return myCheckPrimitivesFlag;
            //    }
            //
            //    /**
            //     * @see NHapi.Base.validation.ValidationContext#setCheckPrimitivesOnSet(boolean)
            //     */
            //    public void setCheckPrimitivesOnSet(boolean check) {
            //        myCheckPrimitivesFlag = check;
            //    }
        }

        /// <summary>   Gets the message rule bindings. </summary>
        ///
        /// <value> a List of <code>RuleBinding</code>s for <code>MessageRule</code>s. </value>

        public virtual System.Collections.IList MessageRuleBindings
        {
            get
            {
                return this.myMessageRuleBindings;
            }
        }

        /// <summary>   Gets the primitive rule bindings. </summary>
        ///
        /// <value> a List of <code>RuleBinding</code>s for <code>PrimitiveTypeRule</code>s. </value>

        public virtual System.Collections.IList PrimitiveRuleBindings
        {
            get
            {
                return this.myPrimitiveRuleBindings;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Gets encoding rules. </summary>
        ///
        /// <exception cref="InvalidCastException"> Thrown when an object cannot be cast to a required
        ///                                         type. </exception>
        ///
        /// <param name="theVersion">   the version. </param>
        /// <param name="theEncoding">  the encoding. </param>
        ///
        /// <returns>   the active encoding rules that apply to the given version and encoding. </returns>

        public virtual IEncodingRule[] getEncodingRules(System.String theVersion, System.String theEncoding)
        {
            System.Collections.IList active = new System.Collections.ArrayList(this.myEncodingRuleBindings.Count);
            for (int i = 0; i < this.myEncodingRuleBindings.Count; i++)
            {
                System.Object o = this.myEncodingRuleBindings[i];
                if (!(o is RuleBinding))
                {
                    throw new System.InvalidCastException("Item in rule binding list is not a RuleBinding");
                }

                RuleBinding binding = (RuleBinding)o;
                if (binding.Active && binding.appliesToVersion(theVersion) && binding.appliesToScope(theEncoding))
                {
                    active.Add(binding.Rule);
                }
            }
            return (IEncodingRule[])SupportClass.ICollectionSupport.ToArray(active, new IEncodingRule[0]);
        }

        /// <summary>   Gets message rules. </summary>
        ///
        /// <exception cref="InvalidCastException"> Thrown when an object cannot be cast to a required
        ///                                         type. </exception>
        ///
        /// <param name="theVersion">       the version. </param>
        /// <param name="theMessageType">   Type of the message. </param>
        /// <param name="theTriggerEvent">  the trigger event. </param>
        ///
        /// <returns>
        /// the active rules that apply to message of the given version, message type, and trigger event.
        /// </returns>

        public virtual IMessageRule[] getMessageRules(
            System.String theVersion,
            System.String theMessageType,
            System.String theTriggerEvent)
        {
            System.Collections.IList active = new System.Collections.ArrayList(this.myMessageRuleBindings.Count);
            for (int i = 0; i < this.myMessageRuleBindings.Count; i++)
            {
                System.Object o = this.myMessageRuleBindings[i];
                if (!(o is RuleBinding))
                {
                    throw new System.InvalidCastException("Item in rule binding list is not a RuleBinding");
                }

                RuleBinding binding = (RuleBinding)o;
                if (binding.Active && binding.appliesToVersion(theVersion)
                    && binding.appliesToScope(theMessageType + "^" + theTriggerEvent))
                {
                    active.Add(binding.Rule);
                }
            }
            return (IMessageRule[])SupportClass.ICollectionSupport.ToArray(active, new IMessageRule[0]);
        }

        /// <summary>   Gets primitive rules. </summary>
        ///
        /// <exception cref="InvalidCastException"> Thrown when an object cannot be cast to a required
        ///                                         type. </exception>
        ///
        /// <param name="theVersion">   the version. </param>
        /// <param name="theTypeName">  Name of the type. </param>
        /// <param name="theType">      Type of the. </param>
        ///
        /// <returns>   active rules for checking the given type in the given version. </returns>

        public virtual IPrimitiveTypeRule[] getPrimitiveRules(
            System.String theVersion,
            System.String theTypeName,
            IPrimitive theType)
        {
            System.Collections.IList active = new System.Collections.ArrayList(this.myPrimitiveRuleBindings.Count);
            for (int i = 0; i < this.myPrimitiveRuleBindings.Count; i++)
            {
                System.Object o = this.myPrimitiveRuleBindings[i];
                if (!(o is RuleBinding))
                {
                    throw new System.InvalidCastException("Item in rule binding list is not a RuleBinding");
                }

                RuleBinding binding = (RuleBinding)o;
                if (binding.Active && binding.appliesToVersion(theVersion) && binding.appliesToScope(theTypeName))
                {
                    active.Add(binding.Rule);
                }
            }
            return (IPrimitiveTypeRule[])SupportClass.ICollectionSupport.ToArray(active, new IPrimitiveTypeRule[0]);
        }

        #endregion
    }
}