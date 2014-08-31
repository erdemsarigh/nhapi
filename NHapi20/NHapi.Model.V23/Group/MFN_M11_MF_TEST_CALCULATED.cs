using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
/// <summary>
/// Represents the MFN_M11_MF_TEST_CALCULATED Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: MFE (Master file entry segment) </li>
/// <li>1: OM1 (General - fields that apply to most observations) </li>
/// <li>2: MFN_M11_MF_TEST_CALC_DETAIL (a Group object) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M11_MF_TEST_CALCULATED : AbstractGroup {

    /// <summary>   Creates a new MFN_M11_MF_TEST_CALCULATED Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public MFN_M11_MF_TEST_CALCULATED(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(OM1), true, false);
	      this.add(typeof(MFN_M11_MF_TEST_CALC_DETAIL), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M11_MF_TEST_CALCULATED - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns MFE (Master file entry segment) - creates it if necessary. </summary>
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

    /// <summary>
    /// Returns OM1 (General - fields that apply to most observations) - creates it if necessary.
    /// </summary>
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

    /// <summary>
    /// Returns MFN_M11_MF_TEST_CALC_DETAIL (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The mf test calculate detail. </value>

	public MFN_M11_MF_TEST_CALC_DETAIL MF_TEST_CALC_DETAIL { 
get{
	   MFN_M11_MF_TEST_CALC_DETAIL ret = null;
	   try {
	      ret = (MFN_M11_MF_TEST_CALC_DETAIL)this.GetStructure("MF_TEST_CALC_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
