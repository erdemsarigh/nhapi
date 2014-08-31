using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V231.Segment{

/// <summary>
/// Represents an HL7 RXO message segment. This segment has the following fields:<ol>
/// <li>RXO-1: Requested Give Code (CE)</li>
/// <li>RXO-2: Requested Give Amount - Minimum (NM)</li>
/// <li>RXO-3: Requested Give Amount - Maximum (NM)</li>
/// <li>RXO-4: Requested Give Units (CE)</li>
/// <li>RXO-5: Requested Dosage Form (CE)</li>
/// <li>RXO-6: Provider’s Pharmacy/Treatment Instructions (CE)</li>
/// <li>RXO-7: Provider’s Administration Instructions (CE)</li>
/// <li>RXO-8: Deliver-to Location (LA1)</li>
/// <li>RXO-9: Allow Substitutions (ID)</li>
/// <li>RXO-10: Requested Dispense Code (CE)</li>
/// <li>RXO-11: Requested Dispense Amount (NM)</li>
/// <li>RXO-12: Requested Dispense Units (CE)</li>
/// <li>RXO-13: Number Of Refills (NM)</li>
/// <li>RXO-14: Ordering Provider’s DEA Number (XCN)</li>
/// <li>RXO-15: Pharmacist/Treatment Supplier’s Verifier ID (XCN)</li>
/// <li>RXO-16: Needs Human Review (ID)</li>
/// <li>RXO-17: Requested Give Per (Time Unit) (ST)</li>
/// <li>RXO-18: Requested Give Strength (NM)</li>
/// <li>RXO-19: Requested Give Strength Units (CE)</li>
/// <li>RXO-20: Indication (CE)</li>
/// <li>RXO-21: Requested Give Rate Amount (ST)</li>
/// <li>RXO-22: Requested Give Rate Units (CE)</li>
/// <li>RXO-23: Total Daily Dose (CQ)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class RXO : AbstractSegment  {

    /// <summary>   Initializes a new instance of the RXO class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RXO(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), false, 1, 100, new System.Object[]{message}, "Requested Give Code");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Give Amount - Minimum");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Give Amount - Maximum");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Give Units");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Dosage Form");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Provider’s Pharmacy/Treatment Instructions");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Provider’s Administration Instructions");
       this.add(typeof(LA1), false, 1, 200, new System.Object[]{message}, "Deliver-to Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 161}, "Allow Substitutions");
       this.add(typeof(CE), false, 1, 100, new System.Object[]{message}, "Requested Dispense Code");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Dispense Amount");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Dispense Units");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Number Of Refills");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Ordering Provider’s DEA Number");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Pharmacist/Treatment Supplier’s Verifier ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Needs Human Review");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Requested Give Per (Time Unit)");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Requested Give Strength");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Give Strength Units");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Indication");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Requested Give Rate Amount");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Requested Give Rate Units");
       this.add(typeof(CQ), false, 1, 10, new System.Object[]{message}, "Total Daily Dose");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Requested Give Code(RXO-1). </summary>
    ///
    /// <value> The requested give code. </value>

	public CE RequestedGiveCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns Requested Give Amount - Minimum(RXO-2). </summary>
    ///
    /// <value> The requested give amount minimum. </value>

	public NM RequestedGiveAmountMinimum
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

    /// <summary>   Returns Requested Give Amount - Maximum(RXO-3). </summary>
    ///
    /// <value> The requested give amount maximum. </value>

	public NM RequestedGiveAmountMaximum
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

    /// <summary>   Returns Requested Give Units(RXO-4). </summary>
    ///
    /// <value> The requested give units. </value>

	public CE RequestedGiveUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

    /// <summary>   Returns Requested Dosage Form(RXO-5). </summary>
    ///
    /// <value> The requested dosage form. </value>

	public CE RequestedDosageForm
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

    /// <summary>
    /// Returns a single repetition of Provider’s Pharmacy/Treatment Instructions(RXO-6). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The provider s pharmacy treatment instructions. </returns>

	public CE GetProviderSPharmacyTreatmentInstructions(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Provider’s Pharmacy/Treatment Instructions (RXO-6).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetProviderSPharmacyTreatmentInstructions() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(6);  
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
  /// Returns the total repetitions of Provider’s Pharmacy/Treatment Instructions (RXO-6).
  /// </summary>
  ///
  /// <value>   The provider s pharmacy treatment instructions repetitions used. </value>

  public int ProviderSPharmacyTreatmentInstructionsRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(6);
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
    /// Returns a single repetition of Provider’s Administration Instructions(RXO-7). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The provider s administration instructions. </returns>

	public CE GetProviderSAdministrationInstructions(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Provider’s Administration Instructions (RXO-7). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetProviderSAdministrationInstructions() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(7);  
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
  /// Returns the total repetitions of Provider’s Administration Instructions (RXO-7).
  /// </summary>
  ///
  /// <value>   The provider s administration instructions repetitions used. </value>

  public int ProviderSAdministrationInstructionsRepetitionsUsed
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

    /// <summary>   Returns Deliver-to Location(RXO-8). </summary>
    ///
    /// <value> The deliver to location. </value>

	public LA1 DeliverToLocation
	{
		get{
			LA1 ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (LA1)t;
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

    /// <summary>   Returns Allow Substitutions(RXO-9). </summary>
    ///
    /// <value> The allow substitutions. </value>

	public ID AllowSubstitutions
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

    /// <summary>   Returns Requested Dispense Code(RXO-10). </summary>
    ///
    /// <value> The requested dispense code. </value>

	public CE RequestedDispenseCode
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

    /// <summary>   Returns Requested Dispense Amount(RXO-11). </summary>
    ///
    /// <value> The requested dispense amount. </value>

	public NM RequestedDispenseAmount
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

    /// <summary>   Returns Requested Dispense Units(RXO-12). </summary>
    ///
    /// <value> The requested dispense units. </value>

	public CE RequestedDispenseUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

    /// <summary>   Returns Number Of Refills(RXO-13). </summary>
    ///
    /// <value> The total number of refills. </value>

	public NM NumberOfRefills
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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
    /// Returns a single repetition of Ordering Provider’s DEA Number(RXO-14). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The ordering provider sdea number. </returns>

	public XCN GetOrderingProviderSDEANumber(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Ordering Provider’s DEA Number (RXO-14). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetOrderingProviderSDEANumber() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(14);  
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

  /// <summary> Returns the total repetitions of Ordering Provider’s DEA Number (RXO-14). </summary>
  ///
  /// <value>   The ordering provider sdea number repetitions used. </value>

  public int OrderingProviderSDEANumberRepetitionsUsed
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
    /// Returns a single repetition of Pharmacist/Treatment Supplier’s Verifier ID(RXO-15). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The pharmacist treatment supplier s verifier identifier. </returns>

	public XCN GetPharmacistTreatmentSupplierSVerifierID(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(15, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Pharmacist/Treatment Supplier’s Verifier ID (RXO-15).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetPharmacistTreatmentSupplierSVerifierID() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(15);  
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
  /// Returns the total repetitions of Pharmacist/Treatment Supplier’s Verifier ID (RXO-15).
  /// </summary>
  ///
  /// <value>   The pharmacist treatment supplier s verifier identifier repetitions used. </value>

  public int PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed
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

    /// <summary>   Returns Needs Human Review(RXO-16). </summary>
    ///
    /// <value> The needs human review. </value>

	public ID NeedsHumanReview
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

    /// <summary>   Returns Requested Give Per (Time Unit)(RXO-17). </summary>
    ///
    /// <value> The requested give per time unit. </value>

	public ST RequestedGivePerTimeUnit
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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

    /// <summary>   Returns Requested Give Strength(RXO-18). </summary>
    ///
    /// <value> The requested give strength. </value>

	public NM RequestedGiveStrength
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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

    /// <summary>   Returns Requested Give Strength Units(RXO-19). </summary>
    ///
    /// <value> The requested give strength units. </value>

	public CE RequestedGiveStrengthUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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
    /// Returns a single repetition of Indication(RXO-20). throws HL7Exception if the repetition
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
			IType t = this.GetField(20, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Indication (RXO-20). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetIndication() {
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

  /// <summary> Returns the total repetitions of Indication (RXO-20). </summary>
  ///
  /// <value>   The indication repetitions used. </value>

  public int IndicationRepetitionsUsed
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

    /// <summary>   Returns Requested Give Rate Amount(RXO-21). </summary>
    ///
    /// <value> The requested give rate amount. </value>

	public ST RequestedGiveRateAmount
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

    /// <summary>   Returns Requested Give Rate Units(RXO-22). </summary>
    ///
    /// <value> The requested give rate units. </value>

	public CE RequestedGiveRateUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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

    /// <summary>   Returns Total Daily Dose(RXO-23). </summary>
    ///
    /// <value> The total number of daily dose. </value>

	public CQ TotalDailyDose
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(23, 0);
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


}}