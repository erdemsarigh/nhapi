/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "SegmentDef.java".  Description: 
/// "Information about a message segment used in the creation of 
/// source code for a Group class" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>

namespace NHapi.Base.SourceGeneration
{
    /// <summary>
    /// Information about a message segment used in the creation of source code for a Group class.
    /// SegmentDef is a slight misnomer because this also includes group start/end indicators, with
    /// group names.  
    /// </summary>

    public class SegmentDef : IStructureDef
    {
        #region Fields

        /// <summary>   The description. </summary>
        private System.String description;

        /// <summary>   Name of the group. </summary>
        private System.String groupName;

        /// <summary>   The name. </summary>
        private System.String name;

        /// <summary>   true to repeating. </summary>
        private bool repeating;

        /// <summary>   true if required. </summary>
        private bool required;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates new SegmentDef. </summary>
        ///
        /// <param name="name">         name of segment. </param>
        /// <param name="groupName">    name of group, if this is not really a segment but a group start
        ///                             indicator. </param>
        /// <param name="required">     true if required, false if not. </param>
        /// <param name="repeating">    true if repeating, false if not. </param>
        /// <param name="description">  The description. </param>

        public SegmentDef(
            System.String name,
            System.String groupName,
            bool required,
            bool repeating,
            System.String description)
        {
            this.name = name;
            this.groupName = groupName;
            this.required = required;
            this.repeating = repeating;
            this.description = description;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Returns a list of the names of the segments that are children of this Structure. If the
        /// structure is a Segment, a 1-element array is returned containing the segment name.  If a
        /// Group, an array of all the segments in the Group, including those nested in subgroups (depth
        /// first).  This method is used to support the XML SIG's convention for deriving group names.
        /// </summary>
        ///
        /// <value> The child segments. </value>

        public virtual System.String[] ChildSegments
        {
            get
            {
                System.String[] result = { this.Name };
                return result;
            }
        }

        /// <summary>   Returns a text description of the structure. </summary>
        ///
        /// <value> The description. </value>

        public virtual System.String Description
        {
            get
            {
                return this.description;
            }
        }

        /// <summary>   Gets the name of the group. </summary>
        ///
        /// <value> name of group, if this is not really a segment but a group start indicator. </value>

        public virtual System.String GroupName
        {
            get
            {
                return this.groupName;
            }
        }

        /// <summary>   Gets the name. </summary>
        ///
        /// <value> name of segment. </value>

        public virtual System.String Name
        {
            get
            {
                System.String result = this.name;
                if (result != null && result.Equals("?"))
                {
                    result = "GenericSegment";
                }
                return result;
            }
        }

        /// <summary>   Returns true if this structure can repeat in the Group. </summary>
        ///
        /// <value> true if repeating, false if not. </value>

        public virtual bool Repeating
        {
            get
            {
                return this.repeating;
            }
        }

        /// <summary>   Returns true if this structure is required in the Group. </summary>
        ///
        /// <value> true if required, false if not. </value>

        public virtual bool Required
        {
            get
            {
                return this.required;
            }
        }

        #endregion
    }
}