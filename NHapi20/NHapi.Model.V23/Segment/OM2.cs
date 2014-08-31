using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

/// <summary>
/// Represents an HL7 OM2 message segment. This segment has the following fields:<ol>
/// <li>OM2-1: Sequence Number - Test/ Observation Master File (NM)</li>
/// <li>OM2-2: Units of Measure (CE)</li>
/// <li>OM2-3: Range of Decimal Precision (NM)</li>
/// <li>OM2-4: Corresponding SI Units of Measure (CE)</li>
/// <li>OM2-5: SI Conversion Factor (TX)</li>
/// <li>OM2-6: Reference (Normal) Range - Ordinal and Continuous Obs (CM_RFR)</li>
/// <li>OM2-7: Critical Range for Ordinal and Continuous Obs (CM_RANGE)</li>
/// <li>OM2-8: Absolute Range for Ordinal and Continuous Obs (CM_ABS_RANGE)</li>
/// <li>OM2-9: Delta Check Criteria (CM_DLT)</li>
/// <li>OM2-10: Minimum Meaningful Increments (NM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class OM2 : AbstractSegment  {

    /// <summary>   Initializes a new instance of the OM2 class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public OM2(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Sequence Number - Test/ Observation Master File");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Units of Measure");
       this.add(typeof(NM), false, 0, 10, new System.Object[]{message}, "Range of Decimal Precision");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Corresponding SI Units of Measure");
       this.add(typeof(TX), false, 1, 60, new System.Object[]{message}, "SI Conversion Factor");
       this.add(typeof(CM_RFR), false, 1, 200, new System.Object[]{message}, "Reference (Normal) Range - Ordinal and Continuous Obs");
       this.add(typeof(CM_RANGE), false, 1, 200, new System.Object[]{message}, "Critical Range for Ordinal and Continuous Obs");
       this.add(typeof(CM_ABS_RANGE), false, 1, 200, new System.Object[]{message}, "Absolute Range for Ordinal and Continuous Obs");
       this.add(typeof(CM_DLT), false, 0, 200, new System.Object[]{message}, "Delta Check Criteria");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Minimum Meaningful Increments");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Sequence Number - Test/ Observation Master File(OM2-1). </summary>
    ///
    /// <value> The sequence number test observation master file. </value>

	public NM SequenceNumberTestObservationMasterFile
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns Units of Measure(OM2-2). </summary>
    ///
    /// <value> The units of measure. </value>

	public CE UnitsOfMeasure
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

    /// <summary>
    /// Returns a single repetition of Range of Decimal Precision(OM2-3). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The range of decimal precision. </returns>

	public NM GetRangeOfDecimalPrecision(int rep)
	{
			NM ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Range of Decimal Precision (OM2-3). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of nm. </returns>

  public NM[] GetRangeOfDecimalPrecision() {
     NM[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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

  /// <summary> Returns the total repetitions of Range of Decimal Precision (OM2-3). </summary>
  ///
  /// <value>   The range of decimal precision repetitions used. </value>

  public int RangeOfDecimalPrecisionRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(3);
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

    /// <summary>   Returns Corresponding SI Units of Measure(OM2-4). </summary>
    ///
    /// <value> The corresponding SI units of measure. </value>

	public CE CorrespondingSIUnitsOfMeasure
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

    /// <summary>   Returns SI Conversion Factor(OM2-5). </summary>
    ///
    /// <value> The SI conversion factor. </value>

	public TX SIConversionFactor
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (TX)t;
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

    /// <summary>   Returns Reference (Normal) Range - Ordinal and Continuous Obs(OM2-6). </summary>
    ///
    /// <value> The reference normal range ordinal continuous obs. </value>

	public CM_RFR ReferenceNormalRangeOrdinalContinuousObs
	{
		get{
			CM_RFR ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (CM_RFR)t;
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

    /// <summary>   Returns Critical Range for Ordinal and Continuous Obs(OM2-7). </summary>
    ///
    /// <value> The critical range for ordinal continuous obs. </value>

	public CM_RANGE CriticalRangeForOrdinalContinuousObs
	{
		get{
			CM_RANGE ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (CM_RANGE)t;
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

    /// <summary>   Returns Absolute Range for Ordinal and Continuous Obs(OM2-8). </summary>
    ///
    /// <value> The absolute range for ordinal continuous obs. </value>

	public CM_ABS_RANGE AbsoluteRangeForOrdinalContinuousObs
	{
		get{
			CM_ABS_RANGE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (CM_ABS_RANGE)t;
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
    /// Returns a single repetition of Delta Check Criteria(OM2-9). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The delta check criteria. </returns>

	public CM_DLT GetDeltaCheckCriteria(int rep)
	{
			CM_DLT ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (CM_DLT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Delta Check Criteria (OM2-9). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres dlt. </returns>

  public CM_DLT[] GetDeltaCheckCriteria() {
     CM_DLT[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new CM_DLT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_DLT)t[i];
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

  /// <summary> Returns the total repetitions of Delta Check Criteria (OM2-9). </summary>
  ///
  /// <value>   The delta check criteria repetitions used. </value>

  public int DeltaCheckCriteriaRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(9);
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

    /// <summary>   Returns Minimum Meaningful Increments(OM2-10). </summary>
    ///
    /// <value> The minimum meaningful increments. </value>

	public NM MinimumMeaningfulIncrements
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


}}