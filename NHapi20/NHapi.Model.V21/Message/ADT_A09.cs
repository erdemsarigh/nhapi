using System;
using NHapi.Base.Log;
using NHapi.Model.V21.Group;
using NHapi.Model.V21.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V21.Message

{
/// <summary>
/// Represents a ADT_A09 message structure (see chapter [AAA]). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: EVN (EVENT TYPE) </li>
/// <li>2: PID (PATIENT IDENTIFICATION) </li>
/// <li>3: PV1 (PATIENT VISIT) </li>
/// <li>4: DG1 (DIAGNOSIS) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class ADT_A09 : AbstractMessage  {

    /// <summary>   Creates a new ADT_A09 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public ADT_A09(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new ADT_A09 Group with DefaultModelClassFactory. </summary>
	public ADT_A09() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for ADT_A09.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EVN), true, false);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PV1), true, false);
	      this.add(typeof(DG1), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADT_A09 - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>
    /// Returns the version number.  This default implementation inspects this.GetClass().getName().
    /// This should be overridden if you are putting a custom message definition in your own package,
    /// or it will default.
    /// </summary>
    ///
    /// <value> s 2.4 if not obvious from package name. </value>

	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}

    /// <summary>   Returns MSH (MESSAGE HEADER) - creates it if necessary. </summary>
    ///
    /// <value> The msh. </value>

	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns EVN (EVENT TYPE) - creates it if necessary. </summary>
    ///
    /// <value> The evn. </value>

	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.GetStructure("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns PID (PATIENT IDENTIFICATION) - creates it if necessary. </summary>
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

    /// <summary>   Returns PV1 (PATIENT VISIT) - creates it if necessary. </summary>
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

    /// <summary>   Returns DG1 (DIAGNOSIS) - creates it if necessary. </summary>
    ///
    /// <value> The dg 1. </value>

	public DG1 DG1 { 
get{
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.GetStructure("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
