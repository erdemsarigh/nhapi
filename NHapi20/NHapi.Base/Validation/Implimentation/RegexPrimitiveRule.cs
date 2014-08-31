/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "RegexPrimitiveRule.java".  Description: 
/// "A PrimitiveTypeRule that validates primitive values using a regular expression" 
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
    using System.Text.RegularExpressions;

    /// <summary>
    /// A <code>PrimitiveTypeRule</code> that validates primitive values using a regular expression.  
    /// </summary>

    public class RegexPrimitiveRule : IPrimitiveTypeRule
    {
        #region Fields

        /// <summary>   A pattern specifying my. </summary>
        private System.Text.RegularExpressions.Regex myPattern;

        /// <summary>   my section reference. </summary>
        private System.String mySectionReference;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the RegexPrimitiveRule class. </summary>
        ///
        /// <param name="theRegex">             a regular expression against which to validate primitive
        ///                                     values. </param>
        /// <param name="theSectionReference">  to be returned by <code>getSectionReference()</code> </param>

        public RegexPrimitiveRule(System.String theRegex, System.String theSectionReference)
        {
            this.myPattern = new Regex(theRegex);
            this.mySectionReference = theSectionReference;
        }

        #endregion

        #region Public Properties

        /// <summary>   The description. </summary>
        ///
        /// <value> The description. </value>

        public virtual System.String Description
        {
            get
            {
                return "Matches the regular expression " + this.myPattern;
            }
        }

        /// <summary>   The section reference. </summary>
        ///
        /// <value> The section reference. </value>

        public virtual System.String SectionReference
        {
            get
            {
                return this.mySectionReference;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Is this rule correct. </summary>
        ///
        /// <param name="value_Renamed">    . </param>
        ///
        /// <returns>   A System.String. </returns>

        public virtual System.String correct(System.String value_Renamed)
        {
            return value_Renamed;
        }

        /// <summary>
        /// Empty string, null, and the HL7 explicit null (two double-quotes) are passed.  
        /// </summary>
        ///
        /// <param name="value_Renamed">    . </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>

        public virtual bool test(System.String value_Renamed)
        {
            if (value_Renamed == null || value_Renamed.Equals("\"\"") || value_Renamed.Equals(""))
            {
                return true;
            }
            return this.myPattern.IsMatch(value_Renamed);
        }

        #endregion
    }
}