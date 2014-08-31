using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/// <summary>
/// Represents an HL7 FT1 message segment. This segment has the following fields:<ol>
/// <li>FT1-1: Set ID - financial transaction (SI)</li>
/// <li>FT1-2: Transaction ID (ST)</li>
/// <li>FT1-3: Transaction batch ID (ST)</li>
/// <li>FT1-4: Transaction date (DT)</li>
/// <li>FT1-5: Transaction posting date (DT)</li>
/// <li>FT1-6: Transaction type (ID)</li>
/// <li>FT1-7: Transaction code (CE)</li>
/// <li>FT1-8: Transaction description (ST)</li>
/// <li>FT1-9: Transaction description - alternate (ST)</li>
/// <li>FT1-10: Transaction quantity (NM)</li>
/// <li>FT1-11: Transaction amount - extended (NM)</li>
/// <li>FT1-12: Transaction amount - unit (NM)</li>
/// <li>FT1-13: Department code (CE)</li>
/// <li>FT1-14: Insurance plan ID (ID)</li>
/// <li>FT1-15: Insurance amount (NM)</li>
/// <li>FT1-16: Assigned Patient Location (CM_INTERNAL_LOCATION)</li>
/// <li>FT1-17: Fee schedule (ID)</li>
/// <li>FT1-18: Patient type (ID)</li>
/// <li>FT1-19: Diagnosis code (CE)</li>
/// <li>FT1-20: Performed by code (CN_PERSON)</li>
/// <li>FT1-21: Ordered by code (CN_PERSON)</li>
/// <li>FT1-22: Unit cost (NM)</li>
/// <li>FT1-23: Filler Order Number (CM_FILLER)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class FT1 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the FT1 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public FT1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - financial transaction");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Transaction ID");
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message}, "Transaction batch ID");
       this.add(typeof(DT), true, 1, 8, new System.Object[]{message}, "Transaction date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Transaction posting date");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 17}, "Transaction type");
       this.add(typeof(CE), true, 1, 20, new System.Object[]{message}, "Transaction code");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Transaction description");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Transaction description - alternate");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Transaction quantity");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Transaction amount - extended");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Transaction amount - unit");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Department code");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 72}, "Insurance plan ID");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Insurance amount");
       this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message}, "Assigned Patient Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 24}, "Fee schedule");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18}, "Patient type");
       this.add(typeof(CE), false, 0, 8, new System.Object[]{message}, "Diagnosis code");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Performed by code");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Ordered by code");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Unit cost");
       this.add(typeof(CM_FILLER), false, 1, 75, new System.Object[]{message}, "Filler Order Number");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Set ID - financial transaction(FT1-1). </summary>
    ///
    /// <value> The set identifier financial transaction. </value>

	public SI SetIDFinancialTransaction
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

    /// <summary>   Returns Transaction ID(FT1-2). </summary>
    ///
    /// <value> The identifier of the transaction. </value>

	public ST TransactionID
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

    /// <summary>   Returns Transaction batch ID(FT1-3). </summary>
    ///
    /// <value> The identifier of the transaction batch. </value>

	public ST TransactionBatchID
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

    /// <summary>   Returns Transaction date(FT1-4). </summary>
    ///
    /// <value> The transaction date. </value>

	public DT TransactionDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

    /// <summary>   Returns Transaction posting date(FT1-5). </summary>
    ///
    /// <value> The transaction posting date. </value>

	public DT TransactionPostingDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

    /// <summary>   Returns Transaction type(FT1-6). </summary>
    ///
    /// <value> The type of the transaction. </value>

	public ID TransactionType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

    /// <summary>   Returns Transaction code(FT1-7). </summary>
    ///
    /// <value> The transaction code. </value>

	public CE TransactionCode
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

    /// <summary>   Returns Transaction description(FT1-8). </summary>
    ///
    /// <value> Information describing the transaction. </value>

	public ST TransactionDescription
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

    /// <summary>   Returns Transaction description - alternate(FT1-9). </summary>
    ///
    /// <value> The transaction description alternate. </value>

	public ST TransactionDescriptionAlternate
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

    /// <summary>   Returns Transaction quantity(FT1-10). </summary>
    ///
    /// <value> The transaction quantity. </value>

	public NM TransactionQuantity
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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

    /// <summary>   Returns Transaction amount - extended(FT1-11). </summary>
    ///
    /// <value> The transaction amount extended. </value>

	public NM TransactionAmountExtended
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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

    /// <summary>   Returns Transaction amount - unit(FT1-12). </summary>
    ///
    /// <value> The transaction amount unit. </value>

	public NM TransactionAmountUnit
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

    /// <summary>   Returns Department code(FT1-13). </summary>
    ///
    /// <value> The department code. </value>

	public CE DepartmentCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

    /// <summary>   Returns Insurance plan ID(FT1-14). </summary>
    ///
    /// <value> The identifier of the insurance plan. </value>

	public ID InsurancePlanID
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

    /// <summary>   Returns Insurance amount(FT1-15). </summary>
    ///
    /// <value> The insurance amount. </value>

	public NM InsuranceAmount
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

    /// <summary>   Returns Assigned Patient Location(FT1-16). </summary>
    ///
    /// <value> The assigned patient location. </value>

	public CM_INTERNAL_LOCATION AssignedPatientLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			IType t = this.GetField(16, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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

    /// <summary>   Returns Fee schedule(FT1-17). </summary>
    ///
    /// <value> The fee schedule. </value>

	public ID FeeSchedule
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

    /// <summary>   Returns Patient type(FT1-18). </summary>
    ///
    /// <value> The type of the patient. </value>

	public ID PatientType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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
    /// Returns a single repetition of Diagnosis code(FT1-19). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The diagnosis code. </returns>

	public CE GetDiagnosisCode(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(19, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Diagnosis code (FT1-19). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetDiagnosisCode() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(19);  
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

  /// <summary> Returns the total repetitions of Diagnosis code (FT1-19). </summary>
  ///
  /// <value>   The diagnosis code repetitions used. </value>

  public int DiagnosisCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(19);
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

    /// <summary>   Returns Performed by code(FT1-20). </summary>
    ///
    /// <value> The performed by code. </value>

	public CN_PERSON PerformedByCode
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (CN_PERSON)t;
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

    /// <summary>   Returns Ordered by code(FT1-21). </summary>
    ///
    /// <value> The ordered by code. </value>

	public CN_PERSON OrderedByCode
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (CN_PERSON)t;
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

    /// <summary>   Returns Unit cost(FT1-22). </summary>
    ///
    /// <value> The unit cost. </value>

	public NM UnitCost
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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

    /// <summary>   Returns Filler Order Number(FT1-23). </summary>
    ///
    /// <value> The filler order number. </value>

	public CM_FILLER FillerOrderNumber
	{
		get{
			CM_FILLER ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (CM_FILLER)t;
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