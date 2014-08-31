using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V23.Datatype
{
/// <summary>
/// <p>The HL7 CM_RFR (reference range) data type.  Consists of the following components: </p><ol>
/// <li>reference range (CM_RANGE)</li>
/// <li>sex (IS)</li>
/// <li>age range (CM_RANGE)</li>
/// <li>age gestation (CM_RANGE)</li>
/// <li>species (TX)</li>
/// <li>race/subspecies (ST)</li>
/// <li>conditions (TX)</li>
/// </ol>
/// </summary>

[Serializable]
public class CM_RFR : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a CM_RFR. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public CM_RFR(IMessage message) : this(message, null){}

    /// <summary>   Creates a CM_RFR. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public CM_RFR(IMessage message, string description) : base(message, description){
		data = new IType[7];
		data[0] = new CM_RANGE(message,"Reference range");
		data[1] = new IS(message, 0,"Sex");
		data[2] = new CM_RANGE(message,"Age range");
		data[3] = new CM_RANGE(message,"Age gestation");
		data[4] = new TX(message,"Species");
		data[5] = new ST(message,"Race/subspecies");
		data[6] = new TX(message,"Conditions");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 7 element CM_RFR composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns reference range (component #0).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The reference range. </value>

	public CM_RANGE ReferenceRange {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns sex (component #1).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The sex. </value>

	public IS Sex {
get{
	   IS ret = null;
	   try {
	      ret = (IS)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns age range (component #2).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The age range. </value>

	public CM_RANGE AgeRange {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns age gestation (component #3).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The age gestation. </value>

	public CM_RANGE AgeGestation {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns species (component #4).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The species. </value>

	public TX Species {
get{
	   TX ret = null;
	   try {
	      ret = (TX)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns race/subspecies (component #5).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The race subspecies. </value>

	public ST RaceSubspecies {
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

    /// <summary>
    /// Returns conditions (component #6).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The conditions. </value>

	public TX Conditions {
get{
	   TX ret = null;
	   try {
	      ret = (TX)this[6];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}