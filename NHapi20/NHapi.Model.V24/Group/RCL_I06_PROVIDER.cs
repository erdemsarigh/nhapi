using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the RCL_I06_PROVIDER Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: PRD (Provider Data) </li>
/// <li>1: CTD (Contact Data) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RCL_I06_PROVIDER : AbstractGroup {

    /// <summary>   Creates a new RCL_I06_PROVIDER Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RCL_I06_PROVIDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PRD), true, false);
	      this.add(typeof(CTD), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RCL_I06_PROVIDER - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns PRD (Provider Data) - creates it if necessary. </summary>
    ///
    /// <value> The prd. </value>

	public PRD PRD { 
get{
	   PRD ret = null;
	   try {
	      ret = (PRD)this.GetStructure("PRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns  first repetition of CTD (Contact Data) - creates it if necessary. </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The ctd. </returns>

	public CTD GetCTD() {
	   CTD ret = null;
	   try {
	      ret = (CTD)this.GetStructure("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CTD
    ///  * (Contact Data) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The ctd. </returns>

	public CTD GetCTD(int rep) { 
	   return (CTD)this.GetStructure("CTD", rep);
	}

    /// <summary>   Gets the ctd repetitions used. </summary>
    ///
    /// <value> The ctd repetitions used. </value>

	public int CTDRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CTD").Length; 
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
