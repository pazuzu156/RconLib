using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Pazuzu156.RconLib
{
	public class RCON
	{
		private Socket _rconSocket;

		public RCON()
		{
			this._rconSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		}

		public bool Connect(IPEndPoint server, string rconPassword)
		{
			try
			{
				this._rconSocket.Connect(server);
			}
			catch(SocketException ex)
			{
				return false;
			}



			return true;
		}
	}
}
