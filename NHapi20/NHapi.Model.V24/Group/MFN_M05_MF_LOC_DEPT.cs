using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the MFN_M05_MF_LOC_DEPT Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: LDP (Location Department) </li>
/// <li>1: LCH (Location Characteristic) optional repeating</li>
/// <li>2: LCC (Location Charge Code) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M05_MF_LOC_DEPT : AbstractGroup {

    /// <summary>   Creates a new MFN_M05_MF_LOC_DEPT Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MFN_M05_MF_LOC_DEPT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(LDP), true, false);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LCC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M05_MF_LOC_DEPT - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns LDP (Location Department) - creates it if necessary. </summary>
    ///
    /// <value> The ldp. </value>

	public LDP LDP { 
get{
	   LDP ret = null;
	   try {
	      ret = (LDP)this.GetStructure("LDP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of LCH (Location Characteristic) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The lch. </returns>

	public LCH GetLCH() {
	   LCH ret = null;
	   try {
	      ret = (LCH)this.GetStructure("LCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of LCH
    ///  * (Location Characteristic) - creates it if necessary throws HL7Exception if the repetition
    ///  requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The lch. </returns>

	public LCH GetLCH(int rep) { 
	   return (LCH)this.GetStructure("LCH", rep);
	}

    /// <summary>   Gets the lch repetitions used. </summary>
    ///
    /// <value> The lch repetitions used. </value>

	public int LCHRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCH").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of LCC (Location Charge Code) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The lcc. </returns>

	public LCC GetLCC() {
	   LCC ret = null;
	   try {
	      ret = (LCC)this.GetStructure("LCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of LCC
    ///  * (Location Charge Code) - creates it if necessary throws HL7Exception if the repetition
    ///  requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The lcc. </returns>

	public LCC GetLCC(int rep) { 
	   return (LCC)this.GetStructure("LCC", rep);
	}

    /// <summary>   Gets the lcc repetitions used. </summary>
    ///
    /// <value> The lcc repetitions used. </value>

	public int LCCRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCC").Length; 
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
