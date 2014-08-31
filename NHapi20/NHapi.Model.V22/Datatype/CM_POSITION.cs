using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{
/// <summary>
/// <p>The HL7 CM_POSITION (Sitzplatz bzw. Saal / Tisch / Stuhl) data type.  Consists of the
/// following components: </p><ol>
/// <li>Saal (ST)</li>
/// <li>Tisch (ST)</li>
/// <li>Stuhl (ST)</li>
/// </ol>
/// </summary>

[Serializable]
public class CM_POSITION : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a CM_POSITION. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public CM_POSITION(IMessage message) : this(message, null){}

    /// <summary>   Creates a CM_POSITION. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public CM_POSITION(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new ST(message,"Saal");
		data[1] = new ST(message,"Tisch");
		data[2] = new ST(message,"Stuhl");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element CM_POSITION composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns Saal (component #0).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The saal. </value>

	public ST Saal {
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
    /// Returns Tisch (component #1).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The tisch. </value>

	public ST Tisch {
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

    /// <summary>
    /// Returns Stuhl (component #2).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The stuhl. </value>

	public ST Stuhl {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}