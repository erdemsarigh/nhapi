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
/// Represents a QBP_Z73 message structure (see chapter 4). This structure contains the following
/// elements:
/// <ol>
/// <li>0: MSH (Message Header) </li>
/// <li>1: QPD (Query Parameter Definition) </li>
/// <li>2: RCP (Response Control Parameter) </li>
/// </ol>
/// </summary>

[Serializable]
public class QBP_Z73 : AbstractMessage  {

    /// <summary>   Creates a new QBP_Z73 Group with custom IModelClassFactory. </summary>
    ///
    /// <param name="factory">  The factory. </param>

	public QBP_Z73(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

    /// <summary>   Creates a new QBP_Z73 Group with DefaultModelClassFactory. </summary>
	public QBP_Z73() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

    /// <summary>
    /// initalize method for QBP_Z73.  This does the segment setup for the message.
    /// </summary>
    ///
    /// <param name="factory">  The factory. </param>

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(QPD), true, false);
	      this.add(typeof(RCP), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating QBP_Z73 - this is probably a bug in the source code generator.", e);
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

}
}
