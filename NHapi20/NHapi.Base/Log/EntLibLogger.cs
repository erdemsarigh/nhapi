namespace NHapi.Base.Log
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Logger implementation logging to Enterprise Library Logging Block.
    /// </summary>
    internal class EntLibLogger : ILog
    {
        #region Constants

        private const string DefaultDebugCategory = "Debug";

        #endregion

        #region Static Fields

        private static TraceSwitch _traceSwitch = new TraceSwitch("nHapi", "nHapi Trace Switch");

        #endregion

        #region Public Properties

        /// <summary>
        /// EntLib does not allow us to check for DebugEnabled, so we return true always.  
        /// This can be filtered out at the configuration level.
        /// </summary>
        public bool DebugEnabled
        {
            get
            {
                return false;
            }
        }

        public bool ErrorEnabled
        {
            get
            {
                return false;
            }
        }

        public bool FatalEnabled
        {
            get
            {
                return false;
            }
        }

        public bool InfoEnabled
        {
            get
            {
                return false;
            }
        }

        public bool TraceEnabled
        {
            get
            {
                return false;
            }
        }

        public bool WarnEnabled
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region Public Methods and Operators

        public void Debug(object message)
        {
            this.Debug(message, null);
        }

        public void Debug(object message, Exception t)
        {
            // Instead of setting a category, we use the Verbose severity to indicate
            // the need for debugging.  This avoids the need to have a consumer of 
            // the library setup a category in the logging configuration.
            WriteLog(message, t, System.Diagnostics.TraceLevel.Verbose);
        }

        public void Error(object message)
        {
            this.Error(message, null);
        }

        public void Error(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Error);
        }

        public void Fatal(object message)
        {
            this.Fatal(message, null);
        }

        public void Fatal(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Error);
        }

        public void Info(object message)
        {
            this.Info(message, null);
        }

        public void Info(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Info);
        }

        public void Trace(object message)
        {
            this.Trace(message, null);
        }

        public void Trace(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Info);
        }

        public void Warn(object message)
        {
            this.Warn(message, null);
        }

        public void Warn(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceLevel.Warning);
        }

        #endregion

        #region Methods

        private static void WriteLog(object message, Exception t, System.Diagnostics.TraceLevel severity)
        {
            WriteLog(message, t, severity, null);
        }

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