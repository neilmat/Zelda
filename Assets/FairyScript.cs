using UnityEngine;
using System.Collections;

public class FairyScript : MonoBehaviour {
	private float speed = .4f;
	// Use this for initialization
	void Start () {
		Vector2 vel;
		vel.x = -1;
		vel.y = 2;
		rigidbody2D.velocity = vel * speed;
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (!col.gameObject.CompareTag ("Player"))
			return;
		playerState.health = playerState.maxHealth;
		print ("Player has " + playerState.health + " Health");
		Destroy (this.gameObject);
	}
}
