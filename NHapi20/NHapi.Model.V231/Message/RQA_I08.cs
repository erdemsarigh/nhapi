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
/// Represents a RQA_I08 message structure (see chapter ). This structure contains the following
/// elements:
/// <ol>
/// <li>0: MSH (MSH - message header segment) </li>
/// <li>1: RF1 (Referral Infomation) optional </li>
/// <li>2: RQA_I08_AUTHORIZATION (a Group object) optional </li>
/// <li>3: RQA_I08_PROVIDER (a Group object) repeating</li>
/// <li>4: PID (PID - patient identification segment) </li>
/// <li>5: NK1 (NK1 - next of kin / associated parties segment-) optional repeating</li>
/// <li>6: RQA_I08_GUARANTOR_INSURANCE (a Group object) optional </li>
/// <li>7: ACC (ACC - accident segment) optional </li>
/// <li>8: DG1 (DG1 - diagnosis segment) optional repeating</li>
/// <li>9: DRG (DRG - diagnosis related group segment) optional repeating</li>
/// <li>10: AL1 (AL1 - patient allergy information segment) optional repeating</li>
/// <li>11: RQA_I08_PROCEDURE (a Group object) optional repeating</li>
/// <li>12: RQA_I08_OBSERVATION (a Group object) optional repeating</li>
/// <li>13: RQA_I08_VISIT (a Group object) optional </li>
/// <li>14: NTE (NTE - notes and comments segment) optional repeating</li>
/// </ol>
/// </summary>

[Serializable]
public class RQA_I08 : AbstractMessage  {

    /// <summary>   Creates a new RQA_I08 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public RQA_I08(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new RQA_I08 Group with DefaultModelClassFactory. </summary>
	public RQA_I08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for RQA_I08.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(RF1), false, false);
	      this.add(typeof(RQA_I08_AUTHORIZATION), false, false);
	      this.add(typeof(RQA_I08_PROVIDER), true, true);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(NK1), false, true);
	      this.add(typeof(RQA_I08_GUARANTOR_INSURANCE), false, false);
	      this.add(typeof(ACC), false, false);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(DRG), false, true);
	      this.add(typeof(AL1), false, true);
	      this.add(typeof(RQA_I08_PROCEDURE), false, true);
	      this.add(typeof(RQA_I08_OBSERVATION), false, true);
	      this.add(typeof(RQA_I08_VISIT), false, false);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RQA_I08 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns RF1 (Referral Infomation) - creates it if necessary. </summary>
    ///
    /// <value> The rf 1. </value>

	public RF1 RF1 { 
get{
	   RF1 ret = null;
	   try {
	      ret = (RF1)this.GetStructure("RF1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns RQA_I08_AUTHORIZATION (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The authorization. </value>

	public RQA_I08_AUTHORIZATION AUTHORIZATION { 
get{
	   RQA_I08_AUTHORIZATION ret = null;
	   try {
	      ret = (RQA_I08_AUTHORIZATION)this.GetStructure("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of RQA_I08_PROVIDER (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The provider. </returns>

	public RQA_I08_PROVIDER GetPROVIDER() {
	   RQA_I08_PROVIDER ret = null;
	   try {
	      ret = (RQA_I08_PROVIDER)this.GetStructure("PROVIDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RQA_I08_PROVIDER
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The provider. </returns>

	public RQA_I08_PROVIDER GetPROVIDER(int rep) { 
	   return (RQA_I08_PROVIDER)this.GetStructure("PROVIDER", rep);
	}

    /// <summary>   Gets the provider repetitions used. </summary>
    ///
    /// <value> The provider repetitions used. </value>

	public int PROVIDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROVIDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
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

    /// <summary>
    /// Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates
    /// it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The nk 1. </returns>

	public NK1 GetNK1() {
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of NK1
    ///  * (NK1 - next of kin / associated parties segment-) - creates it if necessary throws
    ///  HL7Exception if the repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The nk 1. </returns>

	public NK1 GetNK1(int rep) { 
	   return (NK1)this.GetStructure("NK1", rep);
	}

    /// <summary>   Gets the nk 1 repetitions used. </summary>
    ///
    /// <value> The nk 1 repetitions used. </value>

	public int NK1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NK1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns RQA_I08_GUARANTOR_INSURANCE (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <value> The guarantor insurance. </value>

	public RQA_I08_GUARANTOR_INSURANCE GUARANTOR_INSURANCE { 
get{
	   RQA_I08_GUARANTOR_INSURANCE ret = null;
	   try {
	      ret = (RQA_I08_GUARANTOR_INSURANCE)this.GetStructure("GUARANTOR_INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns ACC (ACC - accident segment) - creates it if necessary. </summary>
    ///
    /// <value> The accumulate. </value>

	public ACC ACC { 
get{
	   ACC ret = null;
	   try {
	      ret = (ACC)this.GetStructure("ACC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>
    /// Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The dg 1. </returns>

	public DG1 GetDG1() {
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.GetStructure("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of DG1
    ///  * (DG1 - diagnosis segment) - creates it if necessary throws HL7Exception if the repetition
    ///  requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The dg 1. </returns>

	public DG1 GetDG1(int rep) { 
	   return (DG1)this.GetStructure("DG1", rep);
	}

    /// <summary>   Gets the dg 1 repetitions used. </summary>
    ///
    /// <value> The dg 1 repetitions used. </value>

	public int DG1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DG1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of DRG (DRG - diagnosis related group segment) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The drg. </returns>

	public DRG GetDRG() {
	   DRG ret = null;
	   try {
	      ret = (DRG)this.GetStructure("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of DRG
    ///  * (DRG - diagnosis related group segment) - creates it if necessary throws HL7Exception if
    ///  the repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The drg. </returns>

	public DRG GetDRG(int rep) { 
	   return (DRG)this.GetStructure("DRG", rep);
	}

    /// <summary>   Gets the drg repetitions used. </summary>
    ///
    /// <value> The drg repetitions used. </value>

	public int DRGRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DRG").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if
    /// necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   a l 1. </returns>

	public AL1 GetAL1() {
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.GetStructure("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of AL1
    ///  * (AL1 - patient allergy information segment) - creates it if necessary throws HL7Exception
    ///  if the repetition requested is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   a l 1. </returns>

	public AL1 GetAL1(int rep) { 
	   return (AL1)this.GetStructure("AL1", rep);
	}

    /// <summary>   Gets the al 1 repetitions used. </summary>
    ///
    /// <value> The al 1 repetitions used. </value>

	public int AL1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("AL1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of RQA_I08_PROCEDURE (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The procedure. </returns>

	public RQA_I08_PROCEDURE GetPROCEDURE() {
	   RQA_I08_PROCEDURE ret = null;
	   try {
	      ret = (RQA_I08_PROCEDURE)this.GetStructure("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RQA_I08_PROCEDURE
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The procedure. </returns>

	public RQA_I08_PROCEDURE GetPROCEDURE(int rep) { 
	   return (RQA_I08_PROCEDURE)this.GetStructure("PROCEDURE", rep);
	}

    /// <summary>   Gets the procedure repetitions used. </summary>
    ///
    /// <value> The procedure repetitions used. </value>

	public int PROCEDURERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROCEDURE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>
    /// Returns  first repetition of RQA_I08_OBSERVATION (a Group object) - creates it if necessary.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <returns>   The observation. </returns>

	public RQA_I08_OBSERVATION GetOBSERVATION() {
	   RQA_I08_OBSERVATION ret = null;
	   try {
	      ret = (RQA_I08_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

    /// <summary>
    /// Returns a specific repetition of RQA_I08_OBSERVATION
    ///  * (a Group object) - creates it if necessary throws HL7Exception if the repetition requested
    ///  is more than one
    ///      greater than the number of existing repetitions.
    /// </summary>
    ///
    /// <param name="rep">  The rep. </param>
    ///
    /// <returns>   The observation. </returns>

	public RQA_I08_OBSERVATION GetOBSERVATION(int rep) { 
	   return (RQA_I08_OBSERVATION)this.GetStructure("OBSERVATION", rep);
	}

    /// <summary>   Gets the observation repetitions used. </summary>
    ///
    /// <value> The observation repetitions used. </value>

	public int OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

    /// <summary>   Returns RQA_I08_VISIT (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The visit. </value>

	public RQA_I08_VISIT VISIT { 
get{
	   RQA_I08_VISIT ret = null;
	   try {
	      ret = (RQA_I08_VISIT)this.GetStructure("VISIT");
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

}
}
