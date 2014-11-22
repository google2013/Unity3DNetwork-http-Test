
using Game.Network;



public class TestAck : HTTPPacketAck
{
	public Data data;
	
	public class Data
	{
		public int id;
		public string username;
		public string password;
		public string token;
	}
}
