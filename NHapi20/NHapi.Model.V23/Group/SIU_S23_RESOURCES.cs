using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
/// <summary>
/// Represents the SIU_S23_RESOURCES Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: RGS (Resource Group) </li>
/// <li>1: SIU_S23_SERVICE (a Group object) optional repeating</li>
/// <li>2: SIU_S23_GENERAL_RESOURCE (a Group object) optional repeating</li>
/// <li>3: SIU_S23_LOCATION_RESOURCE (a Group object) optional repeating</li>
/// <li>4: SIU_S23_PERSONNEL_RESOURCE (a Group object) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class SIU_S23_RESOURCES : AbstractGroup {

    /// <summary>   Creates a new SIU_S23_RESOURCES Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public SIU_S23_RESOURCES(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RGS), true, false);
	      this.add(typeof(SIU_S23_SERVICE), false, true);
	      this.add(typeof(SIU_S23_GENERAL_RESOURCE), false, true);
	      this.add(typeof(SIU_S23_LOCATION_RESOURCE), false, true);
	      this.add(typeof(SIU_S23_PERSONNEL_RESOURCE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SIU_S23_RESOURCES - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns RGS (Resource Group) - creates it if necessary. </summary>
    ///
    /// <value> The rgs. </value>

	public RGS RGS { 
get{
	   RGS ret = null;
	   try {
	      ret = (RGS)this.GetStructure("RGS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of SIU_S23_SERVICE (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The service. </returns>

	public SIU_S23_SERVICE GetSERVICE() {
	   SIU_S23_SERVICE ret = null;
	   try {
	      ret = (SIU_S23_SERVICE)this.GetStructure("SERVICE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SIU_S23_SERVICE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The service. </returns>

	public SIU_S23_SERVICE GetSERVICE(int rep) { 
	   return (SIU_S23_SERVICE)this.GetStructure("SERVICE", rep);
	}

    /// <summary>   Gets the service repetitions used. </summary>
    ///
    /// <value> The service repetitions used. </value>

	public int SERVICERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SERVICE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of SIU_S23_GENERAL_RESOURCE (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The general resource. </returns>

	public SIU_S23_GENERAL_RESOURCE GetGENERAL_RESOURCE() {
	   SIU_S23_GENERAL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S23_GENERAL_RESOURCE)this.GetStructure("GENERAL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SIU_S23_GENERAL_RESOURCE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The general resource. </returns>

	public SIU_S23_GENERAL_RESOURCE GetGENERAL_RESOURCE(int rep) { 
	   return (SIU_S23_GENERAL_RESOURCE)this.GetStructure("GENERAL_RESOURCE", rep);
	}

    /// <summary>   Gets the general resource repetitions used. </summary>
    ///
    /// <value> The general resource repetitions used. </value>

	public int GENERAL_RESOURCERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GENERAL_RESOURCE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of SIU_S23_LOCATION_RESOURCE (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The location resource. </returns>

	public SIU_S23_LOCATION_RESOURCE GetLOCATION_RESOURCE() {
	   SIU_S23_LOCATION_RESOURCE ret = null;
	   try {
	      ret = (SIU_S23_LOCATION_RESOURCE)this.GetStructure("LOCATION_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SIU_S23_LOCATION_RESOURCE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The location resource. </returns>

	public SIU_S23_LOCATION_RESOURCE GetLOCATION_RESOURCE(int rep) { 
	   return (SIU_S23_LOCATION_RESOURCE)this.GetStructure("LOCATION_RESOURCE", rep);
	}

    /// <summary>   Gets the location resource repetitions used. </summary>
    ///
    /// <value> The location resource repetitions used. </value>

	public int LOCATION_RESOURCERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LOCATION_RESOURCE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of SIU_S23_PERSONNEL_RESOURCE (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The personnel resource. </returns>

	public SIU_S23_PERSONNEL_RESOURCE GetPERSONNEL_RESOURCE() {
	   SIU_S23_PERSONNEL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S23_PERSONNEL_RESOURCE)this.GetStructure("PERSONNEL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SIU_S23_PERSONNEL_RESOURCE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The personnel resource. </returns>

	public SIU_S23_PERSONNEL_RESOURCE GetPERSONNEL_RESOURCE(int rep) { 
	   return (SIU_S23_PERSONNEL_RESOURCE)this.GetStructure("PERSONNEL_RESOURCE", rep);
	}

    /// <summary>   Gets the personnel resource repetitions used. </summary>
    ///
    /// <value> The personnel resource repetitions used. </value>

	public int PERSONNEL_RESOURCERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PERSONNEL_RESOURCE").Length; 
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
