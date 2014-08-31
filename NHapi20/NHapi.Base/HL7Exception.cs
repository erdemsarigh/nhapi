/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "HL7Exception.java".  Description: 
/// "Represents an exception encountered while processing 
/// an HL7 message" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
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

namespace NHapi.Base
{
    using System;

    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Util;

    /// <summary>   Represents an exception encountered while processing an HL7 message.   </summary>
    [Serializable]
    public class HL7Exception : System.Exception
    {
        #region Constants

        /// <summary>   Acknowledgement Application Accept. </summary>
        public const int ACK_AA = 1;

        /// <summary>   Acknowledgement Application Error. </summary>
        public const int ACK_AE = 2;

        /// <summary>   Acknowledgement Application Reject. </summary>
        public const int ACK_AR = 3;

        /// <summary>   Appplication error. </summary>
        public const int APPLICATION_INTERNAL_ERROR = 207;

        /// <summary>   Application record locked. </summary>
        public const int APPLICATION_RECORD_LOCKED = 206;

        /// <summary>   Date type error. </summary>
        public const int DATA_TYPE_ERROR = 102;

        /// <summary>   Duplicate key id. </summary>
        public const int DUPLICATE_KEY_IDENTIFIER = 205;

        /// <summary>   Message accepted. </summary>
        public const int MESSAGE_ACCEPTED = 0;

        /// <summary>   Required field missing. </summary>
        public const int REQUIRED_FIELD_MISSING = 101;

        /// <summary>   Segment sequence error. </summary>
        public const int SEGMENT_SEQUENCE_ERROR = 100;

        /// <summary>   Table value not found. </summary>
        public const int TABLE_VALUE_NOT_FOUND = 103;

        /// <summary>   Unknown key id. </summary>
        public const int UNKNOWN_KEY_IDENTIFIER = 204;

        /// <summary>   Unsupported event code. </summary>
        public const int UNSUPPORTED_EVENT_CODE = 201;

        /// <summary>   Unsupported message type. </summary>
        public const int UNSUPPORTED_MESSAGE_TYPE = 200;

        /// <summary>   Unsupported processing id. </summary>
        public const int UNSUPPORTED_PROCESSING_ID = 202;

        /// <summary>   Unsupported version id. </summary>
        public const int UNSUPPORTED_VERSION_ID = 203;

        #endregion

        #region Static Fields

        /// <summary>   our log. </summary>
        private static readonly IHapiLog ourLog;

        #endregion

        #region Fields

        /// <summary>   The error code. </summary>
        private int errCode = -1;

        /// <summary>   The field position. </summary>
        private int fieldPosition = -1;

        /// <summary>   The segment. </summary>
        private System.String segment;

        /// <summary>   The segment rep. </summary>
        private int segmentRep = -1;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the HL7Exception class. </summary>
        static HL7Exception()
        {
            ourLog = HapiLogFactory.GetHapiLog(typeof(HL7Exception));
        }

        /// <summary>   Creates an HL7Exception. </summary>
        ///
        /// <param name="message">          The error message. </param>
        /// <param name="errorCondition">   a code describing the the error condition, from HL7 table
        ///                                 0357 (see section 2.16.8 of standard v 2.4) - HL7Exception
        ///                                 defines these codes as integer constants that can be used
        ///                                 here (e.g. HL7Exception.UNSUPPORTED_MESSAGE_TYPE) </param>
        /// <param name="cause">            The excption that caused this exception tobe thrown. </param>

        public HL7Exception(System.String message, int errorCondition, System.Exception cause)
            : base(message, cause)
        {
            this.errCode = errorCondition;
        }

        /// <summary>   Creates an HL7Exception. </summary>
        ///
        /// <param name="message">          the error message. </param>
        /// <param name="errorCondition">   a code describing the the error condition, from HL7 table
        ///                                 0357 (see section 2.16.8 of standard v 2.4) - HL7Exception
        ///                                 defines these codes as integer constants that can be used
        ///                                 here (e.g. HL7Exception.UNSUPPORTED_MESSAGE_TYPE) </param>

        public HL7Exception(System.String message, int errorCondition)
            : base(message)
        {
            this.errCode = errorCondition;
        }

        /// <summary>   Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR. </summary>
        ///
        /// <param name="message">  the error message. </param>
        /// <param name="cause">    The excption that caused this exception tobe thrown. </param>

        public HL7Exception(System.String message, System.Exception cause)
            : base(message, cause)
        {
            this.errCode = HL7Exception.APPLICATION_INTERNAL_ERROR;
        }

        /// <summary>   Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR. </summary>
        ///
        /// <param name="message">  The error message. </param>

        public HL7Exception(System.String message)
            : base(message)
        {
            this.errCode = HL7Exception.APPLICATION_INTERNAL_ERROR;
        }

        #endregion

        #region Public Properties

        /// <summary>   Returns the field number within the segment where the error occured if it has
        ///             been set, -1 otherwise; numbering starts at 1. </summary>
        /// <summary>   Sets the field number (within a segment) where the error occured; numbering
        ///             starts at 1. </summary>
        ///
        /// <value> The field position. </value>

        public virtual int FieldPosition
        {
            get
            {
                return this.fieldPosition;
            }

            set
            {
                this.fieldPosition = value;
            }
        }

        /// <summary>
        /// Overrides Throwable.getMessage() to add the field location of the problem if available.
        /// </summary>
        ///
        /// <value> The message. </value>

        public override System.String Message
        {
            get
            {
                System.Text.StringBuilder msg = new System.Text.StringBuilder();
                msg.Append(base.Message);
                if (this.SegmentName != null)
                {
                    msg.Append(": Segment: ");
                    msg.Append(this.SegmentName);
                }
                if (this.SegmentRepetition != -1)
                {
                    msg.Append(" (rep ");
                    msg.Append(this.SegmentRepetition);
                    msg.Append(")");
                }
                if (this.FieldPosition != -1)
                {
                    msg.Append(" Field #");
                    msg.Append(this.FieldPosition);
                }
                return msg.ToString();
            }
        }

        /// <summary>   Returns the name of the segment where the error occured, if this has been set
        ///             (null otherwise). </summary>
        /// <summary>   Sets the name of the segment where the error occured. </summary>
        ///
        /// <value> The name of the segment. </value>

        public virtual System.String SegmentName
        {
            get
            {
                return this.segment;
            }

            set
            {
                this.segment = value;
            }
        }

        /// <summary>   Returns the sequence number of the segment where the error occured (if there are
        ///             multiple segments with the same name) if this has been set, -1 otherwise -
        ///             numbering starts at 1. </summary>
        /// <summary>   Sets the sequence number of the segment where the error occured if there are
        ///             multiplt segments with the same name (ie the sequenceNum'th segment with the name
        ///             specified in <code>setSegmentName</code>).  Numbering starts at 1. </summary>
        ///
        /// <value> The segment repetition. </value>

        public virtual int SegmentRepetition
        {
            get
            {
                return this.segmentRep;
            }

            set
            {
                this.segmentRep = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Populates the given error segment with information from this Exception. </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="errorSegment"> The error segment. </param>

        public virtual void populate(ISegment errorSegment)
        {
            //make sure it's an ERR
            if (!errorSegment.GetStructureName().Equals("ERR"))
            {
                throw new HL7Exception(
                    "Can only populate an ERR segment with an exception -- got: " + errorSegment.GetType().FullName);
            }

            int rep = errorSegment.GetField(1).Length; //append after existing reps

            if (this.SegmentName != null)
            {
                Terser.Set(errorSegment, 1, rep, 1, 1, this.SegmentName);
            }

            if (this.SegmentRepetition >= 0)
            {
                Terser.Set(errorSegment, 1, rep, 2, 1, System.Convert.ToString(this.SegmentRepetition));
            }

            if (this.FieldPosition >= 0)
            {
                Terser.Set(errorSegment, 1, rep, 3, 1, System.Convert.ToString(this.FieldPosition));
            }

            Terser.Set(errorSegment, 1, rep, 4, 1, System.Convert.ToString(this.errCode));
            Terser.Set(errorSegment, 1, rep, 4, 3, "hl70357");
            Terser.Set(errorSegment, 1, rep, 4, 5, this.Message);

            //try to get error condition text
            try
            {
                System.String desc = TableRepository.Instance.getDescription(357, System.Convert.ToString(this.errCode));
                Terser.Set(errorSegment, 1, rep, 4, 2, desc);
            }
            catch (LookupException e)
            {
                ourLog.Debug(
                    "Warning: LookupException getting error condition text (are we connected to a TableRepository?)",
                    e);
            }
        }

        #endregion
    }
}