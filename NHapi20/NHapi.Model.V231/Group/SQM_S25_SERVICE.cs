using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the SQM_S25_SERVICE Group.  A Group is an ordered collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: AIS (AIS - appointment information - service segment) </li>
/// <li>1: APR (APR - appointment preferences segment) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class SQM_S25_SERVICE : AbstractGroup {

    /// <summary>   Creates a new SQM_S25_SERVICE Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public SQM_S25_SERVICE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(AIS), true, false);
	      this.add(typeof(APR), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SQM_S25_SERVICE - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns AIS (AIS - appointment information - service segment) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The ais. </value>

	public AIS AIS { 
get{
	   AIS ret = null;
	   try {
	      ret = (AIS)this.GetStructure("AIS");
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

}
}
