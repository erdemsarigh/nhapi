using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/// <summary>
/// Represents an HL7 UB1 message segment. This segment has the following fields:<ol>
/// <li>UB1-1: SET ID - UB82 (SI)</li>
/// <li>UB1-2: BLOOD DEDUCTIBLE (ST)</li>
/// <li>UB1-3: BLOOD FURN.-PINTS OF (40) (ST)</li>
/// <li>UB1-4: BLOOD REPLACED-PINTS (41) (ST)</li>
/// <li>UB1-5: BLOOD NOT RPLCD-PINTS(42) (ST)</li>
/// <li>UB1-6: CO-INSURANCE DAYS (25) (ST)</li>
/// <li>UB1-7: CONDITION CODE (ID)</li>
/// <li>UB1-8: COVERED DAYS - (23) (ST)</li>
/// <li>UB1-9: NON COVERED DAYS - (24) (ST)</li>
/// <li>UB1-10: VALUE AMOUNT and CODE (CM)</li>
/// <li>UB1-11: NUMBER OF GRACE DAYS (90) (ST)</li>
/// <li>UB1-12: SPEC. PROG. INDICATOR(44) (ID)</li>
/// <li>UB1-13: PSRO/UR APPROVAL IND. (87) (ID)</li>
/// <li>UB1-14: PSRO/UR APRVD STAY-FM(88) (DT)</li>
/// <li>UB1-15: PSRO/UR APRVD STAY-TO(89) (DT)</li>
/// <li>UB1-16: OCCURRENCE (28-32) (ID)</li>
/// <li>UB1-17: OCCURRENCE SPAN (33) (ID)</li>
/// <li>UB1-18: OCCURRENCE SPAN START DATE(33) (DT)</li>
/// <li>UB1-19: OCCUR. SPAN END DATE (33) (DT)</li>
/// <li>UB1-20: UB-82 LOCATOR 2 (ST)</li>
/// <li>UB1-21: UB-82 LOCATOR 9 (ST)</li>
/// <li>UB1-22: UB-82 LOCATOR 27 (ST)</li>
/// <li>UB1-23: UB-82 LOCATOR 45 (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class UB1 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the UB1 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public UB1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - UB82");
       this.add(typeof(ST), false, 1, 1, new System.Object[]{message}, "BLOOD DEDUCTIBLE");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "BLOOD FURN.-PINTS OF (40)");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "BLOOD REPLACED-PINTS (41)");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "BLOOD NOT RPLCD-PINTS(42)");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "CO-INSURANCE DAYS (25)");
       this.add(typeof(ID), false, 5, 2, new System.Object[]{message, 43}, "CONDITION CODE");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "COVERED DAYS - (23)");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "NON COVERED DAYS - (24)");
       this.add(typeof(CM), false, 8, 12, new System.Object[]{message}, "VALUE AMOUNT and CODE");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "NUMBER OF GRACE DAYS (90)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "SPEC. PROG. INDICATOR(44)");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "PSRO/UR APPROVAL IND. (87)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO/UR APRVD STAY-FM(88)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO/UR APRVD STAY-TO(89)");
       this.add(typeof(ID), false, 5, 20, new System.Object[]{message, 0}, "OCCURRENCE (28-32)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "OCCURRENCE SPAN (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "OCCURRENCE SPAN START DATE(33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "OCCUR. SPAN END DATE (33)");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "UB-82 LOCATOR 2");
       this.add(typeof(ST), false, 1, 7, new System.Object[]{message}, "UB-82 LOCATOR 9");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "UB-82 LOCATOR 27");
       this.add(typeof(ST), false, 1, 17, new System.Object[]{message}, "UB-82 LOCATOR 45");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns SET ID - UB82(UB1-1). </summary>
    ///
    /// <value> The setidub 82. </value>

	public SI SETIDUB82
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

    /// <summary>   Returns BLOOD DEDUCTIBLE(UB1-2). </summary>
    ///
    /// <value> The blooddeductible. </value>

	public ST BLOODDEDUCTIBLE
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (ST)t;
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

    /// <summary>   Returns BLOOD FURN.-PINTS OF (40)(UB1-3). </summary>
    ///
    /// <value> The bloodfurnpintsof. </value>

	public ST BLOODFURNPINTSOF
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (ST)t;
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

    /// <summary>   Returns BLOOD REPLACED-PINTS (41)(UB1-4). </summary>
    ///
    /// <value> The bloodreplacedpints. </value>

	public ST BLOODREPLACEDPINTS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (ST)t;
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

    /// <summary>   Returns BLOOD NOT RPLCD-PINTS(42)(UB1-5). </summary>
    ///
    /// <value> The bloodnotrplcdpints. </value>

	public ST BLOODNOTRPLCDPINTS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (ST)t;
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

    /// <summary>   Returns CO-INSURANCE DAYS (25)(UB1-6). </summary>
    ///
    /// <value> The coinsurancedays. </value>

	public ST COINSURANCEDAYS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (ST)t;
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
    /// Returns a single repetition of CONDITION CODE(UB1-7). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The conditioncode. </returns>

	public ID GetCONDITIONCODE(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of CONDITION CODE (UB1-7). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetCONDITIONCODE() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(7);  
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

  /// <summary> Returns the total repetitions of CONDITION CODE (UB1-7). </summary>
  ///
  /// <value>   The conditioncode repetitions used. </value>

  public int CONDITIONCODERepetitionsUsed
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

    /// <summary>   Returns COVERED DAYS - (23)(UB1-8). </summary>
    ///
    /// <value> The covereddays. </value>

	public ST COVEREDDAYS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (ST)t;
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

    /// <summary>   Returns NON COVERED DAYS - (24)(UB1-9). </summary>
    ///
    /// <value> The noncovereddays. </value>

	public ST NONCOVEREDDAYS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (ST)t;
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
    /// Returns a single repetition of VALUE AMOUNT and CODE(UB1-10). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The valueamountcode. </returns>

	public CM GetVALUEAMOUNTCODE(int rep)
	{
			CM ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (CM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of VALUE AMOUNT and CODE (UB1-10). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres. </returns>

  public CM[] GetVALUEAMOUNTCODE() {
     CM[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new CM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM)t[i];
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

  /// <summary> Returns the total repetitions of VALUE AMOUNT and CODE (UB1-10). </summary>
  ///
  /// <value>   The valueamountcode repetitions used. </value>

  public int VALUEAMOUNTCODERepetitionsUsed
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

    /// <summary>   Returns NUMBER OF GRACE DAYS (90)(UB1-11). </summary>
    ///
    /// <value> The total number of gracedays. </value>

	public ST NUMBEROFGRACEDAYS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (ST)t;
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

    /// <summary>   Returns SPEC. PROG. INDICATOR(44)(UB1-12). </summary>
    ///
    /// <value> The specprogindicator. </value>

	public ID SPECPROGINDICATOR
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

    /// <summary>   Returns PSRO/UR APPROVAL IND. (87)(UB1-13). </summary>
    ///
    /// <value> The psrourapprovalind. </value>

	public ID PSROURAPPROVALIND
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

    /// <summary>   Returns PSRO/UR APRVD STAY-FM(88)(UB1-14). </summary>
    ///
    /// <value> The psrouraprvdstayfm. </value>

	public DT PSROURAPRVDSTAYFM
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

    /// <summary>   Returns PSRO/UR APRVD STAY-TO(89)(UB1-15). </summary>
    ///
    /// <value> The psrouraprvdstayto. </value>

	public DT PSROURAPRVDSTAYTO
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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
    /// Returns a single repetition of OCCURRENCE (28-32)(UB1-16). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The occurrence 2832. </returns>

	public ID GetOCCURRENCE2832(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of OCCURRENCE (28-32) (UB1-16). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetOCCURRENCE2832() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(16);  
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

  /// <summary> Returns the total repetitions of OCCURRENCE (28-32) (UB1-16). </summary>
  ///
  /// <value>   The occurrence 2832 repetitions used. </value>

  public int OCCURRENCE2832RepetitionsUsed
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

    /// <summary>   Returns OCCURRENCE SPAN (33)(UB1-17). </summary>
    ///
    /// <value> The occurrencespan. </value>

	public ID OCCURRENCESPAN
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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

    /// <summary>   Returns OCCURRENCE SPAN START DATE(33)(UB1-18). </summary>
    ///
    /// <value> The occurrencespanstartdate. </value>

	public DT OCCURRENCESPANSTARTDATE
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

    /// <summary>   Returns OCCUR. SPAN END DATE (33)(UB1-19). </summary>
    ///
    /// <value> The occurspanenddate. </value>

	public DT OCCURSPANENDDATE
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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

    /// <summary>   Returns UB-82 LOCATOR 2(UB1-20). </summary>
    ///
    /// <value> The ub 82 locator 2. </value>

	public ST UB82LOCATOR2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (ST)t;
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

    /// <summary>   Returns UB-82 LOCATOR 9(UB1-21). </summary>
    ///
    /// <value> The ub 82 locator 9. </value>

	public ST UB82LOCATOR9
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (ST)t;
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

    /// <summary>   Returns UB-82 LOCATOR 27(UB1-22). </summary>
    ///
    /// <value> The ub 82 locator 27. </value>

	public ST UB82LOCATOR27
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (ST)t;
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

    /// <summary>   Returns UB-82 LOCATOR 45(UB1-23). </summary>
    ///
    /// <value> The ub 82 locator 45. </value>

	public ST UB82LOCATOR45
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (ST)t;
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