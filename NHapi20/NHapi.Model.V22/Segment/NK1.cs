using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/// <summary>
/// Represents an HL7 NK1 message segment. This segment has the following fields:<ol>
/// <li>NK1-1: Set ID - Next of Kin (SI)</li>
/// <li>NK1-2: Name (PN)</li>
/// <li>NK1-3: Relationship (CE)</li>
/// <li>NK1-4: Address (AD)</li>
/// <li>NK1-5: Phone Number (TN)</li>
/// <li>NK1-6: Business Phone Number (TN)</li>
/// <li>NK1-7: Contact Role (CE)</li>
/// <li>NK1-8: Start Date (DT)</li>
/// <li>NK1-9: End Date (DT)</li>
/// <li>NK1-10: Next of Kin (ST)</li>
/// <li>NK1-11: Next of kin job code / class (CM_JOB_CODE)</li>
/// <li>NK1-12: Next of Kin Employee Number (ST)</li>
/// <li>NK1-13: Organization Name (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class NK1 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the NK1 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public NK1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - Next of Kin");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Name");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Relationship");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Address");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Phone Number");
       this.add(typeof(TN), false, 1, 40, new System.Object[]{message}, "Business Phone Number");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Contact Role");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Start Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "End Date");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Next of Kin");
       this.add(typeof(CM_JOB_CODE), false, 1, 60, new System.Object[]{message}, "Next of kin job code / class");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Next of Kin Employee Number");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Organization Name");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Set ID - Next of Kin(NK1-1). </summary>
    ///
    /// <value> The set identifier next of kin. </value>

	public SI SetIDNextOfKin
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

    /// <summary>   Returns Name(NK1-2). </summary>
    ///
    /// <value> The name. </value>

	public PN Name
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

    /// <summary>   Returns Relationship(NK1-3). </summary>
    ///
    /// <value> The relationship. </value>

	public CE Relationship
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns Address(NK1-4). </summary>
    ///
    /// <value> The address. </value>

	public AD Address
	{
		get{
			AD ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

    /// <summary>
    /// Returns a single repetition of Phone Number(NK1-5). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The phone number. </returns>

	public TN GetPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Phone Number (NK1-5). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of tn. </returns>

  public TN[] GetPhoneNumber() {
     TN[] ret = null;
    try {
        IType[] t = this.GetField(5);  
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

  /// <summary> Returns the total repetitions of Phone Number (NK1-5). </summary>
  ///
  /// <value>   The phone number repetitions used. </value>

  public int PhoneNumberRepetitionsUsed
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

    /// <summary>   Returns Business Phone Number(NK1-6). </summary>
    ///
    /// <value> The business phone number. </value>

	public TN BusinessPhoneNumber
	{
		get{
			TN ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (TN)t;
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

    /// <summary>   Returns Contact Role(NK1-7). </summary>
    ///
    /// <value> The contact role. </value>

	public CE ContactRole
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

    /// <summary>   Returns Start Date(NK1-8). </summary>
    ///
    /// <value> The start date. </value>

	public DT StartDate
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

    /// <summary>   Returns End Date(NK1-9). </summary>
    ///
    /// <value> The end date. </value>

	public DT EndDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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

    /// <summary>   Returns Next of Kin(NK1-10). </summary>
    ///
    /// <value> The next of kin. </value>

	public ST NextOfKin
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

    /// <summary>   Returns Next of kin job code / class(NK1-11). </summary>
    ///
    /// <value> The next of kin job code class. </value>

	public CM_JOB_CODE NextOfKinJobCodeClass
	{
		get{
			CM_JOB_CODE ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (CM_JOB_CODE)t;
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

    /// <summary>   Returns Next of Kin Employee Number(NK1-12). </summary>
    ///
    /// <value> The next of kin employee number. </value>

	public ST NextOfKinEmployeeNumber
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

    /// <summary>   Returns Organization Name(NK1-13). </summary>
    ///
    /// <value> The name of the organization. </value>

	public ST OrganizationName
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


}}