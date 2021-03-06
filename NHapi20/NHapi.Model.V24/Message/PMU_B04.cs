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
/// Represents a PMU_B04 message structure (see chapter 15). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (Message Header) </li>
/// <li>1: EVN (Event Type) </li>
/// <li>2: STF (Staff Identification) </li>
/// <li>3: PRA (Practitioner Detail) optional repeating</li>
/// <li>4: ORG (Practitioner Organization Unit) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class PMU_B04 : AbstractMessage  {

    /// <summary>   Creates a new PMU_B04 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public PMU_B04(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new PMU_B04 Group with DefaultModelClassFactory. </summary>
	public PMU_B04() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for PMU_B04.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EVN), true, false);
	      this.add(typeof(STF), true, false);
	      this.add(typeof(PRA), false, true);
	      this.add(typeof(ORG), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PMU_B04 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns EVN (Event Type) - creates it if necessary. </summary>
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

    /// <summary>   Returns STF (Staff Identification) - creates it if necessary. </summary>
    ///
    /// <value> The stf. </value>

	public STF STF { 
get{
	   STF ret = null;
	   try {
	      ret = (STF)this.GetStructure("STF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of PRA (Practitioner Detail) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The pra. </returns>

	public PRA GetPRA() {
	   PRA ret = null;
	   try {
	      ret = (PRA)this.GetStructure("PRA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of PRA
    ///  * (Practitioner Detail) - creates it if necessary throws HL7Exception if the repetition
    ///  requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The pra. </returns>

	public PRA GetPRA(int rep) { 
	   return (PRA)this.GetStructure("PRA", rep);
	}

    /// <summary>   Gets the pra repetitions used. </summary>
    ///
    /// <value> The pra repetitions used. </value>

	public int PRARepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PRA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns ORG (Practitioner Organization Unit) - creates it if necessary. </summary>
    ///
    /// <value> The organisation. </value>

	public ORG ORG { 
get{
	   ORG ret = null;
	   try {
	      ret = (ORG)this.GetStructure("ORG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
