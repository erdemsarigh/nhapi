using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the RAR_RAR_DEFINITION Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: QRD (QRD - original-style query definition segment) </li>
/// <li>1: QRF (QRF - original style query filter segment) optional </li>
/// <li>2: RAR_RAR_PATIENT (a Group object) optional </li>
/// <li>3: RAR_RAR_ORDER (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RAR_RAR_DEFINITION : AbstractGroup {

    /// <summary>   Creates a new RAR_RAR_DEFINITION Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RAR_RAR_DEFINITION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(RAR_RAR_PATIENT), false, false);
	      this.add(typeof(RAR_RAR_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RAR_RAR_DEFINITION - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns QRD (QRD - original-style query definition segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The qrd. </value>

	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns QRF (QRF - original style query filter segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The qrf. </value>

	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.GetStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns RAR_RAR_PATIENT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The patient. </value>

	public RAR_RAR_PATIENT PATIENT { 
get{
	   RAR_RAR_PATIENT ret = null;
	   try {
	      ret = (RAR_RAR_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of RAR_RAR_ORDER (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The order. </returns>

	public RAR_RAR_ORDER GetORDER() {
	   RAR_RAR_ORDER ret = null;
	   try {
	      ret = (RAR_RAR_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RAR_RAR_ORDER
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The order. </returns>

	public RAR_RAR_ORDER GetORDER(int rep) { 
	   return (RAR_RAR_ORDER)this.GetStructure("ORDER", rep);
	}

    /// <summary>   Gets the order repetitions used. </summary>
    ///
    /// <value> The order repetitions used. </value>

	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
