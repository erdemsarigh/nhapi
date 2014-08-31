/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "SizeRule.java".  Description: 
/// "Checks that Primitive values conform to a certain size limit" 
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
    /// <summary>   Checks that Primitive values conform to a certain size limit.   </summary>
    public class SizeRule : IPrimitiveTypeRule
    {
        #region Fields

        /// <summary>   my maximum characters. </summary>
        private int myMaxChars;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the SizeRule class. </summary>
        ///
        /// <param name="theMaxChars">  the maximum number of characters this rule allows in a primitive
        ///                             value. </param>

        public SizeRule(int theMaxChars)
        {
            this.myMaxChars = theMaxChars;
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets the description. </summary>
        ///
        /// <value> The description. </value>
        ///
        /// <seealso cref="NHapi.Base.validation.Rule.getDescription()"/>

        public virtual System.String Description
        {
            get
            {
                return "Maxumim size <= " + this.myMaxChars + " characters";
            }
        }

        /// <summary>   Gets the section reference. </summary>
        ///
        /// <value> The section reference. </value>
        ///
        /// <seealso cref="NHapi.Base.validation.Rule.getSectionReference()"/>

        public virtual System.String SectionReference
        {
            get
            {
                return null;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Does nothing.  If what you wanted was to trim the value to the max size, you should make a
        /// separate rule for that.  
        /// </summary>
        ///
        /// <param name="value_Renamed">    The value renamed. </param>
        ///
        /// <returns>   A System.String. </returns>
        ///
        /// <seealso cref="NHapi.Base.validation.PrimitiveTypeRule.correct(java.lang.String)"/>

        public virtual System.String correct(System.String value_Renamed)
        {
            return value_Renamed;
        }

        /// <summary>   Tests the given value renamed. </summary>
        ///
        /// <param name="value_Renamed">    The value renamed. </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>
        ///
        /// <seealso cref="NHapi.Base.validation.PrimitiveTypeRule.test(java.lang.String)"/>

        public virtual bool test(System.String value_Renamed)
        {
            bool ok = true;
            if (value_Renamed != null && value_Renamed.Length > this.myMaxChars)
            {
                ok = false;
            }
            return ok;
        }

        #endregion
    }
}