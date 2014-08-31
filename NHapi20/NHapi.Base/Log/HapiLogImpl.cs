/*
* HapiLog.java
* 
* Created on May 7, 2003 at 2:23:45 PM
*/

namespace NHapi.Base.Log
{
    /// <summary>
    /// Provides a base implementation of the <code>HapiLog</code> interface.
    /// 
    /// It delegates all method calls declared by <code>Log</code> to the delegate specified in the
    /// contructor.
    /// </summary>

    public class HapiLogImpl : IHapiLog
    {
        #region Fields

        /// <summary>   The inner log. </summary>
        private ILog innerLog;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes a new instance of the HapiLogImpl class. </summary>
        ///
        /// <param name="log">  The log. </param>

        internal HapiLogImpl(ILog log)
        {
            this.innerLog = log;
        }

        #endregion

        #region Public Properties

        /// <summary>   Gets a value indicating whether the debug is enabled. </summary>
        ///
        /// <value> true if debug enabled, false if not. </value>

        public virtual bool DebugEnabled
        {
            get
            {
                return this.innerLog.DebugEnabled;
            }
        }

        /// <summary>   Gets a value indicating whether the error is enabled. </summary>
        ///
        /// <value> true if error enabled, false if not. </value>

        public virtual bool ErrorEnabled
        {
            get
            {
                return this.innerLog.ErrorEnabled;
            }
        }

        /// <summary>   Gets a value indicating whether the fatal is enabled. </summary>
        ///
        /// <value> true if fatal enabled, false if not. </value>

        public virtual bool FatalEnabled
        {
            get
            {
                return this.innerLog.FatalEnabled;
            }
        }

        /// <summary>   Gets a value indicating whether the information is enabled. </summary>
        ///
        /// <value> true if information enabled, false if not. </value>

        public virtual bool InfoEnabled
        {
            get
            {
                return this.innerLog.InfoEnabled;
            }
        }

        /// <summary>   Gets a value indicating whether the trace is enabled. </summary>
        ///
        /// <value> true if trace enabled, false if not. </value>

        public virtual bool TraceEnabled
        {
            get
            {
                return this.innerLog.TraceEnabled;
            }
        }

        /// <summary>   Gets a value indicating whether the warning is enabled. </summary>
        ///
        /// <value> true if warning enabled, false if not. </value>

        public virtual bool WarnEnabled
        {
            get
            {
                return this.innerLog.WarnEnabled;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Debugs the given message. </summary>
        ///
        /// <param name="message">  . </param>

        public virtual void Debug(System.Object message)
        {
            this.innerLog.Debug(message);
        }

        /// <summary>   Debugs. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public virtual void Debug(System.Object message, System.Exception t)
        {
            this.innerLog.Debug(message, t);
        }

        /// <summary>   debug method. </summary>
        ///
        /// <param name="msgPattern">   . </param>
        /// <param name="values">       . </param>
        /// <param name="t">            . </param>

        public virtual void Debug(System.String msgPattern, System.Object[] values, System.Exception t)
        {
            System.String message = System.String.Format(msgPattern, values);
            this.innerLog.Debug(message, t);
        }

        /// <summary>   Errors the given message. </summary>
        ///
        /// <param name="message">  . </param>

        public virtual void Error(System.Object message)
        {
            this.innerLog.Error(message);
        }

        /// <summary>   Errors. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public virtual void Error(System.Object message, System.Exception t)
        {
            this.innerLog.Error(message, t);
        }

        /// <summary>   fatal. </summary>
        ///
        /// <param name="message">  . </param>

        public virtual void Fatal(System.Object message)
        {
            this.innerLog.Fatal(message);
        }

        /// <summary>   fatal. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public virtual void Fatal(System.Object message, System.Exception t)
        {
            this.innerLog.Fatal(message, t);
        }

        /// <summary>   info. </summary>
        ///
        /// <param name="message">  . </param>

        public virtual void Info(System.Object message)
        {
            this.innerLog.Info(message);
        }

        /// <summary>   info. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public virtual void Info(System.Object message, System.Exception t)
        {
            this.innerLog.Info(message, t);
        }

        /// <summary>   To string. </summary>
        ///
        /// <returns>   A System.String that represents this object. </returns>

        public override System.String ToString()
        {
            return this.innerLog.ToString();
        }

        /// <summary>   Traces the given message. </summary>
        ///
        /// <param name="message">  . </param>

        public virtual void Trace(System.Object message)
        {
            this.innerLog.Trace(message);
        }

        /// <summary>   Trace. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public virtual void Trace(System.Object message, System.Exception t)
        {
            this.innerLog.Trace(message, t);
        }

        /// <summary>   Warn. </summary>
        ///
        /// <param name="message">  . </param>

        public virtual void Warn(System.Object message)
        {
            this.innerLog.Warn(message);
        }

        /// <summary>   Warn. </summary>
        ///
        /// <param name="message">  . </param>
        /// <param name="t">        . </param>

        public virtual void Warn(System.Object message, System.Exception t)
        {
            this.innerLog.Warn(message, t);
        }

        #endregion
    }
}