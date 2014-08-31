using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V23.Datatype
{
/// <summary>
/// <p>The HL7 CM_PRL (parent result link) data type.  Consists of the following components:
/// </p><ol>
/// <li>OBX-3 observation identifier of parent result (CE)</li>
/// <li>OBX-4 sub-ID of parent result (ST)</li>
/// <li>part of OBX-5 observation result from parent (TX)</li>
/// </ol>
/// </summary>

[Serializable]
public class CM_PRL : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a CM_PRL. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public CM_PRL(IMessage message) : this(message, null){}

    /// <summary>   Creates a CM_PRL. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public CM_PRL(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new CE(message,"OBX-3 observation identifier of parent result");
		data[1] = new ST(message,"OBX-4 sub-ID of parent result");
		data[2] = new TX(message,"Part of OBX-5 observation result from parent");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element CM_PRL composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns OBX-3 observation identifier of parent result (component #0).  This is a convenience
    /// method that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The obx 3 observation identifier of parent result. </value>

	public CE OBX3ObservationIdentifierOfParentResult {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns OBX-4 sub-ID of parent result (component #1).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The obx 4 sub identifier of parent result. </value>

	public ST OBX4SubIDOfParentResult {
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
    /// Returns part of OBX-5 observation result from parent (component #2).  This is a convenience
    /// method that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The part of obx 5 observation result from parent. </value>

	public TX PartOfOBX5ObservationResultFromParent {
get{
	   TX ret = null;
	   try {
	      ret = (TX)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}