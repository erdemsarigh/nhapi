using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the SQM_S25_REQUEST Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: ARQ (ARQ - appointment request segment) </li>
/// <li>1: APR (APR - appointment preferences segment) optional </li>
/// <li>2: PID (PID - patient identification segment) optional </li>
/// <li>3: SQM_S25_RESOURCES (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class SQM_S25_REQUEST : AbstractGroup {

    /// <summary>   Creates a new SQM_S25_REQUEST Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public SQM_S25_REQUEST(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ARQ), true, false);
	      this.add(typeof(APR), false, false);
	      this.add(typeof(PID), false, false);
	      this.add(typeof(SQM_S25_RESOURCES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SQM_S25_REQUEST - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns ARQ (ARQ - appointment request segment) - creates it if necessary. </summary>
    ///
    /// <value> The arq. </value>

	public ARQ ARQ { 
get{
	   ARQ ret = null;
	   try {
	      ret = (ARQ)this.GetStructure("ARQ");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns APR (APR - appointment preferences segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The APR. </value>

	public APR APR { 
get{
	   APR ret = null;
	   try {
	      ret = (APR)this.GetStructure("APR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns PID (PID - patient identification segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The PID. </value>

	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of SQM_S25_RESOURCES (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The resources. </returns>

	public SQM_S25_RESOURCES GetRESOURCES() {
	   SQM_S25_RESOURCES ret = null;
	   try {
	      ret = (SQM_S25_RESOURCES)this.GetStructure("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SQM_S25_RESOURCES
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The resources. </returns>

	public SQM_S25_RESOURCES GetRESOURCES(int rep) { 
	   return (SQM_S25_RESOURCES)this.GetStructure("RESOURCES", rep);
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
