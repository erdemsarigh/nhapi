using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V231.Segment{

/// <summary>
/// Represents an HL7 SCH message segment. This segment has the following fields:<ol>
/// <li>SCH-1: Placer Appointment ID (EI)</li>
/// <li>SCH-2: Filler Appointment ID (EI)</li>
/// <li>SCH-3: Occurrence Number (NM)</li>
/// <li>SCH-4: Placer Group Number (EI)</li>
/// <li>SCH-5: Schedule ID (CE)</li>
/// <li>SCH-6: Event Reason (CE)</li>
/// <li>SCH-7: Appointment Reason (CE)</li>
/// <li>SCH-8: Appointment Type (CE)</li>
/// <li>SCH-9: Appointment Duration (NM)</li>
/// <li>SCH-10: Appointment Duration Units (CE)</li>
/// <li>SCH-11: Appointment Timing Quantity (TQ)</li>
/// <li>SCH-12: Placer Contact Person (XCN)</li>
/// <li>SCH-13: Placer Contact Phone Number (XTN)</li>
/// <li>SCH-14: Placer Contact Address (XAD)</li>
/// <li>SCH-15: Placer Contact Location (PL)</li>
/// <li>SCH-16: Filler Contact Person (XCN)</li>
/// <li>SCH-17: Filler Contact Phone Number (XTN)</li>
/// <li>SCH-18: Filler Contact Address (XAD)</li>
/// <li>SCH-19: Filler Contact Location (PL)</li>
/// <li>SCH-20: Entered by Person (XCN)</li>
/// <li>SCH-21: Entered by Phone Number (XTN)</li>
/// <li>SCH-22: Entered by Location (PL)</li>
/// <li>SCH-23: Parent Placer Appointment ID (EI)</li>
/// <li>SCH-24: Parent Filler Appointment ID (EI)</li>
/// <li>SCH-25: Filler Status Code (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class SCH : AbstractSegment  {

    /// <summary>   Initializes a new instance of the SCH class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public SCH(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Placer Appointment ID");
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Filler Appointment ID");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Occurrence Number");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Placer Group Number");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Schedule ID");
       this.add(typeof(CE), true, 1, 200, new System.Object[]{message}, "Event Reason");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Appointment Reason");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Appointment Type");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Appointment Duration");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Appointment Duration Units");
       this.add(typeof(TQ), true, 0, 200, new System.Object[]{message}, "Appointment Timing Quantity");
       this.add(typeof(XCN), false, 0, 48, new System.Object[]{message}, "Placer Contact Person");
       this.add(typeof(XTN), false, 1, 40, new System.Object[]{message}, "Placer Contact Phone Number");
       this.add(typeof(XAD), false, 0, 106, new System.Object[]{message}, "Placer Contact Address");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Placer Contact Location");
       this.add(typeof(XCN), true, 0, 38, new System.Object[]{message}, "Filler Contact Person");
       this.add(typeof(XTN), false, 1, 40, new System.Object[]{message}, "Filler Contact Phone Number");
       this.add(typeof(XAD), false, 0, 106, new System.Object[]{message}, "Filler Contact Address");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Filler Contact Location");
       this.add(typeof(XCN), true, 0, 48, new System.Object[]{message}, "Entered by Person");
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message}, "Entered by Phone Number");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Entered by Location");
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Parent Placer Appointment ID");
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Parent Filler Appointment ID");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Filler Status Code");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Placer Appointment ID(SCH-1). </summary>
    ///
    /// <value> The identifier of the placer appointment. </value>

	public EI PlacerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (EI)t;
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

    /// <summary>   Returns Filler Appointment ID(SCH-2). </summary>
    ///
    /// <value> The identifier of the filler appointment. </value>

	public EI FillerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (EI)t;
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

    /// <summary>   Returns Occurrence Number(SCH-3). </summary>
    ///
    /// <value> The occurrence number. </value>

	public NM OccurrenceNumber
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (NM)t;
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

    /// <summary>   Returns Placer Group Number(SCH-4). </summary>
    ///
    /// <value> The placer group number. </value>

	public EI PlacerGroupNumber
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (EI)t;
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

    /// <summary>   Returns Schedule ID(SCH-5). </summary>
    ///
    /// <value> The identifier of the schedule. </value>

	public CE ScheduleID
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (CE)t;
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

    /// <summary>   Returns Event Reason(SCH-6). </summary>
    ///
    /// <value> The event reason. </value>

	public CE EventReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (CE)t;
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

    /// <summary>   Returns Appointment Reason(SCH-7). </summary>
    ///
    /// <value> The appointment reason. </value>

	public CE AppointmentReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (CE)t;
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

    /// <summary>   Returns Appointment Type(SCH-8). </summary>
    ///
    /// <value> The type of the appointment. </value>

	public CE AppointmentType
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (CE)t;
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

    /// <summary>   Returns Appointment Duration(SCH-9). </summary>
    ///
    /// <value> The appointment duration. </value>

	public NM AppointmentDuration
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (NM)t;
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

    /// <summary>   Returns Appointment Duration Units(SCH-10). </summary>
    ///
    /// <value> The appointment duration units. </value>

	public CE AppointmentDurationUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (CE)t;
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
    /// Returns a single repetition of Appointment Timing Quantity(SCH-11). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The appointment timing quantity. </returns>

	public TQ GetAppointmentTimingQuantity(int rep)
	{
			TQ ret = null;
			try
			{
			IType t = this.GetField(11, rep);
				ret = (TQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Appointment Timing Quantity (SCH-11). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of tq. </returns>

  public TQ[] GetAppointmentTimingQuantity() {
     TQ[] ret = null;
    try {
        IType[] t = this.GetField(11);  
        ret = new TQ[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TQ)t[i];
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

  /// <summary> Returns the total repetitions of Appointment Timing Quantity (SCH-11). </summary>
  ///
  /// <value>   The appointment timing quantity repetitions used. </value>

  public int AppointmentTimingQuantityRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Placer Contact Person(SCH-12). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The placer contact person. </returns>

	public XCN GetPlacerContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(12, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Placer Contact Person (SCH-12). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetPlacerContactPerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(12);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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

  /// <summary> Returns the total repetitions of Placer Contact Person (SCH-12). </summary>
  ///
  /// <value>   The placer contact person repetitions used. </value>

  public int PlacerContactPersonRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(12);
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

    /// <summary>   Returns Placer Contact Phone Number(SCH-13). </summary>
    ///
    /// <value> The placer contact phone number. </value>

	public XTN PlacerContactPhoneNumber
	{
		get{
			XTN ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (XTN)t;
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
    /// Returns a single repetition of Placer Contact Address(SCH-14). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The placer contact address. </returns>

	public XAD GetPlacerContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Placer Contact Address (SCH-14). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xad. </returns>

  public XAD[] GetPlacerContactAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(14);  
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

  /// <summary> Returns the total repetitions of Placer Contact Address (SCH-14). </summary>
  ///
  /// <value>   The placer contact address repetitions used. </value>

  public int PlacerContactAddressRepetitionsUsed
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

    /// <summary>   Returns Placer Contact Location(SCH-15). </summary>
    ///
    /// <value> The placer contact location. </value>

	public PL PlacerContactLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (PL)t;
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
    /// Returns a single repetition of Filler Contact Person(SCH-16). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The filler contact person. </returns>

	public XCN GetFillerContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Filler Contact Person (SCH-16). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetFillerContactPerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(16);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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

  /// <summary> Returns the total repetitions of Filler Contact Person (SCH-16). </summary>
  ///
  /// <value>   The filler contact person repetitions used. </value>

  public int FillerContactPersonRepetitionsUsed
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

    /// <summary>   Returns Filler Contact Phone Number(SCH-17). </summary>
    ///
    /// <value> The filler contact phone number. </value>

	public XTN FillerContactPhoneNumber
	{
		get{
			XTN ret = null;
			try
			{
			IType t = this.GetField(17, 0);
				ret = (XTN)t;
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
    /// Returns a single repetition of Filler Contact Address(SCH-18). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The filler contact address. </returns>

	public XAD GetFillerContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(18, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Filler Contact Address (SCH-18). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xad. </returns>

  public XAD[] GetFillerContactAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(18);  
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

  /// <summary> Returns the total repetitions of Filler Contact Address (SCH-18). </summary>
  ///
  /// <value>   The filler contact address repetitions used. </value>

  public int FillerContactAddressRepetitionsUsed
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

    /// <summary>   Returns Filler Contact Location(SCH-19). </summary>
    ///
    /// <value> The filler contact location. </value>

	public PL FillerContactLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (PL)t;
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
    /// Returns a single repetition of Entered by Person(SCH-20). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The entered by person. </returns>

	public XCN GetEnteredByPerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Entered by Person (SCH-20). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetEnteredByPerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(20);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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

  /// <summary> Returns the total repetitions of Entered by Person (SCH-20). </summary>
  ///
  /// <value>   The entered by person repetitions used. </value>

  public int EnteredByPersonRepetitionsUsed
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
    /// Returns a single repetition of Entered by Phone Number(SCH-21). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The entered by phone number. </returns>

	public XTN GetEnteredByPhoneNumber(int rep)
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

  /// <summary> Returns all repetitions of Entered by Phone Number (SCH-21). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetEnteredByPhoneNumber() {
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

  /// <summary> Returns the total repetitions of Entered by Phone Number (SCH-21). </summary>
  ///
  /// <value>   The entered by phone number repetitions used. </value>

  public int EnteredByPhoneNumberRepetitionsUsed
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

    /// <summary>   Returns Entered by Location(SCH-22). </summary>
    ///
    /// <value> The entered by location. </value>

	public PL EnteredByLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (PL)t;
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

    /// <summary>   Returns Parent Placer Appointment ID(SCH-23). </summary>
    ///
    /// <value> The identifier of the parent placer appointment. </value>

	public EI ParentPlacerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (EI)t;
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

    /// <summary>   Returns Parent Filler Appointment ID(SCH-24). </summary>
    ///
    /// <value> The identifier of the parent filler appointment. </value>

	public EI ParentFillerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(24, 0);
				ret = (EI)t;
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

    /// <summary>   Returns Filler Status Code(SCH-25). </summary>
    ///
    /// <value> The filler status code. </value>

	public CE FillerStatusCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(25, 0);
				ret = (CE)t;
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