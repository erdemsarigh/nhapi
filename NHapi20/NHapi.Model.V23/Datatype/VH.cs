using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V23.Datatype
{
/// <summary>
/// <p>The HL7 VH (visiting hours) data type.  Consists of the following components: </p><ol>
/// <li>start day range (ID)</li>
/// <li>end day range (ID)</li>
/// <li>start hour range (TM)</li>
/// <li>end hour range (TM)</li>
/// </ol>
/// </summary>

[Serializable]
public class VH : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a VH. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public VH(IMessage message) : this(message, null){}

    /// <summary>   Creates a VH. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public VH(IMessage message, string description) : base(message, description){
		data = new IType[4];
		data[0] = new ID(message, 0,"Start day range");
		data[1] = new ID(message, 0,"End day range");
		data[2] = new TM(message,"Start hour range");
		data[3] = new TM(message,"End hour range");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 4 element VH composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns start day range (component #0).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The start day range. </value>

	public ID StartDayRange {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns end day range (component #1).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The end day range. </value>

	public ID EndDayRange {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns start hour range (component #2).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The start hour range. </value>

	public TM StartHourRange {
get{
	   TM ret = null;
	   try {
	      ret = (TM)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns end hour range (component #3).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The end hour range. </value>

	public TM EndHourRange {
get{
	   TM ret = null;
	   try {
	      ret = (TM)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}