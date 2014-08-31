using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

/// <summary>
/// Represents an HL7 OBR message segment. This segment has the following fields:<ol>
/// <li>OBR-1: Set ID - Observation Request (SI)</li>
/// <li>OBR-2: Placer Order Number (EI)</li>
/// <li>OBR-3: Filler Order Number (EI)</li>
/// <li>OBR-4: Universal Service Identifier (CE)</li>
/// <li>OBR-5: Priority (ID)</li>
/// <li>OBR-6: Requested Date/Time (TS)</li>
/// <li>OBR-7: Observation Date/Time (TS)</li>
/// <li>OBR-8: Observation End Date/Time (TS)</li>
/// <li>OBR-9: Collection Volume (CQ)</li>
/// <li>OBR-10: Collector Identifier (XCN)</li>
/// <li>OBR-11: Specimen Action Code (ID)</li>
/// <li>OBR-12: Danger Code (CE)</li>
/// <li>OBR-13: Relevant Clinical Information (ST)</li>
/// <li>OBR-14: Specimen Received Date/Time (TS)</li>
/// <li>OBR-15: Specimen Source (CM_SPS)</li>
/// <li>OBR-16: Ordering Provider (XCN)</li>
/// <li>OBR-17: Order Callback Phone Number (XTN)</li>
/// <li>OBR-18: Placer Field 1 (ST)</li>
/// <li>OBR-19: Placer Field 2 (ST)</li>
/// <li>OBR-20: Filler Field 1 (ST)</li>
/// <li>OBR-21: Filler Field 2 (ST)</li>
/// <li>OBR-22: Results Rpt/Status Chng - Date/Time (TS)</li>
/// <li>OBR-23: Charge To Practice (CM_MOC)</li>
/// <li>OBR-24: Diagnostic Service Section ID (ID)</li>
/// <li>OBR-25: Result Status (ID)</li>
/// <li>OBR-26: Parent Result (CM_PRL)</li>
/// <li>OBR-27: Quantity/Timing (TQ)</li>
/// <li>OBR-28: Result Copies To (XCN)</li>
/// <li>OBR-29: Parent Number (CM_EIP)</li>
/// <li>OBR-30: Transportation Mode (ID)</li>
/// <li>OBR-31: Reason For Study (CE)</li>
/// <li>OBR-32: Principal Result Interpreter (CM_NDL)</li>
/// <li>OBR-33: Assistant Result Interpreter (CM_NDL)</li>
/// <li>OBR-34: Technician (CM_NDL)</li>
/// <li>OBR-35: Transcriptionist (CM_NDL)</li>
/// <li>OBR-36: Scheduled Date/Time (TS)</li>
/// <li>OBR-37: Number Of Sample Containers (NM)</li>
/// <li>OBR-38: Transport Logistics Of Collected Sample (CE)</li>
/// <li>OBR-39: Collector’s Comment (CE)</li>
/// <li>OBR-40: Transport Arrangement Responsibility (CE)</li>
/// <li>OBR-41: Transport Arranged (ID)</li>
/// <li>OBR-42: Escort Required (ID)</li>
/// <li>OBR-43: Planned Patient Transport Comment (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class OBR : AbstractSegment  {

    /// <summary>   Initializes a new instance of the OBR class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public OBR(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - Observation Request");
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message}, "Placer Order Number");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Filler Order Number");
       this.add(typeof(CE), true, 1, 200, new System.Object[]{message}, "Universal Service Identifier");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Priority");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Requested Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Observation Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Observation End Date/Time");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Collection Volume");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Collector Identifier");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 65}, "Specimen Action Code");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Danger Code");
       this.add(typeof(ST), false, 1, 300, new System.Object[]{message}, "Relevant Clinical Information");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Specimen Received Date/Time");
       this.add(typeof(CM_SPS), false, 1, 300, new System.Object[]{message}, "Specimen Source");
       this.add(typeof(XCN), false, 0, 120, new System.Object[]{message}, "Ordering Provider");
       this.add(typeof(XTN), false, 2, 40, new System.Object[]{message}, "Order Callback Phone Number");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Placer Field 1");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Placer Field 2");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Filler Field 1");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Filler Field 2");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Results Rpt/Status Chng - Date/Time");
       this.add(typeof(CM_MOC), false, 1, 40, new System.Object[]{message}, "Charge To Practice");
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 74}, "Diagnostic Service Section ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 123}, "Result Status");
       this.add(typeof(CM_PRL), false, 1, 200, new System.Object[]{message}, "Parent Result");
       this.add(typeof(TQ), true, 1, 200, new System.Object[]{message}, "Quantity/Timing");
       this.add(typeof(XCN), false, 5, 150, new System.Object[]{message}, "Result Copies To");
       this.add(typeof(CM_EIP), false, 1, 150, new System.Object[]{message}, "Parent Number");
       this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 124}, "Transportation Mode");
       this.add(typeof(CE), false, 0, 300, new System.Object[]{message}, "Reason For Study");
       this.add(typeof(CM_NDL), false, 1, 200, new System.Object[]{message}, "Principal Result Interpreter");
       this.add(typeof(CM_NDL), false, 0, 200, new System.Object[]{message}, "Assistant Result Interpreter");
       this.add(typeof(CM_NDL), false, 0, 200, new System.Object[]{message}, "Technician");
       this.add(typeof(CM_NDL), false, 0, 200, new System.Object[]{message}, "Transcriptionist");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Scheduled Date/Time");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Number Of Sample Containers");
       this.add(typeof(CE), false, 0, 60, new System.Object[]{message}, "Transport Logistics Of Collected Sample");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Collector’s Comment");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Transport Arrangement Responsibility");
       this.add(typeof(ID), false, 1, 30, new System.Object[]{message, 224}, "Transport Arranged");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 225}, "Escort Required");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Planned Patient Transport Comment");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Set ID - Observation Request(OBR-1). </summary>
    ///
    /// <value> The set identifier observation request. </value>

	public SI SetIDObservationRequest
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

    /// <summary>
    /// Returns a single repetition of Placer Order Number(OBR-2). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The placer order number. </returns>

	public EI GetPlacerOrderNumber(int rep)
	{
			EI ret = null;
			try
			{
			IType t = this.GetField(2, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Placer Order Number (OBR-2). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ei. </returns>

  public EI[] GetPlacerOrderNumber() {
     EI[] ret = null;
    try {
        IType[] t = this.GetField(2);  
        ret = new EI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (EI)t[i];
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

  /// <summary> Returns the total repetitions of Placer Order Number (OBR-2). </summary>
  ///
  /// <value>   The placer order number repetitions used. </value>

  public int PlacerOrderNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(2);
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

    /// <summary>   Returns Filler Order Number(OBR-3). </summary>
    ///
    /// <value> The filler order number. </value>

	public EI FillerOrderNumber
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns Universal Service Identifier(OBR-4). </summary>
    ///
    /// <value> The identifier of the universal service. </value>

	public CE UniversalServiceIdentifier
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

    /// <summary>   Returns Priority(OBR-5). </summary>
    ///
    /// <value> The priority. </value>

	public ID Priority
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

    /// <summary>   Returns Requested Date/Time(OBR-6). </summary>
    ///
    /// <value> The requested date time. </value>

	public TS RequestedDateTime
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

    /// <summary>   Returns Observation Date/Time(OBR-7). </summary>
    ///
    /// <value> The observation date time. </value>

	public TS ObservationDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

    /// <summary>   Returns Observation End Date/Time(OBR-8). </summary>
    ///
    /// <value> The observation end date time. </value>

	public TS ObservationEndDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

    /// <summary>   Returns Collection Volume(OBR-9). </summary>
    ///
    /// <value> The collection volume. </value>

	public CQ CollectionVolume
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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

    /// <summary>
    /// Returns a single repetition of Collector Identifier(OBR-10). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The collector identifier. </returns>

	public XCN GetCollectorIdentifier(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Collector Identifier (OBR-10). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetCollectorIdentifier() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(10);  
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

  /// <summary> Returns the total repetitions of Collector Identifier (OBR-10). </summary>
  ///
  /// <value>   The collector identifier repetitions used. </value>

  public int CollectorIdentifierRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(10);
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

    /// <summary>   Returns Specimen Action Code(OBR-11). </summary>
    ///
    /// <value> The specimen action code. </value>

	public ID SpecimenActionCode
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

    /// <summary>   Returns Danger Code(OBR-12). </summary>
    ///
    /// <value> The danger code. </value>

	public CE DangerCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

    /// <summary>   Returns Relevant Clinical Information(OBR-13). </summary>
    ///
    /// <value> Information describing the relevant clinical. </value>

	public ST RelevantClinicalInformation
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

    /// <summary>   Returns Specimen Received Date/Time(OBR-14). </summary>
    ///
    /// <value> The specimen received date time. </value>

	public TS SpecimenReceivedDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

    /// <summary>   Returns Specimen Source(OBR-15). </summary>
    ///
    /// <value> The specimen source. </value>

	public CM_SPS SpecimenSource
	{
		get{
			CM_SPS ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (CM_SPS)t;
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
    /// Returns a single repetition of Ordering Provider(OBR-16). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The ordering provider. </returns>

	public XCN GetOrderingProvider(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Ordering Provider (OBR-16). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetOrderingProvider() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(16);  
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

  /// <summary> Returns the total repetitions of Ordering Provider (OBR-16). </summary>
  ///
  /// <value>   The ordering provider repetitions used. </value>

  public int OrderingProviderRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(16);
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
    /// Returns a single repetition of Order Callback Phone Number(OBR-17). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The order callback phone number. </returns>

	public XTN GetOrderCallbackPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(17, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Order Callback Phone Number (OBR-17). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of extension. </returns>

  public XTN[] GetOrderCallbackPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(17);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
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

  /// <summary> Returns the total repetitions of Order Callback Phone Number (OBR-17). </summary>
  ///
  /// <value>   The order callback phone number repetitions used. </value>

  public int OrderCallbackPhoneNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(17);
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

    /// <summary>   Returns Placer Field 1(OBR-18). </summary>
    ///
    /// <value> The placer field 1. </value>

	public ST PlacerField1
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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

    /// <summary>   Returns Placer Field 2(OBR-19). </summary>
    ///
    /// <value> The placer field 2. </value>

	public ST PlacerField2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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

    /// <summary>   Returns Filler Field 1(OBR-20). </summary>
    ///
    /// <value> The filler field 1. </value>

	public ST FillerField1
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(20, 0);
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

    /// <summary>   Returns Filler Field 2(OBR-21). </summary>
    ///
    /// <value> The filler field 2. </value>

	public ST FillerField2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(21, 0);
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

    /// <summary>   Returns Results Rpt/Status Chng - Date/Time(OBR-22). </summary>
    ///
    /// <value> The results repeat status chng date time. </value>

	public TS ResultsRptStatusChngDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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

    /// <summary>   Returns Charge To Practice(OBR-23). </summary>
    ///
    /// <value> The charge to practice. </value>

	public CM_MOC ChargeToPractice
	{
		get{
			CM_MOC ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (CM_MOC)t;
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

    /// <summary>   Returns Diagnostic Service Section ID(OBR-24). </summary>
    ///
    /// <value> The identifier of the diagnostic service section. </value>

	public ID DiagnosticServiceSectionID
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(24, 0);
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

    /// <summary>   Returns Result Status(OBR-25). </summary>
    ///
    /// <value> The result status. </value>

	public ID ResultStatus
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(25, 0);
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

    /// <summary>   Returns Parent Result(OBR-26). </summary>
    ///
    /// <value> The parent result. </value>

	public CM_PRL ParentResult
	{
		get{
			CM_PRL ret = null;
			try
			{
			IType t = this.GetField(26, 0);
				ret = (CM_PRL)t;
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

    /// <summary>   Returns Quantity/Timing(OBR-27). </summary>
    ///
    /// <value> The quantity timing. </value>

	public TQ QuantityTiming
	{
		get{
			TQ ret = null;
			try
			{
			IType t = this.GetField(27, 0);
				ret = (TQ)t;
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
    /// Returns a single repetition of Result Copies To(OBR-28). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The result copies to. </returns>

	public XCN GetResultCopiesTo(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(28, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Result Copies To (OBR-28). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of xcn. </returns>

  public XCN[] GetResultCopiesTo() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(28);  
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

  /// <summary> Returns the total repetitions of Result Copies To (OBR-28). </summary>
  ///
  /// <value>   The result copies to repetitions used. </value>

  public int ResultCopiesToRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(28);
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

    /// <summary>   Returns Parent Number(OBR-29). </summary>
    ///
    /// <value> The parent number. </value>

	public CM_EIP ParentNumber
	{
		get{
			CM_EIP ret = null;
			try
			{
			IType t = this.GetField(29, 0);
				ret = (CM_EIP)t;
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

    /// <summary>   Returns Transportation Mode(OBR-30). </summary>
    ///
    /// <value> The transportation mode. </value>

	public ID TransportationMode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(30, 0);
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

    /// <summary>
    /// Returns a single repetition of Reason For Study(OBR-31). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The reason for study. </returns>

	public CE GetReasonForStudy(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(31, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Reason For Study (OBR-31). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetReasonForStudy() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(31);  
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

  /// <summary> Returns the total repetitions of Reason For Study (OBR-31). </summary>
  ///
  /// <value>   The reason for study repetitions used. </value>

  public int ReasonForStudyRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(31);
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

    /// <summary>   Returns Principal Result Interpreter(OBR-32). </summary>
    ///
    /// <value> The principal result interpreter. </value>

	public CM_NDL PrincipalResultInterpreter
	{
		get{
			CM_NDL ret = null;
			try
			{
			IType t = this.GetField(32, 0);
				ret = (CM_NDL)t;
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
    /// Returns a single repetition of Assistant Result Interpreter(OBR-33). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The assistant result interpreter. </returns>

	public CM_NDL GetAssistantResultInterpreter(int rep)
	{
			CM_NDL ret = null;
			try
			{
			IType t = this.GetField(33, rep);
				ret = (CM_NDL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Assistant Result Interpreter (OBR-33). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres ndl. </returns>

  public CM_NDL[] GetAssistantResultInterpreter() {
     CM_NDL[] ret = null;
    try {
        IType[] t = this.GetField(33);  
        ret = new CM_NDL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_NDL)t[i];
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

  /// <summary> Returns the total repetitions of Assistant Result Interpreter (OBR-33). </summary>
  ///
  /// <value>   The assistant result interpreter repetitions used. </value>

  public int AssistantResultInterpreterRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(33);
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
    /// Returns a single repetition of Technician(OBR-34). throws HL7Exception if the repetition
    /// number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The technician. </returns>

	public CM_NDL GetTechnician(int rep)
	{
			CM_NDL ret = null;
			try
			{
			IType t = this.GetField(34, rep);
				ret = (CM_NDL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Technician (OBR-34). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres ndl. </returns>

  public CM_NDL[] GetTechnician() {
     CM_NDL[] ret = null;
    try {
        IType[] t = this.GetField(34);  
        ret = new CM_NDL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_NDL)t[i];
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

  /// <summary> Returns the total repetitions of Technician (OBR-34). </summary>
  ///
  /// <value>   The technician repetitions used. </value>

  public int TechnicianRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(34);
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
    /// Returns a single repetition of Transcriptionist(OBR-35). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The transcriptionist. </returns>

	public CM_NDL GetTranscriptionist(int rep)
	{
			CM_NDL ret = null;
			try
			{
			IType t = this.GetField(35, rep);
				ret = (CM_NDL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Transcriptionist (OBR-35). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of centimetres ndl. </returns>

  public CM_NDL[] GetTranscriptionist() {
     CM_NDL[] ret = null;
    try {
        IType[] t = this.GetField(35);  
        ret = new CM_NDL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_NDL)t[i];
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

  /// <summary> Returns the total repetitions of Transcriptionist (OBR-35). </summary>
  ///
  /// <value>   The transcriptionist repetitions used. </value>

  public int TranscriptionistRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(35);
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

    /// <summary>   Returns Scheduled Date/Time(OBR-36). </summary>
    ///
    /// <value> The scheduled date time. </value>

	public TS ScheduledDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(36, 0);
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

    /// <summary>   Returns Number Of Sample Containers(OBR-37). </summary>
    ///
    /// <value> The total number of sample containers. </value>

	public NM NumberOfSampleContainers
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(37, 0);
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

    /// <summary>
    /// Returns a single repetition of Transport Logistics Of Collected Sample(OBR-38). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The transport logistics of collected sample. </returns>

	public CE GetTransportLogisticsOfCollectedSample(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(38, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary>
  /// Returns all repetitions of Transport Logistics Of Collected Sample (OBR-38).
  /// </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetTransportLogisticsOfCollectedSample() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(38);  
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

  /// <summary>
  /// Returns the total repetitions of Transport Logistics Of Collected Sample (OBR-38).
  /// </summary>
  ///
  /// <value>   The transport logistics of collected sample repetitions used. </value>

  public int TransportLogisticsOfCollectedSampleRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(38);
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
    /// Returns a single repetition of Collector’s Comment(OBR-39). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The collector s comment. </returns>

	public CE GetCollectorSComment(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(39, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Collector’s Comment (OBR-39). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetCollectorSComment() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(39);  
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

  /// <summary> Returns the total repetitions of Collector’s Comment (OBR-39). </summary>
  ///
  /// <value>   The collector s comment repetitions used. </value>

  public int CollectorSCommentRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(39);
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

    /// <summary>   Returns Transport Arrangement Responsibility(OBR-40). </summary>
    ///
    /// <value> The transport arrangement responsibility. </value>

	public CE TransportArrangementResponsibility
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(40, 0);
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

    /// <summary>   Returns Transport Arranged(OBR-41). </summary>
    ///
    /// <value> The transport arranged. </value>

	public ID TransportArranged
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(41, 0);
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

    /// <summary>   Returns Escort Required(OBR-42). </summary>
    ///
    /// <value> The escort required. </value>

	public ID EscortRequired
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(42, 0);
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

    /// <summary>
    /// Returns a single repetition of Planned Patient Transport Comment(OBR-43). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The planned patient transport comment. </returns>

	public CE GetPlannedPatientTransportComment(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(43, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Planned Patient Transport Comment (OBR-43). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetPlannedPatientTransportComment() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(43);  
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

  /// <summary>
  /// Returns the total repetitions of Planned Patient Transport Comment (OBR-43).
  /// </summary>
  ///
  /// <value>   The planned patient transport comment repetitions used. </value>

  public int PlannedPatientTransportCommentRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(43);
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