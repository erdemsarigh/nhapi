using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 BLG message segment. This segment has the following fields:<ol>
/// <li>BLG-1: When to Charge (CCD)</li>
/// <li>BLG-2: Charge Type (ID)</li>
/// <li>BLG-3: Account ID (CX)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class BLG : AbstractSegment  {

    /// <summary>   Initializes a new instance of the BLG class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public BLG(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CCD), false, 1, 40, new System.Object[]{message}, "When to Charge");
       this.add(typeof(ID), false, 1, 50, new System.Object[]{message, 122}, "Charge Type");
       this.add(typeof(CX), false, 1, 100, new System.Object[]{message}, "Account ID");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns When to Charge(BLG-1). </summary>
    ///
    /// <value> The when to charge. </value>

	public CCD WhenToCharge
	{
		get{
			CCD ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (CCD)t;
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

    /// <summary>   Returns Charge Type(BLG-2). </summary>
    ///
    /// <value> The type of the charge. </value>

	public ID ChargeType
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

    /// <summary>   Returns Account ID(BLG-3). </summary>
    ///
    /// <value> The identifier of the account. </value>

	public CX AccountID
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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


}}