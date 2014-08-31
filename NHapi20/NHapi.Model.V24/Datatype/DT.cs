using System;

using NHapi.Base.Model;
namespace NHapi.Model.V24.Datatype
{
/// <summary>   Summary description for DT. </summary>
public class DT: NHapi.Base.Model.Primitive.DT
{
            /// <summary>   Return the version. </summary>
            ///
            /// <value> 2.4. </value>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.4";
			    }
		    }

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="theMessage">   message to which this Type belongs. </param>

                public DT(IMessage theMessage):base(theMessage)
                {}

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="message">      message to which this Type belongs. </param>
                /// <param name="description">  The description of this type. </param>

		        public DT(IMessage message, string description) : base(message,description)
    	        {}
                }}