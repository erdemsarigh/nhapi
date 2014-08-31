using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHapi.Model.V23.Datatype;
using NHapi.Model.V23.Group;
using NHapi.Model.V23.Message;
using NUnit.Framework;

namespace NHapi.NUnit
{
    /// <summary>   A test 23 orc. </summary>
    [TestFixture]
    public class Test23Orc
    {
        /// <summary>   Tests this object. </summary>
        [Test]
        public void Test()
        {
            ORM_O01 msg = new ORM_O01();
            ORM_O01_ORDER order =  msg.GetORDER(0);
            EI placerNumber = order.ORC.GetPlacerOrderNumber(0);
            placerNumber.EntityIdentifier.Value = "123";
            

        }
    }
}
