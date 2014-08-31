using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

/// <summary>
/// Represents an HL7 PEO message segment. This segment has the following fields:<ol>
/// <li>PEO-1: Event Identifiers Used (CE)</li>
/// <li>PEO-2: Event Symptom/Diagnosis Code (CE)</li>
/// <li>PEO-3: Event Onset Date/Time (TS)</li>
/// <li>PEO-4: Event Exacerbation Date/Time (TS)</li>
/// <li>PEO-5: Event Improved Date/Time (TS)</li>
/// <li>PEO-6: Event Ended Data/Time (TS)</li>
/// <li>PEO-7: Event Location Occurred Address (XAD)</li>
/// <li>PEO-8: Event Qualification (ID)</li>
/// <li>PEO-9: Event Serious (ID)</li>
/// <li>PEO-10: Event Expected (ID)</li>
/// <li>PEO-11: Event Outcome (ID)</li>
/// <li>PEO-12: Patient Outcome (ID)</li>
/// <li>PEO-13: Event Description From Others (FT)</li>
/// <li>PEO-14: Event From Original Reporter (FT)</li>
/// <li>PEO-15: Event Description From Patient (FT)</li>
/// <li>PEO-16: Event Description From Practitioner (FT)</li>
/// <li>PEO-17: Event Description From Autopsy (FT)</li>
/// <li>PEO-18: Cause Of Death (CE)</li>
/// <li>PEO-19: Primary Observer Name (XPN)</li>
/// <li>PEO-20: Primary Observer Address (XAD)</li>
/// <li>PEO-21: Primary Observer Telephone (XTN)</li>
/// <li>PEO-22: Primary Observer’s Qualification (ID)</li>
/// <li>PEO-23: Confirmation Provided By (ID)</li>
/// <li>PEO-24: Primary Observer Aware Date/Time (TS)</li>
/// <li>PEO-25: Primary Observer’s Identity May Be Divulged (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PEO : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PEO class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PEO(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), false, 0, 60, new System.Object[]{message}, "Event Identifiers Used");
       this.add(typeof(CE), false, 0, 60, new System.Object[]{message}, "Event Symptom/Diagnosis Code");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Event Onset Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Event Exacerbation Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Event Improved Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Event Ended Data/Time");
       this.add(typeof(XAD), false, 1, 106, new System.Object[]{message}, "Event Location Occurred Address");
       this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 237}, "Event Qualification");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 238}, "Event Serious");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 239}, "Event Expected");
       this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 240}, "Event Outcome");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 241}, "Patient Outcome");
       this.add(typeof(FT), false, 0, 600, new System.Object[]{message}, "Event Description From Others");
       this.add(typeof(FT), false, 0, 600, new System.Object[]{message}, "Event From Original Reporter");
       this.add(typeof(FT), false, 0, 600, new System.Object[]{message}, "Event Description From Patient");
       this.add(typeof(FT), false, 0, 600, new System.Object[]{message}, "Event Description From Practitioner");
       this.add(typeof(FT), false, 0, 600, new System.Object[]{message}, "Event Description From Autopsy");
       this.add(typeof(CE), false, 0, 30, new System.Object[]{message}, "Cause Of Death");
       this.add(typeof(XPN), false, 1, 46, new System.Object[]{message}, "Primary Observer Name");
       this.add(typeof(XAD), false, 0, 106, new System.Object[]{message}, "Primary Observer Address");
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message}, "Primary Observer Telephone");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242}, "Primary Observer’s Qualification");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242}, "Confirmation Provided By");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Primary Observer Aware Date/Time");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 243}, "Primary Observer’s Identity May Be Divulged");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of Event Identifiers Used(PEO-1). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event identifiers used. </returns>

	public CE GetEventIdentifiersUsed(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(1, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Identifiers Used (PEO-1). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetEventIdentifiersUsed() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(1);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Identifiers Used (PEO-1). </summary>
  ///
  /// <value>   The event identifiers used repetitions used. </value>

  public int EventIdentifiersUsedRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(1);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Event Symptom/Diagnosis Code(PEO-2). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event symptom diagnosis code. </returns>

	public CE GetEventSymptomDiagnosisCode(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(2, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Symptom/Diagnosis Code (PEO-2). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetEventSymptomDiagnosisCode() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(2);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Symptom/Diagnosis Code (PEO-2). </summary>
  ///
  /// <value>   The event symptom diagnosis code repetitions used. </value>

  public int EventSymptomDiagnosisCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(2);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Event Onset Date/Time(PEO-3). </summary>
    ///
    /// <value> The event onset date time. </value>

	public TS EventOnsetDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Event Exacerbation Date/Time(PEO-4). </summary>
    ///
    /// <value> The event exacerbation date time. </value>

	public TS EventExacerbationDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Event Improved Date/Time(PEO-5). </summary>
    ///
    /// <value> The event improved date time. </value>

	public TS EventImprovedDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Event Ended Data/Time(PEO-6). </summary>
    ///
    /// <value> The event ended data time. </value>

	public TS EventEndedDataTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Event Location Occurred Address(PEO-7). </summary>
    ///
    /// <value> The event location occurred address. </value>

	public XAD EventLocationOccurredAddress
	{
		get{
			XAD ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (XAD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Event Qualification(PEO-8). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event qualification. </returns>

	public ID GetEventQualification(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(8, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Qualification (PEO-8). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetEventQualification() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(8);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Qualification (PEO-8). </summary>
  ///
  /// <value>   The event qualification repetitions used. </value>

  public int EventQualificationRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(8);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Event Serious(PEO-9). </summary>
    ///
    /// <value> The event serious. </value>

	public ID EventSerious
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Event Expected(PEO-10). </summary>
    ///
    /// <value> The event expected. </value>

	public ID EventExpected
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Event Outcome(PEO-11). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event outcome. </returns>

	public ID GetEventOutcome(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(11, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Outcome (PEO-11). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetEventOutcome() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(11);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Outcome (PEO-11). </summary>
  ///
  /// <value>   The event outcome repetitions used. </value>

  public int EventOutcomeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(11);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Patient Outcome(PEO-12). </summary>
    ///
    /// <value> The patient outcome. </value>

	public ID PatientOutcome
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Event Description From Others(PEO-13). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event description from others. </returns>

	public FT GetEventDescriptionFromOthers(int rep)
	{
			FT ret = null;
			try
			{
			IType t = this.GetField(13, rep);
				ret = (FT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Description From Others (PEO-13). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ft. </returns>

  public FT[] GetEventDescriptionFromOthers() {
     FT[] ret = null;
    try {
        IType[] t = this.GetField(13);  
        ret = new FT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FT)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Description From Others (PEO-13). </summary>
  ///
  /// <value>   The event description from others repetitions used. </value>

  public int EventDescriptionFromOthersRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(13);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Event From Original Reporter(PEO-14). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event from original reporter. </returns>

	public FT GetEventFromOriginalReporter(int rep)
	{
			FT ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (FT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event From Original Reporter (PEO-14). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ft. </returns>

  public FT[] GetEventFromOriginalReporter() {
     FT[] ret = null;
    try {
        IType[] t = this.GetField(14);  
        ret = new FT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FT)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event From Original Reporter (PEO-14). </summary>
  ///
  /// <value>   The event from original reporter repetitions used. </value>

  public int EventFromOriginalReporterRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(14);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Event Description From Patient(PEO-15). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event description from patient. </returns>

	public FT GetEventDescriptionFromPatient(int rep)
	{
			FT ret = null;
			try
			{
			IType t = this.GetField(15, rep);
				ret = (FT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Description From Patient (PEO-15). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ft. </returns>

  public FT[] GetEventDescriptionFromPatient() {
     FT[] ret = null;
    try {
        IType[] t = this.GetField(15);  
        ret = new FT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FT)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Description From Patient (PEO-15). </summary>
  ///
  /// <value>   The event description from patient repetitions used. </value>

  public int EventDescriptionFromPatientRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(15);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Event Description From Practitioner(PEO-16). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event description from practitioner. </returns>

	public FT GetEventDescriptionFromPractitioner(int rep)
	{
			FT ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (FT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Description From Practitioner (PEO-16). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ft. </returns>

  public FT[] GetEventDescriptionFromPractitioner() {
     FT[] ret = null;
    try {
        IType[] t = this.GetField(16);  
        ret = new FT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FT)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary>
  /// Returns the total repetitions of Event Description From Practitioner (PEO-16).
  /// </summary>
  ///
  /// <value>   The event description from practitioner repetitions used. </value>

  public int EventDescriptionFromPractitionerRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(16);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Event Description From Autopsy(PEO-17). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event description from autopsy. </returns>

	public FT GetEventDescriptionFromAutopsy(int rep)
	{
			FT ret = null;
			try
			{
			IType t = this.GetField(17, rep);
				ret = (FT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Description From Autopsy (PEO-17). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ft. </returns>

  public FT[] GetEventDescriptionFromAutopsy() {
     FT[] ret = null;
    try {
        IType[] t = this.GetField(17);  
        ret = new FT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FT)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Event Description From Autopsy (PEO-17). </summary>
  ///
  /// <value>   The event description from autopsy repetitions used. </value>

  public int EventDescriptionFromAutopsyRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(17);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Cause Of Death(PEO-18). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The cause of death. </returns>

	public CE GetCauseOfDeath(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(18, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Cause Of Death (PEO-18). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetCauseOfDeath() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(18);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Cause Of Death (PEO-18). </summary>
  ///
  /// <value>   The cause of death repetitions used. </value>

  public int CauseOfDeathRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(18);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Primary Observer Name(PEO-19). </summary>
    ///
    /// <value> The name of the primary observer. </value>

	public XPN PrimaryObserverName
	{
		get{
			XPN ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (XPN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Primary Observer Address(PEO-20). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The primary observer address. </returns>

	public XAD GetPrimaryObserverAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Primary Observer Address (PEO-20). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xad. </returns>

  public XAD[] GetPrimaryObserverAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(20);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Primary Observer Address (PEO-20). </summary>
  ///
  /// <value>   The primary observer address repetitions used. </value>

  public int PrimaryObserverAddressRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(20);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Primary Observer Telephone(PEO-21). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The primary observer telephone. </returns>

	public XTN GetPrimaryObserverTelephone(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Primary Observer Telephone (PEO-21). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetPrimaryObserverTelephone() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(21);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Primary Observer Telephone (PEO-21). </summary>
  ///
  /// <value>   The primary observer telephone repetitions used. </value>

  public int PrimaryObserverTelephoneRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(21);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Primary Observer’s Qualification(PEO-22). </summary>
    ///
    /// <value> The primary observer s qualification. </value>

	public ID PrimaryObserverSQualification
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Confirmation Provided By(PEO-23). </summary>
    ///
    /// <value> Amount to confirmation provided by. </value>

	public ID ConfirmationProvidedBy
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Primary Observer Aware Date/Time(PEO-24). </summary>
    ///
    /// <value> The primary observer aware date time. </value>

	public TS PrimaryObserverAwareDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(24, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Primary Observer’s Identity May Be Divulged(PEO-25). </summary>
    ///
    /// <value> The primary observer s identity may be divulged. </value>

	public ID PrimaryObserverSIdentityMayBeDivulged
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(25, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}