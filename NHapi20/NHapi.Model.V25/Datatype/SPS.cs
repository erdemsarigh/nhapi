using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V25.Datatype
{
/// <summary>
/// <p>The HL7 SPS (Specimen Source) data type.  Consists of the following components: </p><ol>
/// <li>Specimen Source Name or Code (CWE)</li>
/// <li>Additives (CWE)</li>
/// <li>Specimen Collection Method (TX)</li>
/// <li>Body Site (CWE)</li>
/// <li>Site Modifier (CWE)</li>
/// <li>Collection Method Modifier Code (CWE)</li>
/// <li>Specimen Role (CWE)</li>
/// </ol>
/// </summary>

[Serializable]
public class SPS : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a SPS. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public SPS(IMessage message) : this(message, null){}

    /// <summary>   Creates a SPS. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public SPS(IMessage message, string description) : base(message, description){
		data = new IType[7];
		data[0] = new CWE(message,"Specimen Source Name or Code");
		data[1] = new CWE(message,"Additives");
		data[2] = new TX(message,"Specimen Collection Method");
		data[3] = new CWE(message,"Body Site");
		data[4] = new CWE(message,"Site Modifier");
		data[5] = new CWE(message,"Collection Method Modifier Code");
		data[6] = new CWE(message,"Specimen Role");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 7 element SPS composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns Specimen Source Name or Code (component #0).  This is a convenience method that saves
    /// you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The specimen source name or code. </value>

	public CWE SpecimenSourceNameOrCode {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Additives (component #1).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The additives. </value>

	public CWE Additives {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Specimen Collection Method (component #2).  This is a convenience method that saves
    /// you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The specimen collection method. </value>

	public TX SpecimenCollectionMethod {
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

    /// <summary>
    /// Returns Body Site (component #3).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The body site. </value>

	public CWE BodySite {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Site Modifier (component #4).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The site modifier. </value>

	public CWE SiteModifier {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Collection Method Modifier Code (component #5).  This is a convenience method that
    /// saves you from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The collection method modifier code. </value>

	public CWE CollectionMethodModifierCode {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[5];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Specimen Role (component #6).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The specimen role. </value>

	public CWE SpecimenRole {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[6];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}