using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

/// <summary>
/// Represents an HL7 NST message segment. This segment has the following fields:<ol>
/// <li>NST-1: Statistics Available (ID)</li>
/// <li>NST-2: Source Identifier (ST)</li>
/// <li>NST-3: Source Type (ID)</li>
/// <li>NST-4: Statistics Start (TS)</li>
/// <li>NST-5: Statistics End (TS)</li>
/// <li>NST-6: Receive Character Count (NM)</li>
/// <li>NST-7: Send Character Count (NM)</li>
/// <li>NST-8: Messages Received (NM)</li>
/// <li>NST-9: Messages Sent (NM)</li>
/// <li>NST-10: Checksum Errors Received (NM)</li>
/// <li>NST-11: Length Errors Received (NM)</li>
/// <li>NST-12: Other Errors Received (NM)</li>
/// <li>NST-13: Connect Timeouts (NM)</li>
/// <li>NST-14: Receive Timeouts (NM)</li>
/// <li>NST-15: Network Errors (NM)</li>
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
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 125}, "Statistics Available");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Source Identifier");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 0}, "Source Type");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Statistics Start");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Statistics End");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Receive Character Count");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Send Character Count");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Messages Received");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Messages Sent");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Checksum Errors Received");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Length Errors Received");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Other Errors Received");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Connect Timeouts");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Receive Timeouts");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Network Errors");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Statistics Available(NST-1). </summary>
    ///
    /// <value> The statistics available. </value>

	public ID StatisticsAvailable
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

    /// <summary>   Returns Source Identifier(NST-2). </summary>
    ///
    /// <value> The identifier of the source. </value>

	public ST SourceIdentifier
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

    /// <summary>   Returns Source Type(NST-3). </summary>
    ///
    /// <value> The type of the source. </value>

	public ID SourceType
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

    /// <summary>   Returns Statistics Start(NST-4). </summary>
    ///
    /// <value> The statistics start. </value>

	public TS StatisticsStart
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

    /// <summary>   Returns Statistics End(NST-5). </summary>
    ///
    /// <value> The statistics end. </value>

	public TS StatisticsEnd
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

    /// <summary>   Returns Receive Character Count(NST-6). </summary>
    ///
    /// <value> The number of receive characters. </value>

	public NM ReceiveCharacterCount
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

    /// <summary>   Returns Send Character Count(NST-7). </summary>
    ///
    /// <value> The number of send characters. </value>

	public NM SendCharacterCount
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

    /// <summary>   Returns Messages Received(NST-8). </summary>
    ///
    /// <value> The messages received. </value>

	public NM MessagesReceived
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

    /// <summary>   Returns Messages Sent(NST-9). </summary>
    ///
    /// <value> The messages sent. </value>

	public NM MessagesSent
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

    /// <summary>   Returns Checksum Errors Received(NST-10). </summary>
    ///
    /// <value> The checksum errors received. </value>

	public NM ChecksumErrorsReceived
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

    /// <summary>   Returns Length Errors Received(NST-11). </summary>
    ///
    /// <value> The length errors received. </value>

	public NM LengthErrorsReceived
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

    /// <summary>   Returns Other Errors Received(NST-12). </summary>
    ///
    /// <value> The other errors received. </value>

	public NM OtherErrorsReceived
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

    /// <summary>   Returns Connect Timeouts(NST-13). </summary>
    ///
    /// <value> The connect timeouts. </value>

	public NM ConnectTimeouts
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

    /// <summary>   Returns Receive Timeouts(NST-14). </summary>
    ///
    /// <value> The receive timeouts. </value>

	public NM ReceiveTimeouts
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

    /// <summary>   Returns Network Errors(NST-15). </summary>
    ///
    /// <value> The network errors. </value>

	public NM NetworkErrors
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