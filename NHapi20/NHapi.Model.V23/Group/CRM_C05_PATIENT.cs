using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
/// <summary>
/// Represents the CRM_C05_PATIENT Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: PID (Patient Identification) </li>
/// <li>1: PV1 (Patient visit) optional </li>
/// <li>2: CSR (Clinical Study Registration) </li>
/// <li>3: CSP (Clinical Study Phase) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class CRM_C05_PATIENT : AbstractGroup {

    /// <summary>   Creates a new CRM_C05_PATIENT Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public CRM_C05_PATIENT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PV1), false, false);
	      this.add(typeof(CSR), true, false);
	      this.add(typeof(CSP), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CRM_C05_PATIENT - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns PID (Patient Identification) - creates it if necessary. </summary>
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

    /// <summary>   Returns PV1 (Patient visit) - creates it if necessary. </summary>
    ///
    /// <value> The pv 1. </value>

	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.GetStructure("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns CSR (Clinical Study Registration) - creates it if necessary. </summary>
    ///
    /// <value> The cursor. </value>

	public CSR CSR { 
get{
	   CSR ret = null;
	   try {
	      ret = (CSR)this.GetStructure("CSR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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

}
}
