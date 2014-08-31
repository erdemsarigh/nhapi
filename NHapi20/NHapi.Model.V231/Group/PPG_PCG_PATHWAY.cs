using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the PPG_PCG_PATHWAY Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: PTH (Pathway) </li>
/// <li>1: NTE (NTE - notes and comments segment) optional repeating</li>
/// <li>2: VAR (Variance) optional repeating</li>
/// <li>3: PPG_PCG_PATHWAY_ROLE (a Group object) optional repeating</li>
/// <li>4: PPG_PCG_GOAL (a Group object) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class PPG_PCG_PATHWAY : AbstractGroup {

    /// <summary>   Creates a new PPG_PCG_PATHWAY Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PPG_PCG_PATHWAY(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PTH), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(VAR), false, true);
	      this.add(typeof(PPG_PCG_PATHWAY_ROLE), false, true);
	      this.add(typeof(PPG_PCG_GOAL), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PPG_PCG_PATHWAY - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns PTH (Pathway) - creates it if necessary. </summary>
    ///
    /// <value> The full pathname of the file. </value>

	public PTH PTH { 
get{
	   PTH ret = null;
	   try {
	      ret = (PTH)this.GetStructure("PTH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The nte. </returns>

	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NTE
    ///  * (NTE - notes and comments segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The nte. </returns>

	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

    /// <summary>   Gets the nte repetitions used. </summary>
    ///
    /// <value> The nte repetitions used. </value>

	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns  first repetition of VAR (Variance) - creates it if necessary. </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The variable. </returns>

	public VAR GetVAR() {
	   VAR ret = null;
	   try {
	      ret = (VAR)this.GetStructure("VAR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of VAR
    ///  * (Variance) - creates it if necessary throws HL7Exception if the repetition requested is
    ///  more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The variable. </returns>

	public VAR GetVAR(int rep) { 
	   return (VAR)this.GetStructure("VAR", rep);
	}

    /// <summary>   Gets the variable repetitions used. </summary>
    ///
    /// <value> The variable repetitions used. </value>

	public int VARRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("VAR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of PPG_PCG_PATHWAY_ROLE (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The pathway role. </returns>

	public PPG_PCG_PATHWAY_ROLE GetPATHWAY_ROLE() {
	   PPG_PCG_PATHWAY_ROLE ret = null;
	   try {
	      ret = (PPG_PCG_PATHWAY_ROLE)this.GetStructure("PATHWAY_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PPG_PCG_PATHWAY_ROLE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The pathway role. </returns>

	public PPG_PCG_PATHWAY_ROLE GetPATHWAY_ROLE(int rep) { 
	   return (PPG_PCG_PATHWAY_ROLE)this.GetStructure("PATHWAY_ROLE", rep);
	}

    /// <summary>   Gets the pathway role repetitions used. </summary>
    ///
    /// <value> The pathway role repetitions used. </value>

	public int PATHWAY_ROLERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATHWAY_ROLE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of PPG_PCG_GOAL (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The goal. </returns>

	public PPG_PCG_GOAL GetGOAL() {
	   PPG_PCG_GOAL ret = null;
	   try {
	      ret = (PPG_PCG_GOAL)this.GetStructure("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PPG_PCG_GOAL
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The goal. </returns>

	public PPG_PCG_GOAL GetGOAL(int rep) { 
	   return (PPG_PCG_GOAL)this.GetStructure("GOAL", rep);
	}

    /// <summary>   Gets the goal repetitions used. </summary>
    ///
    /// <value> The goal repetitions used. </value>

	public int GOALRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GOAL").Length; 
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
