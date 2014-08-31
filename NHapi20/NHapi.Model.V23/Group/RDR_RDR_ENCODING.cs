using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
/// <summary>
/// Represents the RDR_RDR_ENCODING Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: RXE (Pharmacy encoded order segment) </li>
/// <li>1: RXR (Pharmacy route segment) </li>
/// <li>2: RXC (Pharmacy component order segment) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RDR_RDR_ENCODING : AbstractGroup {

    /// <summary>   Creates a new RDR_RDR_ENCODING Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RDR_RDR_ENCODING(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXE), true, false);
	      this.add(typeof(RXR), true, false);
	      this.add(typeof(RXC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RDR_RDR_ENCODING - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns RXE (Pharmacy encoded order segment) - creates it if necessary. </summary>
    ///
    /// <value> The rxe. </value>

	public RXE RXE { 
get{
	   RXE ret = null;
	   try {
	      ret = (RXE)this.GetStructure("RXE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns RXR (Pharmacy route segment) - creates it if necessary. </summary>
    ///
    /// <value> The rxr. </value>

	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of RXC (Pharmacy component order segment) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The rxc. </returns>

	public RXC GetRXC() {
	   RXC ret = null;
	   try {
	      ret = (RXC)this.GetStructure("RXC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RXC
    ///  * (Pharmacy component order segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The rxc. </returns>

	public RXC GetRXC(int rep) { 
	   return (RXC)this.GetStructure("RXC", rep);
	}

    /// <summary>   Gets the rxc repetitions used. </summary>
    ///
    /// <value> The rxc repetitions used. </value>

	public int RXCRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXC").Length; 
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
