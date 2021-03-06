/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Group.java".  Description: 
/// "An abstraction representing >1 message parts which may repeated together.
/// An implementation of Group should enforce contraints about on the contents of the group
/// and throw an exception if an attempt is made to add a Structure that the Group instance
/// does not recognize.
/// </summary>
/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </author>

namespace NHapi.Base.Model
{
    /// <summary>
    /// An abstraction representing >1 message parts which may repeated together. An implementation
    /// of Group should enforce contraints about on the contents of the group and throw an exception
    /// if an attempt is made to add a Structure that the Group instance does not recognize.
    /// </summary>

    public interface IGroup : IStructure
    {
        #region Public Properties

        /// <summary>
        /// Returns an ordered array of the names of the Structures in this Group.  These names can be
        /// used to iterate through the group using repeated calls to <code>get(name)</code>.
        /// </summary>
        ///
        /// <value> The names. </value>

        System.String[] Names { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Returns an array of Structure objects by name.  For example, if the Group contains an MSH
        /// segment and "MSH" is supplied then this call would return a 1-element array containing the
        /// MSH segment.  Multiple elements are returned when the segment or group repeats.  The array
        /// may be empty if no repetitions have been accessed yet using the get(...) methods.
        /// </summary>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        ///
        /// <returns>   An array of i structure. </returns>

        IStructure[] GetAll(System.String name);

        /// <summary>   Returns the Class of the Structure at the given name index. </summary>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        ///
        /// <returns>   The class. </returns>

        System.Type GetClass(System.String name);

        /// <summary>
        /// Returns the named structure.  If this Structure is repeating then the first repetition is
        /// returned.  Creates the Structure if necessary.  
        /// </summary>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        ///
        /// <returns>   The structure. </returns>

        IStructure GetStructure(System.String name);

        /// <summary>
        /// Returns a particular repetition of the named Structure. If the given repetition number is one
        /// greater than the existing number of repetitions then a new  
        /// Structure is created.  
        /// </summary>
        ///
        /// <summary>
        /// if the structure is not repeatable and the given rep is > 0,  
        /// or if the given repetition number is more than one greater than the existing number of
        /// repetitions.  
        /// </summary>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        /// <param name="rep">  The rep. </param>
        ///
        /// <returns>   The structure. </returns>

        IStructure GetStructure(System.String name, int rep);

        /// <summary>   Returns true if the named structure is repeating. </summary>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        ///
        /// <returns>   true if repeating, false if not. </returns>

        bool IsRepeating(System.String name);

        /// <summary>   Returns true if the named structure is required. </summary>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        ///
        /// <returns>   true if required, false if not. </returns>

        bool IsRequired(System.String name);

        /// <summary>
        /// Expands the group by introducing a new child Structure (i.e. a new Segment or Group).  This
        /// method is used to support handling of unexpected segments (e.g. Z-segments).  
        /// </summary>
        ///
        /// <summary>
        /// Expands the group definition to include a segment that is not defined by HL7 to be part of
        /// this group (eg an unregistered Z segment). The new segment is slotted at the end of the
        /// group.  Thenceforward if such a segment is encountered it will be parsed into this location.
        /// If the segment name is unrecognized a GenericSegment is used.  The segment is defined as
        /// repeating and not required.  
        /// </summary>
        ///
        /// <param name="index">    index at which to insert the new child. </param>
        ///
        /// <param name="repeating">    whether the child is repeating. </param>
        ///
        /// <param name="required"> whether the child is required. </param>
        ///
        /// <param name="c">    class of the structure to insert (e.g. NTE.class) </param>
        ///
        /// <param name="name"> the child name (e.g. "NTE") </param>
        ///
        /// <returns>
        /// the name used to index the structure (may be appended with a number if name already used)
        /// </returns>

        System.String addNonstandardSegment(System.String name);

        #endregion
    }

    // sample code ... 
    /*Group m = new MessageImpl();
    try {
    m.add(new MSH()); 
    ((MSH)m.get("MSH")).getFieldSeparator().setValue("|");
    m.getMSH().getFieldSeparator().setValue("|");
	
    m.getERR(0).getThing();
    } catch (HL7Exception e) {
	
    }*/
}