using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the ORM_O01_ORDER Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: ORC (ORC - common order segment) </li>
/// <li>1: ORM_O01_ORDER_DETAIL (a Group object) optional </li>
/// <li>2: CTI (CTI - clinical trial identification segment) optional repeating</li>
/// <li>3: BLG (BLG - billing segment) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class ORM_O01_ORDER : AbstractGroup {

    /// <summary>   Creates a new ORM_O01_ORDER Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public ORM_O01_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(ORM_O01_ORDER_DETAIL), false, false);
	      this.add(typeof(CTI), false, true);
	      this.add(typeof(BLG), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORM_O01_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns ORC (ORC - common order segment) - creates it if necessary. </summary>
    ///
    /// <value> The orc. </value>

	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns ORM_O01_ORDER_DETAIL (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The order detail. </value>

	public ORM_O01_ORDER_DETAIL ORDER_DETAIL { 
get{
	   ORM_O01_ORDER_DETAIL ret = null;
	   try {
	      ret = (ORM_O01_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of CTI (CTI - clinical trial identification segment) - creates it
    /// if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The cti. </returns>

	public CTI GetCTI() {
	   CTI ret = null;
	   try {
	      ret = (CTI)this.GetStructure("CTI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CTI
    ///  * (CTI - clinical trial identification segment) - creates it if necessary throws
    ///  HL7Exception if the repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The cti. </returns>

	public CTI GetCTI(int rep) { 
	   return (CTI)this.GetStructure("CTI", rep);
	}

    /// <summary>   Gets the cti repetitions used. </summary>
    ///
    /// <value> The cti repetitions used. </value>

	public int CTIRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CTI").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns BLG (BLG - billing segment) - creates it if necessary. </summary>
    ///
    /// <value> The blg. </value>

	public BLG BLG { 
get{
	   BLG ret = null;
	   try {
	      ret = (BLG)this.GetStructure("BLG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
