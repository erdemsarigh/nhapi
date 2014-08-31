using System;

using NHapi.Base.Model;
namespace NHapi.Model.V231.Datatype
{
/// <summary>   Summary description for ST. </summary>
public class ST: AbstractPrimitive
{
            /// <summary>   Return the version. </summary>
            ///
            /// <value> 2.3.1. </value>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.3.1";
			    }
		    }

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="theMessage">   message to which this Type belongs. </param>

                public ST(IMessage theMessage):base(theMessage)
                {}

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="message">      message to which this Type belongs. </param>
                /// <param name="description">  The description of this type. </param>

		        public ST(IMessage message, string description) : base(message,description)
    	        {}
                }}