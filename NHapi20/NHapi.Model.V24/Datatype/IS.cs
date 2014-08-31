using System;

using NHapi.Base.Model;
namespace NHapi.Model.V24.Datatype
{
/// <summary>   Summary description for IS. </summary>
public class IS: NHapi.Base.Model.Primitive.IS
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
                /// <param name="theTable">     The table which this type belongs. </param>

                public IS(IMessage theMessage,int theTable):base(theMessage, theTable)
                {}

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="message">      message to which this Type belongs. </param>
                /// <param name="theTable">     The table which this type belongs. </param>
                /// <param name="description">  The description of this type. </param>

		        public IS(IMessage message, int theTable, string description) : base(message,theTable, description)
    	        {}
                }}