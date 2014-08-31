using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 IN2 message segment. This segment has the following fields:<ol>
/// <li>IN2-1: Insured's Employee ID (CX)</li>
/// <li>IN2-2: Insured's Social Security Number (ST)</li>
/// <li>IN2-3: Insured's Employer's Name and ID (XCN)</li>
/// <li>IN2-4: Employer Information Data (IS)</li>
/// <li>IN2-5: Mail Claim Party (IS)</li>
/// <li>IN2-6: Medicare Health Ins Card Number (ST)</li>
/// <li>IN2-7: Medicaid Case Name (XPN)</li>
/// <li>IN2-8: Medicaid Case Number (ST)</li>
/// <li>IN2-9: Military Sponsor Name (XPN)</li>
/// <li>IN2-10: Military ID Number (ST)</li>
/// <li>IN2-11: Dependent Of Military Recipient (CE)</li>
/// <li>IN2-12: Military Organization (ST)</li>
/// <li>IN2-13: Military Station (ST)</li>
/// <li>IN2-14: Military Service (IS)</li>
/// <li>IN2-15: Military Rank/Grade (IS)</li>
/// <li>IN2-16: Military Status (IS)</li>
/// <li>IN2-17: Military Retire Date (DT)</li>
/// <li>IN2-18: Military Non-Avail Cert On File (ID)</li>
/// <li>IN2-19: Baby Coverage (ID)</li>
/// <li>IN2-20: Combine Baby Bill (ID)</li>
/// <li>IN2-21: Blood Deductible (ST)</li>
/// <li>IN2-22: Special Coverage Approval Name (XPN)</li>
/// <li>IN2-23: Special Coverage Approval Title (ST)</li>
/// <li>IN2-24: Non-Covered Insurance Code (IS)</li>
/// <li>IN2-25: Payor ID (CX)</li>
/// <li>IN2-26: Payor Subscriber ID (CX)</li>
/// <li>IN2-27: Eligibility Source (IS)</li>
/// <li>IN2-28: Room Coverage Type/Amount (RMC)</li>
/// <li>IN2-29: Policy Type/Amount (PTA)</li>
/// <li>IN2-30: Daily Deductible (DDI)</li>
/// <li>IN2-31: Living Dependency (IS)</li>
/// <li>IN2-32: Ambulatory Status (IS)</li>
/// <li>IN2-33: Citizenship (CE)</li>
/// <li>IN2-34: Primary Language (CE)</li>
/// <li>IN2-35: Living Arrangement (IS)</li>
/// <li>IN2-36: Publicity Code (CE)</li>
/// <li>IN2-37: Protection Indicator (ID)</li>
/// <li>IN2-38: Student Indicator (IS)</li>
/// <li>IN2-39: Religion (CE)</li>
/// <li>IN2-40: Mother's Maiden Name (XPN)</li>
/// <li>IN2-41: Nationality (CE)</li>
/// <li>IN2-42: Ethnic Group (CE)</li>
/// <li>IN2-43: Marital Status (CE)</li>
/// <li>IN2-44: Insured's Employment Start Date (DT)</li>
/// <li>IN2-45: Employment Stop Date (DT)</li>
/// <li>IN2-46: Job Title (ST)</li>
/// <li>IN2-47: Job Code/Class (JCC)</li>
/// <li>IN2-48: Job Status (IS)</li>
/// <li>IN2-49: Employer Contact Person Name (XPN)</li>
/// <li>IN2-50: Employer Contact Person Phone Number (XTN)</li>
/// <li>IN2-51: Employer Contact Reason (IS)</li>
/// <li>IN2-52: Insured's Contact Person's Name (XPN)</li>
/// <li>IN2-53: Insured's Contact Person Phone Number (XTN)</li>
/// <li>IN2-54: Insured's Contact Person Reason (IS)</li>
/// <li>IN2-55: Relationship To The Patient Start Date (DT)</li>
/// <li>IN2-56: Relationship To The Patient Stop Date (DT)</li>
/// <li>IN2-57: Insurance Co. Contact Reason (IS)</li>
/// <li>IN2-58: Insurance Co Contact Phone Number (XTN)</li>
/// <li>IN2-59: Policy Scope (IS)</li>
/// <li>IN2-60: Policy Source (IS)</li>
/// <li>IN2-61: Patient Member Number (CX)</li>
/// <li>IN2-62: Guarantor's Relationship To Insured (CE)</li>
/// <li>IN2-63: Insured's Phone Number - Home (XTN)</li>
/// <li>IN2-64: Insured's Employer Phone Number (XTN)</li>
/// <li>IN2-65: Military Handicapped Program (CE)</li>
/// <li>IN2-66: Suspend Flag (ID)</li>
/// <li>IN2-67: Copay Limit Flag (ID)</li>
/// <li>IN2-68: Stoploss Limit Flag (ID)</li>
/// <li>IN2-69: Insured Organization Name And ID (XON)</li>
/// <li>IN2-70: Insured Employer Organization Name And ID (XON)</li>
/// <li>IN2-71: Race (CE)</li>
/// <li>IN2-72: HCFA Patient's Relationship to Insured (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class IN2 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the IN2 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public IN2(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Insured's Employee ID");
       this.add(typeof(ST), false, 1, 11, new System.Object[]{message}, "Insured's Social Security Number");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Insured's Employer's Name and ID");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 139}, "Employer Information Data");
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 137}, "Mail Claim Party");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Medicare Health Ins Card Number");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Medicaid Case Name");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Medicaid Case Number");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Military Sponsor Name");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Military ID Number");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Dependent Of Military Recipient");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Military Organization");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Military Station");
       this.add(typeof(IS), false, 1, 14, new System.Object[]{message, 140}, "Military Service");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 141}, "Military Rank/Grade");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 142}, "Military Status");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Military Retire Date");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Military Non-Avail Cert On File");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Baby Coverage");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Combine Baby Bill");
       this.add(typeof(ST), false, 1, 1, new System.Object[]{message}, "Blood Deductible");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Special Coverage Approval Name");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Special Coverage Approval Title");
       this.add(typeof(IS), false, 0, 8, new System.Object[]{message, 143}, "Non-Covered Insurance Code");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Payor ID");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Payor Subscriber ID");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 144}, "Eligibility Source");
       this.add(typeof(RMC), false, 0, 250, new System.Object[]{message}, "Room Coverage Type/Amount");
       this.add(typeof(PTA), false, 0, 250, new System.Object[]{message}, "Policy Type/Amount");
       this.add(typeof(DDI), false, 1, 250, new System.Object[]{message}, "Daily Deductible");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 223}, "Living Dependency");
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9}, "Ambulatory Status");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Citizenship");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Primary Language");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220}, "Living Arrangement");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Publicity Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Protection Indicator");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231}, "Student Indicator");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Religion");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Mother's Maiden Name");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Nationality");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Ethnic Group");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Marital Status");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Insured's Employment Start Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Employment Stop Date");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Job Title");
       this.add(typeof(JCC), false, 1, 20, new System.Object[]{message}, "Job Code/Class");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311}, "Job Status");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Employer Contact Person Name");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Employer Contact Person Phone Number");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 222}, "Employer Contact Reason");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Insured's Contact Person's Name");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Insured's Contact Person Phone Number");
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 222}, "Insured's Contact Person Reason");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Relationship To The Patient Start Date");
       this.add(typeof(DT), false, 0, 8, new System.Object[]{message}, "Relationship To The Patient Stop Date");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 232}, "Insurance Co. Contact Reason");
       this.add(typeof(XTN), false, 1, 250, new System.Object[]{message}, "Insurance Co Contact Phone Number");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 312}, "Policy Scope");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 313}, "Policy Source");
       this.add(typeof(CX), false, 1, 250, new System.Object[]{message}, "Patient Member Number");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Guarantor's Relationship To Insured");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Insured's Phone Number - Home");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Insured's Employer Phone Number");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Military Handicapped Program");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Suspend Flag");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Copay Limit Flag");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Stoploss Limit Flag");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Insured Organization Name And ID");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Insured Employer Organization Name And ID");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Race");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "HCFA Patient's Relationship to Insured");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of Insured's Employee ID(IN2-1). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s employee identifier. </returns>

	public CX GetInsuredSEmployeeID(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(1, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Employee ID (IN2-1). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of cx. </returns>

  public CX[] GetInsuredSEmployeeID() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(1);  
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

  /// <summary> Returns the total repetitions of Insured's Employee ID (IN2-1). </summary>
  ///
  /// <value>   The insured s employee identifier repetitions used. </value>

  public int InsuredSEmployeeIDRepetitionsUsed
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

    /// <summary>   Returns Insured's Social Security Number(IN2-2). </summary>
    ///
    /// <value> The insured s social security number. </value>

	public ST InsuredSSocialSecurityNumber
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

    /// <summary>
    /// Returns a single repetition of Insured's Employer's Name and ID(IN2-3). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s employer s name and identifier. </returns>

	public XCN GetInsuredSEmployerSNameAndID(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Employer's Name and ID (IN2-3). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetInsuredSEmployerSNameAndID() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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

  /// <summary> Returns the total repetitions of Insured's Employer's Name and ID (IN2-3). </summary>
  ///
  /// <value>   The insured s employer s name and identifier repetitions used. </value>

  public int InsuredSEmployerSNameAndIDRepetitionsUsed
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

    /// <summary>   Returns Employer Information Data(IN2-4). </summary>
    ///
    /// <value> Information describing the employer information. </value>

	public IS EmployerInformationData
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

    /// <summary>
    /// Returns a single repetition of Mail Claim Party(IN2-5). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The mail claim party. </returns>

	public IS GetMailClaimParty(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Mail Claim Party (IN2-5). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetMailClaimParty() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(5);  
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

  /// <summary> Returns the total repetitions of Mail Claim Party (IN2-5). </summary>
  ///
  /// <value>   The mail claim party repetitions used. </value>

  public int MailClaimPartyRepetitionsUsed
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

    /// <summary>   Returns Medicare Health Ins Card Number(IN2-6). </summary>
    ///
    /// <value> The medicare health insert card number. </value>

	public ST MedicareHealthInsCardNumber
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
    /// Returns a single repetition of Medicaid Case Name(IN2-7). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The medicaid case name. </returns>

	public XPN GetMedicaidCaseName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Medicaid Case Name (IN2-7). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xpn. </returns>

  public XPN[] GetMedicaidCaseName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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

  /// <summary> Returns the total repetitions of Medicaid Case Name (IN2-7). </summary>
  ///
  /// <value>   The medicaid case name repetitions used. </value>

  public int MedicaidCaseNameRepetitionsUsed
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

    /// <summary>   Returns Medicaid Case Number(IN2-8). </summary>
    ///
    /// <value> The medicaid case number. </value>

	public ST MedicaidCaseNumber
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

    /// <summary>
    /// Returns a single repetition of Military Sponsor Name(IN2-9). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The military sponsor name. </returns>

	public XPN GetMilitarySponsorName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Military Sponsor Name (IN2-9). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xpn. </returns>

  public XPN[] GetMilitarySponsorName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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

  /// <summary> Returns the total repetitions of Military Sponsor Name (IN2-9). </summary>
  ///
  /// <value>   The military sponsor name repetitions used. </value>

  public int MilitarySponsorNameRepetitionsUsed
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

    /// <summary>   Returns Military ID Number(IN2-10). </summary>
    ///
    /// <value> The military identifier number. </value>

	public ST MilitaryIDNumber
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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

    /// <summary>   Returns Dependent Of Military Recipient(IN2-11). </summary>
    ///
    /// <value> The dependent of military recipient. </value>

	public CE DependentOfMilitaryRecipient
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

    /// <summary>   Returns Military Organization(IN2-12). </summary>
    ///
    /// <value> The military organization. </value>

	public ST MilitaryOrganization
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

    /// <summary>   Returns Military Station(IN2-13). </summary>
    ///
    /// <value> The military station. </value>

	public ST MilitaryStation
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

    /// <summary>   Returns Military Service(IN2-14). </summary>
    ///
    /// <value> The military service. </value>

	public IS MilitaryService
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

    /// <summary>   Returns Military Rank/Grade(IN2-15). </summary>
    ///
    /// <value> The military rank grade. </value>

	public IS MilitaryRankGrade
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

    /// <summary>   Returns Military Status(IN2-16). </summary>
    ///
    /// <value> The military status. </value>

	public IS MilitaryStatus
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

    /// <summary>   Returns Military Retire Date(IN2-17). </summary>
    ///
    /// <value> The military retire date. </value>

	public DT MilitaryRetireDate
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

    /// <summary>   Returns Military Non-Avail Cert On File(IN2-18). </summary>
    ///
    /// <value> The military non avail cert on file. </value>

	public ID MilitaryNonAvailCertOnFile
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

    /// <summary>   Returns Baby Coverage(IN2-19). </summary>
    ///
    /// <value> The baby coverage. </value>

	public ID BabyCoverage
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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

    /// <summary>   Returns Combine Baby Bill(IN2-20). </summary>
    ///
    /// <value> The combine baby bill. </value>

	public ID CombineBabyBill
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(20, 0);
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

    /// <summary>   Returns Blood Deductible(IN2-21). </summary>
    ///
    /// <value> The blood deductible. </value>

	public ST BloodDeductible
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

    /// <summary>
    /// Returns a single repetition of Special Coverage Approval Name(IN2-22). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The special coverage approval name. </returns>

	public XPN GetSpecialCoverageApprovalName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(22, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Special Coverage Approval Name (IN2-22). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xpn. </returns>

  public XPN[] GetSpecialCoverageApprovalName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(22);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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

  /// <summary> Returns the total repetitions of Special Coverage Approval Name (IN2-22). </summary>
  ///
  /// <value>   The special coverage approval name repetitions used. </value>

  public int SpecialCoverageApprovalNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(22);
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

    /// <summary>   Returns Special Coverage Approval Title(IN2-23). </summary>
    ///
    /// <value> The special coverage approval title. </value>

	public ST SpecialCoverageApprovalTitle
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

    /// <summary>
    /// Returns a single repetition of Non-Covered Insurance Code(IN2-24). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The non covered insurance code. </returns>

	public IS GetNonCoveredInsuranceCode(int rep)
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

  /// <summary> Returns all repetitions of Non-Covered Insurance Code (IN2-24). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetNonCoveredInsuranceCode() {
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

  /// <summary> Returns the total repetitions of Non-Covered Insurance Code (IN2-24). </summary>
  ///
  /// <value>   The non covered insurance code repetitions used. </value>

  public int NonCoveredInsuranceCodeRepetitionsUsed
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
    /// Returns a single repetition of Payor ID(IN2-25). throws HL7Exception if the repetition number
    /// is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The payor identifier. </returns>

	public CX GetPayorID(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(25, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Payor ID (IN2-25). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of cx. </returns>

  public CX[] GetPayorID() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(25);  
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

  /// <summary> Returns the total repetitions of Payor ID (IN2-25). </summary>
  ///
  /// <value>   The payor identifier repetitions used. </value>

  public int PayorIDRepetitionsUsed
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
    /// Returns a single repetition of Payor Subscriber ID(IN2-26). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The payor subscriber identifier. </returns>

	public CX GetPayorSubscriberID(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(26, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Payor Subscriber ID (IN2-26). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of cx. </returns>

  public CX[] GetPayorSubscriberID() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(26);  
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

  /// <summary> Returns the total repetitions of Payor Subscriber ID (IN2-26). </summary>
  ///
  /// <value>   The payor subscriber identifier repetitions used. </value>

  public int PayorSubscriberIDRepetitionsUsed
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

    /// <summary>   Returns Eligibility Source(IN2-27). </summary>
    ///
    /// <value> The eligibility source. </value>

	public IS EligibilitySource
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(27, 0);
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
    /// Returns a single repetition of Room Coverage Type/Amount(IN2-28). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The room coverage type amount. </returns>

	public RMC GetRoomCoverageTypeAmount(int rep)
	{
			RMC ret = null;
			try
			{
			IType t = this.GetField(28, rep);
				ret = (RMC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Room Coverage Type/Amount (IN2-28). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of rmc. </returns>

  public RMC[] GetRoomCoverageTypeAmount() {
     RMC[] ret = null;
    try {
        IType[] t = this.GetField(28);  
        ret = new RMC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (RMC)t[i];
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

  /// <summary> Returns the total repetitions of Room Coverage Type/Amount (IN2-28). </summary>
  ///
  /// <value>   The room coverage type amount repetitions used. </value>

  public int RoomCoverageTypeAmountRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(28);
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
    /// Returns a single repetition of Policy Type/Amount(IN2-29). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The policy type amount. </returns>

	public PTA GetPolicyTypeAmount(int rep)
	{
			PTA ret = null;
			try
			{
			IType t = this.GetField(29, rep);
				ret = (PTA)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Policy Type/Amount (IN2-29). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of pta. </returns>

  public PTA[] GetPolicyTypeAmount() {
     PTA[] ret = null;
    try {
        IType[] t = this.GetField(29);  
        ret = new PTA[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PTA)t[i];
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

  /// <summary> Returns the total repetitions of Policy Type/Amount (IN2-29). </summary>
  ///
  /// <value>   The policy type amount repetitions used. </value>

  public int PolicyTypeAmountRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(29);
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

    /// <summary>   Returns Daily Deductible(IN2-30). </summary>
    ///
    /// <value> The daily deductible. </value>

	public DDI DailyDeductible
	{
		get{
			DDI ret = null;
			try
			{
			IType t = this.GetField(30, 0);
				ret = (DDI)t;
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

    /// <summary>   Returns Living Dependency(IN2-31). </summary>
    ///
    /// <value> The living dependency. </value>

	public IS LivingDependency
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

    /// <summary>
    /// Returns a single repetition of Ambulatory Status(IN2-32). throws HL7Exception if the
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
			IType t = this.GetField(32, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Ambulatory Status (IN2-32). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetAmbulatoryStatus() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(32);  
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

  /// <summary> Returns the total repetitions of Ambulatory Status (IN2-32). </summary>
  ///
  /// <value>   The ambulatory status repetitions used. </value>

  public int AmbulatoryStatusRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(32);
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
    /// Returns a single repetition of Citizenship(IN2-33). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The citizenship. </returns>

	public CE GetCitizenship(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(33, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Citizenship (IN2-33). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetCitizenship() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(33);  
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

  /// <summary> Returns the total repetitions of Citizenship (IN2-33). </summary>
  ///
  /// <value>   The citizenship repetitions used. </value>

  public int CitizenshipRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(33);
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

    /// <summary>   Returns Primary Language(IN2-34). </summary>
    ///
    /// <value> The primary language. </value>

	public CE PrimaryLanguage
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(34, 0);
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

    /// <summary>   Returns Living Arrangement(IN2-35). </summary>
    ///
    /// <value> The living arrangement. </value>

	public IS LivingArrangement
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(35, 0);
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

    /// <summary>   Returns Publicity Code(IN2-36). </summary>
    ///
    /// <value> The publicity code. </value>

	public CE PublicityCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(36, 0);
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

    /// <summary>   Returns Protection Indicator(IN2-37). </summary>
    ///
    /// <value> The protection indicator. </value>

	public ID ProtectionIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(37, 0);
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

    /// <summary>   Returns Student Indicator(IN2-38). </summary>
    ///
    /// <value> The student indicator. </value>

	public IS StudentIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(38, 0);
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

    /// <summary>   Returns Religion(IN2-39). </summary>
    ///
    /// <value> The religion. </value>

	public CE Religion
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(39, 0);
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
    /// Returns a single repetition of Mother's Maiden Name(IN2-40). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The mother s maiden name. </returns>

	public XPN GetMotherSMaidenName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(40, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Mother's Maiden Name (IN2-40). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xpn. </returns>

  public XPN[] GetMotherSMaidenName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(40);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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

  /// <summary> Returns the total repetitions of Mother's Maiden Name (IN2-40). </summary>
  ///
  /// <value>   The mother s maiden name repetitions used. </value>

  public int MotherSMaidenNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(40);
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

    /// <summary>   Returns Nationality(IN2-41). </summary>
    ///
    /// <value> The nationality. </value>

	public CE Nationality
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(41, 0);
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
    /// Returns a single repetition of Ethnic Group(IN2-42). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The ethnic group. </returns>

	public CE GetEthnicGroup(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(42, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Ethnic Group (IN2-42). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetEthnicGroup() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(42);  
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

  /// <summary> Returns the total repetitions of Ethnic Group (IN2-42). </summary>
  ///
  /// <value>   The ethnic group repetitions used. </value>

  public int EthnicGroupRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(42);
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
    /// Returns a single repetition of Marital Status(IN2-43). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The marital status. </returns>

	public CE GetMaritalStatus(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(43, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Marital Status (IN2-43). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetMaritalStatus() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(43);  
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

  /// <summary> Returns the total repetitions of Marital Status (IN2-43). </summary>
  ///
  /// <value>   The marital status repetitions used. </value>

  public int MaritalStatusRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(43);
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

    /// <summary>   Returns Insured's Employment Start Date(IN2-44). </summary>
    ///
    /// <value> The insured s employment start date. </value>

	public DT InsuredSEmploymentStartDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(44, 0);
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

    /// <summary>   Returns Employment Stop Date(IN2-45). </summary>
    ///
    /// <value> The employment stop date. </value>

	public DT EmploymentStopDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(45, 0);
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

    /// <summary>   Returns Job Title(IN2-46). </summary>
    ///
    /// <value> The job title. </value>

	public ST JobTitle
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(46, 0);
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

    /// <summary>   Returns Job Code/Class(IN2-47). </summary>
    ///
    /// <value> The job code class. </value>

	public JCC JobCodeClass
	{
		get{
			JCC ret = null;
			try
			{
			IType t = this.GetField(47, 0);
				ret = (JCC)t;
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

    /// <summary>   Returns Job Status(IN2-48). </summary>
    ///
    /// <value> The job status. </value>

	public IS JobStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(48, 0);
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
    /// Returns a single repetition of Employer Contact Person Name(IN2-49). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The employer contact person name. </returns>

	public XPN GetEmployerContactPersonName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(49, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Employer Contact Person Name (IN2-49). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xpn. </returns>

  public XPN[] GetEmployerContactPersonName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(49);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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

  /// <summary> Returns the total repetitions of Employer Contact Person Name (IN2-49). </summary>
  ///
  /// <value>   The employer contact person name repetitions used. </value>

  public int EmployerContactPersonNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(49);
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
    /// Returns a single repetition of Employer Contact Person Phone Number(IN2-50). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The employer contact person phone number. </returns>

	public XTN GetEmployerContactPersonPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(50, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Employer Contact Person Phone Number (IN2-50). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetEmployerContactPersonPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(50);  
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

  /// <summary>
  /// Returns the total repetitions of Employer Contact Person Phone Number (IN2-50).
  /// </summary>
  ///
  /// <value>   The employer contact person phone number repetitions used. </value>

  public int EmployerContactPersonPhoneNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(50);
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

    /// <summary>   Returns Employer Contact Reason(IN2-51). </summary>
    ///
    /// <value> The employer contact reason. </value>

	public IS EmployerContactReason
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
    /// Returns a single repetition of Insured's Contact Person's Name(IN2-52). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s contact person s name. </returns>

	public XPN GetInsuredSContactPersonSName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(52, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Contact Person's Name (IN2-52). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xpn. </returns>

  public XPN[] GetInsuredSContactPersonSName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(52);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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

  /// <summary> Returns the total repetitions of Insured's Contact Person's Name (IN2-52). </summary>
  ///
  /// <value>   The insured s contact person s name repetitions used. </value>

  public int InsuredSContactPersonSNameRepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of Insured's Contact Person Phone Number(IN2-53). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s contact person phone number. </returns>

	public XTN GetInsuredSContactPersonPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(53, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Contact Person Phone Number (IN2-53). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetInsuredSContactPersonPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(53);  
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

  /// <summary>
  /// Returns the total repetitions of Insured's Contact Person Phone Number (IN2-53).
  /// </summary>
  ///
  /// <value>   The insured s contact person phone number repetitions used. </value>

  public int InsuredSContactPersonPhoneNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(53);
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
    /// Returns a single repetition of Insured's Contact Person Reason(IN2-54). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s contact person reason. </returns>

	public IS GetInsuredSContactPersonReason(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(54, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Contact Person Reason (IN2-54). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of is. </returns>

  public IS[] GetInsuredSContactPersonReason() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(54);  
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

  /// <summary> Returns the total repetitions of Insured's Contact Person Reason (IN2-54). </summary>
  ///
  /// <value>   The insured s contact person reason repetitions used. </value>

  public int InsuredSContactPersonReasonRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(54);
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

    /// <summary>   Returns Relationship To The Patient Start Date(IN2-55). </summary>
    ///
    /// <value> The relationship to the patient start date. </value>

	public DT RelationshipToThePatientStartDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(55, 0);
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
    /// Returns a single repetition of Relationship To The Patient Stop Date(IN2-56). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The relationship to the patient stop date. </returns>

	public DT GetRelationshipToThePatientStopDate(int rep)
	{
			DT ret = null;
			try
			{
			IType t = this.GetField(56, rep);
				ret = (DT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Relationship To The Patient Stop Date (IN2-56). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of dt. </returns>

  public DT[] GetRelationshipToThePatientStopDate() {
     DT[] ret = null;
    try {
        IType[] t = this.GetField(56);  
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

  /// <summary>
  /// Returns the total repetitions of Relationship To The Patient Stop Date (IN2-56).
  /// </summary>
  ///
  /// <value>   The relationship to the patient stop date repetitions used. </value>

  public int RelationshipToThePatientStopDateRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(56);
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

    /// <summary>   Returns Insurance Co. Contact Reason(IN2-57). </summary>
    ///
    /// <value> The insurance co contact reason. </value>

	public IS InsuranceCoContactReason
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(57, 0);
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

    /// <summary>   Returns Insurance Co Contact Phone Number(IN2-58). </summary>
    ///
    /// <value> The insurance co contact phone number. </value>

	public XTN InsuranceCoContactPhoneNumber
	{
		get{
			XTN ret = null;
			try
			{
			IType t = this.GetField(58, 0);
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

    /// <summary>   Returns Policy Scope(IN2-59). </summary>
    ///
    /// <value> The policy scope. </value>

	public IS PolicyScope
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(59, 0);
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

    /// <summary>   Returns Policy Source(IN2-60). </summary>
    ///
    /// <value> The policy source. </value>

	public IS PolicySource
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(60, 0);
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

    /// <summary>   Returns Patient Member Number(IN2-61). </summary>
    ///
    /// <value> The patient member number. </value>

	public CX PatientMemberNumber
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(61, 0);
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

    /// <summary>   Returns Guarantor's Relationship To Insured(IN2-62). </summary>
    ///
    /// <value> The guarantor s relationship to insured. </value>

	public CE GuarantorSRelationshipToInsured
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(62, 0);
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
    /// Returns a single repetition of Insured's Phone Number - Home(IN2-63). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s phone number home. </returns>

	public XTN GetInsuredSPhoneNumberHome(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(63, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Phone Number - Home (IN2-63). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetInsuredSPhoneNumberHome() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(63);  
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

  /// <summary> Returns the total repetitions of Insured's Phone Number - Home (IN2-63). </summary>
  ///
  /// <value>   The insured s phone number home repetitions used. </value>

  public int InsuredSPhoneNumberHomeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(63);
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
    /// Returns a single repetition of Insured's Employer Phone Number(IN2-64). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured s employer phone number. </returns>

	public XTN GetInsuredSEmployerPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(64, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured's Employer Phone Number (IN2-64). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetInsuredSEmployerPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(64);  
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

  /// <summary> Returns the total repetitions of Insured's Employer Phone Number (IN2-64). </summary>
  ///
  /// <value>   The insured s employer phone number repetitions used. </value>

  public int InsuredSEmployerPhoneNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(64);
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

    /// <summary>   Returns Military Handicapped Program(IN2-65). </summary>
    ///
    /// <value> The military handicapped program. </value>

	public CE MilitaryHandicappedProgram
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(65, 0);
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

    /// <summary>   Returns Suspend Flag(IN2-66). </summary>
    ///
    /// <value> The suspend flag. </value>

	public ID SuspendFlag
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(66, 0);
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

    /// <summary>   Returns Copay Limit Flag(IN2-67). </summary>
    ///
    /// <value> The copay limit flag. </value>

	public ID CopayLimitFlag
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(67, 0);
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

    /// <summary>   Returns Stoploss Limit Flag(IN2-68). </summary>
    ///
    /// <value> The stoploss limit flag. </value>

	public ID StoplossLimitFlag
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(68, 0);
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
    /// Returns a single repetition of Insured Organization Name And ID(IN2-69). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured organization name and identifier. </returns>

	public XON GetInsuredOrganizationNameAndID(int rep)
	{
			XON ret = null;
			try
			{
			IType t = this.GetField(69, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Insured Organization Name And ID (IN2-69). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of XON. </returns>

  public XON[] GetInsuredOrganizationNameAndID() {
     XON[] ret = null;
    try {
        IType[] t = this.GetField(69);  
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

  /// <summary>
  /// Returns the total repetitions of Insured Organization Name And ID (IN2-69).
  /// </summary>
  ///
  /// <value>   The insured organization name and identifier repetitions used. </value>

  public int InsuredOrganizationNameAndIDRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(69);
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
    /// Returns a single repetition of Insured Employer Organization Name And ID(IN2-70). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The insured employer organization name and identifier. </returns>

	public XON GetInsuredEmployerOrganizationNameAndID(int rep)
	{
			XON ret = null;
			try
			{
			IType t = this.GetField(70, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Insured Employer Organization Name And ID (IN2-70).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of XON. </returns>

  public XON[] GetInsuredEmployerOrganizationNameAndID() {
     XON[] ret = null;
    try {
        IType[] t = this.GetField(70);  
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

  /// <summary>
  /// Returns the total repetitions of Insured Employer Organization Name And ID (IN2-70).
  /// </summary>
  ///
  /// <value>   The insured employer organization name and identifier repetitions used. </value>

  public int InsuredEmployerOrganizationNameAndIDRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(70);
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
    /// Returns a single repetition of Race(IN2-71). throws HL7Exception if the repetition number is
    /// invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The race. </returns>

	public CE GetRace(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(71, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Race (IN2-71). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetRace() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(71);  
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

  /// <summary> Returns the total repetitions of Race (IN2-71). </summary>
  ///
  /// <value>   The race repetitions used. </value>

  public int RaceRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(71);
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

    /// <summary>   Returns HCFA Patient's Relationship to Insured(IN2-72). </summary>
    ///
    /// <value> The hcfa patient s relationship to insured. </value>

	public CE HCFAPatientSRelationshipToInsured
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(72, 0);
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