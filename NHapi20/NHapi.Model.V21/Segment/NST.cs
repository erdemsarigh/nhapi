using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/// <summary>
/// Represents an HL7 NST message segment. This segment has the following fields:<ol>
/// <li>NST-1: STATISTICS AVAILABLE (ID)</li>
/// <li>NST-2: SOURCE IDENTIFIER (ST)</li>
/// <li>NST-3: SOURCE TYPE (ID)</li>
/// <li>NST-4: STATISTICS START (TS)</li>
/// <li>NST-5: STATISTICS END (TS)</li>
/// <li>NST-6: RECEIVE CHARACTER COUNT (NM)</li>
/// <li>NST-7: SEND CHARACTER COUNT (NM)</li>
/// <li>NST-8: MESSAGES RECEIVED (NM)</li>
/// <li>NST-9: MESSAGES SENT (NM)</li>
/// <li>NST-10: CHECKSUM ERRORS RECEIVED (NM)</li>
/// <li>NST-11: LENGTH ERRORS RECEIVED (NM)</li>
/// <li>NST-12: OTHER ERRORS RECEIVED (NM)</li>
/// <li>NST-13: CONNECT TIMEOUTS (NM)</li>
/// <li>NST-14: RECEIVE TIMEOUTS (NM)</li>
/// <li>NST-15: NETWORK ERRORS (NM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class NST : AbstractSegment  {

    /// <summary>   Initializes a new instance of the NST class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public NST(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 0}, "STATISTICS AVAILABLE");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "SOURCE IDENTIFIER");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 0}, "SOURCE TYPE");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "STATISTICS START");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "STATISTICS END");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "RECEIVE CHARACTER COUNT");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "SEND CHARACTER COUNT");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "MESSAGES RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "MESSAGES SENT");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "CHECKSUM ERRORS RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "LENGTH ERRORS RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "OTHER ERRORS RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "CONNECT TIMEOUTS");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "RECEIVE TIMEOUTS");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "NETWORK ERRORS");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns STATISTICS AVAILABLE(NST-1). </summary>
    ///
    /// <value> The statisticsavailable. </value>

	public ID STATISTICSAVAILABLE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns SOURCE IDENTIFIER(NST-2). </summary>
    ///
    /// <value> The sourceidentifier. </value>

	public ST SOURCEIDENTIFIER
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

    /// <summary>   Returns SOURCE TYPE(NST-3). </summary>
    ///
    /// <value> The sourcetype. </value>

	public ID SOURCETYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns STATISTICS START(NST-4). </summary>
    ///
    /// <value> The statisticsstart. </value>

	public TS STATISTICSSTART
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

    /// <summary>   Returns STATISTICS END(NST-5). </summary>
    ///
    /// <value> The statisticsend. </value>

	public TS STATISTICSEND
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

    /// <summary>   Returns RECEIVE CHARACTER COUNT(NST-6). </summary>
    ///
    /// <value> The receivecharactercount. </value>

	public NM RECEIVECHARACTERCOUNT
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

    /// <summary>   Returns SEND CHARACTER COUNT(NST-7). </summary>
    ///
    /// <value> The sendcharactercount. </value>

	public NM SENDCHARACTERCOUNT
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

    /// <summary>   Returns MESSAGES RECEIVED(NST-8). </summary>
    ///
    /// <value> The messagesreceived. </value>

	public NM MESSAGESRECEIVED
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

    /// <summary>   Returns MESSAGES SENT(NST-9). </summary>
    ///
    /// <value> The messagessent. </value>

	public NM MESSAGESSENT
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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

    /// <summary>   Returns CHECKSUM ERRORS RECEIVED(NST-10). </summary>
    ///
    /// <value> The checksumerrorsreceived. </value>

	public NM CHECKSUMERRORSRECEIVED
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

    /// <summary>   Returns LENGTH ERRORS RECEIVED(NST-11). </summary>
    ///
    /// <value> The lengtherrorsreceived. </value>

	public NM LENGTHERRORSRECEIVED
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

    /// <summary>   Returns OTHER ERRORS RECEIVED(NST-12). </summary>
    ///
    /// <value> The othererrorsreceived. </value>

	public NM OTHERERRORSRECEIVED
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

    /// <summary>   Returns CONNECT TIMEOUTS(NST-13). </summary>
    ///
    /// <value> The connecttimeouts. </value>

	public NM CONNECTTIMEOUTS
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

    /// <summary>   Returns RECEIVE TIMEOUTS(NST-14). </summary>
    ///
    /// <value> The receivetimeouts. </value>

	public NM RECEIVETIMEOUTS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

    /// <summary>   Returns NETWORK ERRORS(NST-15). </summary>
    ///
    /// <value> The networkerrors. </value>

	public NM NETWORKERRORS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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


}}