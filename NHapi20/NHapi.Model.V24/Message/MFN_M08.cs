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
/// Represents a MFN_M08 message structure (see chapter 8). This structure contains the following
/// elements:
/// <ol>
/// <li>0: MSH (Message Header) </li>
/// <li>1: MFI (Master File Identification) </li>
/// <li>2: MFN_M08_MF_TEST_NUMERIC (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class MFN_M08 : AbstractMessage  {

    /// <summary>   Creates a new MFN_M08 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public MFN_M08(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new MFN_M08 Group with DefaultModelClassFactory. </summary>
	public MFN_M08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for MFN_M08.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MFI), true, false);
	      this.add(typeof(MFN_M08_MF_TEST_NUMERIC), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M08 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns MFI (Master File Identification) - creates it if necessary. </summary>
    ///
    /// <value> The mfi. </value>

	public MFI MFI { 
get{
	   MFI ret = null;
	   try {
	      ret = (MFI)this.GetStructure("MFI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of MFN_M08_MF_TEST_NUMERIC (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The mf test numeric. </returns>

	public MFN_M08_MF_TEST_NUMERIC GetMF_TEST_NUMERIC() {
	   MFN_M08_MF_TEST_NUMERIC ret = null;
	   try {
	      ret = (MFN_M08_MF_TEST_NUMERIC)this.GetStructure("MF_TEST_NUMERIC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of MFN_M08_MF_TEST_NUMERIC
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The mf test numeric. </returns>

	public MFN_M08_MF_TEST_NUMERIC GetMF_TEST_NUMERIC(int rep) { 
	   return (MFN_M08_MF_TEST_NUMERIC)this.GetStructure("MF_TEST_NUMERIC", rep);
	}

    /// <summary>   Gets the mf test numeric repetitions used. </summary>
    ///
    /// <value> The mf test numeric repetitions used. </value>

	public int MF_TEST_NUMERICRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MF_TEST_NUMERIC").Length; 
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
