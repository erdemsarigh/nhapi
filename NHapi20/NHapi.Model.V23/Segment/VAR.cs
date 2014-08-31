using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

/// <summary>
/// Represents an HL7 VAR message segment. This segment has the following fields:<ol>
/// <li>VAR-1: Variance Instance ID (EI)</li>
/// <li>VAR-2: Documented Date/Time (TS)</li>
/// <li>VAR-3: Stated Variance Date/Time (TS)</li>
/// <li>VAR-4: Variance Originator (XCN)</li>
/// <li>VAR-5: Variance Classification (CE)</li>
/// <li>VAR-6: Variance Description (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class VAR : AbstractSegment  {

    /// <summary>   Initializes a new instance of the VAR class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public VAR(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(EI), true, 1, 60, new System.Object[]{message}, "Variance Instance ID");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Documented Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Stated Variance Date/Time");
       this.add(typeof(XCN), false, 1, 860, new System.Object[]{message}, "Variance Originator");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Variance Classification");
       this.add(typeof(ST), false, 0, 512, new System.Object[]{message}, "Variance Description");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Variance Instance ID(VAR-1). </summary>
    ///
    /// <value> The identifier of the variance instance. </value>

	public EI VarianceInstanceID
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

    /// <summary>   Returns Documented Date/Time(VAR-2). </summary>
    ///
    /// <value> The documented date time. </value>

	public TS DocumentedDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

    /// <summary>   Returns Stated Variance Date/Time(VAR-3). </summary>
    ///
    /// <value> The stated variance date time. </value>

	public TS StatedVarianceDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns Variance Originator(VAR-4). </summary>
    ///
    /// <value> The variance originator. </value>

	public XCN VarianceOriginator
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (XCN)t;
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

    /// <summary>   Returns Variance Classification(VAR-5). </summary>
    ///
    /// <value> The variance classification. </value>

	public CE VarianceClassification
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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
    /// Returns a single repetition of Variance Description(VAR-6). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The variance description. </returns>

	public ST GetVarianceDescription(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Variance Description (VAR-6). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of st. </returns>

  public ST[] GetVarianceDescription() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(6);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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

  /// <summary> Returns the total repetitions of Variance Description (VAR-6). </summary>
  ///
  /// <value>   The variance description repetitions used. </value>

  public int VarianceDescriptionRepetitionsUsed
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

}}