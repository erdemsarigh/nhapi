using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V231.Segment{

/// <summary>
/// Represents an HL7 PV1 message segment. This segment has the following fields:<ol>
/// <li>PV1-1: Set ID - PV1 (SI)</li>
/// <li>PV1-2: Patient Class (IS)</li>
/// <li>PV1-3: Assigned Patient Location (PL)</li>
/// <li>PV1-4: Admission Type (IS)</li>
/// <li>PV1-5: Preadmit Number (CX)</li>
/// <li>PV1-6: Prior Patient Location (PL)</li>
/// <li>PV1-7: Attending Doctor (XCN)</li>
/// <li>PV1-8: Referring Doctor (XCN)</li>
/// <li>PV1-9: Consulting Doctor (XCN)</li>
/// <li>PV1-10: Hospital Service (IS)</li>
/// <li>PV1-11: Temporary Location (PL)</li>
/// <li>PV1-12: Preadmit Test Indicator (IS)</li>
/// <li>PV1-13: Re-admission Indicator (IS)</li>
/// <li>PV1-14: Admit Source (IS)</li>
/// <li>PV1-15: Ambulatory Status (IS)</li>
/// <li>PV1-16: VIP Indicator (IS)</li>
/// <li>PV1-17: Admitting Doctor (XCN)</li>
/// <li>PV1-18: Patient Type (IS)</li>
/// <li>PV1-19: Visit Number (CX)</li>
/// <li>PV1-20: Financial Class (FC)</li>
/// <li>PV1-21: Charge Price Indicator (IS)</li>
/// <li>PV1-22: Courtesy Code (IS)</li>
/// <li>PV1-23: Credit Rating (IS)</li>
/// <li>PV1-24: Contract Code (IS)</li>
/// <li>PV1-25: Contract Effective Date (DT)</li>
/// <li>PV1-26: Contract Amount (NM)</li>
/// <li>PV1-27: Contract Period (NM)</li>
/// <li>PV1-28: Interest Code (IS)</li>
/// <li>PV1-29: Transfer to Bad Debt Code (IS)</li>
/// <li>PV1-30: Transfer to Bad Debt Date (DT)</li>
/// <li>PV1-31: Bad Debt Agency Code (IS)</li>
/// <li>PV1-32: Bad Debt Transfer Amount (NM)</li>
/// <li>PV1-33: Bad Debt Recovery Amount (NM)</li>
/// <li>PV1-34: Delete Account Indicator (IS)</li>
/// <li>PV1-35: Delete Account Date (DT)</li>
/// <li>PV1-36: Discharge Disposition (IS)</li>
/// <li>PV1-37: Discharged to Location (DLD)</li>
/// <li>PV1-38: Diet Type (CE)</li>
/// <li>PV1-39: Servicing Facility (IS)</li>
/// <li>PV1-40: Bed Status (IS)</li>
/// <li>PV1-41: Account Status (IS)</li>
/// <li>PV1-42: Pending Location (PL)</li>
/// <li>PV1-43: Prior Temporary Location (PL)</li>
/// <li>PV1-44: Admit Date/Time (TS)</li>
/// <li>PV1-45: Discharge Date/Time (TS)</li>
/// <li>PV1-46: Current Patient Balance (NM)</li>
/// <li>PV1-47: Total Charges (NM)</li>
/// <li>PV1-48: Total Adjustments (NM)</li>
/// <li>PV1-49: Total Payments (NM)</li>
/// <li>PV1-50: Alternate Visit ID (CX)</li>
/// <li>PV1-51: Visit Indicator (IS)</li>
/// <li>PV1-52: Other Healthcare Provider (XCN)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PV1 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PV1 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PV1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - PV1");
       this.add(typeof(IS), true, 1, 1, new System.Object[]{message, 4}, "Patient Class");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Assigned Patient Location");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 7}, "Admission Type");
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message}, "Preadmit Number");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Prior Patient Location");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Attending Doctor");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Referring Doctor");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Consulting Doctor");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 69}, "Hospital Service");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Temporary Location");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 87}, "Preadmit Test Indicator");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 92}, "Re-admission Indicator");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 23}, "Admit Source");
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9}, "Ambulatory Status");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 99}, "VIP Indicator");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Admitting Doctor");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 18}, "Patient Type");
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message}, "Visit Number");
       this.add(typeof(FC), false, 0, 50, new System.Object[]{message}, "Financial Class");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 32}, "Charge Price Indicator");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 45}, "Courtesy Code");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 46}, "Credit Rating");
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 44}, "Contract Code");
       this.add(typeof(DT), false, 0, 8, new System.Object[]{message}, "Contract Effective Date");
       this.add(typeof(NM), false, 0, 12, new System.Object[]{message}, "Contract Amount");
       this.add(typeof(NM), false, 0, 3, new System.Object[]{message}, "Contract Period");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 73}, "Interest Code");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 110}, "Transfer to Bad Debt Code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Transfer to Bad Debt Date");
       this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 21}, "Bad Debt Agency Code");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Bad Debt Transfer Amount");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Bad Debt Recovery Amount");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 111}, "Delete Account Indicator");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Delete Account Date");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 112}, "Discharge Disposition");
       this.add(typeof(DLD), false, 1, 25, new System.Object[]{message}, "Discharged to Location");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Diet Type");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 115}, "Servicing Facility");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 116}, "Bed Status");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 117}, "Account Status");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Pending Location");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Prior Temporary Location");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Admit Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Discharge Date/Time");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Current Patient Balance");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Total Charges");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Total Adjustments");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Total Payments");
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message}, "Alternate Visit ID");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 326}, "Visit Indicator");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Other Healthcare Provider");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Set ID - PV1(PV1-1). </summary>
    ///
    /// <value> The set idpv 1. </value>

	public SI SetIDPV1
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (SI)t;
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

    /// <summary>   Returns Patient Class(PV1-2). </summary>
    ///
    /// <value> The patient class. </value>

	public IS PatientClass
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Assigned Patient Location(PV1-3). </summary>
    ///
    /// <value> The assigned patient location. </value>

	public PL AssignedPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns Admission Type(PV1-4). </summary>
    ///
    /// <value> The type of the admission. </value>

	public IS AdmissionType
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Preadmit Number(PV1-5). </summary>
    ///
    /// <value> The preadmit number. </value>

	public CX PreadmitNumber
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (CX)t;
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

    /// <summary>   Returns Prior Patient Location(PV1-6). </summary>
    ///
    /// <value> The prior patient location. </value>

	public PL PriorPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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
    /// Returns a single repetition of Attending Doctor(PV1-7). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The attending doctor. </returns>

	public XCN GetAttendingDoctor(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Attending Doctor (PV1-7). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetAttendingDoctor() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(7);  
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

  /// <summary> Returns the total repetitions of Attending Doctor (PV1-7). </summary>
  ///
  /// <value>   The attending doctor repetitions used. </value>

  public int AttendingDoctorRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(7);
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
    /// Returns a single repetition of Referring Doctor(PV1-8). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The referring doctor. </returns>

	public XCN GetReferringDoctor(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(8, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Referring Doctor (PV1-8). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetReferringDoctor() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(8);  
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

  /// <summary> Returns the total repetitions of Referring Doctor (PV1-8). </summary>
  ///
  /// <value>   The referring doctor repetitions used. </value>

  public int ReferringDoctorRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Consulting Doctor(PV1-9). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The consulting doctor. </returns>

	public XCN GetConsultingDoctor(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Consulting Doctor (PV1-9). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetConsultingDoctor() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(9);  
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

  /// <summary> Returns the total repetitions of Consulting Doctor (PV1-9). </summary>
  ///
  /// <value>   The consulting doctor repetitions used. </value>

  public int ConsultingDoctorRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(9);
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

    /// <summary>   Returns Hospital Service(PV1-10). </summary>
    ///
    /// <value> The hospital service. </value>

	public IS HospitalService
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Temporary Location(PV1-11). </summary>
    ///
    /// <value> The temporary location. </value>

	public PL TemporaryLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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

    /// <summary>   Returns Preadmit Test Indicator(PV1-12). </summary>
    ///
    /// <value> The preadmit test indicator. </value>

	public IS PreadmitTestIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Re-admission Indicator(PV1-13). </summary>
    ///
    /// <value> The re admission indicator. </value>

	public IS ReAdmissionIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Admit Source(PV1-14). </summary>
    ///
    /// <value> The admit source. </value>

	public IS AdmitSource
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(14, 0);
				ret = (IS)t;
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
    /// Returns a single repetition of Ambulatory Status(PV1-15). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The ambulatory status. </returns>

	public IS GetAmbulatoryStatus(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(15, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Ambulatory Status (PV1-15). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetAmbulatoryStatus() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(15);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
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

  /// <summary> Returns the total repetitions of Ambulatory Status (PV1-15). </summary>
  ///
  /// <value>   The ambulatory status repetitions used. </value>

  public int AmbulatoryStatusRepetitionsUsed
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

    /// <summary>   Returns VIP Indicator(PV1-16). </summary>
    ///
    /// <value> The vip indicator. </value>

	public IS VIPIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(16, 0);
				ret = (IS)t;
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
    /// Returns a single repetition of Admitting Doctor(PV1-17). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The admitting doctor. </returns>

	public XCN GetAdmittingDoctor(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(17, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Admitting Doctor (PV1-17). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetAdmittingDoctor() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(17);  
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

  /// <summary> Returns the total repetitions of Admitting Doctor (PV1-17). </summary>
  ///
  /// <value>   The admitting doctor repetitions used. </value>

  public int AdmittingDoctorRepetitionsUsed
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

    /// <summary>   Returns Patient Type(PV1-18). </summary>
    ///
    /// <value> The type of the patient. </value>

	public IS PatientType
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(18, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Visit Number(PV1-19). </summary>
    ///
    /// <value> The visit number. </value>

	public CX VisitNumber
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (CX)t;
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
    /// Returns a single repetition of Financial Class(PV1-20). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The financial class. </returns>

	public FC GetFinancialClass(int rep)
	{
			FC ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (FC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Financial Class (PV1-20). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of fc. </returns>

  public FC[] GetFinancialClass() {
     FC[] ret = null;
    try {
        IType[] t = this.GetField(20);  
        ret = new FC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FC)t[i];
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

  /// <summary> Returns the total repetitions of Financial Class (PV1-20). </summary>
  ///
  /// <value>   The financial class repetitions used. </value>

  public int FinancialClassRepetitionsUsed
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

    /// <summary>   Returns Charge Price Indicator(PV1-21). </summary>
    ///
    /// <value> The charge price indicator. </value>

	public IS ChargePriceIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Courtesy Code(PV1-22). </summary>
    ///
    /// <value> The courtesy code. </value>

	public IS CourtesyCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Credit Rating(PV1-23). </summary>
    ///
    /// <value> The credit rating. </value>

	public IS CreditRating
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (IS)t;
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
    /// Returns a single repetition of Contract Code(PV1-24). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The contract code. </returns>

	public IS GetContractCode(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(24, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Contract Code (PV1-24). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetContractCode() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(24);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
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

  /// <summary> Returns the total repetitions of Contract Code (PV1-24). </summary>
  ///
  /// <value>   The contract code repetitions used. </value>

  public int ContractCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(24);
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
    /// Returns a single repetition of Contract Effective Date(PV1-25). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The contract effective date. </returns>

	public DT GetContractEffectiveDate(int rep)
	{
			DT ret = null;
			try
			{
			IType t = this.GetField(25, rep);
				ret = (DT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Contract Effective Date (PV1-25). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of dt. </returns>

  public DT[] GetContractEffectiveDate() {
     DT[] ret = null;
    try {
        IType[] t = this.GetField(25);  
        ret = new DT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DT)t[i];
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

  /// <summary> Returns the total repetitions of Contract Effective Date (PV1-25). </summary>
  ///
  /// <value>   The contract effective date repetitions used. </value>

  public int ContractEffectiveDateRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(25);
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
    /// Returns a single repetition of Contract Amount(PV1-26). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The contract amount. </returns>

	public NM GetContractAmount(int rep)
	{
			NM ret = null;
			try
			{
			IType t = this.GetField(26, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Contract Amount (PV1-26). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of nm. </returns>

  public NM[] GetContractAmount() {
     NM[] ret = null;
    try {
        IType[] t = this.GetField(26);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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

  /// <summary> Returns the total repetitions of Contract Amount (PV1-26). </summary>
  ///
  /// <value>   The contract amount repetitions used. </value>

  public int ContractAmountRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(26);
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
    /// Returns a single repetition of Contract Period(PV1-27). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The contract period. </returns>

	public NM GetContractPeriod(int rep)
	{
			NM ret = null;
			try
			{
			IType t = this.GetField(27, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Contract Period (PV1-27). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of nm. </returns>

  public NM[] GetContractPeriod() {
     NM[] ret = null;
    try {
        IType[] t = this.GetField(27);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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

  /// <summary> Returns the total repetitions of Contract Period (PV1-27). </summary>
  ///
  /// <value>   The contract period repetitions used. </value>

  public int ContractPeriodRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(27);
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

    /// <summary>   Returns Interest Code(PV1-28). </summary>
    ///
    /// <value> The interest code. </value>

	public IS InterestCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(28, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Transfer to Bad Debt Code(PV1-29). </summary>
    ///
    /// <value> The transfer to bad debt code. </value>

	public IS TransferToBadDebtCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(29, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Transfer to Bad Debt Date(PV1-30). </summary>
    ///
    /// <value> The transfer to bad debt date. </value>

	public DT TransferToBadDebtDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(30, 0);
				ret = (DT)t;
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

    /// <summary>   Returns Bad Debt Agency Code(PV1-31). </summary>
    ///
    /// <value> The bad debt agency code. </value>

	public IS BadDebtAgencyCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(31, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Bad Debt Transfer Amount(PV1-32). </summary>
    ///
    /// <value> The bad debt transfer amount. </value>

	public NM BadDebtTransferAmount
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(32, 0);
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

    /// <summary>   Returns Bad Debt Recovery Amount(PV1-33). </summary>
    ///
    /// <value> The bad debt recovery amount. </value>

	public NM BadDebtRecoveryAmount
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(33, 0);
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

    /// <summary>   Returns Delete Account Indicator(PV1-34). </summary>
    ///
    /// <value> The delete account indicator. </value>

	public IS DeleteAccountIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(34, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Delete Account Date(PV1-35). </summary>
    ///
    /// <value> The delete account date. </value>

	public DT DeleteAccountDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(35, 0);
				ret = (DT)t;
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

    /// <summary>   Returns Discharge Disposition(PV1-36). </summary>
    ///
    /// <value> The discharge disposition. </value>

	public IS DischargeDisposition
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(36, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Discharged to Location(PV1-37). </summary>
    ///
    /// <value> The discharged to location. </value>

	public DLD DischargedToLocation
	{
		get{
			DLD ret = null;
			try
			{
			IType t = this.GetField(37, 0);
				ret = (DLD)t;
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

    /// <summary>   Returns Diet Type(PV1-38). </summary>
    ///
    /// <value> The type of the diet. </value>

	public CE DietType
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(38, 0);
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

    /// <summary>   Returns Servicing Facility(PV1-39). </summary>
    ///
    /// <value> The servicing facility. </value>

	public IS ServicingFacility
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(39, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Bed Status(PV1-40). </summary>
    ///
    /// <value> The bed status. </value>

	public IS BedStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(40, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Account Status(PV1-41). </summary>
    ///
    /// <value> The account status. </value>

	public IS AccountStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(41, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Pending Location(PV1-42). </summary>
    ///
    /// <value> The pending location. </value>

	public PL PendingLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(42, 0);
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

    /// <summary>   Returns Prior Temporary Location(PV1-43). </summary>
    ///
    /// <value> The prior temporary location. </value>

	public PL PriorTemporaryLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(43, 0);
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

    /// <summary>   Returns Admit Date/Time(PV1-44). </summary>
    ///
    /// <value> The admit date time. </value>

	public TS AdmitDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(44, 0);
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

    /// <summary>   Returns Discharge Date/Time(PV1-45). </summary>
    ///
    /// <value> The discharge date time. </value>

	public TS DischargeDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(45, 0);
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

    /// <summary>   Returns Current Patient Balance(PV1-46). </summary>
    ///
    /// <value> The current patient balance. </value>

	public NM CurrentPatientBalance
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(46, 0);
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

    /// <summary>   Returns Total Charges(PV1-47). </summary>
    ///
    /// <value> The total number of charges. </value>

	public NM TotalCharges
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(47, 0);
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

    /// <summary>   Returns Total Adjustments(PV1-48). </summary>
    ///
    /// <value> The total number of adjustments. </value>

	public NM TotalAdjustments
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(48, 0);
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

    /// <summary>   Returns Total Payments(PV1-49). </summary>
    ///
    /// <value> The total number of payments. </value>

	public NM TotalPayments
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(49, 0);
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

    /// <summary>   Returns Alternate Visit ID(PV1-50). </summary>
    ///
    /// <value> The identifier of the alternate visit. </value>

	public CX AlternateVisitID
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(50, 0);
				ret = (CX)t;
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

    /// <summary>   Returns Visit Indicator(PV1-51). </summary>
    ///
    /// <value> The visit indicator. </value>

	public IS VisitIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(51, 0);
				ret = (IS)t;
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
    /// Returns a single repetition of Other Healthcare Provider(PV1-52). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The other healthcare provider. </returns>

	public XCN GetOtherHealthcareProvider(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(52, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Other Healthcare Provider (PV1-52). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetOtherHealthcareProvider() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(52);  
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

  /// <summary> Returns the total repetitions of Other Healthcare Provider (PV1-52). </summary>
  ///
  /// <value>   The other healthcare provider repetitions used. </value>

  public int OtherHealthcareProviderRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(52);
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

}}