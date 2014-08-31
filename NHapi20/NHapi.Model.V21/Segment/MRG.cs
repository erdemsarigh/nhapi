using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/// <summary>
/// Represents an HL7 MRG message segment. This segment has the following fields:<ol>
/// <li>MRG-1: PRIOR PATIENT ID - INTERNAL (CK)</li>
/// <li>MRG-2: PRIOR ALTERNATE PATIENT ID (CK)</li>
/// <li>MRG-3: PRIOR PATIENT ACCOUNT NUMBER (CK)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class MRG : AbstractSegment  {

    /// <summary>   Initializes a new instance of the MRG class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MRG(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CK), true, 1, 16, new System.Object[]{message}, "PRIOR PATIENT ID - INTERNAL");
       this.add(typeof(CK), false, 1, 16, new System.Object[]{message}, "PRIOR ALTERNATE PATIENT ID");
       this.add(typeof(CK), false, 1, 20, new System.Object[]{message}, "PRIOR PATIENT ACCOUNT NUMBER");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns PRIOR PATIENT ID - INTERNAL(MRG-1). </summary>
    ///
    /// <value> The priorpatientidinternal. </value>

	public CK PRIORPATIENTIDINTERNAL
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (CK)t;
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

    /// <summary>   Returns PRIOR ALTERNATE PATIENT ID(MRG-2). </summary>
    ///
    /// <value> The prioralternatepatientid. </value>

	public CK PRIORALTERNATEPATIENTID
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (CK)t;
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

    /// <summary>   Returns PRIOR PATIENT ACCOUNT NUMBER(MRG-3). </summary>
    ///
    /// <value> The priorpatientaccountnumber. </value>

	public CK PRIORPATIENTACCOUNTNUMBER
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (CK)t;
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