using UnityEngine;
using System.Collections;

public class MousePositioning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			Vector2 worldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition );
			//transform.position.x = worldpos.x;
			//transform.position.y = worldpos.y;
			
			Debug.Log(transform.position.x + " " + transform.position.y);
			
			transform.rigidbody2D.velocity = Vector2.zero;
			
			transform.position = new Vector3(0, 0, transform.position.z);
		}
	}
}
