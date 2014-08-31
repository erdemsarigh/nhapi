using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

/// <summary>
/// Represents an HL7 FT1 message segment. This segment has the following fields:<ol>
/// <li>FT1-1: Set ID - Financial Transaction (SI)</li>
/// <li>FT1-2: Transaction ID (ST)</li>
/// <li>FT1-3: Transaction Batch ID (ST)</li>
/// <li>FT1-4: Transaction Date (TS)</li>
/// <li>FT1-5: Transaction Posting Date (TS)</li>
/// <li>FT1-6: Transaction Type (ID)</li>
/// <li>FT1-7: Transaction Code (CE)</li>
/// <li>FT1-8: Transaction Description (ST)</li>
/// <li>FT1-9: Transaction Description - alternate (ST)</li>
/// <li>FT1-10: Transaction Quantity (NM)</li>
/// <li>FT1-11: Transaction Amount - Extended (CP)</li>
/// <li>FT1-12: Transaction Amount - Unit (CP)</li>
/// <li>FT1-13: Department Code (CE)</li>
/// <li>FT1-14: Insurance Plan ID (CE)</li>
/// <li>FT1-15: Insurance Amount (CP)</li>
/// <li>FT1-16: Assigned Patient Location (PL)</li>
/// <li>FT1-17: Fee Schedule (ID)</li>
/// <li>FT1-18: Patient Type (ID)</li>
/// <li>FT1-19: Diagnosis Code (CE)</li>
/// <li>FT1-20: Performed By Code (XCN)</li>
/// <li>FT1-21: Ordered By Code (XCN)</li>
/// <li>FT1-22: Unit Cost (NM)</li>
/// <li>FT1-23: Filler Order Number (EI)</li>
/// <li>FT1-24: Entered By Code (XCN)</li>
/// <li>FT1-25: Procedure Code (CE)</li>
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
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - Financial Transaction");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Transaction ID");
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message}, "Transaction Batch ID");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Transaction Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Transaction Posting Date");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 17}, "Transaction Type");
       this.add(typeof(CE), true, 1, 80, new System.Object[]{message}, "Transaction Code");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Transaction Description");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Transaction Description - alternate");
       this.add(typeof(NM), false, 1, 6, new System.Object[]{message}, "Transaction Quantity");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Transaction Amount - Extended");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Transaction Amount - Unit");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Department Code");
       this.add(typeof(CE), false, 1, 8, new System.Object[]{message}, "Insurance Plan ID");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Insurance Amount");
       this.add(typeof(PL), false, 1, 12, new System.Object[]{message}, "Assigned Patient Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 24}, "Fee Schedule");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18}, "Patient Type");
       this.add(typeof(CE), false, 0, 60, new System.Object[]{message}, "Diagnosis Code");
       this.add(typeof(XCN), false, 1, 120, new System.Object[]{message}, "Performed By Code");
       this.add(typeof(XCN), false, 1, 120, new System.Object[]{message}, "Ordered By Code");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Unit Cost");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Filler Order Number");
       this.add(typeof(XCN), false, 1, 120, new System.Object[]{message}, "Entered By Code");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Procedure Code");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Set ID - Financial Transaction(FT1-1). </summary>
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

    /// <summary>   Returns Transaction Batch ID(FT1-3). </summary>
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

    /// <summary>   Returns Transaction Date(FT1-4). </summary>
    ///
    /// <value> The transaction date. </value>

	public TS TransactionDate
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

    /// <summary>   Returns Transaction Posting Date(FT1-5). </summary>
    ///
    /// <value> The transaction posting date. </value>

	public TS TransactionPostingDate
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

    /// <summary>   Returns Transaction Type(FT1-6). </summary>
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

    /// <summary>   Returns Transaction Code(FT1-7). </summary>
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

    /// <summary>   Returns Transaction Description(FT1-8). </summary>
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

    /// <summary>   Returns Transaction Description - alternate(FT1-9). </summary>
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

    /// <summary>   Returns Transaction Quantity(FT1-10). </summary>
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

    /// <summary>   Returns Transaction Amount - Extended(FT1-11). </summary>
    ///
    /// <value> The transaction amount extended. </value>

	public CP TransactionAmountExtended
	{
		get{
			CP ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (CP)t;
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

    /// <summary>   Returns Transaction Amount - Unit(FT1-12). </summary>
    ///
    /// <value> The transaction amount unit. </value>

	public CP TransactionAmountUnit
	{
		get{
			CP ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (CP)t;
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

    /// <summary>   Returns Department Code(FT1-13). </summary>
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

    /// <summary>   Returns Insurance Plan ID(FT1-14). </summary>
    ///
    /// <value> The identifier of the insurance plan. </value>

	public CE InsurancePlanID
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

    /// <summary>   Returns Insurance Amount(FT1-15). </summary>
    ///
    /// <value> The insurance amount. </value>

	public CP InsuranceAmount
	{
		get{
			CP ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (CP)t;
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

	public PL AssignedPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(16, 0);
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

    /// <summary>   Returns Fee Schedule(FT1-17). </summary>
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

    /// <summary>   Returns Patient Type(FT1-18). </summary>
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
    /// Returns a single repetition of Diagnosis Code(FT1-19). throws HL7Exception if the repetition
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

  /// <summary> Returns all repetitions of Diagnosis Code (FT1-19). </summary>
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

  /// <summary> Returns the total repetitions of Diagnosis Code (FT1-19). </summary>
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

    /// <summary>   Returns Performed By Code(FT1-20). </summary>
    ///
    /// <value> The performed by code. </value>

	public XCN PerformedByCode
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (XCN)t;
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

    /// <summary>   Returns Ordered By Code(FT1-21). </summary>
    ///
    /// <value> The ordered by code. </value>

	public XCN OrderedByCode
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (XCN)t;
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

    /// <summary>   Returns Unit Cost(FT1-22). </summary>
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

	public EI FillerOrderNumber
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

    /// <summary>   Returns Entered By Code(FT1-24). </summary>
    ///
    /// <value> The entered by code. </value>

	public XCN EnteredByCode
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(24, 0);
				ret = (XCN)t;
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

    /// <summary>   Returns Procedure Code(FT1-25). </summary>
    ///
    /// <value> The procedure code. </value>

	public CE ProcedureCode
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