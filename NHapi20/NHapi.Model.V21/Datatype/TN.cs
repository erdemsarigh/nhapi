using System;
using NHapi.Base.Model;
using NHapi.Base;
using NHapi.Base.Model.Primitive;
namespace NHapi.Model.V21.Datatype
{
/// <summary>
/// Represents the HL7 TN (telephone number) datatype.  A TN contains a single String value.
/// </summary>

[Serializable]
public class TN : AbstractPrimitive  {

    /// <summary>   Constructs an uninitialized TN. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public TN(IMessage message) : base(message){
	}

    /// <summary>   Constructs an uninitialized TN. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public TN(IMessage message, string description) : base(message,description){
	}

    /// <summary>   @return "2.1". </summary>
    ///
    /// <returns>   The version. </returns>

	public string getVersion() {
	    return "2.1";
}
}
}