using UnityEngine;
using System.Collections;
using Game.Network;

//	httpTest.cs
//	Author: Lu Zexi
//	2014-11-22


public class httpTest : MonoBehaviour {

	private HTTPSession session;

	// Use this for initialization
	void Start ()
	{
		session = new HTTPSession("http://goshit.luzexi.com/index.php/");

		TestReq req = new TestReq();
		req.arg1 = "1";
		req.arg2 = 0;
		req.arg3 = 0.3f;

		session.SendGET(req , (TestAck ack)=>{
			Debug.Log("ok"); 
			Debug.Log("username: " + ack.data.username);
			Debug.Log("password : " + ack.data.password);
			Debug.Log(" token : " + ack.data.token);
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
