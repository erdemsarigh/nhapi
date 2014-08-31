using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
/// <summary>
/// Represents the MFN_M10_MF_TEST_BATTERIES Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: OM5 (Observation batteries) </li>
/// <li>1: OM4 (Observations that require specimens) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M10_MF_TEST_BATTERIES : AbstractGroup {

    /// <summary>   Creates a new MFN_M10_MF_TEST_BATTERIES Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MFN_M10_MF_TEST_BATTERIES(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OM5), true, false);
	      this.add(typeof(OM4), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M10_MF_TEST_BATTERIES - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns OM5 (Observation batteries) - creates it if necessary. </summary>
    ///
    /// <value> The om 5. </value>

	public OM5 OM5 { 
get{
	   OM5 ret = null;
	   try {
	      ret = (OM5)this.GetStructure("OM5");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of OM4 (Observations that require specimens) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The om 4. </returns>

	public OM4 GetOM4() {
	   OM4 ret = null;
	   try {
	      ret = (OM4)this.GetStructure("OM4");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of OM4
    ///  * (Observations that require specimens) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The om 4. </returns>

	public OM4 GetOM4(int rep) { 
	   return (OM4)this.GetStructure("OM4", rep);
	}

    /// <summary>   Gets the om 4 repetitions used. </summary>
    ///
    /// <value> The om 4 repetitions used. </value>

	public int OM4RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OM4").Length; 
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
