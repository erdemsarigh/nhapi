using System;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message

{
/// <summary>
/// Represents a PPG_PCG message structure (see chapter ). This structure contains the following
/// elements:
/// <ol>
/// <li>0: MSH (MSH - message header segment) </li>
/// <li>1: PID (PID - patient identification segment) </li>
/// <li>2: PPG_PCG_PATIENT_VISIT (a Group object) optional </li>
/// <li>3: PPG_PCG_PATHWAY (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class PPG_PCG : AbstractMessage  {

    /// <summary>   Creates a new PPG_PCG Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public PPG_PCG(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new PPG_PCG Group with DefaultModelClassFactory. </summary>
	public PPG_PCG() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for PPG_PCG.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PPG_PCG_PATIENT_VISIT), false, false);
	      this.add(typeof(PPG_PCG_PATHWAY), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PPG_PCG - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns MSH (MSH - message header segment) - creates it if necessary. </summary>
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

    /// <summary>
    /// Returns PID (PID - patient identification segment) - creates it if necessary.
    /// </summary>
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

    /// <summary>   Returns PPG_PCG_PATIENT_VISIT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The patient visit. </value>

	public PPG_PCG_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PPG_PCG_PATIENT_VISIT ret = null;
	   try {
	      ret = (PPG_PCG_PATIENT_VISIT)this.GetStructure("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of PPG_PCG_PATHWAY (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The pathway. </returns>

	public PPG_PCG_PATHWAY GetPATHWAY() {
	   PPG_PCG_PATHWAY ret = null;
	   try {
	      ret = (PPG_PCG_PATHWAY)this.GetStructure("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PPG_PCG_PATHWAY
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The pathway. </returns>

	public PPG_PCG_PATHWAY GetPATHWAY(int rep) { 
	   return (PPG_PCG_PATHWAY)this.GetStructure("PATHWAY", rep);
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
