using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V231.Segment{

/// <summary>
/// Represents an HL7 ROL message segment. This segment has the following fields:<ol>
/// <li>ROL-1: Role Instance ID (EI)</li>
/// <li>ROL-2: Action Code (ID)</li>
/// <li>ROL-3: Role-ROL (CE)</li>
/// <li>ROL-4: Role Person (XCN)</li>
/// <li>ROL-5: Role Begin Date/Time (TS)</li>
/// <li>ROL-6: Role End Date/Time (TS)</li>
/// <li>ROL-7: Role Duration (CE)</li>
/// <li>ROL-8: Role Action Reason (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class ROL : AbstractSegment  {

    /// <summary>   Initializes a new instance of the ROL class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public ROL(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(EI), true, 1, 60, new System.Object[]{message}, "Role Instance ID");
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 287}, "Action Code");
       this.add(typeof(CE), true, 1, 80, new System.Object[]{message}, "Role-ROL");
       this.add(typeof(XCN), true, 0, 80, new System.Object[]{message}, "Role Person");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Role Begin Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Role End Date/Time");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Role Duration");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Role Action Reason");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Role Instance ID(ROL-1). </summary>
    ///
    /// <value> The identifier of the role instance. </value>

	public EI RoleInstanceID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns Action Code(ROL-2). </summary>
    ///
    /// <value> The action code. </value>

	public ID ActionCode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

    /// <summary>   Returns Role-ROL(ROL-3). </summary>
    ///
    /// <value> The role rol. </value>

	public CE RoleROL
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

    /// <summary>
    /// Returns a single repetition of Role Person(ROL-4). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The role person. </returns>

	public XCN GetRolePerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Role Person (ROL-4). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetRolePerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(4);  
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

  /// <summary> Returns the total repetitions of Role Person (ROL-4). </summary>
  ///
  /// <value>   The role person repetitions used. </value>

  public int RolePersonRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(4);
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

    /// <summary>   Returns Role Begin Date/Time(ROL-5). </summary>
    ///
    /// <value> The role begin date time. </value>

	public TS RoleBeginDateTime
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

    /// <summary>   Returns Role End Date/Time(ROL-6). </summary>
    ///
    /// <value> The role end date time. </value>

	public TS RoleEndDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

    /// <summary>   Returns Role Duration(ROL-7). </summary>
    ///
    /// <value> The role duration. </value>

	public CE RoleDuration
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

    /// <summary>   Returns Role Action Reason(ROL-8). </summary>
    ///
    /// <value> The role action reason. </value>

	public CE RoleActionReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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