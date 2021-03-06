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
/// Represents a CRM_C03 message structure (see chapter [AAA]). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (Message header segment) </li>
/// <li>1: CRM_C03_PATIENT (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class CRM_C03 : AbstractMessage  {

    /// <summary>   Creates a new CRM_C03 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public CRM_C03(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new CRM_C03 Group with DefaultModelClassFactory. </summary>
	public CRM_C03() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for CRM_C03.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(CRM_C03_PATIENT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CRM_C03 - this is probably a bug in the source code generator.", e);
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

    /// <summary>
    /// Returns  first repetition of CRM_C03_PATIENT (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The patient. </returns>

	public CRM_C03_PATIENT GetPATIENT() {
	   CRM_C03_PATIENT ret = null;
	   try {
	      ret = (CRM_C03_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of CRM_C03_PATIENT
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The patient. </returns>

	public CRM_C03_PATIENT GetPATIENT(int rep) { 
	   return (CRM_C03_PATIENT)this.GetStructure("PATIENT", rep);
	}

    /// <summary>   Gets the patient repetitions used. </summary>
    ///
    /// <value> The patient repetitions used. </value>

	public int PATIENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT").Length; 
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
