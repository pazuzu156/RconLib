using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Pazuzu156.RconLib;

namespace RconLibTests
{
	[TestClass]
	public class RCONConnectionTest
	{
		[TestMethod]
		public void TestConnection()
		{
			IPEndPoint server = new IPEndPoint(IPAddress.Parse("192.168.1.50"), 25575);
			RCON rcon = new RCON();
			Assert.IsTrue(rcon.Connect(server, "testpassword"), "connection test");
		}
	}
}
