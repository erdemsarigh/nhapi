namespace NHapi.Base.Log
{
    using System;
    using System.Diagnostics;

    /// <summary>   Logger implementation logging to Enterprise Library Logging Block. </summary>
    internal class EntLibLogger : ILog
    {
        #region Constants

        /// <summary>   The default debug category. </summary>
        private const string DefaultDebugCategory = "Debug";

        #endregion

        #region Static Fields

        /// <summary>   The trace switch. </summary>
        private static TraceSwitch _traceSwitch = new TraceSwitch("nHapi", "nHapi Trace Switch");

        #endregion

        #region Public Properties

        /// <summary>
        /// EntLib does not allow us to check for DebugEnabled, so we return true always.  
        /// This can be filtered out at the configuration level.
        /// </summary>
        ///
        /// <value> true if debug enabled, false if not. </value>

        public bool DebugEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Gets a value indicating whether the error is enabled. </summary>
        ///
        /// <value> true if error enabled, false if not. </value>

        public bool ErrorEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Gets a value indicating whether the fatal is enabled. </summary>
        ///
        /// <value> true if fatal enabled, false if not. </value>

        public bool FatalEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Gets a value indicating whether the information is enabled. </summary>
        ///
        /// <value> true if information enabled, false if not. </value>

        public bool InfoEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Gets a value indicating whether the trace is enabled. </summary>
        ///
        /// <value> true if trace enabled, false if not. </value>

        public bool TraceEnabled
        {
            get
            {
                return false;
            }
        }

        /// <summary>   Gets a value indicating whether the warning is enabled. </summary>
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

        /// <summary>   Debugs. </summary>
        ///
        /// <param name="message">  The message. </param>

        public void Debug(object message)
        {
            this.Debug(message, null);
        }

        /// <summary>   Debugs. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        public void Debug(object message, Exception t)
        {
            // Instead of setting a category, we use the Verbose severity to indicate
            // the need for debugging.  This avoids the need to have a consumer of 
            // the library setup a category in the logging configuration.
            WriteLog(message, t, System.Diagnostics.TraceLevel.Verbose);
        }

        /// <summary>   Errors. </summary>
        ///
        /// <param name="message">  The message. </param>

        public void Error(object message)
        {
            this.Error(message, null);
        }

        /// <summary>   Errors. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        public void Error(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Error);
        }

        /// <summary>   Fatals. </summary>
        ///
        /// <param name="message">  The message. </param>

        public void Fatal(object message)
        {
            this.Fatal(message, null);
        }

        /// <summary>   Fatals. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        public void Fatal(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Error);
        }

        /// <summary>   Infoes. </summary>
        ///
        /// <param name="message">  The message. </param>

        public void Info(object message)
        {
            this.Info(message, null);
        }

        /// <summary>   Infoes. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        public void Info(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Info);
        }

        /// <summary>   Traces. </summary>
        ///
        /// <param name="message">  The message. </param>

        public void Trace(object message)
        {
            this.Trace(message, null);
        }

        /// <summary>   Traces. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        public void Trace(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Info);
        }

        /// <summary>   Warns. </summary>
        ///
        /// <param name="message">  The message. </param>

        public void Warn(object message)
        {
            this.Warn(message, null);
        }

        /// <summary>   Warns. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>

        public void Warn(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Warning);
        }

        #endregion

        #region Methods

        /// <summary>   Writes a log. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>
        /// <param name="severity"> The severity. </param>

        private static void WriteLog(object message, Exception t, System.Diagnostics.TraceLevel severity)
        {
            WriteLog(message, t, severity, null);
        }

        /// <summary>   Writes a log. </summary>
        ///
        /// <param name="message">  The message. </param>
        /// <param name="t">        The Exception to process. </param>
        /// <param name="severity"> The severity. </param>
        /// <param name="category"> The category. </param>

        private static void WriteLog(
            object message,
            Exception t,
            System.Diagnostics.TraceLevel severity,
            string category)
        {
            bool writeTrace = false;
            if (_traceSwitch.Level >= severity)
            {
                writeTrace = true;
            }

            if (writeTrace)
            {
                Exception ex;
                if (message == null)
                {
                    ex = t;
                }
                else
                {
                    ex = new Exception(message.ToString(), t);
                }

                WriteTrace(_traceSwitch, ex, category);
            }
        }

        /// <summary>   Writes a trace. </summary>
        ///
        /// <param name="ts">       The ts. </param>
        /// <param name="ex">       The ex. </param>
        /// <param name="category"> The category. </param>

        private static void WriteTrace(TraceSwitch ts, Exception ex, string category)
        {
            if (category == null)
            {
                System.Diagnostics.Trace.WriteLine(ex);
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(ex, category);
            }
        }

        #endregion
    }
}