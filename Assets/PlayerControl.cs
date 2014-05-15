using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float multiplier = 0.005f;
	public PlayerColors playerColor;
	//public int PlayerNum;
	// Use this for initialization
	void Start () {
		//var names = Input.GetJoystickNames();
		//int count = 0;
		//foreach(string name in names)
		//{
		//	string s = name + " ------- " + count++;
		//	Debug.Log (s);	
		//}
	}
	public enum PlayerColors
	{
		Green,
		Red,
		Yellow,
		Blue,
	}
	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxis(playerColor.ToString() + "X");
		float y = Input.GetAxis(playerColor.ToString() + "Y");
		Vector2 stick = new Vector2(x, y);
		//MovePlayerVelocity(stick);
		MovePlayerPosition(stick);
		/*
		if(PlayerNum==1)
		{
			float x = Input.GetAxis("GreenX");
			float y = Input.GetAxis("GreenY");
			Vector2 stick = new Vector2(x, y) * multiplier;
		
			transform.rigidbody2D.velocity += stick;
		}
		if(PlayerNum==2)		
		{
			float x = Input.GetAxis("RedX");
			float y = Input.GetAxis("RedY");
			Vector2 stick = new Vector2(x, y) * multiplier;
		
			transform.rigidbody2D.velocity += stick;
		}
		if(PlayerNum==3)		
		{
			float x = Input.GetAxis("YellowX");
			float y = Input.GetAxis("YellowY");
			Vector2 stick = new Vector2(x, y) * multiplier;
		
			transform.rigidbody2D.velocity += stick;
		}
		if(PlayerNum==4)		
		{
			float x = Input.GetAxis("BlueX");
			float y = Input.GetAxis("BlueY");
			Vector2 stick = new Vector2(x, y) * multiplier;
		
			transform.rigidbody2D.velocity += stick;
		}
		*/
	}
	public void MovePlayerVelocity(Vector2 stick)
	{
		stick *= multiplier;
		transform.rigidbody2D.velocity += stick;
	}
	public void MovePlayerPosition(Vector2 stick)
	{
		stick *= multiplier;
		
		transform.rigidbody2D.velocity = Vector2.zero;
		transform.rigidbody2D.velocity = stick * 100;
		//Debug.Log(transform.rigidbody2D.velocity);
	}
}
