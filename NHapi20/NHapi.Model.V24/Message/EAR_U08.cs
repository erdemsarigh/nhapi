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
/// Represents a EAR_U08 message structure (see chapter 13). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (Message Header) </li>
/// <li>1: EQU (Equipment Detail) </li>
/// <li>2: EAR_U08_COMMAND_RESPONSE (a Group object) repeating</li>
/// <li>3: ROL (Role) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class EAR_U08 : AbstractMessage  {

    /// <summary>   Creates a new EAR_U08 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public EAR_U08(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new EAR_U08 Group with DefaultModelClassFactory. </summary>
	public EAR_U08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for EAR_U08.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EQU), true, false);
	      this.add(typeof(EAR_U08_COMMAND_RESPONSE), true, true);
	      this.add(typeof(ROL), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating EAR_U08 - this is probably a bug in the source code generator.", e);
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
    /// Returns  first repetition of EAR_U08_COMMAND_RESPONSE (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The command response. </returns>

	public EAR_U08_COMMAND_RESPONSE GetCOMMAND_RESPONSE() {
	   EAR_U08_COMMAND_RESPONSE ret = null;
	   try {
	      ret = (EAR_U08_COMMAND_RESPONSE)this.GetStructure("COMMAND_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of EAR_U08_COMMAND_RESPONSE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The command response. </returns>

	public EAR_U08_COMMAND_RESPONSE GetCOMMAND_RESPONSE(int rep) { 
	   return (EAR_U08_COMMAND_RESPONSE)this.GetStructure("COMMAND_RESPONSE", rep);
	}

    /// <summary>   Gets the command response repetitions used. </summary>
    ///
    /// <value> The command response repetitions used. </value>

	public int COMMAND_RESPONSERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("COMMAND_RESPONSE").Length; 
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
