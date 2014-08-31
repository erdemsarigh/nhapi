using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the SQR_S25_SCHEDULE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: SCH (SCH - schedule activity information segment) </li>
/// <li>1: NTE (NTE - notes and comments segment) optional repeating</li>
/// <li>2: SQR_S25_PATIENT (a Group object) optional </li>
/// <li>3: SQR_S25_RESOURCES (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class SQR_S25_SCHEDULE : AbstractGroup {

    /// <summary>   Creates a new SQR_S25_SCHEDULE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public SQR_S25_SCHEDULE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SCH), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(SQR_S25_PATIENT), false, false);
	      this.add(typeof(SQR_S25_RESOURCES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SQR_S25_SCHEDULE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns SCH (SCH - schedule activity information segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The sch. </value>

	public SCH SCH { 
get{
	   SCH ret = null;
	   try {
	      ret = (SCH)this.GetStructure("SCH");
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

    /// <summary>   Returns SQR_S25_PATIENT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The patient. </value>

	public SQR_S25_PATIENT PATIENT { 
get{
	   SQR_S25_PATIENT ret = null;
	   try {
	      ret = (SQR_S25_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of SQR_S25_RESOURCES (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The resources. </returns>

	public SQR_S25_RESOURCES GetRESOURCES() {
	   SQR_S25_RESOURCES ret = null;
	   try {
	      ret = (SQR_S25_RESOURCES)this.GetStructure("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SQR_S25_RESOURCES
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The resources. </returns>

	public SQR_S25_RESOURCES GetRESOURCES(int rep) { 
	   return (SQR_S25_RESOURCES)this.GetStructure("RESOURCES", rep);
	}

    /// <summary>   Gets the resources repetitions used. </summary>
    ///
    /// <value> The resources repetitions used. </value>

	public int RESOURCESRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RESOURCES").Length; 
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
