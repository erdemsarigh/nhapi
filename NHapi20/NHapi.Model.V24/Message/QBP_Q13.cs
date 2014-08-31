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
/// Represents a QBP_Q13 message structure (see chapter 5). This structure contains the following
/// elements:
/// <ol>
/// <li>0: MSH (Message Header) </li>
/// <li>1: QPD (Query Parameter Definition) </li>
/// <li>2: QBP_Q13_QBP (a Group object) optional </li>
/// <li>3: RDF (Table Row Definition) optional </li>
/// <li>4: RCP (Response Control Parameter) </li>
/// <li>5: DSC (Continuation Pointer) optional </li>
/// </ol>
/// </summary>

[Serializable]
public class QBP_Q13 : AbstractMessage  {

    /// <summary>   Creates a new QBP_Q13 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public QBP_Q13(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new QBP_Q13 Group with DefaultModelClassFactory. </summary>
	public QBP_Q13() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for QBP_Q13.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(QPD), true, false);
	      this.add(typeof(QBP_Q13_QBP), false, false);
	      this.add(typeof(RDF), false, false);
	      this.add(typeof(RCP), true, false);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating QBP_Q13 - this is probably a bug in the source code generator.", e);
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

    /// <summary>   Returns QPD (Query Parameter Definition) - creates it if necessary. </summary>
    ///
    /// <value> The qpd. </value>

	public QPD QPD { 
get{
	   QPD ret = null;
	   try {
	      ret = (QPD)this.GetStructure("QPD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns QBP_Q13_QBP (a Group object) - creates it if necessary. </summary>
    ///
    /// <value> The qbp. </value>

	public QBP_Q13_QBP QBP { 
get{
	   QBP_Q13_QBP ret = null;
	   try {
	      ret = (QBP_Q13_QBP)this.GetStructure("QBP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns RDF (Table Row Definition) - creates it if necessary. </summary>
    ///
    /// <value> The rdf. </value>

	public RDF RDF { 
get{
	   RDF ret = null;
	   try {
	      ret = (RDF)this.GetStructure("RDF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns RCP (Response Control Parameter) - creates it if necessary. </summary>
    ///
    /// <value> The rcp. </value>

	public RCP RCP { 
get{
	   RCP ret = null;
	   try {
	      ret = (RCP)this.GetStructure("RCP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

    /// <summary>   Returns DSC (Continuation Pointer) - creates it if necessary. </summary>
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
