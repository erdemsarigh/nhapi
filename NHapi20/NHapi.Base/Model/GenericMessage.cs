namespace NHapi.Base.Model
{
    using NHapi.Base.Log;
    using NHapi.Base.Parser;

    /// <summary> A generic HL7 message, meant for parsing message with unrecognized structures
    /// into a flat list of segments.
    /// </summary>
    /// <author>  Bryan Tripp
    /// </author>
    public abstract class GenericMessage : AbstractMessage
    {
        #region Constructors and Destructors

        /// <summary> Creates a new instance of GenericMessage. 
        /// 
        /// </summary>
        /// <param name="factory">class factory for contained structures 
        /// </param>
        public GenericMessage(IModelClassFactory factory)
            : base(factory)
        {
            try
            {
                this.addNonstandardSegment("MSH");
            }
            catch (HL7Exception e)
            {
                System.String message = "Unexpected error adding GenericSegment to GenericMessage.";
                HapiLogFactory.GetHapiLog(this.GetType()).Error(message, e);
                throw new System.ApplicationException(message);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary> Returns a subclass of GenericMessage corresponding to a certain version.  
        /// This is needed so that version-specific segments can be added as the message
        /// is parsed.  
        /// </summary>
        public static System.Type getGenericMessageClass(System.String version)
        {
            if (!ParserBase.ValidVersion(version))
            {
                throw new System.ArgumentException("The version " + version + " is not recognized");
            }

            System.Type c = null;
            if (version.Equals("2.1"))
            {
                c = typeof(V21);
            }
            else if (version.Equals("2.2"))
            {
                c = typeof(V22);
            }
            else if (version.Equals("2.3"))
            {
                c = typeof(V23);
            }
            else if (version.Equals("2.3.1"))
            {
                c = typeof(V231);
            }
            else if (version.Equals("2.4"))
            {
                c = typeof(V24);
            }
            else if (version.Equals("2.5"))
            {
                c = typeof(V25);
            }
            return c;
        }

        #endregion

        /// <summary>
        /// Version 2.1 generic message
        /// </summary>
        public class V21 : GenericMessage
        {
            #region Constructors and Destructors

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="factory"></param>
            public V21(IModelClassFactory factory)
                : base(factory)
            {
            }

            #endregion

            #region Public Properties

            /// <summary>
            /// Version of message
            /// </summary>
            public override System.String Version
            {
                get
                {
                    return "2.1";
                }
            }

            #endregion
        }

        /// <summary>
        /// Version 2.2 generic message
        /// </summary>
        public class V22 : GenericMessage
        {
            #region Constructors and Destructors

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="factory"></param>
            public V22(IModelClassFactory factory)
                : base(factory)
            {
            }

            #endregion

            #region Public Properties

            /// <summary>
            /// Version of message
            /// </summary>
            public override System.String Version
            {
                get
                {
                    return "2.2";
                }
            }

            #endregion
        }

        /// <summary>
        /// Version 2.3 generic message
        /// </summary>
        public class V23 : GenericMessage
        {
            #region Constructors and Destructors

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="factory"></param>
            public V23(IModelClassFactory factory)
                : base(factory)
            {
            }

            #endregion

            #region Public Properties

            /// <summary>
            /// Version of message
            /// </summary>
            public override System.String Version
            {
                get
                {
                    return "2.3";
                }
            }

            #endregion
        }

        /// <summary>
        /// Version 2.3.1 generic message
        /// </summary>
        public class V231 : GenericMessage
        {
            #region Constructors and Destructors

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="factory"></param>
            public V231(IModelClassFactory factory)
                : base(factory)
            {
            }

            #endregion

            #region Public Properties

            /// <summary>
            /// Version of message
            /// </summary>
            public override System.String Version
            {
                get
                {
                    return "2.3.1";
                }
            }

            #endregion
        }

        /// <summary>
        /// Version 2.4 generic message
        /// </summary>
        public class V24 : GenericMessage
        {
            #region Constructors and Destructors

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="factory"></param>
            public V24(IModelClassFactory factory)
                : base(factory)
            {
            }

            #endregion

            #region Public Properties

            /// <summary>
            /// Version of message
            /// </summary>
            public override System.String Version
            {
                get
                {
                    return "2.4";
                }
            }

            #endregion
        }

        /// <summary>
        /// Version 2.5 generic message
        /// </summary>
        public class V25 : GenericMessage
        {
            #region Constructors and Destructors

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="factory"></param>
            public V25(IModelClassFactory factory)
                : base(factory)
            {
            }

            #endregion

            #region Public Properties

            /// <summary>
            /// Version of message
            /// </summary>
            public override System.String Version
            {
                get
                {
                    return "2.5";
                }
            }

            #endregion
        }
    }
}