using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V231.Datatype
{
/// <summary>
/// <p>The HL7 OSD (order sequence) data type.  Consists of the following components: </p><ol>
/// <li>sequence/results flag (ID)</li>
/// <li>placer order number: entity identifier (ST)</li>
/// <li>placer order number: namespace ID (IS)</li>
/// <li>filler order number: entity identifier (ST)</li>
/// <li>filler order number: namespace ID (IS)</li>
/// <li>sequence condition value (ST)</li>
/// <li>maximum number of repeats (NM)</li>
/// <li>placer order number: universal ID (ST)</li>
/// <li>placer order number; universal ID type (ID)</li>
/// <li>filler order number: universal ID (ST)</li>
/// <li>filler order number: universal ID type (ID)</li>
/// </ol>
/// </summary>

[Serializable]
public class OSD : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a OSD. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public OSD(IMessage message) : this(message, null){}

    /// <summary>   Creates a OSD. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public OSD(IMessage message, string description) : base(message, description){
		data = new IType[11];
		data[0] = new ID(message, 0,"Sequence/results flag");
		data[1] = new ST(message,"Placer order number: entity identifier");
		data[2] = new IS(message, 0,"Placer order number: namespace ID");
		data[3] = new ST(message,"Filler order number: entity identifier");
		data[4] = new IS(message, 0,"Filler order number: namespace ID");
		data[5] = new ST(message,"Sequence condition value");
		data[6] = new NM(message,"Maximum number of repeats");
		data[7] = new ST(message,"Placer order number: universal ID");
		data[8] = new ID(message, 0,"Placer order number; universal ID type");
		data[9] = new ST(message,"Filler order number: universal ID");
		data[10] = new ID(message, 0,"Filler order number: universal ID type");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 11 element OSD composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns sequence/results flag (component #0).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The sequence results flag. </value>

	public ID SequenceResultsFlag {
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
    /// Returns placer order number: entity identifier (component #1).  This is a convenience method
    /// that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the placer order number entity. </value>

	public ST PlacerOrderNumberEntityIdentifier {
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
    /// Returns placer order number: namespace ID (component #2).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the placer order number namespace. </value>

	public IS PlacerOrderNumberNamespaceID {
get{
	   IS ret = null;
	   try {
	      ret = (IS)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns filler order number: entity identifier (component #3).  This is a convenience method
    /// that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the filler order number entity. </value>

	public ST FillerOrderNumberEntityIdentifier {
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
    /// Returns filler order number: namespace ID (component #4).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the filler order number namespace. </value>

	public IS FillerOrderNumberNamespaceID {
get{
	   IS ret = null;
	   try {
	      ret = (IS)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns sequence condition value (component #5).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The sequence condition value. </value>

	public ST SequenceConditionValue {
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
    /// Returns maximum number of repeats (component #6).  This is a convenience method that saves
    /// you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The maximum number of repeats. </value>

	public NM MaximumNumberOfRepeats {
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
    /// Returns placer order number: universal ID (component #7).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the placer order number universal. </value>

	public ST PlacerOrderNumberUniversalID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[7];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns placer order number; universal ID type (component #8).  This is a convenience method
    /// that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The type of the placer order number universal identifier. </value>

	public ID PlacerOrderNumberUniversalIDType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[8];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns filler order number: universal ID (component #9).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The identifier of the filler order number universal. </value>

	public ST FillerOrderNumberUniversalID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[9];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns filler order number: universal ID type (component #10).  This is a convenience method
    /// that saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The type of the filler order number universal identifier. </value>

	public ID FillerOrderNumberUniversalIDType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[10];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}