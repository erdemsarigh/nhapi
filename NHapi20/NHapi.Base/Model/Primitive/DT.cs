/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "DT.java".  Description:
/// "Note: The class description below has been excerpted from the Hl7 2.3.0 documentation"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2005.  All Rights Reserved.
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
/// </summary>

namespace NHapi.Base.Model.Primitive
{
    /// <summary>   Represents an HL7 DT (date) datatype. </summary>
    public abstract class DT : AbstractPrimitive
    {
        #region Fields

        /// <summary>   my detail. </summary>
        private CommonDT myDetail;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the DT class. </summary>
        ///
        /// <param name="theMessage">   message to which this Type belongs. </param>

        public DT(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>   DT class. </summary>
        ///
        /// <param name="theMessage">   . </param>
        /// <param name="description">  . </param>

        public DT(IMessage theMessage, string description)
            : base(theMessage, description)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>   Returns the day as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The day. </value>

        public virtual int Day
        {
            get
            {
                return this.Detail.Day;
            }
        }

        /// <summary>   Returns the month as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The month. </value>

        public virtual int Month
        {
            get
            {
                return this.Detail.Month;
            }
        }

        /// <summary>
        /// enabled for this primitive or detail setters / getters have been called, forcing further
        /// parsing.
        /// </summary>
        ///
        /// <value> The value. </value>

        public override System.String Value
        {
            get
            {
                System.String result = base.Value;

                if (this.myDetail != null)
                {
                    result = this.myDetail.Value;
                }

                return result;
            }

            set
            {
                base.Value = value;

                if (this.myDetail != null)
                {
                    this.myDetail.Value = value;
                }
            }
        }

        /// <summary>   Returns the year as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The year. </value>

        public virtual int Year
        {
            get
            {
                return this.Detail.Year;
            }
        }

        /// <summary>
        /// exception should be thrown at setValue(), but if not, detailed parsing may be deferred until
        /// this method is called.  
        /// </summary>
        ///
        /// <value> The year precision. </value>

        public virtual int YearPrecision
        {
            set
            {
                this.Detail.YearPrecision = value;
            }
        }

        #endregion

        #region Properties

        /// <summary>   Gets the detail. </summary>
        ///
        /// <value> The detail. </value>

        private CommonDT Detail
        {
            get
            {
                if (this.myDetail == null)
                {
                    this.myDetail = new CommonDT(this.Value);
                }
                return this.myDetail;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// exception should be thrown at setValue(), but if not, detailed parsing may be deferred until
        /// this method is called.  
        /// </summary>
        ///
        /// <param name="yr">   The yr. </param>
        /// <param name="mnth"> The mnth. </param>
        /// <param name="dy">   The dy. </param>
        ///
        /// <seealso cref="CommonDT.setYearMonthDayPrecision(int, int, int)"/>

        public virtual void setYearMonthDayPrecision(int yr, int mnth, int dy)
        {
            this.Detail.setYearMonthDayPrecision(yr, mnth, dy);
        }

        /// <summary>
        /// exception should be thrown at setValue(), but if not, detailed parsing may be deferred until
        /// this method is called.  
        /// </summary>
        ///
        /// <param name="yr">   The yr. </param>
        /// <param name="mnth"> The mnth. </param>
        ///
        /// <seealso cref="CommonDT.setYearMonthPrecision(int, int)"/>

        public virtual void setYearMonthPrecision(int yr, int mnth)
        {
            this.Detail.setYearMonthPrecision(yr, mnth);
        }

        #endregion
    }
}