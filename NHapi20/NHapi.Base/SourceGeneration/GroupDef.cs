/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GroupDef.java".  Description: 
/// "Contains the information needed to create source code for a Group (a 
/// Group is a part of a message that may repeat, and that contains two or 
/// more segments or other groups)" 
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
    /// Contains the information needed to create source code for a Group (a Group is a part of a
    /// message that may repeat, and that contains two or more segments or other groups).
    /// </summary>

    public class GroupDef : IStructureDef
    {
        #region Fields

        /// <summary>   The description. </summary>
        private System.String description;

        /// <summary>   The elements. </summary>
        private System.Collections.ArrayList elements;

        /// <summary>   List of names of the existings. </summary>
        private System.Collections.Hashtable existingNames;

        /// <summary>   Name of the group. </summary>
        private System.String groupName;

        /// <summary>   Name of the message. </summary>
        private System.String messageName;

        /// <summary>   true to repeating. </summary>
        private bool repeating;

        /// <summary>   true if required. </summary>
        private bool required;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates new GroupDef. </summary>
        ///
        /// <param name="messageName">  Name of the message. </param>
        /// <param name="groupName">    Name of the group. </param>
        /// <param name="required">     true if required, false if not. </param>
        /// <param name="repeating">    true if repeating, false if not. </param>
        /// <param name="description">  The description. </param>

        public GroupDef(
            System.String messageName,
            System.String groupName,
            bool required,
            bool repeating,
            System.String description)
        {
            this.messageName = messageName;
            this.groupName = groupName;
            this.elements = new System.Collections.ArrayList();
            this.required = required;
            this.repeating = repeating;
            this.description = description;
            this.existingNames = new System.Collections.Hashtable();
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
                System.Collections.ArrayList deepChildList = new System.Collections.ArrayList();
                for (int i = 0; i < this.elements.Count; i++)
                {
                    IStructureDef childStruct = (IStructureDef)this.elements[i];
                    System.String[] childStructChildren = childStruct.ChildSegments;
                    for (int j = 0; j < childStructChildren.Length; j++)
                    {
                        deepChildList.Add(childStructChildren[j]);
                    }
                }
                System.String[] result = new System.String[deepChildList.Count];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = ((System.String)deepChildList[i]);
                }
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

        /// <summary>
        /// Returns the Java class name of this Group.  This is derived from the message structure and
        /// the group elements.  This should only be called after all the elements are added.  
        /// </summary>
        ///
        /// <value> The name. </value>

        public virtual System.String Name
        {
            get
            {
                System.String result = null;

                if (this.groupName != null && this.groupName.Length > 0)
                {
                    result = this.messageName + "_" + this.groupName;
                }
                else
                {
                    System.Text.StringBuilder name = new System.Text.StringBuilder();
                    name.Append(this.messageName);
                    name.Append("_");
                    System.String[] children = this.ChildSegments;
                    for (int i = 0; i < children.Length; i++)
                    {
                        name.Append(children[i]);
                    }
                    result = name.ToString();
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

        /// <summary>   Returns the structures in this group. </summary>
        ///
        /// <value> The structures. </value>

        public virtual IStructureDef[] Structures
        {
            get
            {
                IStructureDef[] ret = new IStructureDef[this.elements.Count];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (IStructureDef)this.elements[i];
                }
                return ret;
            }
        }

        /// <summary>   Gets the name of the unqualified. </summary>
        ///
        /// <value> group name without message name prepended.   </value>

        public virtual System.String UnqualifiedName
        {
            get
            {
                System.String name = this.Name;
                return name.Substring(this.messageName.Length + 1);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Adds an element (segment or group) to this group. </summary>
        ///
        /// <param name="s">    The IStructureDef to process. </param>

        public virtual void addStructure(IStructureDef s)
        {
            this.elements.Add(s);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the name by which a particular structure can be accessed (eg for use in writing
        /// accessor source code).  This may differ from the class name of the structure of there are >1
        /// structures in the same group with the same class.  
        /// For example in ADT_A01 there are two ROL's that are not in sub-groups - AbstractGroup stores
        /// the first one under the name ROL and the second under the name ROL2.  This method returns
        /// names using the same naming scheme.  The order in which this method is called matters: it
        /// should be called ONCE for each element of the group in the order in which they appear.  
        /// </summary>
        ///
        /// <param name="name"> Returns the Java class name of this Group.  This is derived from the
        ///                     message structure and the group elements.  This should only be called
        ///                     after all the elements are added. </param>
        ///
        /// <returns>   The index name. </returns>

        protected internal virtual System.String getIndexName(System.String name)
        {
            //see if this name is already being used 
            System.Object o = this.existingNames[name];
            int c = 2;
            System.String newName = name;
            while (o != null)
            {
                newName = name + c++;
                o = this.existingNames[newName];
            }
            name = newName;
            this.existingNames[name] = name;
            return name;
        }

        #endregion
    }
}