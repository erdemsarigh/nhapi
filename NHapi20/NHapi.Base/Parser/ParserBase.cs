/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Parser.java".  Description: 
/// "Parses HL7 message Strings into HL7 Message objects and 
/// encodes HL7 Message objects into HL7 message Strings" 
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

namespace NHapi.Base.Parser
{
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.validation;
    using NHapi.Base.validation.impl;

    /// <summary>
    /// Parses HL7 message Strings into HL7 Message objects and encodes HL7 Message objects into HL7
    /// message Strings.  
    /// </summary>

    public abstract class ParserBase
    {
        #region Static Fields

        /// <summary>   The log. </summary>
        private static readonly IHapiLog _log;

        #endregion

        #region Fields

        /// <summary>   The message validator. </summary>
        private MessageValidator _messageValidator;

        /// <summary>   The model class factory. </summary>
        private IModelClassFactory _modelClassFactory;

        /// <summary>   Context for the validation. </summary>
        private IValidationContext _validationContext;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the ParserBase class. </summary>
        static ParserBase()
        {
            _log = HapiLogFactory.GetHapiLog(typeof(ParserBase));
        }

        /// <summary>   Uses DefaultModelClassFactory for model class lookup. </summary>
        public ParserBase()
            : this(new DefaultModelClassFactory())
        {
        }

        /// <summary>   Initializes a new instance of the ParserBase class. </summary>
        ///
        /// <param name="theFactory">   custom factory to use for model class lookup. </param>

        public ParserBase(IModelClassFactory theFactory)
        {
            this._modelClassFactory = theFactory;
            this.ValidationContext = new DefaultValidation();
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets the default encoding. </summary>
        ///
        /// <value> the preferred encoding of this Parser. </value>

        public abstract System.String DefaultEncoding { get; }

        /// <summary>   Gets the factory. </summary>
        ///
        /// <value> the factory used by this Parser for model class lookup. </value>

        public virtual IModelClassFactory Factory
        {
            get
            {
                return this._modelClassFactory;
            }
        }

        /// <summary>   Gets or sets a context for the validation. </summary>
        ///
        /// <value>
        /// the set of validation rules that is applied to messages parsed or encoded by this parser.
        /// </value>
        ///
        /// ### <param name="theContext">   the set of validation rules to be applied to messages parsed
        ///                                 or encoded by this parser (defaults to
        ///                                 ValidationContextFactory.DefaultValidation) </param>

        public virtual IValidationContext ValidationContext
        {
            get
            {
                return this._validationContext;
            }

            set
            {
                this._validationContext = value;
                this._messageValidator = new MessageValidator(value, true);
            }
        }

        #endregion

        #region Properties

        /// <summary>   Returns event->structure maps. </summary>
        ///
        /// <value> The message structures. </value>

        private static System.Collections.IDictionary MessageStructures
        {
            get
            {
                return EventMapper.Instance.Maps;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Given a concatenation of message type and event (e.g. ADT_A04), and the version,
        ///             finds the corresponding message structure (e.g. ADT_A01).  This  
        ///             is needed because some events share message structures, although it is not needed
        ///             when the message structure is explicitly valued in MSH-9-3. If no mapping is
        ///             found, returns the original name. </summary>
        /// <summary>   version is invalid.  </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="name">     The name. </param>
        /// <param name="version">  . </param>
        ///
        /// <returns>   The message structure for event. </returns>

        public static System.String GetMessageStructureForEvent(System.String name, System.String version)
        {
            System.String structure = null;

            if (!ValidVersion(version))
            {
                throw new HL7Exception("The version " + version + " is unknown");
            }

            System.Collections.Specialized.NameValueCollection p = null;
            try
            {
                p = (System.Collections.Specialized.NameValueCollection)MessageStructures[version];
            }
            catch (System.IO.IOException ioe)
            {
                throw new HL7Exception("Unable to access message strutures", ioe);
            }

            if (p == null)
            {
                throw new HL7Exception("No map found for version " + version);
            }

            structure = p.Get(name);

            if (structure == null)
            {
                structure = name;
            }

            return structure;
        }

        /// <summary>
        /// Creates a version-specific MSH object and returns it as a version-independent MSH interface.
        /// throws HL7Exception if there is a problem, e.g. invalid version, code not available for given
        /// version.
        /// </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="version">  . </param>
        /// <param name="factory">  The factory. </param>
        ///
        /// <returns>   An ISegment. </returns>

        public static ISegment MakeControlMSH(System.String version, IModelClassFactory factory)
        {
            ISegment msh = null;

            try
            {
                IMessage dummy =
                    (IMessage)
                        GenericMessage.getGenericMessageClass(version)
                            .GetConstructor(new[] { typeof(IModelClassFactory) })
                            .Invoke(new System.Object[] { factory });

                System.Type[] constructorParamTypes = { typeof(IGroup), typeof(IModelClassFactory) };
                System.Object[] constructorParamArgs = { dummy, factory };
                System.Type c = factory.GetSegmentClass("MSH", version);
                System.Reflection.ConstructorInfo constructor = c.GetConstructor(constructorParamTypes);
                msh = (ISegment)constructor.Invoke(constructorParamArgs);
            }
            catch (System.Exception e)
            {
                throw new HL7Exception(
                    "Couldn't create MSH for version " + version + " (does your classpath include this version?) ... ",
                    HL7Exception.APPLICATION_INTERNAL_ERROR,
                    e);
            }
            return msh;
        }

        /// <summary>
        /// Returns true if the given string represents a valid 2.x version.  Valid versions include
        /// "2.0", "2.0D", "2.1", "2.2", "2.3", "2.3.1", "2.4", "2.5".
        /// </summary>
        ///
        /// <param name="version">  . </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>

        public static bool ValidVersion(System.String version)
        {
            return PackageManager.Instance.IsValidVersion(version);
        }

        /// <summary>   Formats a Message object into an HL7 message string using the given encoding. </summary>
        /// <summary>   (e.g. required fields are null) </summary>
        /// <summary>   supported by this parser.  </summary>
        ///
        /// <param name="source">   a Message object from which to construct an encoded message string. </param>
        /// <param name="encoding"> the name of the HL7 encoding to use (eg "XML"; most implementations
        ///                         support only  
        ///                         one encoding) </param>
        ///
        /// <returns>   the encoded message. </returns>

        public virtual System.String Encode(IMessage source, System.String encoding)
        {
            this._messageValidator.validate(source);
            System.String result = this.DoEncode(source, encoding);
            this._messageValidator.validate(result, encoding.Equals("XML"), source.Version);

            return result;
        }

        /// <summary>   Formats a Message object into an HL7 message string using this parser's  
        ///             default encoding. </summary>
        /// <summary>   (e.g. required fields are null) </summary>
        ///
        /// <param name="source">   a Message object from which to construct an encoded message string. </param>
        ///
        /// <returns>   the encoded message. </returns>
        ///
        /// ### <param name="encoding"> the name of the encoding to use (eg "XML"; most implementations
        ///                             support only one encoding) </param>

        public virtual System.String Encode(IMessage source)
        {
            System.String encoding = this.DefaultEncoding;

            this._messageValidator.validate(source);
            System.String result = this.DoEncode(source);
            this._messageValidator.validate(result, encoding.Equals("XML"), source.Version);

            return result;
        }

        /// <summary>
        /// For response messages, returns the value of MSA-2 (the message ID of the message sent by the
        /// sending system).  This value may be needed prior to main message parsing, so that
        /// (particularly in a multi-threaded scenario) the message can be routed to the thread that sent
        /// the request.  We need this information first so that any parse exceptions are thrown to the
        /// correct thread.  Implementers of Parsers should take care to make the implementation of this
        /// method very fast and robust.  
        /// Returns null if MSA-2 can not be found (e.g. if the message is not a response message).
        /// </summary>
        ///
        /// <param name="message">  a String that contains an HL7 message. </param>
        ///
        /// <returns>   The acknowledge identifier. </returns>

        public abstract System.String GetAckID(System.String message);

        /// <summary>
        /// <p>Returns a minimal amount of data from a message string, including only the data needed to
        /// send a response to the remote system.  This includes the following fields:
        /// <ul><li>field separator</li>
        /// <li>encoding characters</li>
        /// <li>processing ID</li>
        /// <li>message control ID</li></ul>
        /// This method is intended for use when there is an error parsing a message, (so the Message
        /// object is unavailable) but an error message must be sent back to the remote system including
        /// some of the information in the inbound message.  This method parses only that required
        /// information, hopefully avoiding the condition that caused the original error.</p>  
        /// </summary>
        ///
        /// <param name="message">  a String that contains an HL7 message. </param>
        ///
        /// <returns>   an MSH segment. </returns>

        public abstract ISegment GetCriticalResponseData(System.String message);

        /// <summary>
        /// Returns a String representing the encoding of the given message, if the encoding is
        /// recognized.  For example if the given message appears to be encoded using HL7 2.x XML rules
        /// then "XML" would be returned.  
        /// If the encoding is not recognized then null is returned.  That this method returns a specific
        /// encoding does not guarantee that the message is correctly encoded (e.g. well formed XML) -
        /// just that  
        /// it is not encoded using any other encoding than the one returned.  
        /// Returns null if the encoding is not recognized.  
        /// </summary>
        ///
        /// <param name="message">  a String that contains an HL7 message. </param>
        ///
        /// <returns>   The encoding. </returns>

        public abstract System.String GetEncoding(System.String message);

        /// <summary>
        /// Returns the version ID (MSH-12) from the given message, without fully parsing the message.
        /// The version is needed prior to parsing in order to determine the message class into which the
        /// text of the message should be parsed.
        /// </summary>
        ///
        /// <param name="message">  a String that contains an HL7 message. </param>
        ///
        /// <returns>   The version. </returns>

        public abstract System.String GetVersion(System.String message);

        /// <summary>   Parses a message string and returns the corresponding Message object. </summary>
        /// <summary>   is not supported by this parser. </summary>
        ///
        /// <exception cref="HL7Exception"> Thrown when a HL 7 error condition occurs. </exception>
        ///
        /// <param name="message">  a String that contains an HL7 message. </param>
        ///
        /// <returns>   a HAPI Message object parsed from the given String. </returns>

        public virtual IMessage Parse(System.String message)
        {
            System.String version = this.GetVersion(message);
            if (!ValidVersion(version))
            {
                throw new HL7Exception(
                    "Can't process message of version '" + version + "' - version not recognized",
                    HL7Exception.UNSUPPORTED_VERSION_ID);
            }
            return this.Parse(message, version);
        }

        /// <summary>   Parse a message to a specific assembly. </summary>
        ///
        /// <exception cref="EncodingNotSupportedException">    Thrown when an Encoding Not Supported
        ///                                                     error condition occurs. </exception>
        ///
        /// <param name="message">  . </param>
        /// <param name="version">  . </param>
        ///
        /// <returns>   An IMessage. </returns>

        public virtual IMessage Parse(System.String message, System.String version)
        {
            System.String encoding = this.GetEncoding(message);
            if (!this.SupportsEncoding(encoding))
            {
                throw new EncodingNotSupportedException(
                    "Can't parse message beginning " + message.Substring(0, (System.Math.Min(message.Length, 50)) - (0)));
            }

            this._messageValidator.validate(message, encoding.Equals("XML"), version);
            IMessage result = this.DoParse(message, version);
            this._messageValidator.validate(result);

            return result;
        }

        /// <summary>
        /// Returns true if and only if the given encoding is supported by this Parser.  
        /// </summary>
        ///
        /// <param name="encoding"> the name of the HL7 encoding to use (eg "XML"; most implementations
        ///                         support only  
        ///                         one encoding) </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>

        public abstract bool SupportsEncoding(System.String encoding);

        #endregion

        #region Methods

        /// <summary>
        /// Called by encode(Message, String) to perform implementation-specific encoding work.
        /// </summary>
        ///
        /// <summary>   supported by this parser.   </summary>
        ///
        /// <summary>   (e.g. required fields are null) </summary>
        ///
        /// <param name="source">   a Message object from which to construct an encoded message string. </param>
        /// <param name="encoding"> the name of the HL7 encoding to use (eg "XML"; most implementations
        ///                         support only one encoding) </param>
        ///
        /// <returns>   the encoded message. </returns>

        protected internal abstract System.String DoEncode(IMessage source, System.String encoding);

        /// <summary>
        /// Called by encode(Message) to perform implementation-specific encoding work.
        /// </summary>
        ///
        /// <summary>   supported by this parser.   </summary>
        ///
        /// <summary>   (e.g. required fields are null) </summary>
        ///
        /// <param name="source">   a Message object from which to construct an encoded message string. </param>
        ///
        /// <returns>   the encoded message. </returns>

        protected internal abstract System.String DoEncode(IMessage source);

        /// <summary>   Called by parse() to perform implementation-specific parsing work.   </summary>
        ///
        /// <summary>   is not supported by this parser. </summary>
        ///
        /// <param name="message">  a String that contains an HL7 message. </param>
        /// <param name="version">  the name of the HL7 version to which the message belongs (eg "2.5") </param>
        ///
        /// <returns>   a HAPI Message object parsed from the given String. </returns>

        protected internal abstract IMessage DoParse(System.String message, System.String version);

        /// <summary>   Note that the validation context of the resulting message is set to this parser's
        ///             validation context.  The validation context is used within Primitive.setValue(). </summary>
        /// <summary>   class throws an exception on instantiation (e.g. if args are not as expected) </summary>
        ///
        /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
        ///
        /// <param name="theName">      name of the desired structure in the form XXX_YYY. </param>
        /// <param name="theVersion">   HL7 version (e.g. "2.3")  </param>
        /// <param name="isExplicit">   true if the structure was specified explicitly in MSH-9-3, false
        ///                             if it was inferred from MSH-9-1 and MSH-9-2.  If false, a lookup
        ///                             may be performed to find an alternate structure corresponding to
        ///                             that message type and event. </param>
        ///
        /// <returns>   a Message instance. </returns>

        protected internal virtual IMessage InstantiateMessage(
            System.String theName,
            System.String theVersion,
            bool isExplicit)
        {
            IMessage result = null;
            System.Type messageClass = this._modelClassFactory.GetMessageClass(theName, theVersion, isExplicit);
            if (messageClass == null)
            {
                throw new System.Exception("Can't find message class in current package list: " + theName);
            }
            _log.Info("Instantiating msg of class " + messageClass.FullName);
            System.Reflection.ConstructorInfo constructor =
                messageClass.GetConstructor(new[] { typeof(IModelClassFactory) });
            result = (IMessage)constructor.Invoke(new System.Object[] { this._modelClassFactory });
            result.ValidationContext = this._validationContext;
            return result;
        }

        #endregion
    }
}