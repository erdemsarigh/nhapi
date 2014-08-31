/*
* Created on 21-Apr-2005
*/

namespace NHapi.Base.Parser
{
    /// <summary>
    /// Looks up classes for message model components (e.g. concrete implementations of Message,
    /// Group, Segment).  A custom factory can be used to point to custom model components.
    /// </summary>

    public interface IModelClassFactory
    {
        #region Public Methods and Operators

        /// <summary>   Gets group class. </summary>
        ///
        /// <param name="theName">      name of group. </param>
        /// <param name="theVersion">   HL7 version. </param>
        ///
        /// <returns>   a class that implements the specified group. </returns>

        System.Type GetGroupClass(System.String theName, System.String theVersion);

        /// <summary>   Gets message class. </summary>
        ///
        /// <param name="theName">      name of message. </param>
        /// <param name="theVersion">   HL7 version. </param>
        /// <param name="isExplicit">   true if the structure was specified explicitly in MSH-9-3, false
        ///                             if it was inferred from MSH-9-1 and MSH-9-2.  If false, a lookup
        ///                             may be performed to find an alternate structure corresponding to
        ///                             that message type and event. </param>
        ///
        /// <returns>   a class that implements the specified message. </returns>

        System.Type GetMessageClass(System.String theName, System.String theVersion, bool isExplicit);

        /// <summary>   Gets segment class. </summary>
        ///
        /// <param name="theName">      name of segment. </param>
        /// <param name="theVersion">   HL7 version. </param>
        ///
        /// <returns>   a class that implements the specified segment. </returns>

        System.Type GetSegmentClass(System.String theName, System.String theVersion);

        /// <summary>   Gets type class. </summary>
        ///
        /// <param name="theName">      name of type. </param>
        /// <param name="theVersion">   HL7 version. </param>
        ///
        /// <returns>   a class that implements the specified type. </returns>

        System.Type GetTypeClass(System.String theName, System.String theVersion);

        #endregion
    }
}