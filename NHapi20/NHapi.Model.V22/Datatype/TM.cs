using System;

using NHapi.Base.Model;
namespace NHapi.Model.V22.Datatype
{
/// <summary>   Summary description for TM. </summary>
public class TM: NHapi.Base.Model.Primitive.TM
{
            /// <summary>   Return the version. </summary>
            ///
            /// <value> 2.2. </value>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.2";
			    }
		    }

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="theMessage">   message to which this Type belongs. </param>

                public TM(IMessage theMessage):base(theMessage)
                {}

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="message">      message to which this Type belongs. </param>
                /// <param name="description">  The description of this type. </param>

		        public TM(IMessage message, string description) : base(message,description)
    	        {}
                }}