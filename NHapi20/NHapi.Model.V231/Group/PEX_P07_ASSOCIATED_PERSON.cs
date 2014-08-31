using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the PEX_P07_ASSOCIATED_PERSON Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: NK1 (NK1 - next of kin / associated parties segment-) </li>
/// <li>1: PEX_P07_ASSOCIATED_RX_ORDER (a Group object) optional </li>
/// <li>2: PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) optional repeating</li>
/// <li>3: PRB (Problem Detail) optional repeating</li>
/// <li>4: OBX (OBX - observation/result segment) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class PEX_P07_ASSOCIATED_PERSON : AbstractGroup {

    /// <summary>   Creates a new PEX_P07_ASSOCIATED_PERSON Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public PEX_P07_ASSOCIATED_PERSON(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NK1), true, false);
	      this.add(typeof(PEX_P07_ASSOCIATED_RX_ORDER), false, false);
	      this.add(typeof(PEX_P07_ASSOCIATED_RX_ADMIN), false, true);
	      this.add(typeof(PRB), false, true);
	      this.add(typeof(OBX), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PEX_P07_ASSOCIATED_PERSON - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The nk 1. </value>

	public NK1 NK1 { 
get{
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns PEX_P07_ASSOCIATED_RX_ORDER (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The associated receive order. </value>

	public PEX_P07_ASSOCIATED_RX_ORDER ASSOCIATED_RX_ORDER { 
get{
	   PEX_P07_ASSOCIATED_RX_ORDER ret = null;
	   try {
	      ret = (PEX_P07_ASSOCIATED_RX_ORDER)this.GetStructure("ASSOCIATED_RX_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   a ssociated receive admin. </returns>

	public PEX_P07_ASSOCIATED_RX_ADMIN GetASSOCIATED_RX_ADMIN() {
	   PEX_P07_ASSOCIATED_RX_ADMIN ret = null;
	   try {
	      ret = (PEX_P07_ASSOCIATED_RX_ADMIN)this.GetStructure("ASSOCIATED_RX_ADMIN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PEX_P07_ASSOCIATED_RX_ADMIN
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   a ssociated receive admin. </returns>

	public PEX_P07_ASSOCIATED_RX_ADMIN GetASSOCIATED_RX_ADMIN(int rep) { 
	   return (PEX_P07_ASSOCIATED_RX_ADMIN)this.GetStructure("ASSOCIATED_RX_ADMIN", rep);
	}

    /// <summary>   Gets the associated receive admin repetitions used. </summary>
    ///
    /// <value> The associated receive admin repetitions used. </value>

	public int ASSOCIATED_RX_ADMINRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ASSOCIATED_RX_ADMIN").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of PRB (Problem Detail) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The prb. </returns>

	public PRB GetPRB() {
	   PRB ret = null;
	   try {
	      ret = (PRB)this.GetStructure("PRB");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PRB
    ///  * (Problem Detail) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The prb. </returns>

	public PRB GetPRB(int rep) { 
	   return (PRB)this.GetStructure("PRB", rep);
	}

    /// <summary>   Gets the prb repetitions used. </summary>
    ///
    /// <value> The prb repetitions used. </value>

	public int PRBRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PRB").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The obx. </returns>

	public OBX GetOBX() {
	   OBX ret = null;
	   try {
	      ret = (OBX)this.GetStructure("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of OBX
    ///  * (OBX - observation/result segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The obx. </returns>

	public OBX GetOBX(int rep) { 
	   return (OBX)this.GetStructure("OBX", rep);
	}

    /// <summary>   Gets the obx repetitions used. </summary>
    ///
    /// <value> The obx repetitions used. </value>

	public int OBXRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBX").Length; 
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
