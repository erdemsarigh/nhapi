using System;
using NHapi.Model.V23;
using NHapi.Model.V23.Datatype;
using NHapi.Model.V23.Message;
using NHapi.Base.Parser;
using NUnit.Framework;

namespace NHapi.NUnit
{
    /// <summary>   Summary description for DateTypeTest. </summary>
	[TestFixture]
	public class DateTypeTest23
	{
        /// <summary>   Converts this object to a date. </summary>
		[Test]
		public void ConvertToDate()
		{
			DateTime checkDate = DateTime.Now;
			PipeParser parser = new PipeParser();
			ADT_A01 a01 = new ADT_A01();
            a01.PV1.AdmitDateTime.TimeOfAnEvent.Set(checkDate, "yyyyMMdd");
            Assert.AreEqual(a01.PV1.AdmitDateTime.TimeOfAnEvent.Value, checkDate.ToString("yyyyMMdd"));
		}

        /// <summary>   Converts this object to a long date. </summary>
		[Test]
		public void ConvertToLongDate()
		{
			DateTime checkDate = DateTime.Now;
			ACK ack = new ACK();
			ack.MSH.DateTimeOfMessage.TimeOfAnEvent.SetLongDate(checkDate);
			Assert.AreEqual(ack.MSH.DateTimeOfMessage.TimeOfAnEvent.Value, checkDate.ToString("yyyyMMddHHmm"));
		}

        /// <summary>   Converts this object to a long date with second. </summary>
		[Test]
		public void ConvertToLongDateWithSecond()
		{
			DateTime checkDate = DateTime.Now;
			ACK ack = new ACK();
			ack.MSH.DateTimeOfMessage.TimeOfAnEvent.SetLongDateWithSecond(checkDate);
			Assert.AreEqual(ack.MSH.DateTimeOfMessage.TimeOfAnEvent.Value, checkDate.ToString("yyyyMMddHHmmss"));
		}
		
        /// <summary>   Converts this object to a long date with fraction of second. </summary>
		[Test]
		public void ConvertToLongDateWithFractionOfSecond()
		{
			DateTime checkDate = DateTime.Now;
			ACK ack = new ACK();
			ack.MSH.DateTimeOfMessage.TimeOfAnEvent.SetLongDateWithFractionOfSecond(checkDate);
			Assert.AreEqual(ack.MSH.DateTimeOfMessage.TimeOfAnEvent.Value, checkDate.ToString("yyyyMMddHHmmss.FFFF"));
		}
		
        /// <summary>   Converts this object to a short date. </summary>
		[Test]
		public void ConvertToShortDate()
		{
			DateTime checkDate = DateTime.Now;
			ACK ack = new ACK();
			ack.MSH.DateTimeOfMessage.TimeOfAnEvent.SetShortDate(checkDate);
			Assert.AreEqual(ack.MSH.DateTimeOfMessage.TimeOfAnEvent.Value, checkDate.ToString("yyyyMMdd"));
		}

        /// <summary>   Convert back to short date. </summary>
		[Test]
		public void ConvertBackToShortDate()
		{
			DateTime checkDate = DateTime.Now;
			ACK ack = new ACK();
			ack.MSH.DateTimeOfMessage.TimeOfAnEvent.SetShortDate(checkDate);
			
			DateTime checkDate2 = ack.MSH.DateTimeOfMessage.TimeOfAnEvent.GetAsDate();

			Assert.AreEqual(checkDate.ToShortDateString(), checkDate2.ToShortDateString());
		}

        /// <summary>   Convert back to long date. </summary>
		[Test]
		public void ConvertBackToLongDate()
		{
			DateTime checkDate = DateTime.Now;
			ACK ack = new ACK();
			ack.MSH.DateTimeOfMessage.TimeOfAnEvent.SetLongDate(checkDate);
			
			DateTime checkDate2 = ack.MSH.DateTimeOfMessage.TimeOfAnEvent.GetAsDate();

			Assert.AreEqual(checkDate.ToLongDateString(), checkDate2.ToLongDateString());
		}
	}
}
