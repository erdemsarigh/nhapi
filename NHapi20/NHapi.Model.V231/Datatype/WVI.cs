using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V231.Datatype
{
/// <summary>
/// <p>The HL7 WVI (channel identifier) data type.  Consists of the following components: </p><ol>
/// <li>Channel Number (NM)</li>
/// <li>Channel Name (ST)</li>
/// </ol>
/// </summary>

[Serializable]
public class WVI : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a WVI. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public WVI(IMessage message) : this(message, null){}

    /// <summary>   Creates a WVI. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public WVI(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new NM(message,"Channel Number");
		data[1] = new ST(message,"Channel Name");
	}

    /// <summary>   Returns an array containing the data elements. </summary>
    ///
    /// <value> The components. </value>

	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

    /// <summary>
    /// Returns an individual data component.
    /// @throws DataTypeException if the given element number is out of range.
    /// </summary>
    ///
    /// <param name="index">    The index item to get (zero based) </param>
    ///
    /// <returns>   The data component (as a type) at the requested number (ordinal) </returns>

	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element WVI composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns Channel Number (component #0).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The channel number. </value>

	public NM ChannelNumber {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Channel Name (component #1).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The name of the channel. </value>

	public ST ChannelName {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}