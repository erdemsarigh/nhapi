/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Defaultalidation.java".  Description: 
/// "A ValidationContext with a default set of rules initially defined." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2004.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>

namespace NHapi.Base.validation.impl
{
    /// <summary>
    /// A <code>ValidationContext</code> with a default set of rules initially defined. This can be
    /// used as-is for a reasonable level of primitive type validation.
    /// </summary>

    public class DefaultValidation : ValidationContextImpl
    {
        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the DefaultValidation class. </summary>
        public DefaultValidation()
        {
            IRule trim = new TrimLeadingWhitespace();
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "FT", trim));
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "ST", trim));
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "TX", trim));

            IRule size200 = new SizeRule(200);
            IRule size32000 = new SizeRule(32000);
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "FT", size32000));
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "ID", size200));
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "IS", size200));

            IRule nonNegativeInteger = new RegexPrimitiveRule("\\d*", "");
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "SI", nonNegativeInteger));

            IRule number = new RegexPrimitiveRule("(\\+|\\-)?\\d*\\.?\\d*", "");
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "NM", number));

            //IRule telephoneNumber = new RegexPrimitiveRule("(\\d{1,2} )?(\\(\\d{3}\\))?\\d{3}-\\d{4}(X\\d{1,5})?(B\\d{1,5})?(C.*)?", "Version 2.4 Section 2.9.45");
            //PrimitiveRuleBindings.Add(new RuleBinding("*", "TN", telephoneNumber));

            System.String datePattern = "(\\d{4}([01]\\d(\\d{2})?)?)?"; //YYYY[MM[DD]]
            IRule date = new RegexPrimitiveRule(datePattern, "Version 2.5 Section 2.16.24");
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "DT", date));

            System.String timePattern = "([012]\\d([0-5]\\d([0-5]\\d(\\.\\d(\\d(\\d(\\d)?)?)?)?)?)?)?([\\+\\-]\\d{4})?";
            IRule time = new RegexPrimitiveRule(timePattern, "Version 2.5 Section 2.16.79");
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "TM", time));

            System.String datetimePattern =
                "(\\d{4}([01]\\d(\\d{2}([012]\\d([0-5]\\d([0-5]\\d(\\.\\d(\\d(\\d(\\d)?)?)?)?)?)?)?)?)?)?([\\+\\-]\\d{4})?";
            IRule datetime = new RegexPrimitiveRule(datetimePattern, "Version 2.5 Section 2.16.25");
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "TSComponentOne", datetime));
            this.PrimitiveRuleBindings.Add(new RuleBinding("*", "DTM", datetime));
        }

        #endregion
    }
}