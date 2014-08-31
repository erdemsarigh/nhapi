using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V23.Datatype
{
/// <summary>
/// <p>The HL7 XTN (extended telecommunication number) data type.  Consists of the following
/// components: </p><ol>
/// <li>[(999)] 999-9999 [X99999][C any text] (TN)</li>
/// <li>telecommunication use code (ID)</li>
/// <li>telecommunication equipment type (ID) (ID)</li>
/// <li>Email address (ST)</li>
/// <li>Country Code (NM)</li>
/// <li>Area/city code (NM)</li>
/// <li>Phone number (NM)</li>
/// <li>Extension (NM)</li>
/// <li>any text (ST)</li>
/// </ol>
/// </summary>

[Serializable]
public class XTN : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a XTN. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public XTN(IMessage message) : this(message, null){}

    /// <summary>   Creates a XTN. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public XTN(IMessage message, string description) : base(message, description){
		data = new IType[9];
		data[0] = new TN(message,"[(999)] 999-9999 [X99999][C any text]");
		data[1] = new ID(message, 0,"Telecommunication use code");
		data[2] = new ID(message, 0,"Telecommunication equipment type (ID)");
		data[3] = new ST(message,"Email address");
		data[4] = new NM(message,"Country Code");
		data[5] = new NM(message,"Area/city code");
		data[6] = new NM(message,"Phone number");
		data[7] = new NM(message,"Extension");
		data[8] = new ST(message,"Any text");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 9 element XTN composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns [(999)] 999-9999 [X99999][C any text] (component #0).  This is a convenience method
    /// that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The get 9999999 x coordinate 99999 c any text. </value>

	public TN Get9999999X99999CAnyText {
get{
	   TN ret = null;
	   try {
	      ret = (TN)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns telecommunication use code (component #1).  This is a convenience method that saves
    /// you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The telecommunication use code. </value>

	public ID TelecommunicationUseCode {
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
    /// Returns telecommunication equipment type (ID) (component #2).  This is a convenience method
    /// that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The type of the telecommunication equipment. </value>

	public ID TelecommunicationEquipmentType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Email address (component #3).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The email address. </value>

	public ST EmailAddress {
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
    /// Returns Country Code (component #4).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The total number of ry code. </value>

	public NM CountryCode {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Area/city code (component #5).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The area city code. </value>

	public NM AreaCityCode {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[5];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Phone number (component #6).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The phone number. </value>

	public NM PhoneNumber {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[6];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Extension (component #7).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The extension. </value>

	public NM Extension {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[7];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns any text (component #8).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> any text. </value>

	public ST AnyText {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[8];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}