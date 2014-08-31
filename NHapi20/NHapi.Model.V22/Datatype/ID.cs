using System;

using NHapi.Base.Model;
namespace NHapi.Model.V22.Datatype
{
/// <summary>   Summary description for ID. </summary>
public class ID: NHapi.Base.Model.Primitive.ID
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
                /// <param name="theTable">     The table which this type belongs. </param>

                public ID(IMessage theMessage,int theTable):base(theMessage, theTable)
                {}

                /// <summary>   Construct the type. </summary>
                ///
                /// <param name="message">      message to which this Type belongs. </param>
                /// <param name="theTable">     The table which this type belongs. </param>
                /// <param name="description">  The description of this type. </param>

		        public ID(IMessage message, int theTable, string description) : base(message,theTable, description)
    	        {}
                }}