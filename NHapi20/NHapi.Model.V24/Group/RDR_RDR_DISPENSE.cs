using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the RDR_RDR_DISPENSE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: RXD (Pharmacy/Treatment Dispense) </li>
/// <li>1: RXR (Pharmacy/Treatment Route) repeating</li>
/// <li>2: RXC (Pharmacy/Treatment Component Order) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RDR_RDR_DISPENSE : AbstractGroup {

    /// <summary>   Creates a new RDR_RDR_DISPENSE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RDR_RDR_DISPENSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXD), true, false);
	      this.add(typeof(RXR), true, true);
	      this.add(typeof(RXC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RDR_RDR_DISPENSE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns RXD (Pharmacy/Treatment Dispense) - creates it if necessary. </summary>
    ///
    /// <value> Information describing the receive. </value>

	public RXD RXD { 
get{
	   RXD ret = null;
	   try {
	      ret = (RXD)this.GetStructure("RXD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The rxr. </returns>

	public RXR GetRXR() {
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RXR
    ///  * (Pharmacy/Treatment Route) - creates it if necessary throws HL7Exception if the repetition
    ///  requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The rxr. </returns>

	public RXR GetRXR(int rep) { 
	   return (RXR)this.GetStructure("RXR", rep);
	}

    /// <summary>   Gets the rxr repetitions used. </summary>
    ///
    /// <value> The rxr repetitions used. </value>

	public int RXRRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if
    /// necessary.
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
    ///  * (Pharmacy/Treatment Component Order) - creates it if necessary throws HL7Exception if the
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
