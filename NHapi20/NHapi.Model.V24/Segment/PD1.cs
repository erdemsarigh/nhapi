using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 PD1 message segment. This segment has the following fields:<ol>
/// <li>PD1-1: Living Dependency (IS)</li>
/// <li>PD1-2: Living Arrangement (IS)</li>
/// <li>PD1-3: Patient Primary Facility (XON)</li>
/// <li>PD1-4: Patient Primary Care Provider Name and ID No. (XCN)</li>
/// <li>PD1-5: Student Indicator (IS)</li>
/// <li>PD1-6: Handicap (IS)</li>
/// <li>PD1-7: Living Will Code (IS)</li>
/// <li>PD1-8: Organ Donor Code (IS)</li>
/// <li>PD1-9: Separate Bill (ID)</li>
/// <li>PD1-10: Duplicate Patient (CX)</li>
/// <li>PD1-11: Publicity Code (CE)</li>
/// <li>PD1-12: Protection Indicator (ID)</li>
/// <li>PD1-13: Protection Indicator Effective Date (DT)</li>
/// <li>PD1-14: Place of Worship (XON)</li>
/// <li>PD1-15: Advance Directive Code (CE)</li>
/// <li>PD1-16: Immunization Registry Status (IS)</li>
/// <li>PD1-17: Immunization Registry Status Effective Date (DT)</li>
/// <li>PD1-18: Publicity Code Effective Date (DT)</li>
/// <li>PD1-19: Military Branch (IS)</li>
/// <li>PD1-20: Military Rank/Grade (IS)</li>
/// <li>PD1-21: Military Status (IS)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PD1 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PD1 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PD1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 223}, "Living Dependency");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220}, "Living Arrangement");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Patient Primary Facility");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Patient Primary Care Provider Name and ID No.");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231}, "Student Indicator");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295}, "Handicap");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 315}, "Living Will Code");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 316}, "Organ Donor Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Separate Bill");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Duplicate Patient");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Publicity Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Protection Indicator");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Protection Indicator Effective Date");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Place of Worship");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Advance Directive Code");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 441}, "Immunization Registry Status");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Immunization Registry Status Effective Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Publicity Code Effective Date");
       this.add(typeof(IS), false, 1, 5, new System.Object[]{message, 140}, "Military Branch");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 141}, "Military Rank/Grade");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 142}, "Military Status");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of Living Dependency(PD1-1). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The living dependency. </returns>

	public IS GetLivingDependency(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(1, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Living Dependency (PD1-1). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetLivingDependency() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(1);  
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

  /// <summary> Returns the total repetitions of Living Dependency (PD1-1). </summary>
  ///
  /// <value>   The living dependency repetitions used. </value>

  public int LivingDependencyRepetitionsUsed
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

    /// <summary>   Returns Living Arrangement(PD1-2). </summary>
    ///
    /// <value> The living arrangement. </value>

	public IS LivingArrangement
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

    /// <summary>
    /// Returns a single repetition of Patient Primary Facility(PD1-3). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The patient primary facility. </returns>

	public XON GetPatientPrimaryFacility(int rep)
	{
			XON ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Patient Primary Facility (PD1-3). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of XON. </returns>

  public XON[] GetPatientPrimaryFacility() {
     XON[] ret = null;
    try {
        IType[] t = this.GetField(3);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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

  /// <summary> Returns the total repetitions of Patient Primary Facility (PD1-3). </summary>
  ///
  /// <value>   The patient primary facility repetitions used. </value>

  public int PatientPrimaryFacilityRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(3);
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
    /// Returns a single repetition of Patient Primary Care Provider Name and ID No.(PD1-4). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The patient primary care provider name identifier no. </returns>

	public XCN GetPatientPrimaryCareProviderNameIDNo(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Patient Primary Care Provider Name and ID No. (PD1-4).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetPatientPrimaryCareProviderNameIDNo() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(4);  
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

  /// <summary>
  /// Returns the total repetitions of Patient Primary Care Provider Name and ID No. (PD1-4).
  /// </summary>
  ///
  /// <value>   The patient primary care provider name identifier no repetitions used. </value>

  public int PatientPrimaryCareProviderNameIDNoRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(4);
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

    /// <summary>   Returns Student Indicator(PD1-5). </summary>
    ///
    /// <value> The student indicator. </value>

	public IS StudentIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

    /// <summary>   Returns Handicap(PD1-6). </summary>
    ///
    /// <value> The handicap. </value>

	public IS Handicap
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

    /// <summary>   Returns Living Will Code(PD1-7). </summary>
    ///
    /// <value> The living will code. </value>

	public IS LivingWillCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

    /// <summary>   Returns Organ Donor Code(PD1-8). </summary>
    ///
    /// <value> The organ donor code. </value>

	public IS OrganDonorCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

    /// <summary>   Returns Separate Bill(PD1-9). </summary>
    ///
    /// <value> The separate bill. </value>

	public ID SeparateBill
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

    /// <summary>
    /// Returns a single repetition of Duplicate Patient(PD1-10). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The duplicate patient. </returns>

	public CX GetDuplicatePatient(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Duplicate Patient (PD1-10). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of cx. </returns>

  public CX[] GetDuplicatePatient() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
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

  /// <summary> Returns the total repetitions of Duplicate Patient (PD1-10). </summary>
  ///
  /// <value>   The duplicate patient repetitions used. </value>

  public int DuplicatePatientRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(10);
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

    /// <summary>   Returns Publicity Code(PD1-11). </summary>
    ///
    /// <value> The publicity code. </value>

	public CE PublicityCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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

    /// <summary>   Returns Protection Indicator(PD1-12). </summary>
    ///
    /// <value> The protection indicator. </value>

	public ID ProtectionIndicator
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

    /// <summary>   Returns Protection Indicator Effective Date(PD1-13). </summary>
    ///
    /// <value> The protection indicator effective date. </value>

	public DT ProtectionIndicatorEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

    /// <summary>
    /// Returns a single repetition of Place of Worship(PD1-14). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The place of worship. </returns>

	public XON GetPlaceOfWorship(int rep)
	{
			XON ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Place of Worship (PD1-14). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of XON. </returns>

  public XON[] GetPlaceOfWorship() {
     XON[] ret = null;
    try {
        IType[] t = this.GetField(14);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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

  /// <summary> Returns the total repetitions of Place of Worship (PD1-14). </summary>
  ///
  /// <value>   The place of worship repetitions used. </value>

  public int PlaceOfWorshipRepetitionsUsed
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
    /// Returns a single repetition of Advance Directive Code(PD1-15). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The advance directive code. </returns>

	public CE GetAdvanceDirectiveCode(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(15, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Advance Directive Code (PD1-15). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetAdvanceDirectiveCode() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(15);  
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

  /// <summary> Returns the total repetitions of Advance Directive Code (PD1-15). </summary>
  ///
  /// <value>   The advance directive code repetitions used. </value>

  public int AdvanceDirectiveCodeRepetitionsUsed
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

    /// <summary>   Returns Immunization Registry Status(PD1-16). </summary>
    ///
    /// <value> The immunization registry status. </value>

	public IS ImmunizationRegistryStatus
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

    /// <summary>   Returns Immunization Registry Status Effective Date(PD1-17). </summary>
    ///
    /// <value> The immunization registry status effective date. </value>

	public DT ImmunizationRegistryStatusEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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

    /// <summary>   Returns Publicity Code Effective Date(PD1-18). </summary>
    ///
    /// <value> The publicity code effective date. </value>

	public DT PublicityCodeEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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

    /// <summary>   Returns Military Branch(PD1-19). </summary>
    ///
    /// <value> The military branch. </value>

	public IS MilitaryBranch
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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

    /// <summary>   Returns Military Rank/Grade(PD1-20). </summary>
    ///
    /// <value> The military rank grade. </value>

	public IS MilitaryRankGrade
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(20, 0);
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

    /// <summary>   Returns Military Status(PD1-21). </summary>
    ///
    /// <value> The military status. </value>

	public IS MilitaryStatus
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


}}