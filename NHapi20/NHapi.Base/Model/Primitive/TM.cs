/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "TM.java".  Description:
/// "Represents an HL7 TM (time) datatype."
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
    /// <summary>   Represents an HL7 TM (time) datatype. </summary>
    public abstract class TM : AbstractPrimitive
    {
        #region Fields

        /// <summary>   my detail. </summary>
        private CommonTM myDetail;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the TM class. </summary>
        ///
        /// <param name="theMessage">   message to which this Type belongs. </param>

        public TM(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>   Initializes a new instance of the TM class. </summary>
        ///
        /// <param name="theMessage">   message to which this Type belongs. </param>
        /// <param name="description">  The description. </param>

        public TM(IMessage theMessage, string description)
            : base(theMessage, description)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>   Returns the fractional second value as a float. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The fract second. </value>

        public virtual float FractSecond
        {
            get
            {
                return this.Detail.FractSecond;
            }
        }

        /// <summary>   Returns the GMT offset value as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The GMT offset. </value>

        public virtual int GMTOffset
        {
            get
            {
                return this.Detail.GMTOffset;
            }
        }

        /// <summary>   Returns the hour as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The hour. </value>

        public virtual int Hour
        {
            get
            {
                return this.Detail.Hour;
            }
        }

        /// <summary>
        /// exception should be thrown at setValue(), but if not, detailed parsing may be deferred until
        /// this method is called.  
        /// </summary>
        ///
        /// <value> The hour precision. </value>
        ///
        /// <seealso cref="CommonTM.setHourPrecision(int)"/>

        public virtual int HourPrecision
        {
            set
            {
                this.Detail.HourPrecision = value;
            }
        }

        /// <summary>   Returns the minute as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The minute. </value>

        public virtual int Minute
        {
            get
            {
                return this.Detail.Minute;
            }
        }

        /// <summary>
        /// exception should be thrown at setValue(), but if not, detailed parsing may be deferred until
        /// this method is called.  
        /// </summary>
        ///
        /// <value> The offset. </value>
        ///
        /// <seealso cref="CommonTM.setOffset(int)"/>

        public virtual int Offset
        {
            set
            {
                this.Detail.Offset = value;
            }
        }

        /// <summary>   Returns the second as an integer. </summary>
        /// <summary>   exception should be thrown at setValue(), but if not, detailed parsing may be
        ///             deferred until this method is called.  </summary>
        ///
        /// <value> The second. </value>

        public virtual int Second
        {
            get
            {
                return this.Detail.Second;
            }
        }

        /// <summary>
        /// enabled for this primitive or detail setters / getters have been called, forcing further
        /// parsing.
        /// </summary>
        ///
        /// <value> The value. </value>
        ///
        /// <seealso cref="AbstractPrimitive.getValue"/>
        /// <seealso cref="AbstractPrimitive.setValue(java.lang.String)"/>

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

        #endregion

        #region Properties

        /// <summary>   Gets the detail. </summary>
        ///
        /// <value> The detail. </value>

        private CommonTM Detail
        {
            get
            {
                if (this.myDetail == null)
                {
                    this.myDetail = new CommonTM(this.Value);
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
        /// <param name="hr">   The hr. </param>
        /// <param name="min">  The minimum. </param>
        /// <param name="sec">  The security. </param>
        ///
        /// <seealso cref="CommonTM.setHourMinSecondPrecision(int, int, float)"/>

        public virtual void setHourMinSecondPrecision(int hr, int min, float sec)
        {
            this.Detail.setHourMinSecondPrecision(hr, min, sec);
        }

        /// <summary>
        /// exception should be thrown at setValue(), but if not, detailed parsing may be deferred until
        /// this method is called.  
        /// </summary>
        ///
        /// <param name="hr">   The hr. </param>
        /// <param name="min">  The minimum. </param>
        ///
        /// <seealso cref="CommonTM.setHourMinutePrecision(int, int)"/>

        public virtual void setHourMinutePrecision(int hr, int min)
        {
            this.Detail.setHourMinutePrecision(hr, min);
        }

        #endregion
    }
}