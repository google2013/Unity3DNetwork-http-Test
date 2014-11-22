
using Game.Network;


//	TestReq.cs
//	Author: Lu Zexi
//	2012-11-22



public class TestReq:HTTPPacketRequest
{
	public string arg1;
	public int arg2;
	public float arg3;

	public TestReq()
	{
		this.m_strAction = "auth/autoregist?";
	}
}