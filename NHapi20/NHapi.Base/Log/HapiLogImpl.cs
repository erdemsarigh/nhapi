/*
* HapiLog.java
* 
* Created on May 7, 2003 at 2:23:45 PM
*/

namespace NHapi.Base.Log
{
    /// <summary> Provides a base implementation of the <code>HapiLog</code> interface.
    /// 
    /// It delegates all method calls declared by <code>Log</code> to the delegate specified in
    /// the contructor.
    /// 
    /// </summary>
    /// <author>  <a href="mailto:alexei.guevara@uhn.on.ca">Alexei Guevara</a>
    /// </author>
    /// <version>  $Revision: 1.2 $ updated on $Date: 2003/05/26 20:17:06 $ by $Author: aguevara $
    /// </version>
    public class HapiLogImpl : IHapiLog
    {
        #region Fields

        private ILog innerLog;

        #endregion

        #region Constructors and Destructors

        internal HapiLogImpl(ILog log)
        {
            this.innerLog = log;
        }

        #endregion

        #region Public Properties

        /// <returns>
        /// </returns>
        public virtual bool DebugEnabled
        {
            get
            {
                return this.innerLog.DebugEnabled;
            }
        }

        /// <returns>
        /// </returns>
        public virtual bool ErrorEnabled
        {
            get
            {
                return this.innerLog.ErrorEnabled;
            }
        }

        /// <returns>
        /// </returns>
        public virtual bool FatalEnabled
        {
            get
            {
                return this.innerLog.FatalEnabled;
            }
        }

        /// <returns>
        /// </returns>
        public virtual bool InfoEnabled
        {
            get
            {
                return this.innerLog.InfoEnabled;
            }
        }

        /// <returns>
        /// </returns>
        public virtual bool TraceEnabled
        {
            get
            {
                return this.innerLog.TraceEnabled;
            }
        }

        /// <returns>
        /// </returns>
        public virtual bool WarnEnabled
        {
            get
            {
                return this.innerLog.WarnEnabled;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <param name="message">
        /// </param>
        public virtual void Debug(System.Object message)
        {
            this.innerLog.Debug(message);
        }

        /// <param name="message">
        /// </param>
        /// <param name="t">
        /// </param>
        public virtual void Debug(System.Object message, System.Exception t)
        {
            this.innerLog.Debug(message, t);
        }

        /// <summary>
        /// debug method
        /// </summary>
        /// <param name="msgPattern"></param>
        /// <param name="values"></param>
        /// <param name="t"></param>
        public virtual void Debug(System.String msgPattern, System.Object[] values, System.Exception t)
        {
            System.String message = System.String.Format(msgPattern, values);
            this.innerLog.Debug(message, t);
        }

        /// <param name="message">
        /// </param>
        public virtual void Error(System.Object message)
        {
            this.innerLog.Error(message);
        }

        /// <param name="message">
        /// </param>
        /// <param name="t">
        /// </param>
        public virtual void Error(System.Object message, System.Exception t)
        {
            this.innerLog.Error(message, t);
        }

        /// <summary>
        /// fatal
        /// </summary>
        /// <param name="message"></param>
        public virtual void Fatal(System.Object message)
        {
            this.innerLog.Fatal(message);
        }

        /// <summary>
        /// fatal
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public virtual void Fatal(System.Object message, System.Exception t)
        {
            this.innerLog.Fatal(message, t);
        }

        /// <summary>
        /// info
        /// </summary>
        /// <param name="message"></param>
        public virtual void Info(System.Object message)
        {
            this.innerLog.Info(message);
        }

        /// <summary>
        /// info
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public virtual void Info(System.Object message, System.Exception t)
        {
            this.innerLog.Info(message, t);
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns></returns>
        public override System.String ToString()
        {
            return this.innerLog.ToString();
        }

        /// <param name="message">
        /// </param>
        public virtual void Trace(System.Object message)
        {
            this.innerLog.Trace(message);
        }

        /// <summary>
        /// Trace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public virtual void Trace(System.Object message, System.Exception t)
        {
            this.innerLog.Trace(message, t);
        }

        /// <summary>
        /// Warn
        /// </summary>
        /// <param name="message"></param>
        public virtual void Warn(System.Object message)
        {
            this.innerLog.Warn(message);
        }

        /// <summary>
        /// Warn
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public virtual void Warn(System.Object message, System.Exception t)
        {
            this.innerLog.Warn(message, t);
        }

        #endregion
    }
}