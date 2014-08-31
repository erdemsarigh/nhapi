using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the RRD_O14_RESPONSE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: RRD_O14_PATIENT (a Group object) optional </li>
/// <li>1: RRD_O14_ORDER (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RRD_O14_RESPONSE : AbstractGroup {

    /// <summary>   Creates a new RRD_O14_RESPONSE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RRD_O14_RESPONSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RRD_O14_PATIENT), false, false);
	      this.add(typeof(RRD_O14_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RRD_O14_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns RRD_O14_PATIENT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The patient. </value>

	public RRD_O14_PATIENT PATIENT { 
get{
	   RRD_O14_PATIENT ret = null;
	   try {
	      ret = (RRD_O14_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of RRD_O14_ORDER (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The order. </returns>

	public RRD_O14_ORDER GetORDER() {
	   RRD_O14_ORDER ret = null;
	   try {
	      ret = (RRD_O14_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RRD_O14_ORDER
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The order. </returns>

	public RRD_O14_ORDER GetORDER(int rep) { 
	   return (RRD_O14_ORDER)this.GetStructure("ORDER", rep);
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
