/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "MessageNaviagtor.java".  Description:
/// "Used to navigate the nested group structure of a message."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2002.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>

namespace NHapi.Base.Util
{
    using NHapi.Base.Model;

    /// <summary>
    /// <p>Used to navigate the nested group structure of a message.  This is an alternate way of
    /// accessing parts of a message, ie rather than getting a segment through a chain of getXXX()
    /// calls on the message, you can create a MessageNavigator for the message, "navigate" to the
    /// desired segment, and then call getCurrentStructure() to get the segment you have navigated
    /// to.  A message navigator always has a "current location" pointing to some structure location
    /// (segment or group location) within the message.  Note that a location exists whether or not
    /// there are any instances of the structure at that location. </p>
    /// <p>This class is used by Terser, which presents an even more convenient way
    /// of navigating a message.  </p>
    /// <p>This class also has an iterate() method, which iterates over
    /// segments (and optionally groups).  </p>
    /// </summary>

    public class MessageNavigator
    {
        #region Fields

        /// <summary>   The ancestors. </summary>
        private System.Collections.ArrayList ancestors;

        /// <summary>   List of names of the children. </summary>
        private System.String[] childNames;

        /// <summary>   -1 means current structure is current group (special case used for root) </summary>
        private int currentChild;

        /// <summary>   The current group. </summary>
        private IGroup currentGroup;

        /// <summary>   The root. </summary>
        private IGroup root;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Creates a new instance of MessageNavigator. </summary>
        ///
        /// <param name="root"> the root of navigation -- may be a message or a group within a message.
        ///                     Navigation will only occur within the subtree of which the given group is
        ///                     the root. </param>

        public MessageNavigator(IGroup root)
        {
            this.root = root;
            this.reset();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Returns the array of structures at the current location.  
        /// Throws an exception if pointer is at root.  
        /// </summary>
        ///
        /// <value> The current child reps. </value>

        public virtual IStructure[] CurrentChildReps
        {
            get
            {
                if (this.currentGroup == this.root && this.currentChild == -1)
                {
                    throw new HL7Exception("Pointer is at root of navigator: there is no current child");
                }

                System.String childName = this.childNames[this.currentChild];
                return this.currentGroup.GetAll(childName);
            }
        }

        /// <summary>
        /// Returns the group within which the pointer is currently located. If at the root, the root is
        /// returned.  
        /// </summary>
        ///
        /// <value> The current group. </value>

        public virtual IGroup CurrentGroup
        {
            get
            {
                return this.currentGroup;
            }
        }

        /// <summary>   THe root element of this message. </summary>
        ///
        /// <value> The root. </value>

        public virtual IGroup Root
        {
            get
            {
                return this.root;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Drills down into the group at the given index within the current group -- ie sets the
        /// location pointer to the first structure within the child.
        /// </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="childNumber">  the index of the group child into which to drill. </param>
        /// <param name="rep">          the group repetition into which to drill. </param>

        public virtual void drillDown(int childNumber, int rep)
        {
            if (childNumber != -1)
            {
                IStructure s = this.currentGroup.GetStructure(this.childNames[childNumber], rep);
                if (!(s is IGroup))
                {
                    throw new HL7Exception("Can't drill into segment", HL7Exception.APPLICATION_INTERNAL_ERROR);
                }
                IGroup group = (IGroup)s;

                //stack the current group and location
                GroupContext gc = new GroupContext(this, this.currentGroup, this.currentChild);
                this.ancestors.Add(gc);

                this.currentGroup = group;
            }

            this.currentChild = 0;
            this.childNames = this.currentGroup.Names;
        }

        /// <summary>   Drills down into the group at the CURRENT location. </summary>
        ///
        /// <param name="rep">  the group repetition into which to drill. </param>

        public virtual void drillDown(int rep)
        {
            this.drillDown(this.currentChild, rep);
        }

        /// <summary>
        /// Switches the group context to the parent of the current group, and sets the child pointer to
        /// the next sibling.
        /// </summary>
        ///
        /// <returns>   false if already at root. </returns>

        public virtual bool drillUp()
        {
            //pop the top group and resume search there
            if (!(this.ancestors.Count == 0))
            {
                GroupContext gc = (GroupContext)SupportClass.StackSupport.Pop(this.ancestors);
                this.currentGroup = gc.group;
                this.currentChild = gc.child;
                this.childNames = this.currentGroup.Names;
                return true;
            }
            if (this.currentChild == -1)
            {
                return false;
            }
            this.currentChild = -1;
            return true;
        }

        /// <summary>
        /// Returns the given rep of the structure at the current location.  
        /// If at root, always returns the root (the rep is ignored).  
        /// </summary>
        ///
        /// <param name="rep">  the group repetition into which to drill. </param>
        ///
        /// <returns>   The current structure. </returns>

        public virtual IStructure getCurrentStructure(int rep)
        {
            IStructure ret = null;
            if (this.currentChild != -1)
            {
                System.String childName = this.childNames[this.currentChild];
                ret = this.currentGroup.GetStructure(childName, rep);
            }
            else
            {
                ret = this.currentGroup;
            }
            return ret;
        }

        /// <summary>   Returns true if there is a sibling following the current location. </summary>
        ///
        /// <returns>   true if next child, false if not. </returns>

        public virtual bool hasNextChild()
        {
            if (this.childNames.Length > this.currentChild + 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Iterates through the message tree to the next segment/group location (regardless of whether
        /// an instance of the segment exists).  If the end of the tree is reached, starts over at the
        /// root.  Only enters the first repetition of a repeating group -- explicit navigation (using
        /// the drill...() methods) is necessary to get to subsequent reps.
        /// </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="segmentsOnly"> if true, only stops at segments (not groups) </param>
        /// <param name="loop">         if true, loops back to beginning when end of msg reached; if
        ///                             false, throws HL7Exception if end of msg reached. </param>

        public virtual void iterate(bool segmentsOnly, bool loop)
        {
            IStructure start = null;

            if (this.currentChild == -1)
            {
                start = this.currentGroup;
            }
            else
            {
                start = (this.currentGroup.GetStructure(this.childNames[this.currentChild]));
            }

            //using a non-existent direction and not allowing segment creation means that only
            //the first rep of anything is traversed.
            System.Collections.IEnumerator it = new MessageIterator(start, "doesn't exist", false);
            if (segmentsOnly)
            {
                FilterIterator.IPredicate predicate = new AnonymousClassPredicate(this);
                it = new FilterIterator(it, predicate);
            }

            if (it.MoveNext())
            {
                IStructure next = (IStructure)it.Current;
                this.drillHere(next);
            }
            else if (loop)
            {
                this.reset();
            }
            else
            {
                throw new HL7Exception(
                    "End of message reached while iterating without loop",
                    HL7Exception.APPLICATION_INTERNAL_ERROR);
            }
        }

        /// <summary>   Moves to the next sibling of the current location. </summary>
        public virtual void nextChild()
        {
            int child = this.currentChild + 1;
            this.toChild(child);
        }

        /// <summary>   Resets the location to the beginning of the tree (the root) </summary>
        public virtual void reset()
        {
            this.ancestors = new System.Collections.ArrayList();
            this.currentGroup = this.root;
            this.currentChild = -1;
            this.childNames = this.currentGroup.Names;
        }

        /// <summary>   Moves to the sibling of the current location at the specified index. </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="child">    The child. </param>

        public virtual void toChild(int child)
        {
            if (child >= 0 && child < this.childNames.Length)
            {
                this.currentChild = child;
            }
            else
            {
                throw new HL7Exception(
                    "Can't advance to child " + child + " -- only " + this.childNames.Length + " children",
                    HL7Exception.APPLICATION_INTERNAL_ERROR);
            }
        }

        #endregion

        #region Methods

        /// <summary>   Navigates to a specific location in the message. </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="destination">  Destination for the. </param>

        private void drillHere(IStructure destination)
        {
            IStructure pathElem = destination;
            System.Collections.ArrayList pathStack = new System.Collections.ArrayList();
            System.Collections.ArrayList indexStack = new System.Collections.ArrayList();
            do
            {
                MessageIterator.Index index = MessageIterator.getIndex(pathElem.ParentStructure, pathElem);
                indexStack.Add(index);
                pathElem = pathElem.ParentStructure;
                pathStack.Add(pathElem);
            }
            while (!this.root.Equals(pathElem) && !typeof(IMessage).IsAssignableFrom(pathElem.GetType()));

            if (!this.root.Equals(pathElem))
            {
                throw new HL7Exception("The destination provided is not under the root of this navigator");
            }

            this.reset();
            while (!(pathStack.Count == 0))
            {
                IGroup parent = (IGroup)SupportClass.StackSupport.Pop(pathStack);
                MessageIterator.Index index = (MessageIterator.Index)SupportClass.StackSupport.Pop(indexStack);
                int child = this.search(parent.Names, index.name);
                if (!(pathStack.Count == 0))
                {
                    this.drillDown(child, 0);
                }
                else
                {
                    this.toChild(child);
                }
            }
        }

        /// <summary>   Drills down recursively until a segment is reached. </summary>
        private void findLeaf()
        {
            if (this.currentChild == -1)
            {
                this.currentChild = 0;
            }

            System.Type c = this.currentGroup.GetClass(this.childNames[this.currentChild]);
            if (typeof(IGroup).IsAssignableFrom(c))
            {
                this.drillDown(this.currentChild, 0);
                this.findLeaf();
            }
        }

        /// <summary>
        /// Like Arrays.binarySearch, only probably slower and doesn't require a sorted list.  Also just
        /// returns -1 if item isn't found.
        /// </summary>
        ///
        /// <param name="list"> The list. </param>
        /// <param name="item"> The item. </param>
        ///
        /// <returns>   An int. </returns>

        private int search(System.Object[] list, System.Object item)
        {
            int found = -1;
            for (int i = 0; i < list.Length && found == -1; i++)
            {
                if (list[i].Equals(item))
                {
                    found = i;
                }
            }
            return found;
        }

        #endregion

        /// <summary>   The anonymous class predicate. </summary>
        private class AnonymousClassPredicate : FilterIterator.IPredicate
        {
            #region Fields

            /// <summary>   The enclosing instance. </summary>
            private MessageNavigator enclosingInstance;

            #endregion

            #region Constructors and Destructors

            /// <summary>   Initializes a new instance of the AnonymousClassPredicate class. </summary>
            ///
            /// <param name="enclosingInstance">    The enclosing instance. </param>

            public AnonymousClassPredicate(MessageNavigator enclosingInstance)
            {
                this.InitBlock(enclosingInstance);
            }

            #endregion

            #region Public Properties

            /// <summary>   Gets the enclosing instance. </summary>
            ///
            /// <value> The enclosing instance. </value>

            public MessageNavigator Enclosing_Instance
            {
                get
                {
                    return this.enclosingInstance;
                }
            }

            #endregion

            #region Public Methods and Operators

            /// <summary>   Evaluate the object. </summary>
            ///
            /// <param name="obj">  The object. </param>
            ///
            /// <returns>   true if it succeeds, false if it fails. </returns>

            public virtual bool evaluate(System.Object obj)
            {
                if (typeof(ISegment).IsAssignableFrom(obj.GetType()))
                {
                    return true;
                }
                return false;
            }

            #endregion

            #region Methods

            /// <summary>   Initialises the block. </summary>
            ///
            /// <param name="enclosingInstance">    The enclosing instance. </param>

            private void InitBlock(MessageNavigator enclosingInstance)
            {
                this.enclosingInstance = enclosingInstance;
            }

            #endregion
        }

        /// <summary>
        /// A structure to hold current location information at one level of the message tree.  A stack
        /// of these identifies the current location completely.
        /// </summary>

        private class GroupContext
        {
            #region Fields

            /// <summary>   The child. </summary>
            public int child;

            /// <summary>   The group. </summary>
            public IGroup group;

            /// <summary>   The enclosing instance. </summary>
            private MessageNavigator enclosingInstance;

            #endregion

            #region Constructors and Destructors

            /// <summary>   Initializes a new instance of the GroupContext class. </summary>
            ///
            /// <param name="enclosingInstance">    The enclosing instance. </param>
            /// <param name="g">                    The IGroup to process. </param>
            /// <param name="c">                    The int to process. </param>

            public GroupContext(MessageNavigator enclosingInstance, IGroup g, int c)
            {
                this.InitBlock(enclosingInstance);
                this.@group = g;
                this.child = c;
            }

            #endregion

            #region Public Properties

            /// <summary>   Gets the enclosing instance. </summary>
            ///
            /// <value> The enclosing instance. </value>

            public MessageNavigator Enclosing_Instance
            {
                get
                {
                    return this.enclosingInstance;
                }
            }

            #endregion

            #region Methods

            /// <summary>   Initialises the block. </summary>
            ///
            /// <param name="enclosingInstance">    The enclosing instance. </param>

            private void InitBlock(MessageNavigator enclosingInstance)
            {
                this.enclosingInstance = enclosingInstance;
            }

            #endregion
        }
    }
}