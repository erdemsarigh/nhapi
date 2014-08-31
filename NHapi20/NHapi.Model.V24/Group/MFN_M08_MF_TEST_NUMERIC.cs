using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
/// <summary>
/// Represents the MFN_M08_MF_TEST_NUMERIC Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: MFE (Master File Entry) </li>
/// <li>1: OM1 (General Segment) </li>
/// <li>2: OM2 (Numeric Observation) optional </li>
/// <li>3: OM3 (Categorical Service/Test/Observation) optional </li>
/// <li>4: OM4 (Observations that Require Specimens) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M08_MF_TEST_NUMERIC : AbstractGroup {

    /// <summary>   Creates a new MFN_M08_MF_TEST_NUMERIC Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MFN_M08_MF_TEST_NUMERIC(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(OM1), true, false);
	      this.add(typeof(OM2), false, false);
	      this.add(typeof(OM3), false, false);
	      this.add(typeof(OM4), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M08_MF_TEST_NUMERIC - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns MFE (Master File Entry) - creates it if necessary. </summary>
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

    /// <summary>   Returns OM1 (General Segment) - creates it if necessary. </summary>
    ///
    /// <value> The om 1. </value>

	public OM1 OM1 { 
get{
	   OM1 ret = null;
	   try {
	      ret = (OM1)this.GetStructure("OM1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns OM2 (Numeric Observation) - creates it if necessary. </summary>
    ///
    /// <value> The om 2. </value>

	public OM2 OM2 { 
get{
	   OM2 ret = null;
	   try {
	      ret = (OM2)this.GetStructure("OM2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns OM3 (Categorical Service/Test/Observation) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The om 3. </value>

	public OM3 OM3 { 
get{
	   OM3 ret = null;
	   try {
	      ret = (OM3)this.GetStructure("OM3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns OM4 (Observations that Require Specimens) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The om 4. </value>

	public OM4 OM4 { 
get{
	   OM4 ret = null;
	   try {
	      ret = (OM4)this.GetStructure("OM4");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
