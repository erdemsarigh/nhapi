using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

/// <summary>
/// Represents an HL7 SAC message segment. This segment has the following fields:<ol>
/// <li>SAC-1: External Accession Identifier (EI)</li>
/// <li>SAC-2: Accession Identifier (EI)</li>
/// <li>SAC-3: Container Identifier (EI)</li>
/// <li>SAC-4: Primary (parent) Container Identifier (EI)</li>
/// <li>SAC-5: Equipment Container Identifier (EI)</li>
/// <li>SAC-6: Specimen Source (SPS)</li>
/// <li>SAC-7: Registration Date/Time (TS)</li>
/// <li>SAC-8: Container Status (CE)</li>
/// <li>SAC-9: Carrier Type (CE)</li>
/// <li>SAC-10: Carrier Identifier (EI)</li>
/// <li>SAC-11: Position in Carrier (NA)</li>
/// <li>SAC-12: Tray Type - SAC (CE)</li>
/// <li>SAC-13: Tray Identifier (EI)</li>
/// <li>SAC-14: Position in Tray (NA)</li>
/// <li>SAC-15: Location (CE)</li>
/// <li>SAC-16: Container Height (NM)</li>
/// <li>SAC-17: Container Diameter (NM)</li>
/// <li>SAC-18: Barrier Delta (NM)</li>
/// <li>SAC-19: Bottom Delta (NM)</li>
/// <li>SAC-20: Container Height/Diameter/Delta Units (CE)</li>
/// <li>SAC-21: Container Volume (NM)</li>
/// <li>SAC-22: Available Volume (NM)</li>
/// <li>SAC-23: Initial Specimen Volume (NM)</li>
/// <li>SAC-24: Volume  Units (CE)</li>
/// <li>SAC-25: Separator Type (CE)</li>
/// <li>SAC-26: Cap Type (CE)</li>
/// <li>SAC-27: Additive (CE)</li>
/// <li>SAC-28: Specimen Component (CE)</li>
/// <li>SAC-29: Dilution Factor (SN)</li>
/// <li>SAC-30: Treatment (CE)</li>
/// <li>SAC-31: Temperature (SN)</li>
/// <li>SAC-32: Hemolysis Index (NM)</li>
/// <li>SAC-33: Hemolysis Index Units (CE)</li>
/// <li>SAC-34: Lipemia Index (NM)</li>
/// <li>SAC-35: Lipemia Index Units (CE)</li>
/// <li>SAC-36: Icterus Index (NM)</li>
/// <li>SAC-37: Icterus Index Units (CE)</li>
/// <li>SAC-38: Fibrin Index (NM)</li>
/// <li>SAC-39: Fibrin Index Units (CE)</li>
/// <li>SAC-40: System Induced Contaminants (CE)</li>
/// <li>SAC-41: Drug Interference (CE)</li>
/// <li>SAC-42: Artificial Blood (CE)</li>
/// <li>SAC-43: Special Handling Considerations (CE)</li>
/// <li>SAC-44: Other Environmental Factors (CE)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods do not throw
/// exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much an exceptional
/// circumstance as a bug in the code for this class.
/// </summary>

[Serializable]
public class SAC : AbstractSegment  {

    /// <summary>   Initializes a new instance of the SAC class. </summary>
    ///
    /// <param name="parent">   The parent. </param>
    /// <param name="factory">  The factory. </param>

	public SAC(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "External Accession Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Accession Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Container Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Primary (parent) Container Identifier");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Equipment Container Identifier");
       this.add(typeof(SPS), false, 1, 300, new System.Object[]{message}, "Specimen Source");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Registration Date/Time");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Container Status");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Carrier Type");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Carrier Identifier");
       this.add(typeof(NA), false, 1, 80, new System.Object[]{message}, "Position in Carrier");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Tray Type - SAC");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Tray Identifier");
       this.add(typeof(NA), false, 1, 80, new System.Object[]{message}, "Position in Tray");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Location");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Height");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Diameter");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Barrier Delta");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Bottom Delta");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Container Height/Diameter/Delta Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Volume");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Available Volume");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Initial Specimen Volume");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Volume  Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Separator Type");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Cap Type");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Additive");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Specimen Component");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Dilution Factor");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Treatment");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Temperature");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Hemolysis Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Hemolysis Index Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Lipemia Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Lipemia Index Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Icterus Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Icterus Index Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Fibrin Index");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Fibrin Index Units");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "System Induced Contaminants");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Drug Interference");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Artificial Blood");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Special Handling Considerations");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Other Environmental Factors");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>   Returns External Accession Identifier(SAC-1). </summary>
    ///
    /// <value> The identifier of the external accession. </value>

	public EI ExternalAccessionIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Accession Identifier(SAC-2). </summary>
    ///
    /// <value> The identifier of the accession. </value>

	public EI AccessionIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Container Identifier(SAC-3). </summary>
    ///
    /// <value> The identifier of the container. </value>

	public EI ContainerIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Primary (parent) Container Identifier(SAC-4). </summary>
    ///
    /// <value> The identifier of the primary parent container. </value>

	public EI PrimaryParentContainerIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Equipment Container Identifier(SAC-5). </summary>
    ///
    /// <value> The identifier of the equipment container. </value>

	public EI EquipmentContainerIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Specimen Source(SAC-6). </summary>
    ///
    /// <value> The specimen source. </value>

	public SPS SpecimenSource
	{
		get{
			SPS ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (SPS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Registration Date/Time(SAC-7). </summary>
    ///
    /// <value> The registration date time. </value>

	public TS RegistrationDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Container Status(SAC-8). </summary>
    ///
    /// <value> The container status. </value>

	public CE ContainerStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Carrier Type(SAC-9). </summary>
    ///
    /// <value> The type of the carrier. </value>

	public CE CarrierType
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Carrier Identifier(SAC-10). </summary>
    ///
    /// <value> The identifier of the carrier. </value>

	public EI CarrierIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Position in Carrier(SAC-11). </summary>
    ///
    /// <value> The position in carrier. </value>

	public NA PositionInCarrier
	{
		get{
			NA ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (NA)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Tray Type - SAC(SAC-12). </summary>
    ///
    /// <value> The tray type sac. </value>

	public CE TrayTypeSAC
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Tray Identifier(SAC-13). </summary>
    ///
    /// <value> The identifier of the tray. </value>

	public EI TrayIdentifier
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Position in Tray(SAC-14). </summary>
    ///
    /// <value> The position in tray. </value>

	public NA PositionInTray
	{
		get{
			NA ret = null;
			try
			{
			IType t = this.GetField(14, 0);
				ret = (NA)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Location(SAC-15). throws HL7Exception if the repetition number
    /// is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The location. </returns>

	public CE GetLocation(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(15, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Location (SAC-15). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetLocation() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(15);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Location (SAC-15). </summary>
  ///
  /// <value>   The location repetitions used. </value>

  public int LocationRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(15);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Container Height(SAC-16). </summary>
    ///
    /// <value> The height of the container. </value>

	public NM ContainerHeight
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(16, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Container Diameter(SAC-17). </summary>
    ///
    /// <value> The container diameter. </value>

	public NM ContainerDiameter
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(17, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Barrier Delta(SAC-18). </summary>
    ///
    /// <value> The barrier delta. </value>

	public NM BarrierDelta
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(18, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Bottom Delta(SAC-19). </summary>
    ///
    /// <value> The bottom delta. </value>

	public NM BottomDelta
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Container Height/Diameter/Delta Units(SAC-20). </summary>
    ///
    /// <value> The container height diameter delta units. </value>

	public CE ContainerHeightDiameterDeltaUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Container Volume(SAC-21). </summary>
    ///
    /// <value> The container volume. </value>

	public NM ContainerVolume
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Available Volume(SAC-22). </summary>
    ///
    /// <value> The available volume. </value>

	public NM AvailableVolume
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Initial Specimen Volume(SAC-23). </summary>
    ///
    /// <value> The initial specimen volume. </value>

	public NM InitialSpecimenVolume
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Volume  Units(SAC-24). </summary>
    ///
    /// <value> The volume units. </value>

	public CE VolumeUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(24, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Separator Type(SAC-25). </summary>
    ///
    /// <value> The type of the separator. </value>

	public CE SeparatorType
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(25, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Cap Type(SAC-26). </summary>
    ///
    /// <value> The type of the capability. </value>

	public CE CapType
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(26, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Additive(SAC-27). throws HL7Exception if the repetition number
    /// is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The additive. </returns>

	public CE GetAdditive(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(27, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Additive (SAC-27). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetAdditive() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(27);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Additive (SAC-27). </summary>
  ///
  /// <value>   The additive repetitions used. </value>

  public int AdditiveRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(27);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Specimen Component(SAC-28). </summary>
    ///
    /// <value> The specimen component. </value>

	public CE SpecimenComponent
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(28, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Dilution Factor(SAC-29). </summary>
    ///
    /// <value> The dilution factor. </value>

	public SN DilutionFactor
	{
		get{
			SN ret = null;
			try
			{
			IType t = this.GetField(29, 0);
				ret = (SN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Treatment(SAC-30). </summary>
    ///
    /// <value> The treatment. </value>

	public CE Treatment
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(30, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Temperature(SAC-31). </summary>
    ///
    /// <value> The temperature. </value>

	public SN Temperature
	{
		get{
			SN ret = null;
			try
			{
			IType t = this.GetField(31, 0);
				ret = (SN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Hemolysis Index(SAC-32). </summary>
    ///
    /// <value> The hemolysis index. </value>

	public NM HemolysisIndex
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(32, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Hemolysis Index Units(SAC-33). </summary>
    ///
    /// <value> The hemolysis index units. </value>

	public CE HemolysisIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(33, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Lipemia Index(SAC-34). </summary>
    ///
    /// <value> The lipemia index. </value>

	public NM LipemiaIndex
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(34, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Lipemia Index Units(SAC-35). </summary>
    ///
    /// <value> The lipemia index units. </value>

	public CE LipemiaIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(35, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Icterus Index(SAC-36). </summary>
    ///
    /// <value> The icterus index. </value>

	public NM IcterusIndex
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(36, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Icterus Index Units(SAC-37). </summary>
    ///
    /// <value> The icterus index units. </value>

	public CE IcterusIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(37, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Fibrin Index(SAC-38). </summary>
    ///
    /// <value> The fibrin index. </value>

	public NM FibrinIndex
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(38, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>   Returns Fibrin Index Units(SAC-39). </summary>
    ///
    /// <value> The fibrin index units. </value>

	public CE FibrinIndexUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(39, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of System Induced Contaminants(SAC-40). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The system induced contaminants. </returns>

	public CE GetSystemInducedContaminants(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(40, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of System Induced Contaminants (SAC-40). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetSystemInducedContaminants() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(40);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of System Induced Contaminants (SAC-40). </summary>
  ///
  /// <value>   The system induced contaminants repetitions used. </value>

  public int SystemInducedContaminantsRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(40);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Drug Interference(SAC-41). throws HL7Exception if the
    /// repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The drug interference. </returns>

	public CE GetDrugInterference(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(41, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Drug Interference (SAC-41). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetDrugInterference() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(41);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Drug Interference (SAC-41). </summary>
  ///
  /// <value>   The drug interference repetitions used. </value>

  public int DrugInterferenceRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(41);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>   Returns Artificial Blood(SAC-42). </summary>
    ///
    /// <value> The artificial blood. </value>

	public CE ArtificialBlood
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(42, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

    /// <summary>
    /// Returns a single repetition of Special Handling Considerations(SAC-43). throws HL7Exception
    /// if the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The special handling considerations. </returns>

	public CE GetSpecialHandlingConsiderations(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(43, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Special Handling Considerations (SAC-43). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetSpecialHandlingConsiderations() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(43);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Special Handling Considerations (SAC-43). </summary>
  ///
  /// <value>   The special handling considerations repetitions used. </value>

  public int SpecialHandlingConsiderationsRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(43);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

    /// <summary>
    /// Returns a single repetition of Other Environmental Factors(SAC-44). throws HL7Exception if
    /// the repetition number is invalid.
    /// </summary>
    ///
    /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
    ///
    /// <param name="rep">  The repetition number (this is a repeating field) </param>
    ///
    /// <returns>   The other environmental factors. </returns>

	public CE GetOtherEnvironmentalFactors(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(44, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /// <summary> Returns all repetitions of Other Environmental Factors (SAC-44). </summary>
  ///
  /// <exception cref="Exception">  Thrown when an exception error condition occurs. </exception>
  ///
  /// <returns> An array of ce. </returns>

  public CE[] GetOtherEnvironmentalFactors() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(44);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  /// <summary> Returns the total repetitions of Other Environmental Factors (SAC-44). </summary>
  ///
  /// <value>   The other environmental factors repetitions used. </value>

  public int OtherEnvironmentalFactorsRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(44);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

}}