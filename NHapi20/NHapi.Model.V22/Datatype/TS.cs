using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{
/// <summary>
/// <p>The HL7 TS (time stamp) data type.  Consists of the following components: </p><ol>
/// <li>time of an event (TSComponentOne)</li>
/// <li>degree of precision (ST)</li>
/// </ol>
/// </summary>

[Serializable]
public class TS : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a TS. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public TS(IMessage message) : this(message, null){}

    /// <summary>   Creates a TS. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public TS(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new TSComponentOne(message,"Time of an event");
		data[1] = new ST(message,"Degree of precision");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element TS composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns time of an event (component #0).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The time of an event. </value>

	public TSComponentOne TimeOfAnEvent {
get{
	   TSComponentOne ret = null;
	   try {
	      ret = (TSComponentOne)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns degree of precision (component #1).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The degree of precision. </value>

	public ST DegreeOfPrecision {
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