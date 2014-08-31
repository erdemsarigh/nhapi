/*
* HapiLogFactory.java
* 
* Created on May 7, 2003 at 2:19:17 PM
*/

namespace NHapi.Base.Log
{
    /// <summary>
    /// &lt;p&gt;Factory for creating {@link HapiLog} instances. It is factory that delegates the
    /// discovery process to the <code> LogFactory </code>
    /// class and wraps the discovered <code> Log </code> with a new instance of the
    /// <code>HapiLog</code> class.
    /// </summary>

    public sealed class HapiLogFactory
    {
        #region Constructors and Destructors

        /// <summary>   Do not allow instantiation. </summary>
        private HapiLogFactory()
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Convenience method to return a named HAPI logger, without the application having to care
        /// about factories.
        /// </summary>
        ///
        /// <param name="clazz">    Class for which a log name will be derived. </param>
        ///
        /// <returns>   The hapi log. </returns>
        ///
        /// ### <exception cref="LogConfigurationException">    if a suitable <code>Log</code>
        ///                                                     instance cannot be returned. </exception>

        public static IHapiLog GetHapiLog(System.Type clazz)
        {
            IHapiLog retVal = null;

            ILog log = LogFactory.GetLog(clazz);
            retVal = new HapiLogImpl(log);

            return retVal;
        }

        /// <summary>
        /// Convenience method to return a named HAPI logger, without the application having to care
        /// about factories.
        /// </summary>
        ///
        /// <param name="name"> Logical name of the <code>Log</code> instance to be returned (the meaning
        ///                     of this name is only known to the underlying logging implementation that
        ///                     is being wrapped) </param>
        ///
        /// <returns>   The hapi log. </returns>
        ///
        /// ### <exception cref="LogConfigurationException">    if a suitable <code>Log</code>
        ///                                                     instance cannot be returned. </exception>

        public static IHapiLog GetHapiLog(System.String name)
        {
            IHapiLog retVal = null;

            ILog log = LogFactory.GetLog(name);
            retVal = new HapiLogImpl(log);

            return retVal;
        }

        #endregion
    }
}