using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the MFN_M05_MF_LOCATION Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: MFE (MFE - master file entry segment) </li>
/// <li>1: LOC (LOC - location identification segment) </li>
/// <li>2: LCH (LCH - location characteristic segment) optional repeating</li>
/// <li>3: LRL (LRL - location relationship segment) optional repeating</li>
/// <li>4: MFN_M05_MF_LOC_DEPT (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M05_MF_LOCATION : AbstractGroup {

    /// <summary>   Creates a new MFN_M05_MF_LOCATION Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MFN_M05_MF_LOCATION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(LOC), true, false);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LRL), false, true);
	      this.add(typeof(MFN_M05_MF_LOC_DEPT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M05_MF_LOCATION - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns MFE (MFE - master file entry segment) - creates it if necessary. </summary>
    ///
    /// <value> The mfe. </value>

	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.GetStructure("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns LOC (LOC - location identification segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The location. </value>

	public LOC LOC { 
get{
	   LOC ret = null;
	   try {
	      ret = (LOC)this.GetStructure("LOC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of LCH (LCH - location characteristic segment) - creates it if
    /// necessary.
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
    ///  * (LCH - location characteristic segment) - creates it if necessary throws HL7Exception if
    ///  the repetition requested is more than one
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
    /// Returns  first repetition of LRL (LRL - location relationship segment) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The lrl. </returns>

	public LRL GetLRL() {
	   LRL ret = null;
	   try {
	      ret = (LRL)this.GetStructure("LRL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of LRL
    ///  * (LRL - location relationship segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The lrl. </returns>

	public LRL GetLRL(int rep) { 
	   return (LRL)this.GetStructure("LRL", rep);
	}

    /// <summary>   Gets the lrl repetitions used. </summary>
    ///
    /// <value> The lrl repetitions used. </value>

	public int LRLRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LRL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of MFN_M05_MF_LOC_DEPT (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The mf location dept. </returns>

	public MFN_M05_MF_LOC_DEPT GetMF_LOC_DEPT() {
	   MFN_M05_MF_LOC_DEPT ret = null;
	   try {
	      ret = (MFN_M05_MF_LOC_DEPT)this.GetStructure("MF_LOC_DEPT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of MFN_M05_MF_LOC_DEPT
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The mf location dept. </returns>

	public MFN_M05_MF_LOC_DEPT GetMF_LOC_DEPT(int rep) { 
	   return (MFN_M05_MF_LOC_DEPT)this.GetStructure("MF_LOC_DEPT", rep);
	}

    /// <summary>   Gets the mf location dept repetitions used. </summary>
    ///
    /// <value> The mf location dept repetitions used. </value>

	public int MF_LOC_DEPTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MF_LOC_DEPT").Length; 
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
