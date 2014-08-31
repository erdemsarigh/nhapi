namespace NHapi.Base.Log
{
    using System;

    /// <summary>   Interface for log. </summary>
    ///
    /// <remarks>   Added for conversion will need to replace. </remarks>

    public interface ILog
    {
        #region Public Properties

        /// <summary>   Gets a value indicating whether the debug is enabled. </summary>
        ///
        /// <value> true if debug enabled, false if not. </value>

        bool DebugEnabled { get; }

        /// <summary>   Gets a value indicating whether the error is enabled. </summary>
        ///
        /// <value> true if error enabled, false if not. </value>

        bool ErrorEnabled { get; }

        /// <summary>   Gets a value indicating whether the fatal is enabled. </summary>
        ///
        /// <value> true if fatal enabled, false if not. </value>

        bool FatalEnabled { get; }

        /// <summary>   Gets a value indicating whether the information is enabled. </summary>
        ///
        /// <value> true if information enabled, false if not. </value>

        bool InfoEnabled { get; }

        /// <summary>   Gets a value indicating whether the trace is enabled. </summary>
        ///
        /// <value> true if trace enabled, false if not. </value>

        bool TraceEnabled { get; }

        /// <summary>   Gets a value indicating whether the warning is enabled. </summary>
        ///
        /// <value> true if warning enabled, false if not. </value>

        bool WarnEnabled { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Debugs. </summary>
        ///
        /// <param name="message">  The message. </param>

        void Debug(System.Object message);

        /// <summary>   Debugs. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        void Debug(System.Object message, System.Exception t);

        /// <summary>   Errors. </summary>
        ///
        /// <param name="message">  The message. </param>

        void Error(System.Object message);

        /// <summary>   Errors. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        void Error(System.Object message, System.Exception t);

        /// <summary>   Fatals. </summary>
        ///
        /// <param name="message">  The message. </param>

        void Fatal(System.Object message);

        /// <summary>   Fatals. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        void Fatal(System.Object message, System.Exception t);

        /// <summary>   Infoes. </summary>
        ///
        /// <param name="message">  The message. </param>

        void Info(System.Object message);

        /// <summary>   Infoes. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        void Info(System.Object message, System.Exception t);

        /// <summary>   Traces. </summary>
        ///
        /// <param name="message">  The message. </param>

        void Trace(System.Object message);

        /// <summary>   Traces. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        void Trace(System.Object message, System.Exception t);

        /// <summary>   Warns. </summary>
        ///
        /// <param name="message">  The message. </param>

        void Warn(System.Object message);

        /// <summary>   Warns. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        void Warn(System.Object message, System.Exception t);

        #endregion
    }

    /// <summary>   Dummy logger. </summary>
    public sealed class DummyLogger : ILog
    {
        #region Public Properties

        /// <summary>   Is debug enabled. </summary>
        ///
        /// <value> true if debug enabled, false if not. </value>

        public bool DebugEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Is error enabled. </summary>
        ///
        /// <value> true if error enabled, false if not. </value>

        public bool ErrorEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Is fatal enabled. </summary>
        ///
        /// <value> true if fatal enabled, false if not. </value>

        public bool FatalEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Is info enabled. </summary>
        ///
        /// <value> true if information enabled, false if not. </value>

        public bool InfoEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   is trace enabled. </summary>
        ///
        /// <value> true if trace enabled, false if not. </value>

        public bool TraceEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Is warn enabled. </summary>
        ///
        /// <value> true if warning enabled, false if not. </value>

        public bool WarnEnabled
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Write debug message. </summary>
        ///
        /// <param name="message">  . </param>

        public void Debug(object message)
        {
            // No implementation
        }

        /// <summary>   Write debug message. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public void Debug(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>   Write error. </summary>
        ///
        /// <param name="message">  . </param>

        public void Error(object message)
        {
            // No implementation
        }

        /// <summary>   Write error. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public void Error(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>   Write fatal. </summary>
        ///
        /// <param name="message">  . </param>

        public void Fatal(object message)
        {
            // No implementation
        }

        /// <summary>   Write fatal. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public void Fatal(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>   Write info. </summary>
        ///
        /// <param name="message">  . </param>

        public void Info(object message)
        {
            // No implementation
        }

        /// <summary>   Write info. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public void Info(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>   Write trace. </summary>
        ///
        /// <param name="message">  . </param>

        public void Trace(object message)
        {
            // No implementation
        }

        /// <summary>   Write trace. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public void Trace(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>   Write warn. </summary>
        ///
        /// <param name="message">  . </param>

        public void Warn(object message)
        {
            // No implementation
        }

        /// <summary>   Write warn. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public void Warn(object message, Exception t)
        {
            // No implementation
        }

        #endregion
    }
}