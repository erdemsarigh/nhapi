using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V231.Datatype
{
/// <summary>
/// <p>The HL7 CF (coded element with formatted values) data type.  Consists of the following
/// components: </p><ol>
/// <li>identifier (ST)</li>
/// <li>formatted text (FT)</li>
/// <li>name of coding system (ST)</li>
/// <li>alternate identifier (ST)</li>
/// <li>alternate formatted text (FT)</li>
/// <li>name of alternate coding system (ST)</li>
/// </ol>
/// </summary>

[Serializable]
public class CF : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a CF. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public CF(IMessage message) : this(message, null){}

    /// <summary>   Creates a CF. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public CF(IMessage message, string description) : base(message, description){
		data = new IType[6];
		data[0] = new ST(message,"Identifier");
		data[1] = new FT(message,"Formatted text");
		data[2] = new ST(message,"Name of coding system");
		data[3] = new ST(message,"Alternate identifier");
		data[4] = new FT(message,"Alternate formatted text");
		data[5] = new ST(message,"Name of alternate coding system");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 6 element CF composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns identifier (component #0).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier. </value>

	public ST Identifier {
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
    /// Returns formatted text (component #1).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The formatted text. </value>

	public FT FormattedText {
get{
	   FT ret = null;
	   try {
	      ret = (FT)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns name of coding system (component #2).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The Name of the coding system. </value>

	public ST NameOfCodingSystem {
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

    /// <summary>
    /// Returns alternate identifier (component #3).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the alternate. </value>

	public ST AlternateIdentifier {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns alternate formatted text (component #4).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The alternate formatted text. </value>

	public FT AlternateFormattedText {
get{
	   FT ret = null;
	   try {
	      ret = (FT)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns name of alternate coding system (component #5).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The Name of the alternate coding system. </value>

	public ST NameOfAlternateCodingSystem {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[5];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}