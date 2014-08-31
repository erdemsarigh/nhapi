using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V25.Datatype
{
/// <summary>
/// <p>The HL7 TQ (Timing Quantity) data type.  Consists of the following components: </p><ol>
/// <li>Quantity (CQ)</li>
/// <li>Interval (RI)</li>
/// <li>Duration (ST)</li>
/// <li>Start Date/Time (TS)</li>
/// <li>End Date/Time (TS)</li>
/// <li>Priority (ST)</li>
/// <li>Condition (ST)</li>
/// <li>Text (TX)</li>
/// <li>Conjunction (ID)</li>
/// <li>Order Sequencing (OSD)</li>
/// <li>Occurrence Duration (CE)</li>
/// <li>Total Occurrences (NM)</li>
/// </ol>
/// </summary>

[Serializable]
public class TQ : AbstractType, IComposite{
    /// <summary>   The data. </summary>
	private IType[] data;

    /// <summary>   Creates a TQ. </summary>
    ///
    /// <param name="message">  The Message to which this Type belongs. </param>

	public TQ(IMessage message) : this(message, null){}

    /// <summary>   Creates a TQ. </summary>
    ///
    /// <param name="message">      The Message to which this Type belongs. </param>
    /// <param name="description">  The description of this type. </param>

	public TQ(IMessage message, string description) : base(message, description){
		data = new IType[12];
		data[0] = new CQ(message,"Quantity");
		data[1] = new RI(message,"Interval");
		data[2] = new ST(message,"Duration");
		data[3] = new TS(message,"Start Date/Time");
		data[4] = new TS(message,"End Date/Time");
		data[5] = new ST(message,"Priority");
		data[6] = new ST(message,"Condition");
		data[7] = new TX(message,"Text");
		data[8] = new ID(message, 472,"Conjunction");
		data[9] = new OSD(message,"Order Sequencing");
		data[10] = new CE(message,"Occurrence Duration");
		data[11] = new NM(message,"Total Occurrences");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 12 element TQ composite"); 
		} 
	} 
	} 

    /// <summary>
    /// Returns Quantity (component #0).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The quantity. </value>

	public CQ Quantity {
get{
	   CQ ret = null;
	   try {
	      ret = (CQ)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Interval (component #1).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The interval. </value>

	public RI Interval {
get{
	   RI ret = null;
	   try {
	      ret = (RI)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Duration (component #2).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The duration. </value>

	public ST Duration {
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
    /// Returns Start Date/Time (component #3).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The start date time. </value>

	public TS StartDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns End Date/Time (component #4).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The end date time. </value>

	public TS EndDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Priority (component #5).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The priority. </value>

	public ST Priority {
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
    /// Returns Condition (component #6).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The condition. </value>

	public ST Condition {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[6];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Text (component #7).  This is a convenience method that saves you from casting and
    /// handling an exception.
    /// </summary>
    ///
    /// <value> The text. </value>

	public TX Text {
get{
	   TX ret = null;
	   try {
	      ret = (TX)this[7];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Conjunction (component #8).  This is a convenience method that saves you from casting
    /// and handling an exception.
    /// </summary>
    ///
    /// <value> The conjunction. </value>

	public ID Conjunction {
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
    /// Returns Order Sequencing (component #9).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The order sequencing. </value>

	public OSD OrderSequencing {
get{
	   OSD ret = null;
	   try {
	      ret = (OSD)this[9];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Occurrence Duration (component #10).  This is a convenience method that saves you
    /// from casting and handling an exception.
    /// </summary>
    ///
    /// <value> The occurrence duration. </value>

	public CE OccurrenceDuration {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[10];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}

    /// <summary>
    /// Returns Total Occurrences (component #11).  This is a convenience method that saves you from
    /// casting and handling an exception.
    /// </summary>
    ///
    /// <value> The total number of occurrences. </value>

	public NM TotalOccurrences {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[11];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}