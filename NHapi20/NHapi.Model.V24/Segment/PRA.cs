using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 PRA message segment. This segment has the following fields:<ol>
/// <li>PRA-1: Primary Key Value - PRA (CE)</li>
/// <li>PRA-2: Practitioner Group (CE)</li>
/// <li>PRA-3: Practitioner Category (IS)</li>
/// <li>PRA-4: Provider Billing (ID)</li>
/// <li>PRA-5: Specialty (SPD)</li>
/// <li>PRA-6: Practitioner ID Numbers (PLN)</li>
/// <li>PRA-7: Privileges (PIP)</li>
/// <li>PRA-8: Date Entered Practice (DT)</li>
/// <li>PRA-9: Institution (CE)</li>
/// <li>PRA-10: Date Left Practice (DT)</li>
/// <li>PRA-11: Government Reimbursement Billing Eligibility (CE)</li>
/// <li>PRA-12: Set ID - PRA (SI)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PRA : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PRA class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PRA(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Primary Key Value - PRA");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Practitioner Group");
       this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 186}, "Practitioner Category");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 187}, "Provider Billing");
       this.add(typeof(SPD), false, 0, 100, new System.Object[]{message}, "Specialty");
       this.add(typeof(PLN), false, 0, 100, new System.Object[]{message}, "Practitioner ID Numbers");
       this.add(typeof(PIP), false, 0, 200, new System.Object[]{message}, "Privileges");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Date Entered Practice");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Institution");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Date Left Practice");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Government Reimbursement Billing Eligibility");
       this.add(typeof(SI), false, 1, 60, new System.Object[]{message}, "Set ID - PRA");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Primary Key Value - PRA(PRA-1). </summary>
    ///
    /// <value> The primary key value pra. </value>

	public CE PrimaryKeyValuePRA
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

    /// <summary>
    /// Returns a single repetition of Practitioner Group(PRA-2). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The practitioner group. </returns>

	public CE GetPractitionerGroup(int rep)
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

  /// <summary> Returns all repetitions of Practitioner Group (PRA-2). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetPractitionerGroup() {
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

  /// <summary> Returns the total repetitions of Practitioner Group (PRA-2). </summary>
  ///
  /// <value>   The practitioner group repetitions used. </value>

  public int PractitionerGroupRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Practitioner Category(PRA-3). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The practitioner category. </returns>

	public IS GetPractitionerCategory(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Practitioner Category (PRA-3). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetPractitionerCategory() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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

  /// <summary> Returns the total repetitions of Practitioner Category (PRA-3). </summary>
  ///
  /// <value>   The practitioner category repetitions used. </value>

  public int PractitionerCategoryRepetitionsUsed
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

    /// <summary>   Returns Provider Billing(PRA-4). </summary>
    ///
    /// <value> The provider billing. </value>

	public ID ProviderBilling
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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
    /// Returns a single repetition of Specialty(PRA-5). throws HL7Exception if the repetition number
    /// is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The specialty. </returns>

	public SPD GetSpecialty(int rep)
	{
			SPD ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (SPD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Specialty (PRA-5). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of speed. </returns>

  public SPD[] GetSpecialty() {
     SPD[] ret = null;
    try {
        IType[] t = this.GetField(5);  
        ret = new SPD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (SPD)t[i];
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

  /// <summary> Returns the total repetitions of Specialty (PRA-5). </summary>
  ///
  /// <value>   The specialty repetitions used. </value>

  public int SpecialtyRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(5);
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
    /// Returns a single repetition of Practitioner ID Numbers(PRA-6). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The practitioner identifier numbers. </returns>

	public PLN GetPractitionerIDNumbers(int rep)
	{
			PLN ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (PLN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Practitioner ID Numbers (PRA-6). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of pln. </returns>

  public PLN[] GetPractitionerIDNumbers() {
     PLN[] ret = null;
    try {
        IType[] t = this.GetField(6);  
        ret = new PLN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PLN)t[i];
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

  /// <summary> Returns the total repetitions of Practitioner ID Numbers (PRA-6). </summary>
  ///
  /// <value>   The practitioner identifier numbers repetitions used. </value>

  public int PractitionerIDNumbersRepetitionsUsed
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
    /// Returns a single repetition of Privileges(PRA-7). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The privileges. </returns>

	public PIP GetPrivileges(int rep)
	{
			PIP ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (PIP)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Privileges (PRA-7). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of pip. </returns>

  public PIP[] GetPrivileges() {
     PIP[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new PIP[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PIP)t[i];
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

  /// <summary> Returns the total repetitions of Privileges (PRA-7). </summary>
  ///
  /// <value>   The privileges repetitions used. </value>

  public int PrivilegesRepetitionsUsed
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

    /// <summary>   Returns Date Entered Practice(PRA-8). </summary>
    ///
    /// <value> The date entered practice. </value>

	public DT DateEnteredPractice
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

    /// <summary>   Returns Institution(PRA-9). </summary>
    ///
    /// <value> The institution. </value>

	public CE Institution
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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

    /// <summary>   Returns Date Left Practice(PRA-10). </summary>
    ///
    /// <value> The date left practice. </value>

	public DT DateLeftPractice
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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
    /// Returns a single repetition of Government Reimbursement Billing Eligibility(PRA-11). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The government reimbursement billing eligibility. </returns>

	public CE GetGovernmentReimbursementBillingEligibility(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(11, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Government Reimbursement Billing Eligibility (PRA-11).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetGovernmentReimbursementBillingEligibility() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(11);  
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
  /// Returns the total repetitions of Government Reimbursement Billing Eligibility (PRA-11).
  /// </summary>
  ///
  /// <value>   The government reimbursement billing eligibility repetitions used. </value>

  public int GovernmentReimbursementBillingEligibilityRepetitionsUsed
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

    /// <summary>   Returns Set ID - PRA(PRA-12). </summary>
    ///
    /// <value> The set idpra. </value>

	public SI SetIDPRA
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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


}}