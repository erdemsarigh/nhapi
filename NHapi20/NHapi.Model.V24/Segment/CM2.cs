using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 CM2 message segment. This segment has the following fields:<ol>
/// <li>CM2-1: Set ID- CM2 (SI)</li>
/// <li>CM2-2: Scheduled Time Point (CE)</li>
/// <li>CM2-3: Description of Time Point (ST)</li>
/// <li>CM2-4: Events Scheduled This Time Point (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class CM2 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the CM2 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public CM2(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID- CM2");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Scheduled Time Point");
       this.add(typeof(ST), false, 1, 300, new System.Object[]{message}, "Description of Time Point");
       this.add(typeof(CE), true, 200, 250, new System.Object[]{message}, "Events Scheduled This Time Point");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Set ID- CM2(CM2-1). </summary>
    ///
    /// <value> The set idcm 2. </value>

	public SI SetIDCM2
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

    /// <summary>   Returns Scheduled Time Point(CM2-2). </summary>
    ///
    /// <value> The scheduled time point. </value>

	public CE ScheduledTimePoint
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

    /// <summary>   Returns Description of Time Point(CM2-3). </summary>
    ///
    /// <value> The description of time point. </value>

	public ST DescriptionOfTimePoint
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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
    /// Returns a single repetition of Events Scheduled This Time Point(CM2-4). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The events scheduled this time point. </returns>

	public CE GetEventsScheduledThisTimePoint(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Events Scheduled This Time Point (CM2-4). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetEventsScheduledThisTimePoint() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(4);  
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

  /// <summary> Returns the total repetitions of Events Scheduled This Time Point (CM2-4). </summary>
  ///
  /// <value>   The events scheduled this time point repetitions used. </value>

  public int EventsScheduledThisTimePointRepetitionsUsed
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

}}