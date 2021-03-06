/* <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "CommmonTM.java".  Description:
/// "Note: The class description below has been excerpted from the Hl7 2.4 documentation"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
*/

namespace NHapi.Base.Model.Primitive
{
    using NHapi.Base.Log;

    /// <summary>
    /// This class contains functionality used by the TM class in the version 2.3.0, 2.3.1, and 2.4
    /// packages
    /// 
    /// Note: The class description below has been excerpted from the Hl7 2.4 documentation.
    /// Sectional references made below also refer to the same documentation.
    /// 
    /// Format: HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ] In prior versions of HL7, this data type was always
    /// specified to be in the format HHMM[SS[.SSSS]][+/-ZZZZ] using a 24 hour clock notation. In the
    /// current and future versions, the precision of a time may be expressed by limiting the number
    /// of digits used with the format specification as shown above. By site-specific agreement,
    /// HHMM[SS[.SSSS]][+/-ZZZZ] may be used where backward compatibility must be maintained. Thus,
    /// HH is used to specify a precision of "hour," HHMM is used to specify a precision of "minute,"
    /// HHMMSS is used to specify a precision of seconds, and HHMMSS.SSSS is used to specify a
    /// precision of ten-thousandths of a second. In each of these cases, the time zone is an
    /// optional component. The fractional seconds could be sent by a transmitter who requires
    /// greater precision than whole seconds. Fractional representations of minutes, hours or other
    /// higher-order units of time are not permitted. Note: The time zone [+/-ZZZZ], when used, is
    /// restricted to legally-defined time zones and is represented in HHMM format. The time zone of
    /// the sender may be sent optionally as an offset from the coordinated universal time
    /// (previously known as Greenwich Mean Time). Where the time zone is not present in a particular
    /// TM field but is included as part of the date/time field in the MSH segment, the MSH value
    /// will be used as the default time zone. Otherwise, the time is understood to refer to the
    /// local time of the sender. Midnight is represented as 0000. Examples:|235959+1100| 1 second
    /// before midnight in a time zone eleven hours ahead of Universal Coordinated Time (i.e., east
    /// of Greenwich).
    /// |0800| Eight AM, local time of the sender.
    /// |093544.2312| 44.2312 seconds after Nine thirty-five AM, local time of sender.
    /// |13| 1pm (with a precision of hours), local time of sender.
    /// </summary>

    public class CommonTM
    {
        #region Static Fields

        /// <summary>   The log. </summary>
        private static readonly IHapiLog log;

        #endregion

        #region Fields

        /// <summary>   The fraction of security. </summary>
        private float fractionOfSec;

        /// <summary>   The hour. </summary>
        private int hour;

        /// <summary>   The minute. </summary>
        private int minute;

        /// <summary>   Set the off belongs to. </summary>
        private int offSet;

        /// <summary>   The omit offset foreground. </summary>
        private char omitOffsetFg = 'n';

        /// <summary>   The second. </summary>
        private int second;

        /// <summary>   The value renamed. </summary>
        private System.String value_Renamed;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the CommonTM class. </summary>
        static CommonTM()
        {
            log = HapiLogFactory.GetHapiLog(typeof(CommonTM));
        }

        /// <summary>
        /// Constructs a TM datatype with fields initialzed to zero and the value set to null.
        /// </summary>

        public CommonTM()
        {
            //initialize all DT fields
            this.value_Renamed = null;
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
            this.fractionOfSec = 0;
            this.offSet = -99;
        } //end constructor

        /// <summary>
        /// Constructs a TM object with the given value. The stored value will be in the following format
        /// HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ].
        /// </summary>
        ///
        /// <param name="val">  The value. </param>

        public CommonTM(System.String val)
        {
            this.Value = val;
        }

        #endregion

        #region Public Properties

        /// <summary>   Returns the fractional second value as a float. </summary>
        ///
        /// <value> The fract second. </value>

        public virtual float FractSecond
        {
            get
            {
                return this.fractionOfSec;
            }
        }

        /// <summary>   Returns the GMT offset value as an integer, -99 if not set. </summary>
        ///
        /// <value> The GMT offset. </value>

        public virtual int GMTOffset
        {
            get
            {
                return this.offSet;
            }
        }

        /// <summary>   Returns the hour as an integer. </summary>
        ///
        /// <value> The hour. </value>

        public virtual int Hour
        {
            get
            {
                return this.hour;
            }
        }

        /// <summary>
        /// This method takes in an integer value for the hour and performs validations, it then sets the
        /// value field formatted as an HL7 time value with hour precision (HH).
        /// </summary>
        ///
        /// <value> The hour precision. </value>

        public virtual int HourPrecision
        {
            set
            {
                try
                {
                    //validate input value
                    if ((value < 0) || (value > 23))
                    {
                        System.String msg = "The hour value of the TM datatype must be >=0 and <=23";
                        DataTypeException e = new DataTypeException(msg);
                        throw e;
                    } //end if
                    this.hour = value;
                    this.minute = 0;
                    this.second = 0;
                    this.fractionOfSec = 0;
                    this.offSet = 0;
                    //Here the offset is not defined, we should omit showing it in the
                    //return value from the getValue() method
                    this.omitOffsetFg = 'y';
                    this.value_Renamed = DataTypeUtil.preAppendZeroes(value, 2);
                }
                    //end try
                catch (DataTypeException e)
                {
                    throw e;
                }
                    //end catch
                catch (System.Exception e)
                {
                    throw new DataTypeException(e.Message);
                } //end catch
            }
        }

        /// <summary>   Returns the minute as an integer. </summary>
        ///
        /// <value> The minute. </value>

        public virtual int Minute
        {
            get
            {
                return this.minute;
            }
        }

        /// <summary>
        /// This method takes in the four digit (signed) GMT offset and sets the offset field.
        /// </summary>
        ///
        /// <value> The offset. </value>

        public virtual int Offset
        {
            set
            {
                try
                {
                    //When this function is called an offset is being created/updated
                    //we should not omit displaying it in the return value from
                    //the getValue() method
                    this.omitOffsetFg = 'n';
                    System.String offsetStr = System.Convert.ToString(value);
                    if ((value >= 0 && offsetStr.Length > 4) || (value < 0 && offsetStr.Length > 5))
                    {
                        //The length of the GMT offset must be no greater than 5 characters (including the sign)
                        System.String msg = "The length of the GMT offset for the TM datatype value does"
                                            + " not conform to the allowable format [+/-ZZZZ]. Value: " + value;
                        DataTypeException e = new DataTypeException(msg);
                        throw e;
                    } //end if
                    //obtain the absolute value of the input
                    int absOffset = System.Math.Abs(value);
                    //extract the hour data from the offset value.
                    //first preappend zeros so we have a 4 char offset value (without sign)
                    offsetStr = DataTypeUtil.preAppendZeroes(absOffset, 4);
                    int hrOffsetInt = System.Int32.Parse(offsetStr.Substring(0, (2) - (0)));
                    //check to see if the hour value is valid
                    if ((hrOffsetInt < 0) || (hrOffsetInt > 23))
                    {
                        System.String msg = "The GMT offset hour value of the TM datatype must be >=0 and <=23";
                        DataTypeException e = new DataTypeException(msg);
                        throw e;
                    } //end if
                    //extract the minute data from the offset value.
                    int minOffsetInt = System.Int32.Parse(offsetStr.Substring(2, (4) - (2)));
                    //check to see if the minute value is valid
                    if ((minOffsetInt < 0) || (minOffsetInt > 59))
                    {
                        System.String msg = "The GMT offset minute value of the TM datatype must be >=0 and <=59";
                        DataTypeException e = new DataTypeException(msg);
                        throw e;
                    } //end if
                    //The input value is valid, now store it in the offset field
                    this.offSet = value;
                }
                    //end try
                catch (DataTypeException e)
                {
                    throw e;
                }
                    //end catch
                catch (System.Exception e)
                {
                    throw new DataTypeException("An unexpected exception ocurred", e);
                } //end catch
            }
        }

        /// <summary>   Returns the second as an integer. </summary>
        ///
        /// <value> The second. </value>

        public virtual int Second
        {
            get
            {
                return this.second;
            }
        }

        /// <summary>   Returns the HL7 TM string value. </summary>
        /// <summary>   This method takes in a string HL7 Time value and performs validations then sets
        ///             the value field.  The stored value will be in the following format
        ///             HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ]. Note: Trailing zeros supplied in the time value
        ///             (HH[MM[SS[.S[S[S[S]]]]]])
        ///             and GMT offset ([+/-ZZZZ]) will be preserved. Note: If the GMT offset is not
        ///             supplied then the local time zone (using standard time zone format which is not
        ///             modified for daylight savings)
        ///             will be stored as a default. </summary>
        ///
        /// <value> The value. </value>

        public virtual System.String Value
        {
            get
            {
                //combine the value field with the offSet field and return it
                System.String returnVal = null;
                if (this.value_Renamed != null && !this.value_Renamed.Equals(""))
                {
                    if (this.omitOffsetFg == 'n' && !this.value_Renamed.Equals("\"\""))
                    {
                        int absOffset = System.Math.Abs(this.offSet);
                        System.String sign = "";
                        if (this.offSet >= 0)
                        {
                            sign = "+";
                        }
                            //end if
                        else
                        {
                            sign = "-";
                        } //end else
                        returnVal = this.value_Renamed + sign + DataTypeUtil.preAppendZeroes(absOffset, 4);
                    }
                    else
                    {
                        returnVal = this.value_Renamed;
                    } //end else
                } //end if
                return returnVal;
            }

            set
            {
                if (value != null && !value.Equals("") && !value.Equals("\"\""))
                {
                    //check to see if any of the following characters exist: "." or "+/-"
                    //this will help us determine the acceptable lengths

                    int d = value.IndexOf(".");
                    int sp = value.IndexOf("+");
                    int sm = value.IndexOf("-");
                    int indexOfSign = -1;
                    bool offsetExists = false;
                    if ((sp != -1) || (sm != -1))
                    {
                        offsetExists = true;
                    }
                    if (sp != -1)
                    {
                        indexOfSign = sp;
                    }
                    if (sm != -1)
                    {
                        indexOfSign = sm;
                    }

                    try
                    {
                        //If the GMT offset exists then extract it from the input string and store it
                        //in another variable called tempOffset. Also, store the time value
                        //(without the offset)in a separate variable called timeVal.
                        //If there is no GMT offset then simply set timeVal to val.
                        System.String timeVal = value;
                        System.String tempOffset = null;
                        if (offsetExists)
                        {
                            timeVal = value.Substring(0, (indexOfSign) - (0));
                            tempOffset = value.Substring(indexOfSign);
                        } //end if

                        if (offsetExists && (tempOffset.Length != 5))
                        {
                            //The length of the GMT offset must be 5 characters (including the sign)
                            System.String msg = "The length of the TM datatype value does not conform to an allowable"
                                                + " format. Format should conform to HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ]";
                            DataTypeException e = new DataTypeException(msg);
                            throw e;
                        } //end if

                        if (d != -1)
                        {
                            //here we know that decimal exists
                            //thus length of the time value can be between 8 and 11 characters
                            if ((timeVal.Length < 8) || (timeVal.Length > 11))
                            {
                                System.String msg =
                                    "The length of the TM datatype value does not conform to an allowable"
                                    + " format. Format should conform to HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ]";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                        } //end if

                        if (d == -1)
                        {
                            //here we know that the decimal does not exist
                            //thus length of the time value can be 2 or 4 or 6 characters
                            if ((timeVal.Length != 2) && (timeVal.Length != 4) && (timeVal.Length != 6))
                            {
                                System.String msg =
                                    "The length of the TM datatype value does not conform to an allowable"
                                    + " format. Format should conform to HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ]";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                        } //end if

                        //We will now try to validate the timeVal portion of the TM datatype value
                        if (timeVal.Length >= 2)
                        {
                            //extract the hour data from the input value.  If the first 2 characters
                            //are not numeric then a number format exception will be generated
                            int hrInt = System.Int32.Parse(timeVal.Substring(0, (2) - (0)));
                            //check to see if the hour value is valid
                            if ((hrInt < 0) || (hrInt > 23))
                            {
                                System.String msg = "The hour value of the TM datatype must be >=0 and <=23";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                            this.hour = hrInt;
                        } //end if

                        if (timeVal.Length >= 4)
                        {
                            //extract the minute data from the input value
                            //If these characters are not numeric then a number
                            //format exception will be generated
                            int minInt = System.Int32.Parse(timeVal.Substring(2, (4) - (2)));
                            //check to see if the minute value is valid
                            if ((minInt < 0) || (minInt > 59))
                            {
                                System.String msg = "The minute value of the TM datatype must be >=0 and <=59";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                            this.minute = minInt;
                        } //end if

                        if (timeVal.Length >= 6)
                        {
                            //extract the seconds data from the input value
                            //If these characters are not numeric then a number
                            //format exception will be generated
                            int secInt = System.Int32.Parse(timeVal.Substring(4, (6) - (4)));
                            //check to see if the seconds value is valid
                            if ((secInt < 0) || (secInt > 59))
                            {
                                System.String msg = "The seconds value of the TM datatype must be >=0 and <=59";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                            this.second = secInt;
                        } //end if

                        if (timeVal.Length >= 8)
                        {
                            //extract the fractional second value from the input value
                            //If these characters are not numeric then a number
                            //format exception will be generated
                            float fract = System.Single.Parse(timeVal.Substring(6));
                            //check to see if the fractional second value is valid
                            if ((fract < 0) || (fract >= 1))
                            {
                                System.String msg =
                                    "The fractional second value of the TM datatype must be >= 0 and < 1";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                            this.fractionOfSec = fract;
                        } //end if

                        //We will now try to validate the tempOffset portion of the TM datatype value
                        if (offsetExists)
                        {
                            //in case the offset are a series of zeros we should not omit displaying
                            //it in the return value from the getValue() method
                            this.omitOffsetFg = 'n';
                            //remove the sign from the temp offset
                            System.String tempOffsetNoS = tempOffset.Substring(1);
                            //extract the hour data from the offset value.  If the first 2 characters
                            //are not numeric then a number format exception will be generated
                            int offsetInt = System.Int32.Parse(tempOffsetNoS.Substring(0, (2) - (0)));
                            //check to see if the hour value is valid
                            if ((offsetInt < 0) || (offsetInt > 23))
                            {
                                System.String msg = "The GMT offset hour value of the TM datatype must be >=0 and <=23";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                            //extract the minute data from the offset value.  If these characters
                            //are not numeric then a number format exception will be generated
                            offsetInt = System.Int32.Parse(tempOffsetNoS.Substring(2, (4) - (2)));
                            //check to see if the minute value is valid
                            if ((offsetInt < 0) || (offsetInt > 59))
                            {
                                System.String msg =
                                    "The GMT offset minute value of the TM datatype must be >=0 and <=59";
                                DataTypeException e = new DataTypeException(msg);
                                throw e;
                            } //end if
                            //validation done, update the offSet field
                            this.offSet = System.Int32.Parse(tempOffsetNoS);
                            //add the sign back to the offset if it is negative
                            if (sm != -1)
                            {
                                this.offSet = (-1) * this.offSet;
                            } //end if
                        } //end if

                        //If the GMT offset has not been supplied then set the offset to the
                        //local timezone
                        //[Bryan: changing this to omit time zone because erroneous if parser in different zone than sender]
                        if (!offsetExists)
                        {
                            this.omitOffsetFg = 'y';
                            // set the offSet field to the current time and local time zone
                            //offSet = DataTypeUtil.getLocalGMTOffset();
                        } //end if

                        //validations are now done store the time value into the private value field
                        this.value_Renamed = timeVal;
                    }
                        //end try
                    catch (DataTypeException e)
                    {
                        throw e;
                    }
                        //end catch
                    catch (System.Exception e)
                    {
                        throw new DataTypeException("An unexpected exception ocurred", e);
                    } //end catch
                }
                    //end if
                else
                {
                    //set the private value field to null or empty space.
                    this.value_Renamed = value;
                } //end else
            }
        }

        #endregion

        //end constructor

        #region Public Methods and Operators

        /// <summary>
        /// Returns a string value representing the input Gregorian Calendar object in an Hl7 Time Format.
        /// </summary>
        ///
        /// <exception cref="DataTypeException">    Thrown when a Data Type error condition occurs. </exception>
        ///
        /// <param name="cal">  The cal. </param>
        ///
        /// <returns>   cal as a System.String. </returns>

        public static System.String toHl7TMFormat(System.Globalization.GregorianCalendar cal)
        {
            System.String val = "";
            try
            {
                //set the input cal object so that it can report errors
                //on it's value
                int calHour = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.HOUR_OF_DAY);
                int calMin = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.MINUTE);
                int calSec = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.SECOND);
                int calMilli = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.MILLISECOND);
                //the inputs seconds and milli seconds should be combined into a float type
                float fractSec = calMilli / 1000F;
                float calSecFloat = calSec + fractSec;
                int calOffset = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.ZONE_OFFSET)
                                + SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.DST_OFFSET);
                //Note the input's Offset value is in milliseconds, we must convert it to
                //a 4 digit integer in the HL7 Offset format.
                int offSetSignInt;
                if (calOffset < 0)
                {
                    offSetSignInt = -1;
                }
                else
                {
                    offSetSignInt = 1;
                }
                //get the absolute value of the gmtOffSet
                int absGmtOffSet = System.Math.Abs(calOffset);
                int gmtOffSetHours = absGmtOffSet / (3600 * 1000);
                int gmtOffSetMin = (absGmtOffSet / 60000) % (60);
                //reset calOffset
                calOffset = ((gmtOffSetHours * 100) + gmtOffSetMin) * offSetSignInt;
                //Create an object of the TS class and populate it with the above values
                //then return the HL7 string value from the object
                CommonTM tm = new CommonTM();
                tm.setHourMinSecondPrecision(calHour, calMin, calSecFloat);
                tm.Offset = calOffset;
                val = tm.Value;
            }
                // end try
            catch (DataTypeException e)
            {
                throw e;
            }
                //end catch
            catch (System.Exception e)
            {
                throw new DataTypeException("An unexpected exception ocurred", e);
            } //end catch
            return val;
        }

        /// <summary>
        /// This method takes in integer values for the hour, minute, seconds, and fractional seconds
        /// (going to the tenthousandths precision). The method performs validations and then sets the
        /// value field formatted as an HL7 time value with a precision that starts from the hour and
        /// goes down to the tenthousandths of a second (HHMMSS.SSSS). Note: all of the precisions from
        /// tenths down to tenthousandths of a second are optional. If the precision goes below
        /// tenthousandths of a second then the second value will be rounded to the nearest
        /// tenthousandths of a second.
        /// </summary>
        ///
        /// <exception cref="DataTypeException">    Thrown when a Data Type error condition occurs. </exception>
        ///
        /// <param name="hr">   The hr. </param>
        /// <param name="min">  The minimum. </param>
        /// <param name="sec">  The security. </param>

        public virtual void setHourMinSecondPrecision(int hr, int min, float sec)
        {
            try
            {
                this.setHourMinutePrecision(hr, min);
                //multiply the seconds input value by 10000 and round the result
                //then divide the number by tenthousand and store it back.
                //This will round the fractional seconds to the nearest tenthousandths
                int secMultRound = (int)System.Math.Round(10000F * sec);
                sec = secMultRound / 10000F;
                //Now store the second and fractional component
                this.second = (int)System.Math.Floor(sec);
                //validate input seconds value
                if ((this.second < 0) || (this.second >= 60))
                {
                    System.String msg = "The (rounded) second value of the TM datatype must be >=0 and <60";
                    DataTypeException e = new DataTypeException(msg);
                    throw e;
                } //end if
                int fractionOfSecInt = secMultRound - (this.second * 10000);
                this.fractionOfSec = fractionOfSecInt / 10000F;
                System.String fractString = "";
                //Now convert the fractionOfSec field to a string without the leading zero
                if (this.fractionOfSec != 0.0F)
                {
                    fractString = (this.fractionOfSec.ToString()).Substring(1);
                } //end if
                //Now update the value field
                this.offSet = 0;
                //Here the offset is not defined, we should omit showing it in the
                //return value from the getValue() method
                this.omitOffsetFg = 'y';
                this.value_Renamed = this.value_Renamed + DataTypeUtil.preAppendZeroes(this.second, 2) + fractString;
            }
                //end try
            catch (DataTypeException e)
            {
                throw e;
            }
                //end catch
            catch (System.Exception e)
            {
                throw new DataTypeException("An unexpected exception ocurred", e);
            } //end catch
        }

        /// <summary>
        /// This method takes in integer values for the hour and minute and performs validations, it then
        /// sets the value field formatted as an HL7 time value with hour and minute precision (HHMM).
        /// </summary>
        ///
        /// <exception cref="DataTypeException">    Thrown when a Data Type error condition occurs. </exception>
        ///
        /// <param name="hr">   The hr. </param>
        /// <param name="min">  The minimum. </param>

        public virtual void setHourMinutePrecision(int hr, int min)
        {
            try
            {
                this.HourPrecision = hr;
                //validate input minute value
                if ((min < 0) || (min > 59))
                {
                    System.String msg = "The minute value of the TM datatype must be >=0 and <=59";
                    DataTypeException e = new DataTypeException(msg);
                    throw e;
                } //end if
                this.minute = min;
                this.second = 0;
                this.fractionOfSec = 0;
                this.offSet = 0;
                //Here the offset is not defined, we should omit showing it in the
                //return value from the getValue() method
                this.omitOffsetFg = 'y';
                this.value_Renamed = this.value_Renamed + DataTypeUtil.preAppendZeroes(min, 2);
            }
                //end try
            catch (DataTypeException e)
            {
                throw e;
            }
                //end catch
            catch (System.Exception e)
            {
                throw new DataTypeException(e.Message);
            } //end catch
        }

        #endregion
    } //end class
}