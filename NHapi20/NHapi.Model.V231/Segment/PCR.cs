using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V231.Segment{

/// <summary>
/// Represents an HL7 PCR message segment. This segment has the following fields:<ol>
/// <li>PCR-1: Implicated Product (CE)</li>
/// <li>PCR-2: Generic Product (IS)</li>
/// <li>PCR-3: Product Class (CE)</li>
/// <li>PCR-4: Total Duration Of Therapy (CQ)</li>
/// <li>PCR-5: Product Manufacture Date (TS)</li>
/// <li>PCR-6: Product Expiration Date (TS)</li>
/// <li>PCR-7: Product Implantation Date (TS)</li>
/// <li>PCR-8: Product Explantation Date (TS)</li>
/// <li>PCR-9: Single Use Device (IS)</li>
/// <li>PCR-10: Indication For Product Use (CE)</li>
/// <li>PCR-11: Product Problem (IS)</li>
/// <li>PCR-12: Product Serial/Lot Number (ST)</li>
/// <li>PCR-13: Product Available For Inspection (IS)</li>
/// <li>PCR-14: Product Evaluation Performed (CE)</li>
/// <li>PCR-15: Product Evaluation Status (CE)</li>
/// <li>PCR-16: Product Evaluation Results (CE)</li>
/// <li>PCR-17: Evaluated Product Source (ID)</li>
/// <li>PCR-18: Date Product Returned To Manufacturer (TS)</li>
/// <li>PCR-19: Device Operator Qualifications (ID)</li>
/// <li>PCR-20: Relatedness Assessment (ID)</li>
/// <li>PCR-21: Action Taken In Response To The Event (ID)</li>
/// <li>PCR-22: Event Causality Observations (ID)</li>
/// <li>PCR-23: Indirect Exposure Mechanism (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class PCR : AbstractSegment  {

    /// <summary>   Initializes a new instance of the PCR class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PCR(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), true, 1, 60, new System.Object[]{message}, "Implicated Product");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 249}, "Generic Product");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Product Class");
       this.add(typeof(CQ), false, 1, 8, new System.Object[]{message}, "Total Duration Of Therapy");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Manufacture Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Expiration Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Implantation Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Explantation Date");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 244}, "Single Use Device");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Indication For Product Use");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 245}, "Product Problem");
       this.add(typeof(ST), false, 3, 30, new System.Object[]{message}, "Product Serial/Lot Number");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 246}, "Product Available For Inspection");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Product Evaluation Performed");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Product Evaluation Status");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Product Evaluation Results");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 248}, "Evaluated Product Source");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date Product Returned To Manufacturer");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242}, "Device Operator Qualifications");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 250}, "Relatedness Assessment");
       this.add(typeof(ID), false, 6, 2, new System.Object[]{message, 251}, "Action Taken In Response To The Event");
       this.add(typeof(ID), false, 6, 2, new System.Object[]{message, 252}, "Event Causality Observations");
       this.add(typeof(ID), false, 3, 1, new System.Object[]{message, 253}, "Indirect Exposure Mechanism");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns Implicated Product(PCR-1). </summary>
    ///
    /// <value> The implicated product. </value>

	public CE ImplicatedProduct
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

    /// <summary>   Returns Generic Product(PCR-2). </summary>
    ///
    /// <value> The generic product. </value>

	public IS GenericProduct
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Product Class(PCR-3). </summary>
    ///
    /// <value> The product class. </value>

	public CE ProductClass
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

    /// <summary>   Returns Total Duration Of Therapy(PCR-4). </summary>
    ///
    /// <value> The total number of duration of therapy. </value>

	public CQ TotalDurationOfTherapy
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

    /// <summary>   Returns Product Manufacture Date(PCR-5). </summary>
    ///
    /// <value> The product manufacture date. </value>

	public TS ProductManufactureDate
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

    /// <summary>   Returns Product Expiration Date(PCR-6). </summary>
    ///
    /// <value> The product expiration date. </value>

	public TS ProductExpirationDate
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

    /// <summary>   Returns Product Implantation Date(PCR-7). </summary>
    ///
    /// <value> The product implantation date. </value>

	public TS ProductImplantationDate
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

    /// <summary>   Returns Product Explantation Date(PCR-8). </summary>
    ///
    /// <value> The product explantation date. </value>

	public TS ProductExplantationDate
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

    /// <summary>   Returns Single Use Device(PCR-9). </summary>
    ///
    /// <value> The single use device. </value>

	public IS SingleUseDevice
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Indication For Product Use(PCR-10). </summary>
    ///
    /// <value> The indication for product use. </value>

	public CE IndicationForProductUse
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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

    /// <summary>   Returns Product Problem(PCR-11). </summary>
    ///
    /// <value> The product problem. </value>

	public IS ProductProblem
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (IS)t;
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
    /// Returns a single repetition of Product Serial/Lot Number(PCR-12). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The product serial lot number. </returns>

	public ST GetProductSerialLotNumber(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(12, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Product Serial/Lot Number (PCR-12). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of st. </returns>

  public ST[] GetProductSerialLotNumber() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(12);  
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

  /// <summary> Returns the total repetitions of Product Serial/Lot Number (PCR-12). </summary>
  ///
  /// <value>   The product serial lot number repetitions used. </value>

  public int ProductSerialLotNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(12);
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

    /// <summary>   Returns Product Available For Inspection(PCR-13). </summary>
    ///
    /// <value> The product available for inspection. </value>

	public IS ProductAvailableForInspection
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (IS)t;
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

    /// <summary>   Returns Product Evaluation Performed(PCR-14). </summary>
    ///
    /// <value> The product evaluation performed. </value>

	public CE ProductEvaluationPerformed
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

    /// <summary>   Returns Product Evaluation Status(PCR-15). </summary>
    ///
    /// <value> The product evaluation status. </value>

	public CE ProductEvaluationStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

    /// <summary>   Returns Product Evaluation Results(PCR-16). </summary>
    ///
    /// <value> The product evaluation results. </value>

	public CE ProductEvaluationResults
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(16, 0);
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

    /// <summary>   Returns Evaluated Product Source(PCR-17). </summary>
    ///
    /// <value> The evaluated product source. </value>

	public ID EvaluatedProductSource
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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

    /// <summary>   Returns Date Product Returned To Manufacturer(PCR-18). </summary>
    ///
    /// <value> The date product returned to manufacturer. </value>

	public TS DateProductReturnedToManufacturer
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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

    /// <summary>   Returns Device Operator Qualifications(PCR-19). </summary>
    ///
    /// <value> The device operator qualifications. </value>

	public ID DeviceOperatorQualifications
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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

    /// <summary>   Returns Relatedness Assessment(PCR-20). </summary>
    ///
    /// <value> The relatedness assessment. </value>

	public ID RelatednessAssessment
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(20, 0);
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
    /// Returns a single repetition of Action Taken In Response To The Event(PCR-21). throws
    /// HL7Exception if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The action taken in response to the event. </returns>

	public ID GetActionTakenInResponseToTheEvent(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Action Taken In Response To The Event (PCR-21). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetActionTakenInResponseToTheEvent() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(21);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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
  /// Returns the total repetitions of Action Taken In Response To The Event (PCR-21).
  /// </summary>
  ///
  /// <value>   The action taken in response to the event repetitions used. </value>

  public int ActionTakenInResponseToTheEventRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(21);
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
    /// Returns a single repetition of Event Causality Observations(PCR-22). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The event causality observations. </returns>

	public ID GetEventCausalityObservations(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(22, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Event Causality Observations (PCR-22). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetEventCausalityObservations() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(22);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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

  /// <summary> Returns the total repetitions of Event Causality Observations (PCR-22). </summary>
  ///
  /// <value>   The event causality observations repetitions used. </value>

  public int EventCausalityObservationsRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(22);
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
    /// Returns a single repetition of Indirect Exposure Mechanism(PCR-23). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The indirect exposure mechanism. </returns>

	public ID GetIndirectExposureMechanism(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(23, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Indirect Exposure Mechanism (PCR-23). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of identifier. </returns>

  public ID[] GetIndirectExposureMechanism() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(23);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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

  /// <summary> Returns the total repetitions of Indirect Exposure Mechanism (PCR-23). </summary>
  ///
  /// <value>   The indirect exposure mechanism repetitions used. </value>

  public int IndirectExposureMechanismRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(23);
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