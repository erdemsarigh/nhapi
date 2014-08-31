namespace NHapi.Base
{
    using System;

    /// <summary>   Exception for signalling SQL errors. </summary>
    [global::System.Serializable]
    public class SQLException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the SQLException class. </summary>
        public SQLException()
        {
        }

        /// <summary>   Initializes a new instance of the SQLException class. </summary>
        ///
        /// <param name="message">  The message. </param>

        public SQLException(string message)
            : base(message)
        {
        }

        /// <summary>   Initializes a new instance of the SQLException class. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="inner">    The inner. </param>

        public SQLException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>   Initializes a new instance of the SQLException class. </summary>
        ///
        /// <param name="info">     The information. </param>
        /// <param name="context">  The context. </param>

        protected SQLException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}