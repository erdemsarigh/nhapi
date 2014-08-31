using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V24.Datatype
{
/// <summary>
/// <p>The HL7 CK (composite ID with check digit) data type.  Consists of the following
/// components: </p><ol>
/// <li>ID number (NM) (NM)</li>
/// <li>check digit (NM) (NM)</li>
/// <li>code identifying the check digit scheme employed (ID)</li>
/// <li>assigning authority (HD)</li>
/// </ol>
/// </summary>

[Serializable]
public class CK : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a CK. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public CK(IMessage message) : this(message, null){}

    /// <summary>   Creates a CK. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public CK(IMessage message, string description) : base(message, description){
		data = new IType[4];
		data[0] = new NM(message,"ID number (NM)");
		data[1] = new NM(message,"Check digit (NM)");
		data[2] = new ID(message, 0,"Code identifying the check digit scheme employed");
		data[3] = new HD(message,"Assigning authority");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 4 element CK composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns ID number (NM) (component #0).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier number. </value>

	public NM IDNumber {
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
    /// Returns check digit (NM) (component #1).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The check digit. </value>

	public NM CheckDigit {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns code identifying the check digit scheme employed (component #2).  This is a
    /// convenience method that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The code identifying the check digit scheme employed. </value>

	public ID CodeIdentifyingTheCheckDigitSchemeEmployed {
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
    /// Returns assigning authority (component #3).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The assigning authority. </value>

	public HD AssigningAuthority {
get{
	   HD ret = null;
	   try {
	      ret = (HD)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}