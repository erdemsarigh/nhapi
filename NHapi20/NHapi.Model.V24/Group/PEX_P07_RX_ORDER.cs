using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the PEX_P07_RX_ORDER Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: RXE (Pharmacy/Treatment Encoded Order) </li>
/// <li>1: RXR (Pharmacy/Treatment Route) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class PEX_P07_RX_ORDER : AbstractGroup {

    /// <summary>   Creates a new PEX_P07_RX_ORDER Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PEX_P07_RX_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXE), true, false);
	      this.add(typeof(RXR), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PEX_P07_RX_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary. </summary>
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

}
}
