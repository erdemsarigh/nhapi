using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V24.Datatype
{
/// <summary>
/// <p>The HL7 DIN (activation date) data type.  Consists of the following components: </p><ol>
/// <li>date (TS)</li>
/// <li>institution name (CE)</li>
/// </ol>
/// </summary>

[Serializable]
public class DIN : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a DIN. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public DIN(IMessage message) : this(message, null){}

    /// <summary>   Creates a DIN. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public DIN(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new TS(message,"Date");
		data[1] = new CE(message,"Institution name");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element DIN composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns date (component #0).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The date. </value>

	public TS Date {
get{
	   TS ret = null;
	   try {
	      ret = (TS)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns institution name (component #1).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The name of the institution. </value>

	public CE InstitutionName {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}