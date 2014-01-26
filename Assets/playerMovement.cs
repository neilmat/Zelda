using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed = 4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(edgeDetection.panning == true) return;
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Vector2 vel = rigidbody2D.velocity;
		vel.x = speed * h;
		vel.y = speed * v;

		rigidbody2D.velocity = vel;
	}
}
