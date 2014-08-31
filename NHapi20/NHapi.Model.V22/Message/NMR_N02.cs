using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V22.Message

{
/// <summary>
/// Represents a NMR_N02 message structure (see chapter [AAA]). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: MSA (MESSAGE ACKNOWLEDGMENT) </li>
/// <li>2: ERR (ERROR) optional </li>
/// <li>3: QRD (QUERY DEFINITION) optional </li>
/// <li>4: NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class NMR_N02 : AbstractMessage  {

    /// <summary>   Creates a new NMR_N02 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public NMR_N02(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new NMR_N02 Group with DefaultModelClassFactory. </summary>
	public NMR_N02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for NMR_N02.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(QRD), false, false);
	      this.add(typeof(NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating NMR_N02 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary. </summary>
    ///
    /// <value> The msa. </value>

	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns ERR (ERROR) - creates it if necessary. </summary>
    ///
    /// <value> The error. </value>

	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.GetStructure("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns QRD (QUERY DEFINITION) - creates it if necessary. </summary>
    ///
    /// <value> The qrd. </value>

	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT (a Group object) -
    /// creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The clock and stats with notes alternate. </returns>

	public NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT GetCLOCK_AND_STATS_WITH_NOTES_ALT() {
	   NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT ret = null;
	   try {
	      ret = (NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT)this.GetStructure("CLOCK_AND_STATS_WITH_NOTES_ALT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The clock and stats with notes alternate. </returns>

	public NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT GetCLOCK_AND_STATS_WITH_NOTES_ALT(int rep) { 
	   return (NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT)this.GetStructure("CLOCK_AND_STATS_WITH_NOTES_ALT", rep);
	}

    /// <summary>   Gets the clock and stats with notes alternate repetitions used. </summary>
    ///
    /// <value> The clock and stats with notes alternate repetitions used. </value>

	public int CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CLOCK_AND_STATS_WITH_NOTES_ALT").Length; 
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
