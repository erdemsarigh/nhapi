using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
/// <summary>
/// Represents the MFN_M06_MF_CLIN_STUDY Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: MFE (Master file entry segment) </li>
/// <li>1: CM0 (Clinical Study Master) </li>
/// <li>2: MFN_M06_MF_PHASE_SCHED_DETAIL (a Group object) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M06_MF_CLIN_STUDY : AbstractGroup {

    /// <summary>   Creates a new MFN_M06_MF_CLIN_STUDY Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MFN_M06_MF_CLIN_STUDY(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(CM0), true, false);
	      this.add(typeof(MFN_M06_MF_PHASE_SCHED_DETAIL), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M06_MF_CLIN_STUDY - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns MFE (Master file entry segment) - creates it if necessary. </summary>
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

    /// <summary>   Returns CM0 (Clinical Study Master) - creates it if necessary. </summary>
    ///
    /// <value> The centimetres 0. </value>

	public CM0 CM0 { 
get{
	   CM0 ret = null;
	   try {
	      ret = (CM0)this.GetStructure("CM0");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of MFN_M06_MF_PHASE_SCHED_DETAIL (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The mf phase sched detail. </returns>

	public MFN_M06_MF_PHASE_SCHED_DETAIL GetMF_PHASE_SCHED_DETAIL() {
	   MFN_M06_MF_PHASE_SCHED_DETAIL ret = null;
	   try {
	      ret = (MFN_M06_MF_PHASE_SCHED_DETAIL)this.GetStructure("MF_PHASE_SCHED_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of MFN_M06_MF_PHASE_SCHED_DETAIL
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The mf phase sched detail. </returns>

	public MFN_M06_MF_PHASE_SCHED_DETAIL GetMF_PHASE_SCHED_DETAIL(int rep) { 
	   return (MFN_M06_MF_PHASE_SCHED_DETAIL)this.GetStructure("MF_PHASE_SCHED_DETAIL", rep);
	}

    /// <summary>   Gets the mf phase sched detail repetitions used. </summary>
    ///
    /// <value> The mf phase sched detail repetitions used. </value>

	public int MF_PHASE_SCHED_DETAILRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MF_PHASE_SCHED_DETAIL").Length; 
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
