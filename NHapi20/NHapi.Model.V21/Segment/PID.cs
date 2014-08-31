using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/// <summary>
/// Represents an HL7 PID message segment. This segment has the following fields:<ol>
/// <li>PID-1: SET ID - PATIENT ID (SI)</li>
/// <li>PID-2: PATIENT ID EXTERNAL (EXTERNAL ID) (CK)</li>
/// <li>PID-3: PATIENT ID INTERNAL (INTERNAL ID) (CK)</li>
/// <li>PID-4: ALTERNATE PATIENT ID (ST)</li>
/// <li>PID-5: PATIENT NAME (PN)</li>
/// <li>PID-6: MOTHER'S MAIDEN NAME (ST)</li>
/// <li>PID-7: DATE OF BIRTH (DT)</li>
/// <li>PID-8: SEX (ID)</li>
/// <li>PID-9: PATIENT ALIAS (PN)</li>
/// <li>PID-10: ETHNIC GROUP (ID)</li>
/// <li>PID-11: PATIENT ADDRESS (AD)</li>
/// <li>PID-12: COUNTY CODE (ID)</li>
/// <li>PID-13: PHONE NUMBER - HOME (TN)</li>
/// <li>PID-14: PHONE NUMBER - BUSINESS (TN)</li>
/// <li>PID-15: LANGUAGE - PATIENT (ST)</li>
/// <li>PID-16: MARITAL STATUS (ID)</li>
/// <li>PID-17: RELIGION (ID)</li>
/// <li>PID-18: PATIENT ACCOUNT NUMBER (CK)</li>
/// <li>PID-19: SSN NUMBER - PATIENT (ST)</li>
/// <li>PID-20: DRIVER'S LIC NUM - PATIENT (CM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PID : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PID class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PID(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - PATIENT ID");
       this.add(typeof(CK), false, 1, 16, new System.Object[]{message}, "PATIENT ID EXTERNAL (EXTERNAL ID)");
       this.add(typeof(CK), true, 1, 16, new System.Object[]{message}, "PATIENT ID INTERNAL (INTERNAL ID)");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "ALTERNATE PATIENT ID");
       this.add(typeof(PN), true, 1, 48, new System.Object[]{message}, "PATIENT NAME");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "MOTHER'S MAIDEN NAME");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "DATE OF BIRTH");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "SEX");
       this.add(typeof(PN), false, 0, 48, new System.Object[]{message}, "PATIENT ALIAS");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 5}, "ETHNIC GROUP");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "PATIENT ADDRESS");
       this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0}, "COUNTY CODE");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "PHONE NUMBER - HOME");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "PHONE NUMBER - BUSINESS");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "LANGUAGE - PATIENT");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 2}, "MARITAL STATUS");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 6}, "RELIGION");
       this.add(typeof(CK), false, 1, 20, new System.Object[]{message}, "PATIENT ACCOUNT NUMBER");
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message}, "SSN NUMBER - PATIENT");
       this.add(typeof(CM), false, 1, 25, new System.Object[]{message}, "DRIVER'S LIC NUM - PATIENT");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns SET ID - PATIENT ID(PID-1). </summary>
    ///
    /// <value> The setidpatientid. </value>

	public SI SETIDPATIENTID
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

    /// <summary>   Returns PATIENT ID EXTERNAL (EXTERNAL ID)(PID-2). </summary>
    ///
    /// <value> The patientidexternalexternalid. </value>

	public CK PATIENTIDEXTERNALEXTERNALID
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (CK)t;
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

    /// <summary>   Returns PATIENT ID INTERNAL (INTERNAL ID)(PID-3). </summary>
    ///
    /// <value> The patientidinternalinternalid. </value>

	public CK PATIENTIDINTERNALINTERNALID
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (CK)t;
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

    /// <summary>   Returns ALTERNATE PATIENT ID(PID-4). </summary>
    ///
    /// <value> The alternatepatientid. </value>

	public ST ALTERNATEPATIENTID
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

    /// <summary>   Returns PATIENT NAME(PID-5). </summary>
    ///
    /// <value> The patientname. </value>

	public PN PATIENTNAME
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (PN)t;
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

    /// <summary>   Returns MOTHER'S MAIDEN NAME(PID-6). </summary>
    ///
    /// <value> The mothersmaidenname. </value>

	public ST MOTHERSMAIDENNAME
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

    /// <summary>   Returns DATE OF BIRTH(PID-7). </summary>
    ///
    /// <value> The dateofbirth. </value>

	public DT DATEOFBIRTH
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

    /// <summary>   Returns SEX(PID-8). </summary>
    ///
    /// <value> The sex. </value>

	public ID SEX
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
    /// Returns a single repetition of PATIENT ALIAS(PID-9). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The patientalias. </returns>

	public PN GetPATIENTALIAS(int rep)
	{
			PN ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (PN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of PATIENT ALIAS (PID-9). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of pn. </returns>

  public PN[] GetPATIENTALIAS() {
     PN[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new PN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PN)t[i];
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

  /// <summary> Returns the total repetitions of PATIENT ALIAS (PID-9). </summary>
  ///
  /// <value>   The patientalias repetitions used. </value>

  public int PATIENTALIASRepetitionsUsed
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

    /// <summary>   Returns ETHNIC GROUP(PID-10). </summary>
    ///
    /// <value> The ethnicgroup. </value>

	public ID ETHNICGROUP
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

    /// <summary>   Returns PATIENT ADDRESS(PID-11). </summary>
    ///
    /// <value> The patientaddress. </value>

	public AD PATIENTADDRESS
	{
		get{
			AD ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (AD)t;
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

    /// <summary>   Returns COUNTY CODE(PID-12). </summary>
    ///
    /// <value> The total number of ycode. </value>

	public ID COUNTYCODE
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
    /// Returns a single repetition of PHONE NUMBER - HOME(PID-13). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The phonenumberhome. </returns>

	public TN GetPHONENUMBERHOME(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.GetField(13, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of PHONE NUMBER - HOME (PID-13). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of tn. </returns>

  public TN[] GetPHONENUMBERHOME() {
     TN[] ret = null;
    try {
        IType[] t = this.GetField(13);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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

  /// <summary> Returns the total repetitions of PHONE NUMBER - HOME (PID-13). </summary>
  ///
  /// <value>   The phonenumberhome repetitions used. </value>

  public int PHONENUMBERHOMERepetitionsUsed
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
    /// Returns a single repetition of PHONE NUMBER - BUSINESS(PID-14). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The phonenumberbusiness. </returns>

	public TN GetPHONENUMBERBUSINESS(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of PHONE NUMBER - BUSINESS (PID-14). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of tn. </returns>

  public TN[] GetPHONENUMBERBUSINESS() {
     TN[] ret = null;
    try {
        IType[] t = this.GetField(14);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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

  /// <summary> Returns the total repetitions of PHONE NUMBER - BUSINESS (PID-14). </summary>
  ///
  /// <value>   The phonenumberbusiness repetitions used. </value>

  public int PHONENUMBERBUSINESSRepetitionsUsed
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

    /// <summary>   Returns LANGUAGE - PATIENT(PID-15). </summary>
    ///
    /// <value> The languagepatient. </value>

	public ST LANGUAGEPATIENT
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

    /// <summary>   Returns MARITAL STATUS(PID-16). </summary>
    ///
    /// <value> The maritalstatus. </value>

	public ID MARITALSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(16, 0);
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

    /// <summary>   Returns RELIGION(PID-17). </summary>
    ///
    /// <value> The religion. </value>

	public ID RELIGION
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

    /// <summary>   Returns PATIENT ACCOUNT NUMBER(PID-18). </summary>
    ///
    /// <value> The patientaccountnumber. </value>

	public CK PATIENTACCOUNTNUMBER
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.GetField(18, 0);
				ret = (CK)t;
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

    /// <summary>   Returns SSN NUMBER - PATIENT(PID-19). </summary>
    ///
    /// <value> The ssnnumberpatient. </value>

	public ST SSNNUMBERPATIENT
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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

    /// <summary>   Returns DRIVER'S LIC NUM - PATIENT(PID-20). </summary>
    ///
    /// <value> The driverslicnumpatient. </value>

	public CM DRIVERSLICNUMPATIENT
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (CM)t;
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