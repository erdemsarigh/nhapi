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
/// Represents a NMQ_N02 message structure (see chapter [AAA]). This structure contains the
/// following elements:
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: NMQ_N02_QRY_WITH_DETAIL (a Group object) optional </li>
/// <li>2: NMQ_N02_CLOCK_AND_STATISTICS (a Group object) repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class NMQ_N02 : AbstractMessage  {

    /// <summary>   Creates a new NMQ_N02 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public NMQ_N02(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new NMQ_N02 Group with DefaultModelClassFactory. </summary>
	public NMQ_N02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for NMQ_N02.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(NMQ_N02_QRY_WITH_DETAIL), false, false);
	      this.add(typeof(NMQ_N02_CLOCK_AND_STATISTICS), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating NMQ_N02 - this is probably a bug in the source code generator.", e);
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

    /// <summary>
    /// Returns NMQ_N02_QRY_WITH_DETAIL (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The query with detail. </value>

	public NMQ_N02_QRY_WITH_DETAIL QRY_WITH_DETAIL { 
get{
	   NMQ_N02_QRY_WITH_DETAIL ret = null;
	   try {
	      ret = (NMQ_N02_QRY_WITH_DETAIL)this.GetStructure("QRY_WITH_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of NMQ_N02_CLOCK_AND_STATISTICS (a Group object) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The clock and statistics. </returns>

	public NMQ_N02_CLOCK_AND_STATISTICS GetCLOCK_AND_STATISTICS() {
	   NMQ_N02_CLOCK_AND_STATISTICS ret = null;
	   try {
	      ret = (NMQ_N02_CLOCK_AND_STATISTICS)this.GetStructure("CLOCK_AND_STATISTICS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NMQ_N02_CLOCK_AND_STATISTICS
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The clock and statistics. </returns>

	public NMQ_N02_CLOCK_AND_STATISTICS GetCLOCK_AND_STATISTICS(int rep) { 
	   return (NMQ_N02_CLOCK_AND_STATISTICS)this.GetStructure("CLOCK_AND_STATISTICS", rep);
	}

    /// <summary>   Gets the clock and statistics repetitions used. </summary>
    ///
    /// <value> The clock and statistics repetitions used. </value>

	public int CLOCK_AND_STATISTICSRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CLOCK_AND_STATISTICS").Length; 
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
