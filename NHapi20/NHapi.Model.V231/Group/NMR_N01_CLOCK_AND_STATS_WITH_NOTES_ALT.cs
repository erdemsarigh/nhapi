using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
/// <summary>
/// Represents the NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT Group.  A Group is an ordered
/// collection of message
///  segments that can repeat together or be optionally in/excluded together. This Group contains
///  the following elements:
/// <ol>
/// <li>0: NCK (System Clock) optional </li>
/// <li>1: NTE (NTE - notes and comments segment) optional repeating</li>
/// <li>2: NST (Application control level statistics) optional </li>
/// <li>3: NTE (NTE - notes and comments segment) optional repeating</li>
/// <li>4: NSC (Application status change) optional </li>
/// <li>5: NTE (NTE - notes and comments segment) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT : AbstractGroup {

    /// <summary>   Creates a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT Group. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NCK), false, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(NST), false, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(NSC), false, false);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT - this is probably a bug in the source code generator.", e);
	   }
	}

    /// <summary>   Returns NCK (System Clock) - creates it if necessary. </summary>
    ///
    /// <value> The nck. </value>

	public NCK NCK { 
get{
	   NCK ret = null;
	   try {
	      ret = (NCK)this.GetStructure("NCK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The nte. </returns>

	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NTE
    ///  * (NTE - notes and comments segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The nte. </returns>

	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

    /// <summary>   Gets the nte repetitions used. </summary>
    ///
    /// <value> The nte repetitions used. </value>

	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns NST (Application control level statistics) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The nst. </value>

	public NST NST { 
get{
	   NST ret = null;
	   try {
	      ret = (NST)this.GetStructure("NST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of NTE2 (NTE - notes and comments segment) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The nte 2. </returns>

	public NTE GetNTE2() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NTE2
    ///  * (NTE - notes and comments segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The nte 2. </returns>

	public NTE GetNTE2(int rep) { 
	   return (NTE)this.GetStructure("NTE2", rep);
	}

    /// <summary>   Gets the nte 2 repetitions used. </summary>
    ///
    /// <value> The nte 2 repetitions used. </value>

	public int NTE2RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE2").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns NSC (Application status change) - creates it if necessary. </summary>
    ///
    /// <value> The nsc. </value>

	public NSC NSC { 
get{
	   NSC ret = null;
	   try {
	      ret = (NSC)this.GetStructure("NSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of NTE3 (NTE - notes and comments segment) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The nte 3. </returns>

	public NTE GetNTE3() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NTE3
    ///  * (NTE - notes and comments segment) - creates it if necessary throws HL7Exception if the
    ///  repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The nte 3. </returns>

	public NTE GetNTE3(int rep) { 
	   return (NTE)this.GetStructure("NTE3", rep);
	}

    /// <summary>   Gets the nte 3 repetitions used. </summary>
    ///
    /// <value> The nte 3 repetitions used. </value>

	public int NTE3RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE3").Length; 
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
