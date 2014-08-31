using System;
using NHapi.Base.Log;
using NHapi.Model.V23.Group;
using NHapi.Model.V23.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V23.Message

{
/// <summary>
/// Represents a PPP_PCC message structure (see chapter [AAA]). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (Message header segment) </li>
/// <li>1: PID (Patient Identification) </li>
/// <li>2: PPP_PCC_PATIENT_VISIT (a Group object) optional </li>
/// <li>3: PPP_PCC_PATHWAY (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class PPP_PCC : AbstractMessage  {

    /// <summary>   Creates a new PPP_PCC Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public PPP_PCC(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new PPP_PCC Group with DefaultModelClassFactory. </summary>
	public PPP_PCC() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for PPP_PCC.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PPP_PCC_PATIENT_VISIT), false, false);
	      this.add(typeof(PPP_PCC_PATHWAY), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PPP_PCC - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns MSH (Message header segment) - creates it if necessary. </summary>
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

    /// <summary>   Returns PPP_PCC_PATIENT_VISIT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The patient visit. </value>

	public PPP_PCC_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PPP_PCC_PATIENT_VISIT ret = null;
	   try {
	      ret = (PPP_PCC_PATIENT_VISIT)this.GetStructure("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of PPP_PCC_PATHWAY (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The pathway. </returns>

	public PPP_PCC_PATHWAY GetPATHWAY() {
	   PPP_PCC_PATHWAY ret = null;
	   try {
	      ret = (PPP_PCC_PATHWAY)this.GetStructure("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PPP_PCC_PATHWAY
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The pathway. </returns>

	public PPP_PCC_PATHWAY GetPATHWAY(int rep) { 
	   return (PPP_PCC_PATHWAY)this.GetStructure("PATHWAY", rep);
	}

    /// <summary>   Gets the pathway repetitions used. </summary>
    ///
    /// <value> The pathway repetitions used. </value>

	public int PATHWAYRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATHWAY").Length; 
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
