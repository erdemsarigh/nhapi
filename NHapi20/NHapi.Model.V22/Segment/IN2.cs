using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/// <summary>
/// Represents an HL7 IN2 message segment. This segment has the following fields:<ol>
/// <li>IN2-1: Insured's employee ID (ST)</li>
/// <li>IN2-2: Insured's social security number (ST)</li>
/// <li>IN2-3: Insured's employer name (CN_PERSON)</li>
/// <li>IN2-4: Employer information data (ID)</li>
/// <li>IN2-5: Mail claim party (ID)</li>
/// <li>IN2-6: Medicare health insurance card number (NM)</li>
/// <li>IN2-7: Medicaid case name (PN)</li>
/// <li>IN2-8: Medicaid case number (NM)</li>
/// <li>IN2-9: Champus sponsor name (PN)</li>
/// <li>IN2-10: Champus ID number (NM)</li>
/// <li>IN2-11: Dependent of champus recipient (ID)</li>
/// <li>IN2-12: Champus organization (ST)</li>
/// <li>IN2-13: Champus station (ST)</li>
/// <li>IN2-14: Champus service (ID)</li>
/// <li>IN2-15: Champus rank / grade (ID)</li>
/// <li>IN2-16: Champus status (ID)</li>
/// <li>IN2-17: Champus retire date (DT)</li>
/// <li>IN2-18: Champus non-availability certification on file (ID)</li>
/// <li>IN2-19: Baby coverage (ID)</li>
/// <li>IN2-20: Combine baby bill (ID)</li>
/// <li>IN2-21: Blood deductible (NM)</li>
/// <li>IN2-22: Special coverage approval name (PN)</li>
/// <li>IN2-23: Special coverage approval title (ST)</li>
/// <li>IN2-24: Non-covered insurance code (ID)</li>
/// <li>IN2-25: Payor ID (ST)</li>
/// <li>IN2-26: Payor subscriber ID (ST)</li>
/// <li>IN2-27: Eligibility source (ID)</li>
/// <li>IN2-28: Room coverage type / amount (CM_RMC)</li>
/// <li>IN2-29: Policy type / amount (CM_PTA)</li>
/// <li>IN2-30: Daily deductible (CM_DDI)</li>
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
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Insured's employee ID");
       this.add(typeof(ST), false, 1, 9, new System.Object[]{message}, "Insured's social security number");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Insured's employer name");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 139}, "Employer information data");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 137}, "Mail claim party");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "Medicare health insurance card number");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Medicaid case name");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "Medicaid case number");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Champus sponsor name");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Champus ID number");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "Dependent of champus recipient");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Champus organization");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Champus station");
       this.add(typeof(ID), false, 1, 14, new System.Object[]{message, 140}, "Champus service");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 141}, "Champus rank / grade");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 142}, "Champus status");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Champus retire date");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Champus non-availability certification on file");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Baby coverage");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Combine baby bill");
       this.add(typeof(NM), false, 1, 1, new System.Object[]{message}, "Blood deductible");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Special coverage approval name");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Special coverage approval title");
       this.add(typeof(ID), false, 0, 8, new System.Object[]{message, 143}, "Non-covered insurance code");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Payor ID");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Payor subscriber ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 144}, "Eligibility source");
       this.add(typeof(CM_RMC), false, 0, 25, new System.Object[]{message}, "Room coverage type / amount");
       this.add(typeof(CM_PTA), false, 0, 25, new System.Object[]{message}, "Policy type / amount");
       this.add(typeof(CM_DDI), false, 1, 25, new System.Object[]{message}, "Daily deductible");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Insured's employee ID(IN2-1). </summary>
    ///
    /// <value> The identifier of the insured s employee. </value>

	public ST InsuredSEmployeeID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns Insured's social security number(IN2-2). </summary>
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

    /// <summary>   Returns Insured's employer name(IN2-3). </summary>
    ///
    /// <value> The name of the insured s employer. </value>

	public CN_PERSON InsuredSEmployerName
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns Employer information data(IN2-4). </summary>
    ///
    /// <value> Information describing the employer information. </value>

	public ID EmployerInformationData
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

    /// <summary>   Returns Mail claim party(IN2-5). </summary>
    ///
    /// <value> The mail claim party. </value>

	public ID MailClaimParty
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

    /// <summary>   Returns Medicare health insurance card number(IN2-6). </summary>
    ///
    /// <value> The medicare health insurance card number. </value>

	public NM MedicareHealthInsuranceCardNumber
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

    /// <summary>   Returns Medicaid case name(IN2-7). </summary>
    ///
    /// <value> The name of the medicaid case. </value>

	public PN MedicaidCaseName
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

    /// <summary>   Returns Medicaid case number(IN2-8). </summary>
    ///
    /// <value> The medicaid case number. </value>

	public NM MedicaidCaseNumber
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

    /// <summary>   Returns Champus sponsor name(IN2-9). </summary>
    ///
    /// <value> The name of the champus sponsor. </value>

	public PN ChampusSponsorName
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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

    /// <summary>   Returns Champus ID number(IN2-10). </summary>
    ///
    /// <value> The champus identifier number. </value>

	public NM ChampusIDNumber
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

    /// <summary>   Returns Dependent of champus recipient(IN2-11). </summary>
    ///
    /// <value> The dependent of champus recipient. </value>

	public ID DependentOfChampusRecipient
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

    /// <summary>   Returns Champus organization(IN2-12). </summary>
    ///
    /// <value> The champus organization. </value>

	public ST ChampusOrganization
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

    /// <summary>   Returns Champus station(IN2-13). </summary>
    ///
    /// <value> The champus station. </value>

	public ST ChampusStation
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

    /// <summary>   Returns Champus service(IN2-14). </summary>
    ///
    /// <value> The champus service. </value>

	public ID ChampusService
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

    /// <summary>   Returns Champus rank / grade(IN2-15). </summary>
    ///
    /// <value> The champus rank grade. </value>

	public ID ChampusRankGrade
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

    /// <summary>   Returns Champus status(IN2-16). </summary>
    ///
    /// <value> The champus status. </value>

	public ID ChampusStatus
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

    /// <summary>   Returns Champus retire date(IN2-17). </summary>
    ///
    /// <value> The champus retire date. </value>

	public DT ChampusRetireDate
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

    /// <summary>   Returns Champus non-availability certification on file(IN2-18). </summary>
    ///
    /// <value> The champus non availability certification on file. </value>

	public ID ChampusNonAvailabilityCertificationOnFile
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

    /// <summary>   Returns Baby coverage(IN2-19). </summary>
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

    /// <summary>   Returns Combine baby bill(IN2-20). </summary>
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

    /// <summary>   Returns Blood deductible(IN2-21). </summary>
    ///
    /// <value> The blood deductible. </value>

	public NM BloodDeductible
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(21, 0);
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

    /// <summary>   Returns Special coverage approval name(IN2-22). </summary>
    ///
    /// <value> The name of the special coverage approval. </value>

	public PN SpecialCoverageApprovalName
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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

    /// <summary>   Returns Special coverage approval title(IN2-23). </summary>
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
    /// Returns a single repetition of Non-covered insurance code(IN2-24). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The non covered insurance code. </returns>

	public ID GetNonCoveredInsuranceCode(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(24, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Non-covered insurance code (IN2-24). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetNonCoveredInsuranceCode() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(24);  
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

  /// <summary> Returns the total repetitions of Non-covered insurance code (IN2-24). </summary>
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

    /// <summary>   Returns Payor ID(IN2-25). </summary>
    ///
    /// <value> The identifier of the payor. </value>

	public ST PayorID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(25, 0);
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

    /// <summary>   Returns Payor subscriber ID(IN2-26). </summary>
    ///
    /// <value> The identifier of the payor subscriber. </value>

	public ST PayorSubscriberID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(26, 0);
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

    /// <summary>   Returns Eligibility source(IN2-27). </summary>
    ///
    /// <value> The eligibility source. </value>

	public ID EligibilitySource
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(27, 0);
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
    /// Returns a single repetition of Room coverage type / amount(IN2-28). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The room coverage type amount. </returns>

	public CM_RMC GetRoomCoverageTypeAmount(int rep)
	{
			CM_RMC ret = null;
			try
			{
			IType t = this.GetField(28, rep);
				ret = (CM_RMC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Room coverage type / amount (IN2-28). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres rmc. </returns>

  public CM_RMC[] GetRoomCoverageTypeAmount() {
     CM_RMC[] ret = null;
    try {
        IType[] t = this.GetField(28);  
        ret = new CM_RMC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_RMC)t[i];
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

  /// <summary> Returns the total repetitions of Room coverage type / amount (IN2-28). </summary>
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
    /// Returns a single repetition of Policy type / amount(IN2-29). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The policy type amount. </returns>

	public CM_PTA GetPolicyTypeAmount(int rep)
	{
			CM_PTA ret = null;
			try
			{
			IType t = this.GetField(29, rep);
				ret = (CM_PTA)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Policy type / amount (IN2-29). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres pta. </returns>

  public CM_PTA[] GetPolicyTypeAmount() {
     CM_PTA[] ret = null;
    try {
        IType[] t = this.GetField(29);  
        ret = new CM_PTA[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_PTA)t[i];
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

  /// <summary> Returns the total repetitions of Policy type / amount (IN2-29). </summary>
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

    /// <summary>   Returns Daily deductible(IN2-30). </summary>
    ///
    /// <value> The daily deductible. </value>

	public CM_DDI DailyDeductible
	{
		get{
			CM_DDI ret = null;
			try
			{
			IType t = this.GetField(30, 0);
				ret = (CM_DDI)t;
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