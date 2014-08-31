using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 RXD message segment. This segment has the following fields:<ol>
/// <li>RXD-1: Dispense Sub-ID Counter (NM)</li>
/// <li>RXD-2: Dispense/Give Code (CE)</li>
/// <li>RXD-3: Date/Time Dispensed (TS)</li>
/// <li>RXD-4: Actual Dispense Amount (NM)</li>
/// <li>RXD-5: Actual Dispense Units (CE)</li>
/// <li>RXD-6: Actual Dosage Form (CE)</li>
/// <li>RXD-7: Prescription Number (ST)</li>
/// <li>RXD-8: Number of Refills Remaining (NM)</li>
/// <li>RXD-9: Dispense Notes (ST)</li>
/// <li>RXD-10: Dispensing Provider (XCN)</li>
/// <li>RXD-11: Substitution Status (ID)</li>
/// <li>RXD-12: Total Daily Dose (CQ)</li>
/// <li>RXD-13: Dispense-To Location (LA2)</li>
/// <li>RXD-14: Needs Human Review (ID)</li>
/// <li>RXD-15: Pharmacy/Treatment Supplier's Special Dispensing Instructions (CE)</li>
/// <li>RXD-16: Actual Strength (NM)</li>
/// <li>RXD-17: Actual Strength Unit (CE)</li>
/// <li>RXD-18: Substance Lot Number (ST)</li>
/// <li>RXD-19: Substance Expiration Date (TS)</li>
/// <li>RXD-20: Substance Manufacturer Name (CE)</li>
/// <li>RXD-21: Indication (CE)</li>
/// <li>RXD-22: Dispense Package Size (NM)</li>
/// <li>RXD-23: Dispense Package Size Unit (CE)</li>
/// <li>RXD-24: Dispense Package Method (ID)</li>
/// <li>RXD-25: Supplementary Code (CE)</li>
/// <li>RXD-26: Initiating Location (CE)</li>
/// <li>RXD-27: Packaging/Assembly Location (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class RXD : AbstractSegment  {

    /// <summary>   Initializes a new instance of the RXD class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RXD(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), true, 1, 4, new System.Object[]{message}, "Dispense Sub-ID Counter");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Dispense/Give Code");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Date/Time Dispensed");
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message}, "Actual Dispense Amount");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Actual Dispense Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Actual Dosage Form");
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message}, "Prescription Number");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Number of Refills Remaining");
       this.add(typeof(ST), false, 0, 200, new System.Object[]{message}, "Dispense Notes");
       this.add(typeof(XCN), false, 0, 200, new System.Object[]{message}, "Dispensing Provider");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167}, "Substitution Status");
       this.add(typeof(CQ), false, 1, 10, new System.Object[]{message}, "Total Daily Dose");
       this.add(typeof(LA2), false, 1, 200, new System.Object[]{message}, "Dispense-To Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Needs Human Review");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Pharmacy/Treatment Supplier's Special Dispensing Instructions");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Actual Strength");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Actual Strength Unit");
       this.add(typeof(ST), false, 0, 20, new System.Object[]{message}, "Substance Lot Number");
       this.add(typeof(TS), false, 0, 26, new System.Object[]{message}, "Substance Expiration Date");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Substance Manufacturer Name");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Indication");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Dispense Package Size");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Dispense Package Size Unit");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 321}, "Dispense Package Method");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Supplementary Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Initiating Location");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Packaging/Assembly Location");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Dispense Sub-ID Counter(RXD-1). </summary>
    ///
    /// <value> The dispense sub identifier counter. </value>

	public NM DispenseSubIDCounter
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns Dispense/Give Code(RXD-2). </summary>
    ///
    /// <value> The dispense give code. </value>

	public CE DispenseGiveCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

    /// <summary>   Returns Date/Time Dispensed(RXD-3). </summary>
    ///
    /// <value> The date time dispensed. </value>

	public TS DateTimeDispensed
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

    /// <summary>   Returns Actual Dispense Amount(RXD-4). </summary>
    ///
    /// <value> The actual dispense amount. </value>

	public NM ActualDispenseAmount
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

    /// <summary>   Returns Actual Dispense Units(RXD-5). </summary>
    ///
    /// <value> The actual dispense units. </value>

	public CE ActualDispenseUnits
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

    /// <summary>   Returns Actual Dosage Form(RXD-6). </summary>
    ///
    /// <value> The actual dosage form. </value>

	public CE ActualDosageForm
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

    /// <summary>   Returns Prescription Number(RXD-7). </summary>
    ///
    /// <value> The prescription number. </value>

	public ST PrescriptionNumber
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

    /// <summary>   Returns Number of Refills Remaining(RXD-8). </summary>
    ///
    /// <value> The total number of refills remaining. </value>

	public NM NumberOfRefillsRemaining
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

    /// <summary>
    /// Returns a single repetition of Dispense Notes(RXD-9). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The dispense notes. </returns>

	public ST GetDispenseNotes(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Dispense Notes (RXD-9). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of st. </returns>

  public ST[] GetDispenseNotes() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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

  /// <summary> Returns the total repetitions of Dispense Notes (RXD-9). </summary>
  ///
  /// <value>   The dispense notes repetitions used. </value>

  public int DispenseNotesRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Dispensing Provider(RXD-10). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The dispensing provider. </returns>

	public XCN GetDispensingProvider(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Dispensing Provider (RXD-10). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetDispensingProvider() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(10);  
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

  /// <summary> Returns the total repetitions of Dispensing Provider (RXD-10). </summary>
  ///
  /// <value>   The dispensing provider repetitions used. </value>

  public int DispensingProviderRepetitionsUsed
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

    /// <summary>   Returns Substitution Status(RXD-11). </summary>
    ///
    /// <value> The substitution status. </value>

	public ID SubstitutionStatus
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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

    /// <summary>   Returns Total Daily Dose(RXD-12). </summary>
    ///
    /// <value> The total number of daily dose. </value>

	public CQ TotalDailyDose
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (CQ)t;
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

    /// <summary>   Returns Dispense-To Location(RXD-13). </summary>
    ///
    /// <value> The dispense to location. </value>

	public LA2 DispenseToLocation
	{
		get{
			LA2 ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (LA2)t;
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

    /// <summary>   Returns Needs Human Review(RXD-14). </summary>
    ///
    /// <value> The needs human review. </value>

	public ID NeedsHumanReview
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

    /// <summary>
    /// Returns a single repetition of Pharmacy/Treatment Supplier's Special Dispensing
    /// Instructions(RXD-15). throws HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The pharmacy treatment supplier s special dispensing instructions. </returns>

	public CE GetPharmacyTreatmentSupplierSSpecialDispensingInstructions(int rep)
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

  /// <summary>
  /// Returns all repetitions of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXD-
  /// 15).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetPharmacyTreatmentSupplierSSpecialDispensingInstructions() {
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

  /// <summary>
  /// Returns the total repetitions of Pharmacy/Treatment Supplier's Special Dispensing Instructions
  /// (RXD-15).
  /// </summary>
  ///
  /// <value>
  /// The pharmacy treatment supplier s special dispensing instructions repetitions used.
  /// </value>

  public int PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed
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

    /// <summary>   Returns Actual Strength(RXD-16). </summary>
    ///
    /// <value> The actual strength. </value>

	public NM ActualStrength
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(16, 0);
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

    /// <summary>   Returns Actual Strength Unit(RXD-17). </summary>
    ///
    /// <value> The actual strength unit. </value>

	public CE ActualStrengthUnit
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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
    /// Returns a single repetition of Substance Lot Number(RXD-18). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The substance lot number. </returns>

	public ST GetSubstanceLotNumber(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(18, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Substance Lot Number (RXD-18). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of st. </returns>

  public ST[] GetSubstanceLotNumber() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(18);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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

  /// <summary> Returns the total repetitions of Substance Lot Number (RXD-18). </summary>
  ///
  /// <value>   The substance lot number repetitions used. </value>

  public int SubstanceLotNumberRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Substance Expiration Date(RXD-19). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The substance expiration date. </returns>

	public TS GetSubstanceExpirationDate(int rep)
	{
			TS ret = null;
			try
			{
			IType t = this.GetField(19, rep);
				ret = (TS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Substance Expiration Date (RXD-19). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ts. </returns>

  public TS[] GetSubstanceExpirationDate() {
     TS[] ret = null;
    try {
        IType[] t = this.GetField(19);  
        ret = new TS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TS)t[i];
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

  /// <summary> Returns the total repetitions of Substance Expiration Date (RXD-19). </summary>
  ///
  /// <value>   The substance expiration date repetitions used. </value>

  public int SubstanceExpirationDateRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Substance Manufacturer Name(RXD-20). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The substance manufacturer name. </returns>

	public CE GetSubstanceManufacturerName(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Substance Manufacturer Name (RXD-20). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetSubstanceManufacturerName() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(20);  
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

  /// <summary> Returns the total repetitions of Substance Manufacturer Name (RXD-20). </summary>
  ///
  /// <value>   The substance manufacturer name repetitions used. </value>

  public int SubstanceManufacturerNameRepetitionsUsed
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
    /// Returns a single repetition of Indication(RXD-21). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The indication. </returns>

	public CE GetIndication(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Indication (RXD-21). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetIndication() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(21);  
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

  /// <summary> Returns the total repetitions of Indication (RXD-21). </summary>
  ///
  /// <value>   The indication repetitions used. </value>

  public int IndicationRepetitionsUsed
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

    /// <summary>   Returns Dispense Package Size(RXD-22). </summary>
    ///
    /// <value> The size of the dispense package. </value>

	public NM DispensePackageSize
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

    /// <summary>   Returns Dispense Package Size Unit(RXD-23). </summary>
    ///
    /// <value> The dispense package size unit. </value>

	public CE DispensePackageSizeUnit
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(23, 0);
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

    /// <summary>   Returns Dispense Package Method(RXD-24). </summary>
    ///
    /// <value> The dispense package method. </value>

	public ID DispensePackageMethod
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(24, 0);
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
    /// Returns a single repetition of Supplementary Code(RXD-25). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The supplementary code. </returns>

	public CE GetSupplementaryCode(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(25, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Supplementary Code (RXD-25). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetSupplementaryCode() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(25);  
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

  /// <summary> Returns the total repetitions of Supplementary Code (RXD-25). </summary>
  ///
  /// <value>   The supplementary code repetitions used. </value>

  public int SupplementaryCodeRepetitionsUsed
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

    /// <summary>   Returns Initiating Location(RXD-26). </summary>
    ///
    /// <value> The initiating location. </value>

	public CE InitiatingLocation
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(26, 0);
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

    /// <summary>   Returns Packaging/Assembly Location(RXD-27). </summary>
    ///
    /// <value> The packaging assembly location. </value>

	public CE PackagingAssemblyLocation
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(27, 0);
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