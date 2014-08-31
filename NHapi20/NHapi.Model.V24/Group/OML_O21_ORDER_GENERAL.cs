using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the OML_O21_ORDER_GENERAL Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: OML_O21_CONTAINER_1 (a Group object) optional </li>
/// <li>1: OML_O21_ORDER (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class OML_O21_ORDER_GENERAL : AbstractGroup {

    /// <summary>   Creates a new OML_O21_ORDER_GENERAL Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public OML_O21_ORDER_GENERAL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OML_O21_CONTAINER_1), false, false);
	      this.add(typeof(OML_O21_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating OML_O21_ORDER_GENERAL - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns OML_O21_CONTAINER_1 (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The container 1. </value>

	public OML_O21_CONTAINER_1 CONTAINER_1 { 
get{
	   OML_O21_CONTAINER_1 ret = null;
	   try {
	      ret = (OML_O21_CONTAINER_1)this.GetStructure("CONTAINER_1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of OML_O21_ORDER (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The order. </returns>

	public OML_O21_ORDER GetORDER() {
	   OML_O21_ORDER ret = null;
	   try {
	      ret = (OML_O21_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of OML_O21_ORDER
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The order. </returns>

	public OML_O21_ORDER GetORDER(int rep) { 
	   return (OML_O21_ORDER)this.GetStructure("ORDER", rep);
	}

    /// <summary>   Gets the order repetitions used. </summary>
    ///
    /// <value> The order repetitions used. </value>

	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
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
