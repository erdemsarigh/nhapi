using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the CSU_C09_STUDY_PHASE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: CSP (Clinical Study Phase) optional repeating</li>
/// <li>1: CSU_C09_STUDY_SCHEDULE (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class CSU_C09_STUDY_PHASE : AbstractGroup {

    /// <summary>   Creates a new CSU_C09_STUDY_PHASE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public CSU_C09_STUDY_PHASE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(CSP), false, true);
	      this.add(typeof(CSU_C09_STUDY_SCHEDULE), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CSU_C09_STUDY_PHASE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The csp. </returns>

	public CSP GetCSP() {
	   CSP ret = null;
	   try {
	      ret = (CSP)this.GetStructure("CSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CSP
    ///  * (Clinical Study Phase) - creates it if necessary throws HL7Exception if the repetition
    ///  requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The csp. </returns>

	public CSP GetCSP(int rep) { 
	   return (CSP)this.GetStructure("CSP", rep);
	}

    /// <summary>   Gets the csp repetitions used. </summary>
    ///
    /// <value> The csp repetitions used. </value>

	public int CSPRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CSP").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of CSU_C09_STUDY_SCHEDULE (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The study schedule. </returns>

	public CSU_C09_STUDY_SCHEDULE GetSTUDY_SCHEDULE() {
	   CSU_C09_STUDY_SCHEDULE ret = null;
	   try {
	      ret = (CSU_C09_STUDY_SCHEDULE)this.GetStructure("STUDY_SCHEDULE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CSU_C09_STUDY_SCHEDULE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The study schedule. </returns>

	public CSU_C09_STUDY_SCHEDULE GetSTUDY_SCHEDULE(int rep) { 
	   return (CSU_C09_STUDY_SCHEDULE)this.GetStructure("STUDY_SCHEDULE", rep);
	}

    /// <summary>   Gets the study schedule repetitions used. </summary>
    ///
    /// <value> The study schedule repetitions used. </value>

	public int STUDY_SCHEDULERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("STUDY_SCHEDULE").Length; 
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
