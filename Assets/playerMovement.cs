using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed = 4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(playerState.disabled == true) return;
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Vector2 vel = rigidbody2D.velocity;
		vel.x = vel.y = 0;

		if(v != 0)vel.y = speed * v;
		else vel.x = speed * h;

		rigidbody2D.velocity = vel;
	}
}
