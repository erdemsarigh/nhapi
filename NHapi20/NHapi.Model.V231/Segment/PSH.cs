using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V231.Segment{

/// <summary>
/// Represents an HL7 PSH message segment. This segment has the following fields:<ol>
/// <li>PSH-1: Report Type (ST)</li>
/// <li>PSH-2: Report Form Identifier (ST)</li>
/// <li>PSH-3: Report Date (TS)</li>
/// <li>PSH-4: Report Interval Start Date (TS)</li>
/// <li>PSH-5: Report Interval End Date (TS)</li>
/// <li>PSH-6: Quantity Manufactured (CQ)</li>
/// <li>PSH-7: Quantity Distributed (CQ)</li>
/// <li>PSH-8: Quantity Distributed Method (ID)</li>
/// <li>PSH-9: Quantity Distributed Comment (FT)</li>
/// <li>PSH-10: Quantity in Use (CQ)</li>
/// <li>PSH-11: Quantity in Use Method (ID)</li>
/// <li>PSH-12: Quantity in Use Comment (FT)</li>
/// <li>PSH-13: Number of Product Experience Reports Filed by Facility (NM)</li>
/// <li>PSH-14: Number of Product Experience Reports Filed by Distributor (NM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PSH : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PSH class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PSH(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), true, 1, 60, new System.Object[]{message}, "Report Type");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Report Form Identifier");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Report Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Report Interval Start Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Report Interval End Date");
       this.add(typeof(CQ), false, 1, 12, new System.Object[]{message}, "Quantity Manufactured");
       this.add(typeof(CQ), false, 1, 12, new System.Object[]{message}, "Quantity Distributed");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 329}, "Quantity Distributed Method");
       this.add(typeof(FT), false, 1, 600, new System.Object[]{message}, "Quantity Distributed Comment");
       this.add(typeof(CQ), false, 1, 12, new System.Object[]{message}, "Quantity in Use");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 329}, "Quantity in Use Method");
       this.add(typeof(FT), false, 1, 600, new System.Object[]{message}, "Quantity in Use Comment");
       this.add(typeof(NM), false, 8, 2, new System.Object[]{message}, "Number of Product Experience Reports Filed by Facility");
       this.add(typeof(NM), false, 8, 2, new System.Object[]{message}, "Number of Product Experience Reports Filed by Distributor");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Report Type(PSH-1). </summary>
    ///
    /// <value> The type of the report. </value>

	public ST ReportType
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

    /// <summary>   Returns Report Form Identifier(PSH-2). </summary>
    ///
    /// <value> The identifier of the report form. </value>

	public ST ReportFormIdentifier
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

    /// <summary>   Returns Report Date(PSH-3). </summary>
    ///
    /// <value> The report date. </value>

	public TS ReportDate
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

    /// <summary>   Returns Report Interval Start Date(PSH-4). </summary>
    ///
    /// <value> The report interval start date. </value>

	public TS ReportIntervalStartDate
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

    /// <summary>   Returns Report Interval End Date(PSH-5). </summary>
    ///
    /// <value> The report interval end date. </value>

	public TS ReportIntervalEndDate
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

    /// <summary>   Returns Quantity Manufactured(PSH-6). </summary>
    ///
    /// <value> The quantity manufactured. </value>

	public CQ QuantityManufactured
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (CQ)t;
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

    /// <summary>   Returns Quantity Distributed(PSH-7). </summary>
    ///
    /// <value> The quantity distributed. </value>

	public CQ QuantityDistributed
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (CQ)t;
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

    /// <summary>   Returns Quantity Distributed Method(PSH-8). </summary>
    ///
    /// <value> The quantity distributed method. </value>

	public ID QuantityDistributedMethod
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

    /// <summary>   Returns Quantity Distributed Comment(PSH-9). </summary>
    ///
    /// <value> The quantity distributed comment. </value>

	public FT QuantityDistributedComment
	{
		get{
			FT ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (FT)t;
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

    /// <summary>   Returns Quantity in Use(PSH-10). </summary>
    ///
    /// <value> The quantity in use. </value>

	public CQ QuantityInUse
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (CQ)t;
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

    /// <summary>   Returns Quantity in Use Method(PSH-11). </summary>
    ///
    /// <value> The quantity in use method. </value>

	public ID QuantityInUseMethod
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

    /// <summary>   Returns Quantity in Use Comment(PSH-12). </summary>
    ///
    /// <value> The quantity in use comment. </value>

	public FT QuantityInUseComment
	{
		get{
			FT ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (FT)t;
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
    /// Returns a single repetition of Number of Product Experience Reports Filed by Facility(PSH-
    /// 13). throws HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The number of product experience reports filed by facility. </returns>

	public NM GetNumberOfProductExperienceReportsFiledByFacility(int rep)
	{
			NM ret = null;
			try
			{
			IType t = this.GetField(13, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Number of Product Experience Reports Filed by Facility (PSH-13).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of nm. </returns>

  public NM[] GetNumberOfProductExperienceReportsFiledByFacility() {
     NM[] ret = null;
    try {
        IType[] t = this.GetField(13);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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

  /// <summary>
  /// Returns the total repetitions of Number of Product Experience Reports Filed by Facility (PSH-
  /// 13).
  /// </summary>
  ///
  /// <value>
  /// The total number of product experience reports filed by facility repetitions used.
  /// </value>

  public int NumberOfProductExperienceReportsFiledByFacilityRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(13);
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
    /// Returns a single repetition of Number of Product Experience Reports Filed by Distributor(PSH-
    /// 14). throws HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The number of product experience reports filed by distributor. </returns>

	public NM GetNumberOfProductExperienceReportsFiledByDistributor(int rep)
	{
			NM ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Number of Product Experience Reports Filed by Distributor (PSH-14).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of nm. </returns>

  public NM[] GetNumberOfProductExperienceReportsFiledByDistributor() {
     NM[] ret = null;
    try {
        IType[] t = this.GetField(14);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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

  /// <summary>
  /// Returns the total repetitions of Number of Product Experience Reports Filed by Distributor (PSH-
  /// 14).
  /// </summary>
  ///
  /// <value>
  /// The total number of product experience reports filed by distributor repetitions used.
  /// </value>

  public int NumberOfProductExperienceReportsFiledByDistributorRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(14);
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