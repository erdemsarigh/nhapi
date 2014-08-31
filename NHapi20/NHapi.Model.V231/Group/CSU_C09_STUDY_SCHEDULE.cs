using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the CSU_C09_STUDY_SCHEDULE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: CSS (CSS - clinical study data schedule segment) optional </li>
/// <li>1: CSU_C09_STUDY_OBSERVATION (a Group object) repeating</li>
/// <li>2: CSU_C09_STUDY_PHARM (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class CSU_C09_STUDY_SCHEDULE : AbstractGroup {

    /// <summary>   Creates a new CSU_C09_STUDY_SCHEDULE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public CSU_C09_STUDY_SCHEDULE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(CSS), false, false);
	      this.add(typeof(CSU_C09_STUDY_OBSERVATION), true, true);
	      this.add(typeof(CSU_C09_STUDY_PHARM), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CSU_C09_STUDY_SCHEDULE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns CSS (CSS - clinical study data schedule segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The CSS. </value>

	public CSS CSS { 
get{
	   CSS ret = null;
	   try {
	      ret = (CSS)this.GetStructure("CSS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of CSU_C09_STUDY_OBSERVATION (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The study observation. </returns>

	public CSU_C09_STUDY_OBSERVATION GetSTUDY_OBSERVATION() {
	   CSU_C09_STUDY_OBSERVATION ret = null;
	   try {
	      ret = (CSU_C09_STUDY_OBSERVATION)this.GetStructure("STUDY_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CSU_C09_STUDY_OBSERVATION
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The study observation. </returns>

	public CSU_C09_STUDY_OBSERVATION GetSTUDY_OBSERVATION(int rep) { 
	   return (CSU_C09_STUDY_OBSERVATION)this.GetStructure("STUDY_OBSERVATION", rep);
	}

    /// <summary>   Gets the study observation repetitions used. </summary>
    ///
    /// <value> The study observation repetitions used. </value>

	public int STUDY_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("STUDY_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of CSU_C09_STUDY_PHARM (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The study pharm. </returns>

	public CSU_C09_STUDY_PHARM GetSTUDY_PHARM() {
	   CSU_C09_STUDY_PHARM ret = null;
	   try {
	      ret = (CSU_C09_STUDY_PHARM)this.GetStructure("STUDY_PHARM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CSU_C09_STUDY_PHARM
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The study pharm. </returns>

	public CSU_C09_STUDY_PHARM GetSTUDY_PHARM(int rep) { 
	   return (CSU_C09_STUDY_PHARM)this.GetStructure("STUDY_PHARM", rep);
	}

    /// <summary>   Gets the study pharm repetitions used. </summary>
    ///
    /// <value> The study pharm repetitions used. </value>

	public int STUDY_PHARMRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("STUDY_PHARM").Length; 
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
