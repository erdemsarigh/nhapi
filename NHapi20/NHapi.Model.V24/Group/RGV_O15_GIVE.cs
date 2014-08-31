using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the RGV_O15_GIVE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: RXG (Pharmacy/Treatment Give) </li>
/// <li>1: RXR (Pharmacy/Treatment Route) repeating</li>
/// <li>2: RXC (Pharmacy/Treatment Component Order) optional repeating</li>
/// <li>3: RGV_O15_OBSERVATION (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RGV_O15_GIVE : AbstractGroup {

    /// <summary>   Creates a new RGV_O15_GIVE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public RGV_O15_GIVE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXG), true, false);
	      this.add(typeof(RXR), true, true);
	      this.add(typeof(RXC), false, true);
	      this.add(typeof(RGV_O15_OBSERVATION), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RGV_O15_GIVE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns RXG (Pharmacy/Treatment Give) - creates it if necessary. </summary>
    ///
    /// <value> The rxg. </value>

	public RXG RXG { 
get{
	   RXG ret = null;
	   try {
	      ret = (RXG)this.GetStructure("RXG");
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

    /// <summary>
    /// Returns  first repetition of RGV_O15_OBSERVATION (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The observation. </returns>

	public RGV_O15_OBSERVATION GetOBSERVATION() {
	   RGV_O15_OBSERVATION ret = null;
	   try {
	      ret = (RGV_O15_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RGV_O15_OBSERVATION
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The observation. </returns>

	public RGV_O15_OBSERVATION GetOBSERVATION(int rep) { 
	   return (RGV_O15_OBSERVATION)this.GetStructure("OBSERVATION", rep);
	}

    /// <summary>   Gets the observation repetitions used. </summary>
    ///
    /// <value> The observation repetitions used. </value>

	public int OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBSERVATION").Length; 
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
