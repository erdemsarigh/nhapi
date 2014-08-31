using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 PDA message segment. This segment has the following fields:<ol>
/// <li>PDA-1: Death Cause Code (CE)</li>
/// <li>PDA-2: Death Location (PL)</li>
/// <li>PDA-3: Death Certified Indicator (ID)</li>
/// <li>PDA-4: Death Certificate Signed Date/Time (TS)</li>
/// <li>PDA-5: Death Certified By (XCN)</li>
/// <li>PDA-6: Autopsy Indicator (ID)</li>
/// <li>PDA-7: Autopsy Start and End Date/Time (DR)</li>
/// <li>PDA-8: Autopsy Performed By (XCN)</li>
/// <li>PDA-9: Coroner Indicator (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PDA : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PDA class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PDA(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Death Cause Code");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Death Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Death Certified Indicator");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Death Certificate Signed Date/Time");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Death Certified By");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Autopsy Indicator");
       this.add(typeof(DR), false, 1, 53, new System.Object[]{message}, "Autopsy Start and End Date/Time");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Autopsy Performed By");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Coroner Indicator");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of Death Cause Code(PDA-1). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The death cause code. </returns>

	public CE GetDeathCauseCode(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(1, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Death Cause Code (PDA-1). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetDeathCauseCode() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(1);  
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

  /// <summary> Returns the total repetitions of Death Cause Code (PDA-1). </summary>
  ///
  /// <value>   The death cause code repetitions used. </value>

  public int DeathCauseCodeRepetitionsUsed
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

    /// <summary>   Returns Death Location(PDA-2). </summary>
    ///
    /// <value> The death location. </value>

	public PL DeathLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (PL)t;
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

    /// <summary>   Returns Death Certified Indicator(PDA-3). </summary>
    ///
    /// <value> The death certified indicator. </value>

	public ID DeathCertifiedIndicator
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

    /// <summary>   Returns Death Certificate Signed Date/Time(PDA-4). </summary>
    ///
    /// <value> The death certificate signed date time. </value>

	public TS DeathCertificateSignedDateTime
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

    /// <summary>   Returns Death Certified By(PDA-5). </summary>
    ///
    /// <value> Amount to death certified by. </value>

	public XCN DeathCertifiedBy
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

    /// <summary>   Returns Autopsy Indicator(PDA-6). </summary>
    ///
    /// <value> The autopsy indicator. </value>

	public ID AutopsyIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

    /// <summary>   Returns Autopsy Start and End Date/Time(PDA-7). </summary>
    ///
    /// <value> The autopsy start and end date time. </value>

	public DR AutopsyStartAndEndDateTime
	{
		get{
			DR ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (DR)t;
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

    /// <summary>   Returns Autopsy Performed By(PDA-8). </summary>
    ///
    /// <value> Amount to autopsy performed by. </value>

	public XCN AutopsyPerformedBy
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

    /// <summary>   Returns Coroner Indicator(PDA-9). </summary>
    ///
    /// <value> The coroner indicator. </value>

	public ID CoronerIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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


}}