using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{
/// <summary>
/// <p>The HL7 CM_RI (interval) data type.  Consists of the following components: </p><ol>
/// <li>repeat pattern (ST)</li>
/// <li>explicit time intevall (ST)</li>
/// </ol>
/// </summary>

[Serializable]
public class CM_RI : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a CM_RI. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public CM_RI(IMessage message) : this(message, null){}

    /// <summary>   Creates a CM_RI. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public CM_RI(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new ST(message,"Repeat pattern");
		data[1] = new ST(message,"Explicit time intevall");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element CM_RI composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns repeat pattern (component #0).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The repeat pattern. </value>

	public ST RepeatPattern {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns explicit time intevall (component #1).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The explicit time intevall. </value>

	public ST ExplicitTimeIntevall {
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