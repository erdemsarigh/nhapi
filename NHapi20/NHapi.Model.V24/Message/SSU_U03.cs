using System;
using NHapi.Base.Log;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V24.Message

{
/// <summary>
/// Represents a SSU_U03 message structure (see chapter 13). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (Message Header) </li>
/// <li>1: EQU (Equipment Detail) </li>
/// <li>2: SSU_U03_SPECIMEN_CONTAINER (a Group object) repeating</li>
/// <li>3: ROL (Role) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class SSU_U03 : AbstractMessage  {

    /// <summary>   Creates a new SSU_U03 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public SSU_U03(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new SSU_U03 Group with DefaultModelClassFactory. </summary>
	public SSU_U03() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for SSU_U03.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EQU), true, false);
	      this.add(typeof(SSU_U03_SPECIMEN_CONTAINER), true, true);
	      this.add(typeof(ROL), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SSU_U03 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns MSH (Message Header) - creates it if necessary. </summary>
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

    /// <summary>   Returns EQU (Equipment Detail) - creates it if necessary. </summary>
    ///
    /// <value> The equ. </value>

	public EQU EQU { 
get{
	   EQU ret = null;
	   try {
	      ret = (EQU)this.GetStructure("EQU");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of SSU_U03_SPECIMEN_CONTAINER (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The specimen container. </returns>

	public SSU_U03_SPECIMEN_CONTAINER GetSPECIMEN_CONTAINER() {
	   SSU_U03_SPECIMEN_CONTAINER ret = null;
	   try {
	      ret = (SSU_U03_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of SSU_U03_SPECIMEN_CONTAINER
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The specimen container. </returns>

	public SSU_U03_SPECIMEN_CONTAINER GetSPECIMEN_CONTAINER(int rep) { 
	   return (SSU_U03_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER", rep);
	}

    /// <summary>   Gets the specimen container repetitions used. </summary>
    ///
    /// <value> The specimen container repetitions used. </value>

	public int SPECIMEN_CONTAINERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SPECIMEN_CONTAINER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns ROL (Role) - creates it if necessary. </summary>
    ///
    /// <value> The rol. </value>

	public ROL ROL { 
get{
	   ROL ret = null;
	   try {
	      ret = (ROL)this.GetStructure("ROL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
