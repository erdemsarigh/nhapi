/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "Terser.java".  Description:
/// "Wraps a message to provide access to fields using a more terse syntax."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2002.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
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
    using System;

    using NHapi.Base.Log;
    using NHapi.Base.Model;

    /// <summary>
    /// <p>Wraps a message to provide access to fields using a terse location specification syntax.
    /// For example: </p>
    /// <p><code>terser.set("MSH-9-3", "ADT_A01");</code>  <br/>
    /// can be used instead of <br/>
    /// <code>message.getMSH().getMessageType().getMessageStructure().setValue("ADT_A01"); </code> </p>
    /// <p>The syntax of a location spec is as follows: </p>
    /// <p>location_spec: <code>segment_path_spec "-" field ["(" rep ")"] ["-" component ["-" subcomponent]] </code></p>
    /// <p>... where rep, field, component, and subcomponent are integers (representing, respectively,
    /// the field repetition (starting at 0), and the field number, component number, and subcomponent
    /// numbers (starting at 1).  Omitting the rep is equivalent to specifying 0; omitting the
    /// component or subcomponent is equivalent to specifying 1.</p>
    /// <p>The syntax for the segment_path_spec is as follows: </p>
    /// &lt;p&gt;segment_path_spec: </code> ["/"] (group_spec ["(" rep ")"] "/")* segment_spec ["(" rep ")"]</code></p>
    /// <p> ... where rep has the same meaning as for fields.  A leading "/" indicates that navigation to the
    /// location begins at the root of the message; ommitting this indicates that navigation begins at the
    /// current location of the underlying SegmentFinder (see getFinder() -- this allows manual navigation
    /// if desired).  The syntax for group_spec is: </p>
    /// <p>group_spec: <code>["."] group_name_pattern</code></p>
    /// <p>Here, a . indicates that the group should be searched for (using a SegmentFinder) starting at the
    /// current location in the message.  The wildcards "*" and "?" represent any number of arbitrary characters,
    /// and a single arbitrary character, respectively.  For example, "M*" and "?S?" match MSH.  The first
    /// group with a name that matches the given group_name_pattern will be matched.  </p>
    /// <p>The segment_spec is analogous to the group_spec. </p>
    /// <p>As another example, the following subcomponent in an SIU_S12 message: <p>
    /// <p><code>msg.getSIU_S12_RGSAISNTEAIGNTEAILNTEAIPNTE(1).getSIU_S12_AIGNTE().getAIG().getResourceGroup(1).getIdentifier();</code></p>
    /// </p> ... is referenced by all of the following location_spec: </p>
    /// <p><code>/SIU_S12_RGSAISNTEAIGNTEAILNTEAIPNTE(1)/SIU_S12_AIGNTE/AIG-5(1)-1 <br/>
    /// /*AIG*(1)/SIU_S12_AIGNTE/AIG-5(1)-1 <br/>
    /// /*AIG*(1)/.AIG-5(1) </code></p>
    /// <p>The search function only iterates through rep 0 of each group.  Thus if rep 0 of the first group
    /// in this example was desired instead of rep 1, the following syntax would also work (since there is
    /// only one AIG segment position in SUI_S12): </p>
    /// <p><code>/.AIG-5(1)</code></p>
    /// </summary>

    public class Terser
    {
        #region Static Fields

        /// <summary>   The log. </summary>
        private static IHapiLog log;

        #endregion

        #region Fields

        /// <summary>   The finder. </summary>
        private SegmentFinder finder;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the Terser class. </summary>
        static Terser()
        {
            log = HapiLogFactory.GetHapiLog(typeof(Terser));
        }

        /// <summary>   Creates a new instance of Terser. </summary>
        ///
        /// <param name="message">  The message. </param>

        public Terser(IMessage message)
        {
            this.finder = new SegmentFinder(message);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Returns the segment finder used by this Terser.  Navigating the finder will influence the
        /// behaviour of the Terser accordingly.  Ie when the full path of the segment is not specified
        /// the segment will be sought beginning at the current location of the finder.
        /// </summary>
        ///
        /// <value> The finder. </value>

        public virtual SegmentFinder Finder
        {
            get
            {
                return this.finder;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Returns the string value of the Primitive at the given location. </summary>
        ///
        /// <param name="segment">      the segment from which to get the primitive. </param>
        /// <param name="field">        the field number. </param>
        /// <param name="rep">          the field repetition. </param>
        /// <param name="component">    the component number (use 1 for primitive field) </param>
        /// <param name="subcomponent"> the subcomponent number (use 1 for primitive component) </param>
        ///
        /// <returns>   A System.String. </returns>

        public static System.String Get(ISegment segment, int field, int rep, int component, int subcomponent)
        {
            IPrimitive prim = getPrimitive(segment, field, rep, component, subcomponent);
            return prim.Value;
        }

        /// <summary>   Sets the string value of the Primitive at the given location. </summary>
        ///
        /// <param name="segment">          the segment from which to get the primitive. </param>
        /// <param name="field">            the field number. </param>
        /// <param name="rep">              the field repetition. </param>
        /// <param name="component">        the component number (use 1 for primitive field) </param>
        /// <param name="subcomponent">     the subcomponent number (use 1 for primitive component) </param>
        /// <param name="value_Renamed">    The value renamed. </param>

        public static void Set(
            ISegment segment,
            int field,
            int rep,
            int component,
            int subcomponent,
            System.String value_Renamed)
        {
            IPrimitive prim = getPrimitive(segment, field, rep, component, subcomponent);
            prim.Value = value_Renamed;
        }

        /// <summary>
        /// Given a Terser path, returns an array containing field num, field rep, component, and
        /// subcomponent.  
        /// </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="spec"> The specifier. </param>
        ///
        /// <returns>   An array of int. </returns>

        public static int[] getIndices(System.String spec)
        {
            SupportClass.Tokenizer tok = new SupportClass.Tokenizer(spec, "-", false);
            tok.NextToken(); //skip over segment
            if (!tok.HasMoreTokens())
            {
                throw new HL7Exception("Must specify field in spec " + spec, HL7Exception.APPLICATION_INTERNAL_ERROR);
            }

            int[] ret = null;
            try
            {
                SupportClass.Tokenizer fieldSpec = new SupportClass.Tokenizer(tok.NextToken(), "()", false);
                int fieldNum = System.Int32.Parse(fieldSpec.NextToken());
                int fieldRep = 0;
                if (fieldSpec.HasMoreTokens())
                {
                    fieldRep = System.Int32.Parse(fieldSpec.NextToken());
                }

                int component = 1;
                if (tok.HasMoreTokens())
                {
                    component = System.Int32.Parse(tok.NextToken());
                }

                int subcomponent = 1;
                if (tok.HasMoreTokens())
                {
                    subcomponent = System.Int32.Parse(tok.NextToken());
                }
                int[] result = { fieldNum, fieldRep, component, subcomponent };
                ret = result;
            }
            catch (System.FormatException)
            {
                throw new HL7Exception("Invalid integer in spec " + spec, HL7Exception.APPLICATION_INTERNAL_ERROR);
            }

            return ret;
        }

        /// <summary>
        /// Returns the Primitive object at the given location in the given field.  
        /// It is intended that the given type be at the field level, although extra components will be
        /// added blindly if, for example, you provide a primitive subcomponent instead and specify
        /// component or subcomponent > 1.
        /// </summary>
        ///
        /// <param name="type">         The type. </param>
        /// <param name="component">    the component number (use 1 for primitive field) </param>
        /// <param name="subcomponent"> the subcomponent number (use 1 for primitive component) </param>
        ///
        /// <returns>   The primitive. </returns>

        public static IPrimitive getPrimitive(IType type, int component, int subcomponent)
        {
            IType comp = getComponent(type, component);
            IType sub = getComponent(comp, subcomponent);
            return getPrimitive(sub);
        }

        /// <summary>
        /// Returns the number of components in the given type, i.e. the number of standard components
        /// (e.g. 6 for CE) plus any extra components that have been added at runtime.  
        /// </summary>
        ///
        /// <param name="type"> The type. </param>
        ///
        /// <returns>   The total number of components. </returns>

        public static int numComponents(IType type)
        {
            if (typeof(Varies).IsAssignableFrom(type.GetType()))
            {
                return numComponents(((Varies)type).Data);
            }
            return numStandardComponents(type) + type.ExtraComponents.numComponents();
        }

        /// <summary> Returns the number of components in the given field, i.e. the
        /// number of standard components (e.g. 6 for CE) plus any extra components that
        /// have been added at runtime.  This may vary by repetition, as different reps
        /// may have different extra components.
        /// </summary>
        /*public static int numComponents(Type field) throws HL7Exception {
        return numComponents(seg.GetField(field, rep));
        }*/

        /// <summary>
        /// Returns the number of sub-components in the specified component, i.e. the number of standard
        /// sub-components (e.g. 6 for CE) plus any extra components that that have been added at runtime.
        /// </summary>
        ///
        /// <param name="type">         The type. </param>
        /// <param name="component">    numbered from 1. </param>
        ///
        /// <returns>   The total number of sub components. </returns>

        public static int numSubComponents(IType type, int component)
        {
            int n = -1;
            if (component == 1 && typeof(IPrimitive).IsAssignableFrom(type.GetType()))
            {
                //note that getComponent(primitive, 1) below returns the primitive 
                //itself -- if we do numComponents on it, we'll end up with the 
                //number of components in the field, not the number of subcomponents
                n = 1;
            }
            else
            {
                IType comp = getComponent(type, component);
                n = numComponents(comp);
            }
            return n;
            /*
            //Type t = seg.GetField(field, rep);
            if (Varies.class.isAssignableFrom(type.GetClass())) {
            return numSubComponents(((Varies) type).getData(), component);
            } else if (Primitive.class.isAssignableFrom(type.GetClass()) && component == 1) {
            n = 1;  
            } else if (Composite.class.isAssignableFrom(type.GetClass()) && component <= numStandardComponents(t)) {
            n = numComponents(((Composite) type).getComponent(component - 1));
            } else { //we're being asked about subcomponents of an extra component
            n = numComponents(t.getExtraComponents().getComponent(component - numStandardComponents(t) - 1));
            }
            return n;
            */
        }

        /// <summary>
        /// <p>Gets the string value of the field specified.  See the class docs for syntax of the
        /// location spec.  </p>
        /// &lt;p&gt;If a repetition is omitted for a repeating segment or field, the first rep is used.
        /// If the component or subcomponent is not specified for a composite field, the first component
        /// is used (this allows one to write code that will work with later versions of the HL7
        /// standard).
        /// </summary>
        ///
        /// <param name="spec"> The specifier. </param>
        ///
        /// <returns>   A System.String. </returns>

        public virtual System.String Get(System.String spec)
        {
            SupportClass.Tokenizer tok = new SupportClass.Tokenizer(spec, "-", false);
            ISegment segment = this.getSegment(tok.NextToken());

            int[] ind = getIndices(spec);
            return Get(segment, ind[0], ind[1], ind[2], ind[3]);
        }

        /// <summary>
        /// Sets the string value of the field specified.  See class docs for location spec syntax.
        /// </summary>
        ///
        /// <param name="spec">             The specifier. </param>
        /// <param name="value_Renamed">    The value renamed. </param>

        public virtual void Set(System.String spec, System.String value_Renamed)
        {
            SupportClass.Tokenizer tok = new SupportClass.Tokenizer(spec, "-", false);
            ISegment segment = this.getSegment(tok.NextToken());

            int[] ind = getIndices(spec);
            if (log.DebugEnabled)
            {
                log.Debug(
                    "Setting " + spec + " seg: " + segment.GetStructureName() + " ind: " + ind[0] + " " + ind[1] + " "
                    + ind[2] + " " + ind[3]);
            }
            Set(segment, ind[0], ind[1], ind[2], ind[3], value_Renamed);
        }

        /// <summary>   Returns the segment specified in the given segment_path_spec. </summary>
        ///
        /// <param name="segSpec">  Information describing the segment. </param>
        ///
        /// <returns>   The segment. </returns>

        public virtual ISegment getSegment(System.String segSpec)
        {
            ISegment seg = null;

            if (segSpec.Substring(0, (1) - (0)).Equals("/"))
            {
                this.Finder.reset();
            }

            SupportClass.Tokenizer tok = new SupportClass.Tokenizer(segSpec, "/", false);
            SegmentFinder finder = this.Finder;
            while (tok.HasMoreTokens())
            {
                System.String pathSpec = tok.NextToken();
                Terser.PathSpec ps = this.parsePathSpec(pathSpec);
                if (tok.HasMoreTokens())
                {
                    ps.isGroup = true;
                }
                else
                {
                    ps.isGroup = false;
                }

                if (ps.isGroup)
                {
                    IGroup g = null;
                    if (ps.find)
                    {
                        g = finder.findGroup(ps.pattern, ps.rep);
                    }
                    else
                    {
                        g = finder.getGroup(ps.pattern, ps.rep);
                    }
                    finder = new SegmentFinder(g);
                }
                else
                {
                    if (ps.find)
                    {
                        seg = finder.findSegment(ps.pattern, ps.rep);
                    }
                    else
                    {
                        seg = finder.getSegment(ps.pattern, ps.rep);
                    }
                }
            }

            return seg;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the component (or sub-component, as the case may be) at the given index.  If it does
        /// not exist, it is added as an "extra component".  
        /// If comp > 1 is requested from a Varies with GenericPrimitive data, the data is set to
        /// GenericComposite (this avoids the creation of a chain of ExtraComponents on
        /// GenericPrimitives).  
        /// Components are numbered from 1.  
        /// </summary>
        ///
        /// <exception cref="ApplicationException"> Thrown when an Application error condition occurs. </exception>
        ///
        /// <param name="type"> The type. </param>
        /// <param name="comp"> The component. </param>
        ///
        /// <returns>   The component. </returns>

        private static IType getComponent(IType type, int comp)
        {
            IType ret = null;
            if (typeof(Varies).IsAssignableFrom(type.GetType()))
            {
                Varies v = (Varies)type;

                try
                {
                    if (comp > 1 && typeof(GenericPrimitive).IsAssignableFrom(v.Data.GetType()))
                    {
                        v.Data = new GenericComposite(v.Message);
                    }
                }
                catch (DataTypeException de)
                {
                    System.String message = "Unexpected exception copying data to generic composite: " + de.Message;
                    log.Error(message, de);
                    throw new System.ApplicationException(message);
                }

                ret = getComponent(v.Data, comp);
            }
            else
            {
                if (typeof(IPrimitive).IsAssignableFrom(type.GetType()) && comp == 1)
                {
                    ret = type;
                }
                else if (typeof(GenericComposite).IsAssignableFrom(type.GetType())
                         || (typeof(IComposite).IsAssignableFrom(type.GetType()) && comp <= numStandardComponents(type)))
                {
                    //note that GenericComposite can return components > number of standard components

                    try
                    {
                        ret = ((IComposite)type)[comp - 1];
                    }
                    catch (System.Exception e)
                    {
                        //TODO:  This may not be the write exception type:  Error() was originally thrown, but was not in project.
                        throw new ApplicationException(
                            "Internal error: HL7Exception thrown on getComponent(x) where x < # standard components.",
                            e);
                    }
                }
                else
                {
                    ret = type.ExtraComponents.getComponent(comp - numStandardComponents(type) - 1);
                }
            }
            return ret;
        }

        /// <summary>   Returns the Primitive object at the given location. </summary>
        ///
        /// <param name="segment">      the segment from which to get the primitive. </param>
        /// <param name="field">        the field number. </param>
        /// <param name="rep">          the field repetition. </param>
        /// <param name="component">    the component number (use 1 for primitive field) </param>
        /// <param name="subcomponent"> the subcomponent number (use 1 for primitive component) </param>
        ///
        /// <returns>   The primitive. </returns>

        private static IPrimitive getPrimitive(ISegment segment, int field, int rep, int component, int subcomponent)
        {
            IType type = segment.GetField(field, rep);
            return getPrimitive(type, component, subcomponent);
        }

        /// <summary>
        /// Attempts to extract a Primitive from the given type. If it's a composite, drills down through
        /// first components until a primitive is reached.
        /// </summary>
        ///
        /// <exception cref="ApplicationException"> Thrown when an Application error condition occurs. </exception>
        ///
        /// <param name="type"> The type. </param>
        ///
        /// <returns>   The primitive. </returns>

        private static IPrimitive getPrimitive(IType type)
        {
            IPrimitive p = null;
            if (typeof(Varies).IsAssignableFrom(type.GetType()))
            {
                p = getPrimitive(((Varies)type).Data);
            }
            else if (typeof(IComposite).IsAssignableFrom(type.GetType()))
            {
                try
                {
                    p = getPrimitive(((IComposite)type)[0]);
                }
                catch (HL7Exception)
                {
                    throw new System.ApplicationException(
                        "Internal error: HL7Exception thrown on Composite.getComponent(0).");
                }
            }
            else if (type is IPrimitive)
            {
                p = (IPrimitive)type;
            }
            return p;
        }

        /// <summary>   Number standard components. </summary>
        ///
        /// <param name="t">    The IType to process. </param>
        ///
        /// <returns>   The total number of standard components. </returns>

        private static int numStandardComponents(IType t)
        {
            int n = 0;
            if (typeof(Varies).IsAssignableFrom(t.GetType()))
            {
                n = numStandardComponents(((Varies)t).Data);
            }
            else if (typeof(IComposite).IsAssignableFrom(t.GetType()))
            {
                n = ((IComposite)t).Components.Length;
            }
            else
            {
                n = 1;
            }
            return n;
        }

        /// <summary>   Gets path information from a path spec. </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="spec"> The specifier. </param>
        ///
        /// <returns>   A PathSpec. </returns>

        private PathSpec parsePathSpec(System.String spec)
        {
            PathSpec ps = new PathSpec(this);

            if (spec.StartsWith("."))
            {
                ps.find = true;
                spec = spec.Substring(1);
            }
            else
            {
                ps.find = false;
            }

            if (spec.Length == 0)
            {
                throw new HL7Exception("Invalid path (some path element is either empty or contains only a dot)");
            }
            SupportClass.Tokenizer tok = new SupportClass.Tokenizer(spec, "()", false);
            ps.pattern = tok.NextToken();
            if (tok.HasMoreTokens())
            {
                System.String repString = tok.NextToken();
                try
                {
                    ps.rep = System.Int32.Parse(repString);
                }
                catch (System.FormatException)
                {
                    throw new HL7Exception(repString + " is not a valid rep #", HL7Exception.APPLICATION_INTERNAL_ERROR);
                }
            }
            else
            {
                ps.rep = 0;
            }
            return ps;
        }

        #endregion

        /// <summary>   Struct for information about a step in a segment path. </summary>
        private class PathSpec
        {
            #region Fields

            /// <summary>   true to find. </summary>
            public bool find;

            /// <summary>   true if this object is group. </summary>
            public bool isGroup;

            /// <summary>   Specifies the pattern. </summary>
            public System.String pattern;

            /// <summary>   The rep. </summary>
            public int rep;

            /// <summary>   The enclosing instance. </summary>
            private Terser enclosingInstance;

            #endregion

            #region Constructors and Destructors

            /// <summary>   Initializes a new instance of the PathSpec class. </summary>
            ///
            /// <param name="enclosingInstance">    The enclosing instance. </param>

            public PathSpec(Terser enclosingInstance)
            {
                this.InitBlock(enclosingInstance);
            }

            #endregion

            #region Public Properties

            /// <summary>   Gets the enclosing instance. </summary>
            ///
            /// <value> The enclosing instance. </value>

            public Terser Enclosing_Instance
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

            private void InitBlock(Terser enclosingInstance)
            {
                this.enclosingInstance = enclosingInstance;
            }

            #endregion
        }
    }
}