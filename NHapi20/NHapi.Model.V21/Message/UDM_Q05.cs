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
/// Represents a UDM_Q05 message structure (see chapter [AAA]). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: URD (RESULTS/UPDATE DEFINITION) </li>
/// <li>2: URS (UNSOLICITED SELECTION) optional </li>
/// <li>3: DSP (DISPLAY DATA) repeating</li>
/// <li>4: DSC (CONTINUATION POINTER) </li>
/// </ol>
/// </summary>

[Serializable]
public class UDM_Q05 : AbstractMessage  {

    /// <summary>   Creates a new UDM_Q05 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public UDM_Q05(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new UDM_Q05 Group with DefaultModelClassFactory. </summary>
	public UDM_Q05() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for UDM_Q05.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(URD), true, false);
	      this.add(typeof(URS), false, false);
	      this.add(typeof(DSP), true, true);
	      this.add(typeof(DSC), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating UDM_Q05 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns URD (RESULTS/UPDATE DEFINITION) - creates it if necessary. </summary>
    ///
    /// <value> The URD. </value>

	public URD URD { 
get{
	   URD ret = null;
	   try {
	      ret = (URD)this.GetStructure("URD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns URS (UNSOLICITED SELECTION) - creates it if necessary. </summary>
    ///
    /// <value> The urs. </value>

	public URS URS { 
get{
	   URS ret = null;
	   try {
	      ret = (URS)this.GetStructure("URS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns  first repetition of DSP (DISPLAY DATA) - creates it if necessary. </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The DSP. </returns>

	public DSP GetDSP() {
	   DSP ret = null;
	   try {
	      ret = (DSP)this.GetStructure("DSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of DSP
    ///  * (DISPLAY DATA) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The DSP. </returns>

	public DSP GetDSP(int rep) { 
	   return (DSP)this.GetStructure("DSP", rep);
	}

    /// <summary>   Gets the DSP repetitions used. </summary>
    ///
    /// <value> The DSP repetitions used. </value>

	public int DSPRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DSP").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns DSC (CONTINUATION POINTER) - creates it if necessary. </summary>
    ///
    /// <value> The dsc. </value>

	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
