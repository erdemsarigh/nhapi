using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the ORG_O20_RESPONSE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: ORG_O20_PATIENT (a Group object) optional </li>
/// <li>1: ORG_O20_ORDER (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class ORG_O20_RESPONSE : AbstractGroup {

    /// <summary>   Creates a new ORG_O20_RESPONSE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public ORG_O20_RESPONSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORG_O20_PATIENT), false, false);
	      this.add(typeof(ORG_O20_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORG_O20_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns ORG_O20_PATIENT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The patient. </value>

	public ORG_O20_PATIENT PATIENT { 
get{
	   ORG_O20_PATIENT ret = null;
	   try {
	      ret = (ORG_O20_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of ORG_O20_ORDER (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The order. </returns>

	public ORG_O20_ORDER GetORDER() {
	   ORG_O20_ORDER ret = null;
	   try {
	      ret = (ORG_O20_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of ORG_O20_ORDER
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The order. </returns>

	public ORG_O20_ORDER GetORDER(int rep) { 
	   return (ORG_O20_ORDER)this.GetStructure("ORDER", rep);
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
